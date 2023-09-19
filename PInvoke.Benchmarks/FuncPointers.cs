﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface.FuncPointers;
using PInvoke.NativeInterface.Models;

namespace PInvoke.Benchmarks
{
    // Function pointers are only supported in .NET 5 and newer
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net80)]
    public class FuncPointers : BenchmarkBase
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Void_Empty)]
        public void Empty_Void() => NativeFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory(Categories.SGCT)]
        public void Empty_Void_SGCT() => NativeFunctions.Empty_Void_SGCT();

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_Empty_In)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray(int[] array) => NativeFunctions.Empty_IntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.SGCT)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray_SGCT(int[] array) => NativeFunctions.Empty_IntArray_SGCT(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_Empty_In)]
        public void Empty_String() => NativeFunctions.Empty_String(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.SGCT)]
        public void Empty_String_SGCT() => NativeFunctions.Empty_String_SGCT(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Int_Out)]
        public int ConstantInt() => NativeFunctions.ConstantInt();

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Int_InOut)]
        public int MultiplyInt() => NativeFunctions.MultiplyInt(1234, 4321);

        [Benchmark]
        [BenchmarkCategory(Categories.SGCT)]
        public int MultiplyInt_SGCT() => NativeFunctions.MultiplyInt_SGCT(1234, 4321);

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Bool_InOut)]
        public bool NegateBool() => NativeFunctions.NegateBool(false);

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_In)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public int SumIntArray(int[] array) => NativeFunctions.SumIntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_InOut)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray(int[] array) => NativeFunctions.FillIntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_InOut)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray_PinnedHandle(int[] array) => NativeFunctions.FillIntArray_Pinned(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_In)]
        public int StringLength_Utf8() => NativeFunctions.StringLength_Utf8(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_In)]
        public int StringLength_Utf16() => NativeFunctions.StringLength_Utf16(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_InOut)]
        public string StringToUppercase_Fixed() => NativeFunctions.StringToUppercase_Fixed(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_Blittable)]
        [ArgumentsSource(nameof(BlittableStructs))]
        public BlittableStruct SumIntsInStruct_Return(BlittableStruct input) =>
            NativeFunctions.SumIntsInStruct_Return(input);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_Blittable)]
        [ArgumentsSource(nameof(BlittableStructs))]
        public void SumIntsInStruct_Ref(BlittableStruct input) =>
            NativeFunctions.SumIntsInStruct_Ref(ref input);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_Blittable)]
        [ArgumentsSource(nameof(BlittableClasses))]
        public void SumIntsInClass_Ref(BlittableClass input) =>
            NativeFunctions.SumIntsInClass_Ref(input);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_NonBlittable)]
        [ArgumentsSource(nameof(NonBlittableStructs))]
        public void UpdateNonBlittableStruct_Manual(NonBlittableStruct input) =>
            NativeFunctions.UpdateNonBlittableStruct_Manual(ref input);
    }
}
