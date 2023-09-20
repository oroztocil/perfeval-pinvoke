using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.PortableExecutable;

using BenchmarkDotNet.Characteristics;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;

namespace PInvoke.Benchmarks
{
    internal class FilteredCsvExporter : CsvMeasurementsExporter
    {
        private static readonly Lazy<MeasurementColumn[]> Columns = new Lazy<MeasurementColumn[]>(new Func<MeasurementColumn[]>(BuildColumns));


        public FilteredCsvExporter(CsvSeparator separator, SummaryStyle style)
            : base(separator, style)
        { }

        public override void ExportToLog(Summary summary, ILogger logger)
        {
            string realSeparator = Separator;
            MeasurementColumn[] columns = GetColumns(summary);
            logger.WriteLine(string.Join(realSeparator, columns.Select((MeasurementColumn c) => CsvHelper.Escape(c.Title, realSeparator))));
            ImmutableArray<BenchmarkReport>.Enumerator enumerator = summary.Reports.GetEnumerator();
            while (enumerator.MoveNext())
            {
                BenchmarkReport current = enumerator.Current;
                foreach (Measurement allMeasurement in current.AllMeasurements.Where(m => m.IterationStage == IterationStage.Result))
                {
                    int num = 0;
                    while (num < columns.Length)
                    {
                        logger.Write(CsvHelper.Escape(columns[num].GetValue(summary, current, allMeasurement), realSeparator));
                        if (++num < columns.Length)
                        {
                            logger.Write(realSeparator);
                        }
                    }

                    logger.WriteLine();
                }
            }
        }

        private static MeasurementColumn[] GetColumns(Summary summary)
        {
            Summary summary2 = summary;
            if (!summary2.BenchmarksCases.Any((benchmark) => benchmark.Config.HasMemoryDiagnoser()))
            {
                return Columns.Value;
            }

            return new List<MeasurementColumn>(Columns.Value)
            {
                new MeasurementColumn("Gen_0", (_, report, __) => report.GcStats.Gen0Collections.ToString(summary2.GetCultureInfo())),
                new MeasurementColumn("Gen_1", (_, report, __) => report.GcStats.Gen1Collections.ToString(summary2.GetCultureInfo())),
                new MeasurementColumn("Gen_2", (_, report, __) => report.GcStats.Gen2Collections.ToString(summary2.GetCultureInfo())),
                new MeasurementColumn("Allocated_Bytes", (_, report, __) => report.GcStats.GetBytesAllocatedPerOperation(report.BenchmarkCase).ToString() ?? "unknown")
            }.ToArray();
        }

        private static MeasurementColumn[] BuildColumns()
        {
            List<MeasurementColumn> list = new List<MeasurementColumn>
            {
                new MeasurementColumn("Category", (Summary summary, BenchmarkReport report, Measurement m) => report.BenchmarkCase.Descriptor.Categories[0]),
                new MeasurementColumn("OS", (Summary summary, BenchmarkReport report, Measurement m) => Environment.OSVersion.Platform.ToString()),
                new MeasurementColumn("Target_Type", (Summary summary, BenchmarkReport report, Measurement m) => report.BenchmarkCase.Descriptor.Type.Name),
                new MeasurementColumn("Target_Method", (Summary summary, BenchmarkReport report, Measurement m) => report.BenchmarkCase.Descriptor.WorkloadMethodDisplayInfo)
            };

            var enabledCharacteristics = new string[] { "Runtime" };
            var characteristics = CharacteristicHelper.GetAllPresentableCharacteristics(typeof(Job), includeIgnoreOnApply: true)
                .Where(c => enabledCharacteristics.Contains(c.Id));

            foreach (Characteristic characteristic in characteristics)
            {
                list.Add(new MeasurementColumn("Job_" + characteristic.Id, (Summary summary, BenchmarkReport report, Measurement m) =>
                    CharacteristicPresenter.SummaryPresenter.ToPresentation(report.BenchmarkCase.Job, characteristic)));
            }

            list.Add(new MeasurementColumn("Params", (Summary summary, BenchmarkReport report, Measurement m) => report.BenchmarkCase.Parameters.PrintInfo));
            list.Add(new MeasurementColumn("Measurement_IterationMode", (Summary summary, BenchmarkReport report, Measurement m) => m.IterationMode.ToString()));
            list.Add(new MeasurementColumn("Measurement_IterationStage", (Summary summary, BenchmarkReport report, Measurement m) => m.IterationStage.ToString()));
            list.Add(new MeasurementColumn("Measurement_IterationIndex", (Summary summary, BenchmarkReport report, Measurement m) => m.IterationIndex.ToString()));
            list.Add(new MeasurementColumn("Measurement_Operations", (Summary summary, BenchmarkReport report, Measurement m) => m.Operations.ToString()));
            list.Add(new MeasurementColumn("Measurement_Value", (Summary summary, BenchmarkReport report, Measurement m) => (m.Nanoseconds / (double)m.Operations).ToString("0.##", summary.GetCultureInfo())));
            return list.ToArray();
        }

        private struct MeasurementColumn
        {
            public string Title { get; }

            public Func<Summary, BenchmarkReport, Measurement, string> GetValue { get; }

            public MeasurementColumn(string title, Func<Summary, BenchmarkReport, Measurement, string> getValue)
            {
                Title = title;
                GetValue = getValue;
            }
        }
    }
}
