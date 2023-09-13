using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface.DllImport;

namespace PInvoke.Benchmarks
{
    // DllImport is supported in all .NET versions
#if OS_WINDOWS
    [SimpleJob(RuntimeMoniker.Net48)]
#endif
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser]
    public class DllImport
    {
        public static IEnumerable<int[]> RandomIntArrays => Data.RandomIntArrays;
        public static IEnumerable<int[]> EmptyIntArrays => Data.EmptyIntArrays;

        [Benchmark]
        [BenchmarkCategory(Categories.Empty)]
        public void Empty_Void() => NativeFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InArray)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray(int[] array) => NativeFunctions.Empty_IntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InArray)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray_FixedPtr(int[] array) => NativeFunctions.Empty_IntArray_FixedPtr(array, array.Length);

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
        public int SumIntArray(int[] array) => NativeFunctions.SumIntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.OutArray)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray(int[] array) => NativeFunctions.FillIntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.OutArray)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray_OutAttr(int[] array) => NativeFunctions.FillIntArray_OutAttr(array, array.Length);


        [Benchmark]
        [BenchmarkCategory(Categories.OutArray)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray_PinnedHandle(int[] array) => NativeFunctions.FillIntArray_Pinned(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.OutArray)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray_FixedPtr(int[] array) => NativeFunctions.FillIntArray_FixedPtr(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.InString)]
        public int StringLength_MultiByte() => NativeFunctions.StringLength_MultiByte("abraka dabra");

        [Benchmark]
        [BenchmarkCategory(Categories.InString)]
        public int StringLength_Utf16() => NativeFunctions.StringLength_Utf16("abraka dabra");

        [Benchmark]
        [BenchmarkCategory(Categories.OutString)]
        public string StringToUppercase_ByteArray() => NativeFunctions.StringToUppercase_ByteArray("abraka dabra");

        [Benchmark]
        [BenchmarkCategory(Categories.OutString)]
        public string StringToUppercase_StringBuilder() => NativeFunctions.StringToUppercase_StringBuilder("abraka dabra");

        [Benchmark]
        [BenchmarkCategory(Categories.OutString)]
        public string StringToUppercase_Pointer() => NativeFunctions.StringToUppercase_Pointer("abraka dabra");
    }
}