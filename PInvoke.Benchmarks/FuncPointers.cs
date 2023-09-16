using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface.FuncPointers;
using PInvoke.NativeInterface.Models;

using System.Collections.Generic;

namespace PInvoke.Benchmarks
{
    // Function pointers are only supported in .NET 5 and newer
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser]
    public class FuncPointers
    {
        public static IEnumerable<int[]> EmptyIntArrays => Data.EmptyIntArrays;
        public static IEnumerable<int[]> RandomIntArrays => Data.RandomIntArrays;
        public static IEnumerable<BlittableStruct> BlittableStructs => Data.BlittableStructs;
        public static IEnumerable<BlittableClass> BlittableClasses => Data.BlittableClasses;

        [Benchmark]
        [BenchmarkCategory(Categories.Empty)]
        public void Empty_Void() => NativeFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InArray)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray_Fixed(int[] array) => NativeFunctions.Empty_IntArray_Fixed(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InString)]
        public void Empty_String() => NativeFunctions.Empty_String("abraka dabra");

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
        [BenchmarkCategory(Categories.InArray)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public int SumIntArray_Fixed(int[] array) => NativeFunctions.SumIntArray_Fixed(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.OutArray)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray_Fixed(int[] array) => NativeFunctions.FillIntArray_Fixed(array, array.Length);
    }
}
