using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

using PInvoke.NativeInterface.Models;

namespace PInvoke.NativeInterface.LibraryImport
{
    [CustomMarshaller(typeof(NonBlittableStruct), MarshalMode.Default, typeof(NonBlittableStructMarshaller))]
    public static unsafe class NonBlittableStructMarshaller
    {
        public static MarshalledStruct ConvertToUnmanaged(NonBlittableStruct managed)
        {
            var numberArrayPtr = Marshal.AllocHGlobal(sizeof(int) * managed.numberArray.Length);
            Marshal.Copy(managed.numberArray, 0, numberArrayPtr, managed.numberArray.Length);

            var marshalled = new MarshalledStruct
            {
                number = managed.number,
                flag = managed.flag,
                text = Marshal.StringToHGlobalAnsi(managed.text),
                numberArray = numberArrayPtr,
                numberArraySize = managed.numberArray.Length
            };

            return marshalled;
        }

        public static NonBlittableStruct ConvertToManaged(MarshalledStruct marshalled)
        {
            var numberArray = new int[marshalled.numberArraySize];
            Marshal.Copy(marshalled.numberArray, numberArray, 0, numberArray.Length);

            var managed = new NonBlittableStruct
            {
                number = marshalled.number,
                flag = marshalled.flag,
                text = Marshal.PtrToStringAnsi(marshalled.text),
                numberArray = numberArray
            };

            return managed;
        }

        public static void Free(MarshalledStruct marshalled)
        {
            Marshal.FreeHGlobal(marshalled.text);
            Marshal.FreeHGlobal(marshalled.numberArray);
        }

        public unsafe struct MarshalledStruct
        {
            public int number;
            public bool flag;
            public IntPtr text;
            public IntPtr numberArray;
            public int numberArraySize;
        }
    }
}
