using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

using PInvoke.NativeInterface.Models;

namespace PInvoke.NativeInterface.LibraryImport
{
    [CustomMarshaller(typeof(NonBlittableStruct), MarshalMode.Default, typeof(NonBlittableStatetelessMarshaller))]
    public static unsafe class NonBlittableStatetelessMarshaller
    {
        public static MarshalledNonBlittableStruct ConvertToUnmanaged(NonBlittableStruct managed)
        {
            var numberArrayPtr = Marshal.AllocCoTaskMem(sizeof(int) * managed.numberArray.Length);
            Marshal.Copy(managed.numberArray, 0, numberArrayPtr, managed.numberArray.Length);

            var textPtr = Marshal.StringToCoTaskMemUTF8(managed.text);

            var marshalled = new MarshalledNonBlittableStruct
            {
                number = managed.number,
                flag = MarshalExtensions.BoolToByte(managed.flag),
                text = textPtr,
                numberArray = numberArrayPtr,
                numberArraySize = managed.numberArray.Length
            };

            return marshalled;
        }

        public static NonBlittableStruct ConvertToManaged(MarshalledNonBlittableStruct marshalled)
        {
            var numberArray = new int[marshalled.numberArraySize];
            Marshal.Copy(marshalled.numberArray, numberArray, 0, numberArray.Length);

            var text = Marshal.PtrToStringUTF8(marshalled.text);

            var managed = new NonBlittableStruct
            {
                number = marshalled.number,
                flag = MarshalExtensions.ByteToBool(marshalled.flag),
                text = text,
                numberArray = numberArray
            };

            return managed;
        }

        public static void Free(MarshalledNonBlittableStruct marshalled)
        {
            Marshal.FreeCoTaskMem(marshalled.text);
            Marshal.FreeCoTaskMem(marshalled.numberArray);
        }
    }
}
