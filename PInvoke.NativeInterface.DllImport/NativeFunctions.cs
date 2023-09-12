using System.Runtime.InteropServices;

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

        // Struct functions
    }
}
