using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;

namespace PInvoke.Benchmarks
{
    internal class ColdStartJobAttribute(
        RuntimeMoniker runtimeMoniker,
        int launchCount = Settings.ColdStartLaunchCount,
        int warmupCount = 0,
        int iterationCount = Settings.ColdStartIterationCount,
        int invocationCount = Settings.ColdStartInvocationCount,
        string? id = null,
        bool baseline = false)
        : SimpleJobAttribute(RunStrategy.ColdStart, runtimeMoniker, launchCount, warmupCount, iterationCount, invocationCount, id, baseline)
    { }
}
