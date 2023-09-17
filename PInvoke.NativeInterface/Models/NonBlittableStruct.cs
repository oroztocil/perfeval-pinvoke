using System;
using System.Runtime.InteropServices;

namespace PInvoke.NativeInterface.Models
{
    public struct NonBlittableStruct
    {
        public int number;
        public bool flag;
        public string text;
        public int[] numberArray;
    }

    [StructLayout(LayoutKind.Sequential)]
    public ref struct MarshalledNonBlittableStruct
    {
        public int number;
        public int numberArraySize;
        public IntPtr numberArray;
        public IntPtr text;
        public byte flag;
    }
}
