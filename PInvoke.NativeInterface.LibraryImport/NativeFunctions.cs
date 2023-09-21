using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

using PInvoke.NativeInterface.Models;

[assembly: DisableRuntimeMarshalling]

namespace PInvoke.NativeInterface.LibraryImport
{
    public static partial class NativeFunctions
    {
        // Primitive-type functions

        [LibraryImport(BenchLibrary.Name)]
        public static partial void Empty_Void();

        [LibraryImport(BenchLibrary.Name, EntryPoint = "Empty_Void")]
        [SuppressGCTransition]
        public static partial void Empty_VoidSGCT();

        [LibraryImport(BenchLibrary.Name, EntryPoint = "Empty_Void", SetLastError = true)]
        public static partial void Empty_VoidSLE();

        [LibraryImport(BenchLibrary.Name)]
        public static partial int ConstantInt();

        [LibraryImport(BenchLibrary.Name)]
        public static partial int MultiplyInt(int a, int b);

        [LibraryImport(BenchLibrary.Name, EntryPoint = "MultiplyInt", SetLastError = true)]
        public static partial int MultiplyIntSLE(int a, int b);

        [LibraryImport(BenchLibrary.Name)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static partial bool NegateBool([MarshalAs(UnmanagedType.U1)] bool value);

        // Array functions

        [LibraryImport(BenchLibrary.Name)]
        public static partial int SumIntArray(int[] arr, int count);

        [LibraryImport(BenchLibrary.Name)]
        public static partial void FillIntArray(int[] arr, int count);

        [LibraryImport(BenchLibrary.Name, EntryPoint = "FillIntArray")]
        internal static partial void FillIntArray_Ptr(IntPtr arr, int count);

        public static void FillIntArray_Pinned(int[] arr, int count)
        {
            GCHandle pinnedArray = GCHandle.Alloc(arr, GCHandleType.Pinned);
            IntPtr ptr = pinnedArray.AddrOfPinnedObject();

            FillIntArray_Ptr(ptr, count);

            pinnedArray.Free();
        }

        public static unsafe void FillIntArray_Fixed(int[] arr, int count)
        {
            fixed (int* ptr = arr)
            {
                FillIntArray_Ptr((IntPtr)ptr, count);
            }
        }

        // String functions

        [LibraryImport(BenchLibrary.Name, EntryPoint = "StringLength8", StringMarshalling = StringMarshalling.Utf8)]
        public static partial int StringLength_Utf8(string str);

        [LibraryImport(BenchLibrary.Name, EntryPoint = "StringLength16", StringMarshalling = StringMarshalling.Utf16)]
        public static partial int StringLength_Utf16(string str);

        [LibraryImport(BenchLibrary.Name, EntryPoint = "StringToUppercase")]
        internal static partial void StringToUppercase_ByteArray(byte[] str, int length);

        public static string StringToUppercase_ByteArray(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            StringToUppercase_ByteArray(bytes, bytes.Length);
            return Encoding.UTF8.GetString(bytes);
        }

        [DllImport(BenchLibrary.Name, EntryPoint = "StringToUppercase")]
        internal static extern void StringToUppercase_Fixed(IntPtr str, int length);

        public static unsafe string StringToUppercase_Fixed(string str)
        {
            var utf8Buffer = Encoding.UTF8.GetBytes(str);

            fixed (byte* ptr = utf8Buffer)
            {
                StringToUppercase_Fixed((IntPtr)ptr, utf8Buffer.Length);
            }

            return Encoding.UTF8.GetString(utf8Buffer);
        }

        public static string StringToUppercase_PooledByteArray(string str)
        {
            var buffer = ArrayPool<byte>.Shared.Rent(str.Length);
            var byteCount = Encoding.UTF8.GetBytes(str, buffer);
            StringToUppercase_ByteArray(buffer, byteCount);
            var result = Encoding.UTF8.GetString(buffer, 0, byteCount);
            ArrayPool<byte>.Shared.Return(buffer);
            return result;
        }

        // Struct functions

        [LibraryImport(BenchLibrary.Name)]
        public static partial BlittableStruct SumIntsInStruct_Return(BlittableStruct input);

        [LibraryImport(BenchLibrary.Name, EntryPoint = "SumIntsInStruct_Pointer")]
        public static partial void SumIntsInStruct_Ref(ref BlittableStruct input);

        [LibraryImport(BenchLibrary.Name, EntryPoint = "UpdateNonBlittableStruct")]
        public static partial void UpdateNonBlittableStruct_Marshaller(
            [MarshalUsing(typeof(NonBlittableStatelessMarshaller))] ref NonBlittableStruct input);

        [LibraryImport(BenchLibrary.Name, EntryPoint = "UpdateNonBlittableStruct")]
        internal static partial void UpdateNonBlittableStruct_Manual(ref MarshalledNonBlittableStruct input);

        public static unsafe void UpdateNonBlittableStruct_Manual(ref NonBlittableStruct input)
        {
            var utf8Buffer = Encoding.UTF8.GetBytes(input.text);

            fixed (byte* textPtr = utf8Buffer)
            fixed (int* numberArrayPtr = input.numberArray)
            {
                var marshalled = new MarshalledNonBlittableStruct
                {
                    number = input.number,
                    flag = MarshalExtensions.BoolToByte(input.flag),
                    numberArray = (IntPtr)numberArrayPtr,
                    numberArraySize = input.numberArray.Length,
                    text = (IntPtr)textPtr
                };

                UpdateNonBlittableStruct_Manual(ref marshalled);

                input.number = marshalled.number;
                input.flag = MarshalExtensions.ByteToBool(marshalled.flag);
                input.text = Encoding.UTF8.GetString(utf8Buffer);
            }
        }
    }
}
