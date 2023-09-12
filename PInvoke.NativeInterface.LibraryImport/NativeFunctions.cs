using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace PInvoke.NativeInterface.LibraryImport
{
    public static partial class NativeFunctions
    {
        // Primitive-type functions

        [LibraryImport(BenchLibrary.Name)]
        public static partial void Empty();

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
        public static unsafe partial double SumDoubleArray(double[] arr, int count);

        // String functions

        [LibraryImport(BenchLibrary.Name, StringMarshalling = StringMarshalling.Utf8)]
        public static partial int StringLength8(string str);
        //public static partial int StringLength8([MarshalUsing(typeof(AnsiStringMarshaller))] string str);

        [LibraryImport(BenchLibrary.Name, StringMarshalling = StringMarshalling.Utf16)]
        public static partial int StringLength16(string str);

        // Struct functions
    }
}