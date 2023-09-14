using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PInvoke.NativeInterface.FuncPointers
{
    public static class NativeFunctions
    {
        private static readonly IntPtr libraryHandle;

        private static readonly IntPtr ptr_Empty_Void;
        private static readonly IntPtr ptr_Empty_IntArray;
        private static readonly IntPtr ptr_Empty_String;

        private static readonly IntPtr ptr_MultiplyInt;
        private static readonly IntPtr ptr_ConstantInt;
        private static readonly IntPtr ptr_NegateBool;

        private static readonly IntPtr ptr_SumIntArray;
        private static readonly IntPtr ptr_FillIntArray;

        static NativeFunctions()
        {
            libraryHandle = NativeLibrary.Load(BenchLibrary.Name);

            ptr_Empty_Void = NativeLibrary.GetExport(libraryHandle, nameof(Empty_Void));
            ptr_Empty_IntArray = NativeLibrary.GetExport(libraryHandle, nameof(Empty_IntArray_Fixed));
            ptr_Empty_String = NativeLibrary.GetExport(libraryHandle, nameof(Empty_String));

            ptr_ConstantInt = NativeLibrary.GetExport(libraryHandle, nameof(ConstantInt));
            ptr_MultiplyInt = NativeLibrary.GetExport(libraryHandle, nameof(MultiplyInt));
            ptr_NegateBool = NativeLibrary.GetExport(libraryHandle, nameof(NegateBool));

            ptr_SumIntArray = NativeLibrary.GetExport(libraryHandle, nameof(SumIntArray_Fixed));
            ptr_FillIntArray = NativeLibrary.GetExport(libraryHandle, nameof(FillIntArray_Fixed));
        }

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
            var ptr = (byte*)Marshal.StringToHGlobalAnsi(str);
            ((delegate* unmanaged<byte*, void>)ptr_Empty_String)(ptr);
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
