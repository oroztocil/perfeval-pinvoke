using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PInvoke.NativeInterface.FuncPointers
{
    public static class NativeFunctions
    {
        private static readonly IntPtr lib = NativeLibrary.Load(BenchLibrary.Name);

        private static readonly IntPtr ptr_Empty_Void = NativeLibrary.GetExport(lib, nameof(Empty_Void));
        private static readonly IntPtr ptr_Empty_IntArray = NativeLibrary.GetExport(lib, "Empty_IntArray");
        private static readonly IntPtr ptr_Empty_String = NativeLibrary.GetExport(lib, nameof(Empty_String));
        private static readonly IntPtr ptr_ConstantInt = NativeLibrary.GetExport(lib, nameof(ConstantInt));
        private static readonly IntPtr ptr_MultiplyInt = NativeLibrary.GetExport(lib, nameof(MultiplyInt));
        private static readonly IntPtr ptr_NegateBool = NativeLibrary.GetExport(lib, nameof(NegateBool));
        private static readonly IntPtr ptr_SumIntArray = NativeLibrary.GetExport(lib, "SumIntArray");
        private static readonly IntPtr ptr_FillIntArray = NativeLibrary.GetExport(lib, "FillIntArray");

        // Empty-bodied functions

        public static unsafe void Empty_Void() =>
            ((delegate* unmanaged<void>)ptr_Empty_Void)();


        public static unsafe void Empty_IntArray_Fixed(int[] arr, int count)
        {
            fixed (int* arrPtr = arr)
            {
                ((delegate* unmanaged<int*, int, void>)ptr_Empty_IntArray)(arrPtr, count);
            }
        }

        public static unsafe void Empty_String(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            fixed (byte* ptr = bytes)
            {
                ((delegate* unmanaged<byte*, void>)ptr_Empty_String)(ptr);
            }
        }

        // Simple functions with primitive arguments

        public static unsafe int ConstantInt() =>
            ((delegate* unmanaged<int>)ptr_ConstantInt)();


        public static unsafe int MultiplyInt(int a, int b) =>
            ((delegate* unmanaged<int, int, int>)ptr_MultiplyInt)(a, b);

        public static unsafe bool NegateBool(bool value) =>
            ((delegate* unmanaged<bool, bool>)ptr_NegateBool)(value);

        // Array functions

        public static unsafe int SumIntArray_Fixed(int[] arr, int count)
        {
            fixed (int* arrPtr = arr)
            {
                return ((delegate* unmanaged<int*, int, int>)ptr_SumIntArray)(arrPtr, count);
            }
        }

        public static unsafe void FillIntArray_Fixed(int[] arr, int count)
        {
            fixed (int* arrPtr = arr)
            {
                ((delegate* unmanaged<int*, int, void>)ptr_FillIntArray)(arrPtr, count);

            }
        }
    }
}
