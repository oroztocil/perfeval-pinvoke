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
        // [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvSuppressGCTransition) })]

        // Primitive-type functions

        [LibraryImport(BenchLibrary.Name)]
        public static partial void Empty_Void();

        [LibraryImport(BenchLibrary.Name)]
        public static partial void Empty_IntArray(int[] arr, int count);

        [LibraryImport(BenchLibrary.Name, EntryPoint = "Empty_IntArray")]
        internal static partial void Empty_IntArray_FixedPtr(IntPtr arr, int count);

        public static unsafe void Empty_IntArray_Fixed(int[] arr, int count)
        {
            fixed (int* ptr = arr)
            {
                Empty_IntArray_FixedPtr((IntPtr)ptr, count);
            }
        }

        [LibraryImport(BenchLibrary.Name, StringMarshalling = StringMarshalling.Utf8)]
        public static partial void Empty_String(string str);

        [LibraryImport(BenchLibrary.Name)]
        public static partial int ConstantInt();

        [LibraryImport(BenchLibrary.Name)]
        public static partial int MultiplyInt(int a, int b);

        [LibraryImport(BenchLibrary.Name)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool NegateBool([MarshalAs(UnmanagedType.Bool)] bool value);

        // Array functions

        [LibraryImport(BenchLibrary.Name)]
        public static partial int SumIntArray(int[] arr, int count);

        [LibraryImport(BenchLibrary.Name)]
        public static partial void FillIntArray(int[] arr, int count);

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

        public static string StringToUppercase_PooledByteArray(string str)
        {
            var buffer = ArrayPool<byte>.Shared.Rent(str.Length);
            var byteCount = Encoding.UTF8.GetBytes(str, buffer);
            StringToUppercase_ByteArray(buffer, byteCount);
            return Encoding.UTF8.GetString(buffer, 0, byteCount);
        }

        // Struct functions

        [LibraryImport(BenchLibrary.Name)]
        public static partial BlittableStruct SumIntsInStruct_Return(BlittableStruct data);

        [LibraryImport(BenchLibrary.Name)]
        public static partial void SumIntsInStruct_Ref(ref BlittableStruct data);

        //[LibraryImport(BenchLibrary.Name, EntryPoint = "SumIntsInStruct_Pointer")]
        //public static partial void SumIntsInClass_Pointer(BlittableClass data);

        [LibraryImport(BenchLibrary.Name)]
        public static partial void UpdateStruct_Pointer(
            [MarshalUsing(typeof(NonBlittableStructMarshaller))] ref NonBlittableStruct data);
    }
}