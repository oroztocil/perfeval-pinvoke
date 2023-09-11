using System.Runtime.InteropServices;

namespace PInvokeReport.Benchmarks.DllImport
{
    internal static class NativeFunctions
    {
        public const string LibraryName = "bench_lib";

        [DllImport(LibraryName)]
        public static extern int Mul2(int x);
    }
}
