using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace PInvoke.Benchmarks
{
    // .NET 4.8 is Windows-only
#if OS_WINDOWS
    [SimpleJob(RuntimeMoniker.Net48)]
#endif
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser]
    public class Managed : BenchmarkBase
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Managed)]
        public long GetTimestamp() => Stopwatch.GetTimestamp();

        [Benchmark]
        [BenchmarkCategory(Categories.Managed)]
        public bool QueryPerformanceCounter() => QueryPerformanceCounter(out long value);

        [Benchmark]
        [BenchmarkCategory(Categories.Managed)]
        public bool QueryPerformanceCounter2() => QueryPerformanceCounter2(out long value);

        [Benchmark]
        [BenchmarkCategory(Categories.Managed)]
        public bool QueryPerformanceCounter3() => QueryPerformanceCounter3(out long value);

        [Benchmark]
        [BenchmarkCategory(Categories.Managed)]
        public bool QueryPerformanceCounter4() => QueryPerformanceCounter4(out long value);

        [DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceCounter")]
        private static extern bool QueryPerformanceCounter(out long value);

        [DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceCounter", SetLastError = false)]
        private static extern bool QueryPerformanceCounter2(out long value);

        [DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceCounter", SetLastError = false, ExactSpelling = true)]
        private static extern bool QueryPerformanceCounter3(out long value);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceCounter", SetLastError = false, ExactSpelling = true)]
        private static extern bool QueryPerformanceCounter4(out long value);
    }
}
