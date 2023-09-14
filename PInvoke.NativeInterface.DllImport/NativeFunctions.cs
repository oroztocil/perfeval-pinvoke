using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PInvoke.NativeInterface.DllImport
{
    public static class NativeFunctions
    {
        // Empty-bodied functions

        [DllImport(BenchLibrary.Name)]
        public static extern void Empty_Void();

        [DllImport(BenchLibrary.Name)]
        public static extern void Empty_IntArray(int[] arr, int count);

        [DllImport(BenchLibrary.Name, EntryPoint = "Empty_IntArray")]
        internal static extern void Empty_IntArray_Fixed(IntPtr arr, int count);

        public static unsafe void Empty_IntArray_Fixed(int[] arr, int count)
        {
            fixed (int* ptr = arr)
            {
                Empty_IntArray_Fixed((IntPtr)ptr, count);
            }
        }

        [DllImport(BenchLibrary.Name, CharSet = CharSet.Ansi)]
        public static extern void Empty_String(string str);

        // Simple functions with primitive arguments

        [DllImport(BenchLibrary.Name)]
        public static extern int ConstantInt();

        [DllImport(BenchLibrary.Name)]
        public static extern int MultiplyInt(int a, int b);

        [DllImport(BenchLibrary.Name)]
        public static extern bool NegateBool(bool value);

        // Array functions

        [DllImport(BenchLibrary.Name)]
        public static extern int SumIntArray(int[] arr, int count);

        [DllImport(BenchLibrary.Name)]
        public static extern void FillIntArray(int[] arr, int count);

        [DllImport(BenchLibrary.Name, EntryPoint = "FillIntArray")]
        public static extern void FillIntArray_OutAttr([Out] int[] arr, int count);

        [DllImport(BenchLibrary.Name, EntryPoint = "FillIntArray")]
        internal static extern void FillIntArray_IntPtr(IntPtr arr, int count);

        public static void FillIntArray_Pinned(int[] arr, int count)
        {
            GCHandle pinnedArray = GCHandle.Alloc(arr, GCHandleType.Pinned);
            IntPtr ptr = pinnedArray.AddrOfPinnedObject();

            FillIntArray_IntPtr(ptr, count);

            pinnedArray.Free();
        }

        public static unsafe void FillIntArray_Fixed(int[] arr, int count)
        {
            fixed (int* ptr = arr)
            {
                FillIntArray_IntPtr((IntPtr)ptr, count);
            }
        }

        // String functions

        [DllImport(BenchLibrary.Name, EntryPoint = "StringLength8", CharSet = CharSet.Ansi)]
        public static extern int StringLength_MultiByte(string str);

        [DllImport(BenchLibrary.Name, EntryPoint = "StringLength16", CharSet = CharSet.Unicode)]
        public static extern int StringLength_Utf16(string str);

        [DllImport(BenchLibrary.Name, EntryPoint = "StringToUppercase", CharSet = CharSet.Ansi)]
        internal static extern void StringToUppercase_ByteArray(byte[] str, int length);

        public static string StringToUppercase_ByteArray(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            StringToUppercase_ByteArray(bytes, bytes.Length);
            return Encoding.UTF8.GetString(bytes);
        }

        [DllImport(BenchLibrary.Name, EntryPoint = "StringToUppercase", CharSet = CharSet.Ansi)]
        internal static extern void StringToUppercase_StringBuilder(StringBuilder str, int length);

        public static string StringToUppercase_StringBuilder(string str)
        {
            var sb = new StringBuilder(str);
            StringToUppercase_StringBuilder(sb, sb.Capacity);
            return sb.ToString();
        }

        [DllImport(BenchLibrary.Name, EntryPoint = "StringToUppercase", CharSet = CharSet.Ansi)]
        internal static extern void StringToUppercase_Pointer(IntPtr str, int length);

        public static string StringToUppercase_Pointer(string str)
        {
            var utf8Buffer = Encoding.UTF8.GetBytes(str);
            var ptr = IntPtr.Zero;

            try
            {
                ptr = Marshal.AllocHGlobal(utf8Buffer.Length);

                Marshal.Copy(utf8Buffer, 0, ptr, utf8Buffer.Length);

                StringToUppercase_Pointer(ptr, utf8Buffer.Length);

                Marshal.Copy(ptr, utf8Buffer, 0,  utf8Buffer.Length);

                return Encoding.UTF8.GetString(utf8Buffer);
            }
            finally
            {
                if (ptr != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(ptr);
                }
            }
        }

        // Struct functions

        // Pass in struct by value

        // Pass struct by reference

        // Return struct on stack?
    }
}
