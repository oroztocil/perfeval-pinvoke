using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using PInvoke.NativeInterface.Models;

namespace PInvoke.NativeInterface.DllImport
{
    public static class NativeFunctions
    {
        // Empty-bodied functions

        [DllImport(BenchLibrary.Name)]
        public static extern void Empty_Void();

        [DllImport(BenchLibrary.Name, EntryPoint = "Empty_Void")]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Empty_VoidSUCS();

        [DllImport(BenchLibrary.Name, EntryPoint = "Empty_Void", SetLastError = true)]
        public static extern void Empty_VoidSLE();

        [DllImport(BenchLibrary.Name)]
        public static extern void Empty_IntArray(int[] arr, int count);

        [DllImport(BenchLibrary.Name, EntryPoint = "Empty_IntArray")]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Empty_IntArraySUCS(int[] arr, int count);

        [DllImport(BenchLibrary.Name, EntryPoint = "Empty_IntArray")]
        internal static extern void Empty_IntArray_Fixed(IntPtr arr, int count);

        public static unsafe void Empty_IntArray_Fixed(int[] arr, int count)
        {
            fixed (int* ptr = arr)
            {
                Empty_IntArray_Fixed((IntPtr)ptr, count);
            }
        }

        [DllImport(BenchLibrary.Name)]
        public static extern void Empty_String([MarshalAs(UnmanagedType.LPUTF8Str)] string str);

        [DllImport(BenchLibrary.Name, EntryPoint = "Empty_String")]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Empty_StringSUCS([MarshalAs(UnmanagedType.LPUTF8Str)] string str);

        // Simple functions with primitive arguments

        [DllImport(BenchLibrary.Name)]
        public static extern int ConstantInt();

        [DllImport(BenchLibrary.Name)]
        public static extern int MultiplyInt(int a, int b);

        [DllImport(BenchLibrary.Name, EntryPoint = "MultiplyInt", SetLastError = true)]
        public static extern int MultiplyIntSLE(int a, int b);

        [DllImport(BenchLibrary.Name)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool NegateBool([MarshalAs(UnmanagedType.U1)] bool value);

        // Array functions

        [DllImport(BenchLibrary.Name)]
        public static extern int SumIntArray(int[] arr, int count);

        [DllImport(BenchLibrary.Name)]
        public static extern void FillIntArray(int[] arr, int count);

        [DllImport(BenchLibrary.Name, EntryPoint = "FillIntArray")]
        public static extern void FillIntArray_OutAttr([Out] int[] arr, int count);

        [DllImport(BenchLibrary.Name, EntryPoint = "FillIntArray")]
        internal static extern void FillIntArray_Ptr(IntPtr arr, int count);

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

        [DllImport(BenchLibrary.Name, EntryPoint = "StringLength8")]
        public static extern int StringLength_Utf8([MarshalAs(UnmanagedType.LPUTF8Str)] string str);

        [DllImport(BenchLibrary.Name, EntryPoint = "StringLength16", CharSet = CharSet.Unicode)]
        public static extern int StringLength_Utf16(string str);

        [DllImport(BenchLibrary.Name, EntryPoint = "StringToUppercase")]
        internal static extern void StringToUppercase_ByteArray(byte[] str, int length);

        public static string StringToUppercase_ByteArray(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            StringToUppercase_ByteArray(bytes, bytes.Length);
            return Encoding.UTF8.GetString(bytes);
        }

        [DllImport(BenchLibrary.Name, EntryPoint = "StringToUppercase")]
        internal static extern void StringToUppercase_StringBuilder(StringBuilder str, int length);

        public static string StringToUppercase_StringBuilder(string str)
        {
            var sb = new StringBuilder(str);
            StringToUppercase_StringBuilder(sb, sb.Capacity);
            return sb.ToString();
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

        // Struct functions

        [DllImport(BenchLibrary.Name)]
        public static extern BlittableStruct SumIntsInStruct_Return(BlittableStruct input);

        [DllImport(BenchLibrary.Name, EntryPoint = "SumIntsInStruct_Pointer")]
        public static extern void SumIntsInStruct_Ref(ref BlittableStruct input);

        [DllImport(BenchLibrary.Name, EntryPoint = "SumIntsInStruct_Pointer")]
        public static extern void SumIntsInClass_Ref([In, Out] BlittableClass input);

        [DllImport(BenchLibrary.Name, EntryPoint = "UpdateNonBlittableStruct")]
        internal static extern void UpdateNonBlittableStruct_Manual(ref MarshalledNonBlittableStruct input);

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
