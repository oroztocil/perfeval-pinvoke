using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface.DllImport;

namespace PInvoke.Benchmarks.DllImport
{
    // DllImport is supported in all .NET versions
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class DllImport
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Empty)]
        public void Empty() => NativeFunctions.Empty();

        [Benchmark]
        [BenchmarkCategory(Categories.ConstantInt)]
        public int ConstantInt() => NativeFunctions.ConstantInt();

        [Benchmark]
        [BenchmarkCategory(Categories.MultiplyInt)]
        public int MultiplyInt() => NativeFunctions.MultiplyInt(1234, 4321);

        [Benchmark]
        [BenchmarkCategory(Categories.NegateBool)]
        public bool NegateBool() => NativeFunctions.NegateBool(false);

        [Benchmark]
        [BenchmarkCategory(Categories.SumIntArray)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public int SumIntArray(int[] array) => NativeFunctions.SumIntArray(array, array.Length);

        public static IEnumerable<int[]> RandomIntArrays => Data.RandomIntArrays;

        [Benchmark]
        [BenchmarkCategory(Categories.StringLength)]
        public int StringLength8() => NativeFunctions.StringLength8("abraka dabra");

        [Benchmark]
        [BenchmarkCategory(Categories.StringLength)]
        public int StringLength16() => NativeFunctions.StringLength16("abraka dabra");
    }
}