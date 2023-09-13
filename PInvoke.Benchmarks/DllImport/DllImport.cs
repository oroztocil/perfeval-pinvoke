using System.Collections.Generic;
using System.Text;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface.DllImport;

namespace PInvoke.Benchmarks.DllImport
{
    // DllImport is supported in all .NET versions
    #if WINDOWS
    [SimpleJob(RuntimeMoniker.Net48)]
    #endif
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class DllImport
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Empty)]
        public void Empty() => NativeFunctions.Empty();

        [Benchmark]
        [BenchmarkCategory(Categories.ReturnInt)]
        public int ConstantInt() => NativeFunctions.ConstantInt();
d
        [Benchmark]
        [BenchmarkCategory(Categories.InReturnInt)]
        public int MultiplyInt() => NativeFunctions.MultiplyInt(1234, 4321);

        [Benchmark]
        [BenchmarkCategory(Categories.InReturnBool)]
        public bool NegateBool() => NativeFunctions.NegateBool(false);

        [Benchmark]
        [BenchmarkCategory(Categories.InIntArray)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public int SumIntArray(int[] array) => NativeFunctions.SumIntArray(array, array.Length);

        public static IEnumerable<int[]> RandomIntArrays => Data.RandomIntArrays;

        [Benchmark]
        [BenchmarkCategory(Categories.InString)]
        public int StringLength8() => NativeFunctions.StringLength8("abraka dabra");

        [Benchmark]
        [BenchmarkCategory(Categories.InString)]
        public int StringLength16() => NativeFunctions.StringLength16("abraka dabra");

        [Benchmark]
        [BenchmarkCategory(Categories.OutString)]
        public string StringToUppercase() => NativeFunctions.StringToUppercase("abraka dabra");
    }
}