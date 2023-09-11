using System.Runtime.InteropServices;

namespace PInvokeReport.Benchmarks
{
    internal static partial class NativeFunctions

    {
        public const string LibraryName = "bench_lib";

        [LibraryImport(LibraryName)]
        public static partial int Mul2(int x);
    }
}
