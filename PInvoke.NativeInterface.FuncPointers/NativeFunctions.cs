using System;
using System.Runtime.InteropServices;
using System.Text;

using PInvoke.NativeInterface.Models;

namespace PInvoke.NativeInterface.FuncPointers
{
    public static unsafe class NativeFunctions
    {
        private static readonly IntPtr lib = NativeLibrary.Load(BenchLibrary.Name);

        private static readonly IntPtr ptr_Empty_Void = NativeLibrary.GetExport(lib, nameof(Empty_Void));
        private static readonly IntPtr ptr_ConstantInt = NativeLibrary.GetExport(lib, nameof(ConstantInt));
        private static readonly IntPtr ptr_MultiplyInt = NativeLibrary.GetExport(lib, nameof(MultiplyInt));
        private static readonly IntPtr ptr_NegateBool = NativeLibrary.GetExport(lib, nameof(NegateBool));
        private static readonly IntPtr ptr_SumIntArray = NativeLibrary.GetExport(lib, "SumIntArray");
        private static readonly IntPtr ptr_FillIntArray = NativeLibrary.GetExport(lib, "FillIntArray");
        private static readonly IntPtr ptr_StringLength_Utf8 = NativeLibrary.GetExport(lib, "StringLength8");
        private static readonly IntPtr ptr_StringLength_Utf16 = NativeLibrary.GetExport(lib, "StringLength16");
        private static readonly IntPtr ptr_StringToUppercase = NativeLibrary.GetExport(lib, "StringToUppercase");
        private static readonly IntPtr ptr_SumIntsInStruct_Return = NativeLibrary.GetExport(lib, "SumIntsInStruct_Return");
        private static readonly IntPtr ptr_SumIntsInStruct_Pointer = NativeLibrary.GetExport(lib, "SumIntsInStruct_Pointer");
        private static readonly IntPtr ptr_UpdateNonBlittableStruct = NativeLibrary.GetExport(lib, "UpdateNonBlittableStruct");

        // Empty-bodied functions

        public static void Empty_Void() =>
            ((delegate* unmanaged<void>)ptr_Empty_Void)();

        public static void Empty_VoidSGCT() =>
            ((delegate* unmanaged[SuppressGCTransition]<void>)ptr_Empty_Void)();


        // Simple functions with primitive arguments

        public static int ConstantInt() =>
            ((delegate* unmanaged<int>)ptr_ConstantInt)();


        public static unsafe int MultiplyInt(int a, int b) =>
            ((delegate* unmanaged<int, int, int>)ptr_MultiplyInt)(a, b);

        public static unsafe int MultiplyInt_SGCT(int a, int b) =>
            ((delegate* unmanaged[SuppressGCTransition]<int, int, int>)ptr_MultiplyInt)(a, b);

        public static bool NegateBool(bool value)
        {
            byte marshalled = MarshalExtensions.BoolToByte(value);
            byte result = ((delegate* unmanaged<byte, byte>)ptr_NegateBool)(marshalled);
            return MarshalExtensions.ByteToBool(result);
        }

        // Array functions

        public static int SumIntArray(int[] arr, int count)
        {
            fixed (int* arrPtr = arr)
            {
                return ((delegate* unmanaged<int*, int, int>)ptr_SumIntArray)(arrPtr, count);
            }
        }

        public static void FillIntArray(int[] arr, int count)
        {
            fixed (int* arrPtr = arr)
            {
                ((delegate* unmanaged<int*, int, void>)ptr_FillIntArray)(arrPtr, count);
            }
        }

        public static void FillIntArray_Pinned(int[] arr, int count)
        {
            GCHandle pinnedArray = GCHandle.Alloc(arr, GCHandleType.Pinned);
            IntPtr ptr = pinnedArray.AddrOfPinnedObject();

            ((delegate* unmanaged<int*, int, void>)ptr_FillIntArray)((int*)ptr, count);

            pinnedArray.Free();
        }

        public static int StringLength_Utf8(string str)
        {
            var ptr = Marshal.StringToCoTaskMemUTF8(str);
            int result = ((delegate* unmanaged<IntPtr, int>)ptr_StringLength_Utf8)(ptr);
            Marshal.FreeCoTaskMem(ptr);
            return result;
        }

        public static int StringLength_Utf16(string str)
        {
            fixed (char* ptr = str)
            {
                return ((delegate* unmanaged<char*, int>)ptr_StringLength_Utf16)(ptr);
            }
        }

        internal static void StringToUppercase_Fixed(byte* ptr, int length) =>
            ((delegate* unmanaged<byte*, int, void>)ptr_StringToUppercase)(ptr, length);

        public static string StringToUppercase_Fixed(string str)
        {
            var utf8Buffer = Encoding.UTF8.GetBytes(str);

            fixed (byte* ptr = utf8Buffer)
            {
                StringToUppercase_Fixed(ptr, utf8Buffer.Length);
            }

            return Encoding.UTF8.GetString(utf8Buffer);
        }

        public static BlittableStruct SumIntsInStruct_Return(BlittableStruct input) =>
            ((delegate* unmanaged<BlittableStruct, BlittableStruct>)ptr_SumIntsInStruct_Return)(input);

        public static void SumIntsInStruct_Ref(ref BlittableStruct input) =>
            ((delegate* unmanaged<ref BlittableStruct, void>)ptr_SumIntsInStruct_Pointer)(ref input);

        public static void SumIntsInClass_Ref(BlittableClass input) =>
            ((delegate* unmanaged<BlittableClass, void>)ptr_SumIntsInStruct_Pointer)(input);

        internal static void UpdateNonBlittableStruct_Manual(ref MarshalledNonBlittableStruct input) =>
            ((delegate* unmanaged<ref MarshalledNonBlittableStruct, void>)ptr_UpdateNonBlittableStruct)(ref input);

        public static void UpdateNonBlittableStruct_Manual(ref NonBlittableStruct input)
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
