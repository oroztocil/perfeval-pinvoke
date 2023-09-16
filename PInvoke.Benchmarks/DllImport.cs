using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface.DllImport;
using PInvoke.NativeInterface.Models;

namespace PInvoke.Benchmarks
{
    // DllImport is supported in all .NET versions, .NET 4.8 is Windows-only
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
        public static IEnumerable<BlittableStruct> BlittableStructs => Data.BlittableStructs;
        public static IEnumerable<BlittableClass> BlittableClasses => Data.BlittableClasses;

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
        public void FillIntArray_Fixed(int[] array) => NativeFunctions.FillIntArray_Fixed(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.InString)]
        public int StringLength_Utf8() => NativeFunctions.StringLength_Utf8("abraka dabra");

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
        public string StringToUppercase_Pointer() => NativeFunctions.StringToUppercase_Fixed("abraka dabra");

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct)]
        [ArgumentsSource(nameof(BlittableStructs))]
        public BlittableStruct SumIntsInStruct_Return(BlittableStruct data) =>
            NativeFunctions.SumIntsInStruct_Return(data);

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct)]
        [ArgumentsSource(nameof(BlittableStructs))]
        public void SumIntsInStruct_Ref(BlittableStruct data) =>
            NativeFunctions.SumIntsInStruct_Ref(ref data);

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct)]
        [ArgumentsSource(nameof(BlittableClasses))]
        public void SumIntsInClass_Ref(BlittableClass data) =>
            NativeFunctions.SumIntsInClass_Ref(data);
    }
}