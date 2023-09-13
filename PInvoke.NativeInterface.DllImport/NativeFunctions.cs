using System.Runtime.InteropServices;
using System.Text;

namespace PInvoke.NativeInterface.DllImport
{
    public static class NativeFunctions
    {
        // Primitive-type functions

        [DllImport(BenchLibrary.Name)]
        public static extern void Empty();

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
        public static extern unsafe double SumDoubleArray(double[] arr, int count);

        // String functions
        
        [DllImport(BenchLibrary.Name, CharSet = CharSet.Ansi)]
        public static extern int StringLength8(string str);

        [DllImport(BenchLibrary.Name, CharSet = CharSet.Unicode)]
        public static extern int StringLength16(string str);

        [DllImport(BenchLibrary.Name, CharSet = CharSet.Ansi)]
        internal static extern void StringToUppercase(byte[] str, int length);
        //internal static extern void StringToUppercase(StringBuilder str, int length);

        public static string StringToUppercase(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            StringToUppercase(bytes, bytes.Length);
            return Encoding.UTF8.GetString(bytes);
        }

        //public static string StringToUppercase2(string str)
        //{
        //    var sb = new StringBuilder(str);
        //    StringToUppercase(sb, sb.Capacity);
        //    return sb.ToString();
        //}

        // Struct functions
    }
}
