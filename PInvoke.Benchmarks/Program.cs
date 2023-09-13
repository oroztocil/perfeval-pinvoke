using System.Collections.Generic;
using System.Linq;

using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace PInvoke.Benchmarks
{
    public static class Program
    {
        static int Main(string[] args)
        {
            var summaries = BenchmarkSwitcher
                .FromAssembly(typeof(Program).Assembly)
                .Run(args, ManualConfig
                    .Create(DefaultConfig.Instance)
                    .HideColumns(Column.Job, Column.Namespace)
                    .AddColumn(CategoriesColumn.Default)
                    .WithOptions(ConfigOptions.JoinSummary));

            return IsSuccess(summaries) ? 0 : 1;
        }

        private static bool IsSuccess(IEnumerable<Summary> summaries) =>
            summaries.Any() && !summaries.Any(summary => 
                summary.HasCriticalValidationErrors
                    || summary.Reports.Any(report => !report.BuildResult.IsBuildSuccess));
    }
}