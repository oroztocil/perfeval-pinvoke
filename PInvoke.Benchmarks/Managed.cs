using System.Runtime.CompilerServices;

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
    [KeepBenchmarkFiles]
    [CsvExporter]
    [CsvMeasurementsExporter]
    [HtmlExporter]
    [RPlotExporter]
    public class Managed : BenchmarkBase
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.Managed)]
        public void Empty_Void() => ManagedFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.Managed)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray(int[] array) => ManagedFunctions.Empty_IntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InString, Categories.Managed)]
        public void Empty_String() => ManagedFunctions.Empty_String(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.ReturnInt, Categories.Managed)]
        public int ConstantInt() => ManagedFunctions.ConstantInt();

        [Benchmark]
        [BenchmarkCategory(Categories.InReturnInt, Categories.Managed)]
        public int MultiplyInt() => ManagedFunctions.MultiplyInt(1234, 4321);

        [Benchmark]
        [BenchmarkCategory(Categories.InReturnBool, Categories.Managed)]
        public bool NegateBool() => ManagedFunctions.NegateBool(false);
    }

    internal static class ManagedFunctions
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Empty_Void()
        {
            // Method intentionally left empty.
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Empty_IntArray(int[] array, int length)
        {
            // Method intentionally left empty.
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Empty_String(string str)
        {
            // Method intentionally left empty.
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int ConstantInt() => 42;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int MultiplyInt(int a, int b) => a * b;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static bool NegateBool(bool value) => !value;
    }
}
