using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace PInvokeReport.Benchmarks.LibraryImport
{
    // LibraryImport is only supported in .NET 7 and newer
    [SimpleJob(RuntimeMoniker.Net70)]
    public class Benchmarks
    {
        [Params(21, 2121212121)]
        public int Input { get; set; }

        [Benchmark]
        public int Mul2Dll() => NativeFunctions.Mul2(Input);
    }
}
