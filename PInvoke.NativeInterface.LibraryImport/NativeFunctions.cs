using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace PInvoke.NativeInterface.LibraryImport
{
    public static partial class NativeFunctions
    {
        // Primitive-type functions

        [LibraryImport(BenchLibrary.Name)]
        public static partial void Empty_Void();

        [LibraryImport(BenchLibrary.Name)]
        public static partial void Empty_IntArray(int[] arr, int count);

        [LibraryImport(BenchLibrary.Name, EntryPoint = "Empty_IntArray")]
        internal static partial void Empty_IntArray_FixedPtr(IntPtr arr, int count);

        public static unsafe void Empty_IntArray_FixedPtr(int[] arr, int count)
        {
            fixed (int* ptr = arr)
            {
                Empty_IntArray_FixedPtr((IntPtr)ptr, count);
            }
        }

        [LibraryImport(BenchLibrary.Name, StringMarshallingCustomType = typeof(AnsiStringMarshaller))]
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

        [LibraryImport(BenchLibrary.Name, EntryPoint = "StringLength8", StringMarshallingCustomType = typeof(AnsiStringMarshaller))]
        public static partial int StringLength_MultiByte(string str);

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

        // Struct functions
    }
}