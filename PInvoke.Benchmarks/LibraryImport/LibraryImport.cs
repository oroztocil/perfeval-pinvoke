using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface.LibraryImport;

namespace PInvoke.Benchmarks.LibraryImport
{
    // LibraryImport is only supported in .NET 7 and newer
    [SimpleJob(RuntimeMoniker.Net70)]
    public class LibraryImport
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Empty)]
        public void Empty() => NativeFunctions.Empty();

        [Benchmark]
        [BenchmarkCategory(Categories.ReturnInt)]
        public int ConstantInt() => NativeFunctions.ConstantInt();

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
