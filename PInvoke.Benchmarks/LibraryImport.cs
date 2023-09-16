using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface.LibraryImport;
using PInvoke.NativeInterface.Models;

namespace PInvoke.Benchmarks
{
    // LibraryImport is only supported in .NET 7 and newer
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser]
    public class LibraryImport
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
        public string StringToUppercase_PooledByteArray() => NativeFunctions.StringToUppercase_PooledByteArray("abraka dabra");

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct)]
        [ArgumentsSource(nameof(BlittableStructs))]
        public BlittableStruct SumIntsInStruct_Return(BlittableStruct data) =>
            NativeFunctions.SumIntsInStruct_Return(data);

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct)]
        [ArgumentsSource(nameof(BlittableStructs))]
        public void SumIntsInStruct_Pointer(BlittableStruct data) =>
            NativeFunctions.SumIntsInStruct_Ref(ref data);

        //[Benchmark]
        //[BenchmarkCategory(Categories.InStruct, Categories.OutStruct)]
        //[ArgumentsSource(nameof(BlittableClasses))]
        //public void SumIntsInClass_Pointer(BlittableClass data) =>
        //    NativeFunctions.SumIntsInClass_Pointer(data);
    }
}
