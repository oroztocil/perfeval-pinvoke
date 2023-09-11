using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace PInvokeReport.Benchmarks.DllImport
{
    // DllImport is supported in all .NET versions
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class Benchmarks
    {
        [Params(21, 2121212121)]
        public int Input { get; set; }

        [Benchmark]
        public int Mul2Dll() => NativeFunctions.Mul2(Input);
    }
}
