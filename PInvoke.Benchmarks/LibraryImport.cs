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
    public class LibraryImport : BenchmarkBase
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.SGCT)]
        public void Empty_Void() => NativeFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.SGCT)]
        public void Empty_Void_SGCT() => NativeFunctions.Empty_Void_SGCT();

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InArray)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray(int[] array) => NativeFunctions.Empty_IntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InArray, Categories.SGCT)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray_SGCT(int[] array) => NativeFunctions.Empty_IntArray_SGCT(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InArray)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray_Fixed(int[] array) => NativeFunctions.Empty_IntArray_Fixed(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InString)]
        public void Empty_String() => NativeFunctions.Empty_String(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InString, Categories.SGCT)]
        public void Empty_String_SGCT() => NativeFunctions.Empty_String_SGCT(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.ReturnInt)]
        public int ConstantInt() => NativeFunctions.ConstantInt();

        [Benchmark]
        [BenchmarkCategory(Categories.InReturnInt)]
        public int MultiplyInt() => NativeFunctions.MultiplyInt(1234, 4321);

        [Benchmark]
        [BenchmarkCategory(Categories.InReturnInt, Categories.SGCT)]
        public int MultiplyInt_SGCT() => NativeFunctions.MultiplyInt_SGCT(1234, 4321);

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
        public void FillIntArray_PinnedHandle(int[] array) => NativeFunctions.FillIntArray_Pinned(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.OutArray)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray_Fixed(int[] array) => NativeFunctions.FillIntArray_Fixed(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.InString)]
        public int StringLength_Utf8() => NativeFunctions.StringLength_Utf8(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.InString)]
        public int StringLength_Utf16() => NativeFunctions.StringLength_Utf16(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.OutString)]
        public string StringToUppercase_ByteArray() => NativeFunctions.StringToUppercase_ByteArray(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.OutString)]
        public string StringToUppercase_Fixed() => NativeFunctions.StringToUppercase_Fixed(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct)]
        [ArgumentsSource(nameof(BlittableStructs))]
        public BlittableStruct SumIntsInStruct_Return(BlittableStruct input) =>
            NativeFunctions.SumIntsInStruct_Return(input);

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct)]
        [ArgumentsSource(nameof(BlittableStructs))]
        public void SumIntsInStruct_Ref(BlittableStruct input) =>
            NativeFunctions.SumIntsInStruct_Ref(ref input);

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct, Categories.NonBlittable)]
        [ArgumentsSource(nameof(NonBlittableStructs))]
        public void UpdateNonBlittableStruct_Manual(NonBlittableStruct input) =>
            NativeFunctions.UpdateNonBlittableStruct_Manual(ref input);

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct, Categories.NonBlittable)]
        [ArgumentsSource(nameof(NonBlittableStructs))]
        public void UpdateNonBlittableStruct_Marshaller(NonBlittableStruct input) =>
            NativeFunctions.UpdateNonBlittableStruct_Marshaller(ref input);
    }
}
