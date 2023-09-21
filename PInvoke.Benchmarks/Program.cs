using System;
using System.Collections.Generic;
using System.Linq;

using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

using Microsoft.Extensions.Configuration;

namespace PInvoke.Benchmarks
{
    public static class Program
    {
        static int Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            var runCategory = configuration.GetValue("anyCategories", "Complete");

            var csvExporter = new FilteredCsvExporter(
                CsvSeparator.Semicolon,
                new SummaryStyle(
                    cultureInfo: System.Globalization.CultureInfo.CurrentCulture,
                    printUnitsInHeader: true,
                    printUnitsInContent: false,
                    timeUnit: Perfolizer.Horology.TimeUnit.Nanosecond,
                    sizeUnit: SizeUnit.B                    
                ));

            var config = ManualConfig
                    .Create(DefaultConfig.Instance)
                    .AddExporter(csvExporter)
                    .AddColumn(StatisticColumn.Median, StatisticColumn.Min, StatisticColumn.Max)
                    .HideColumns(Column.Job, Column.Namespace)
                    .WithArtifactsPath($"./Results/{runCategory}_" + DateTime.Now.ToString("s").Replace(":", "_"))
                    .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Alphabetical))
                    .WithOptions(ConfigOptions.JoinSummary);

            var summaries = BenchmarkSwitcher
                .FromAssembly(typeof(Program).Assembly)
                .Run(args, config);

            return IsSuccess(summaries) ? 0 : 1;
        }

        private static bool IsSuccess(IEnumerable<Summary> summaries) =>
            summaries.Any() && !summaries.Any(summary => 
                summary.HasCriticalValidationErrors
                    || summary.Reports.Any(report => !report.BuildResult.IsBuildSuccess));
    }
}