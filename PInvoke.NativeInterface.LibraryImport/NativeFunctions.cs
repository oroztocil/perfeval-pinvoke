using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

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

        [LibraryImport(BenchLibrary.Name, StringMarshallingCustomType = typeof(AnsiStringMarshaller))]
        public static partial int StringLength8(string str);

        [LibraryImport(BenchLibrary.Name, StringMarshalling = StringMarshalling.Utf16)]
        public static partial int StringLength16(string str);

        [LibraryImport(BenchLibrary.Name)]
        internal static partial void StringToUppercase(byte[] str, int length);
        
        public static string StringToUppercase(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            StringToUppercase(bytes, bytes.Length);
            return Encoding.UTF8.GetString(bytes);
        }

        // Struct functions
    }
}