using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace PInvokeReport.Benchmarks
{
    public static class Program
    {
        static void Main()
        {
            _ = BenchmarkRunner.Run(
                typeof(Program).Assembly,
                ManualConfig
                    .Create(DefaultConfig.Instance)
                    .WithOptions(ConfigOptions.JoinSummary)
                    .WithOptions(ConfigOptions.DisableLogFile));
        }
    }
}