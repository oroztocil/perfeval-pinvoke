﻿using System.Runtime.InteropServices;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface;
using PInvoke.NativeInterface.LibraryImport;
using PInvoke.NativeInterface.Models;

namespace PInvoke.Benchmarks
{
    // LibraryImport is only supported in .NET 7 and newer
    [SimpleJob(RuntimeMoniker.Net80)]
    public partial class LibraryImport : BenchmarkBase
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Void_Empty, Categories.SGCT, Categories.SLE)]
        public void EmptyVoid() => NativeFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory(Categories.SGCT)]
        public void EmptyVoid_SGCT() => NativeFunctions.Empty_VoidSGCT();

        [Benchmark]
        [BenchmarkCategory(Categories.SLE)]
        public void EmptyVoid_SLE() => NativeFunctions.Empty_VoidSLE();

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Int_Out)]
        public int ConstantInt() => NativeFunctions.ConstantInt();

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Int_InOut)]
        public int MultiplyInt() => NativeFunctions.MultiplyInt(1234, 4321);

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Bool_InOut)]
        public bool NegateBool() => NativeFunctions.NegateBool(false);

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_In)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public int SumIntArray(int[] input) => NativeFunctions.SumIntArray(input, input.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_InOut)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray_ByValue(int[] input) => NativeFunctions.FillIntArray(input, input.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_InOut)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray_Pinned(int[] input) => NativeFunctions.FillIntArray_Pinned(input, input.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_InOut)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray_Fixed(int[] input) => NativeFunctions.FillIntArray_Fixed(input, input.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_In)]
        public int StringLength_Utf8() => NativeFunctions.StringLength_Utf8(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_In)]
        public int StringLength_Utf16() => NativeFunctions.StringLength_Utf16(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_InOut)]
        public string StringToUppercase_ByteArray() => NativeFunctions.StringToUppercase_ByteArray(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_InOut)]
        public string StringToUppercase_Fixed() => NativeFunctions.StringToUppercase_Fixed(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_Blittable)]
        [ArgumentsSource(nameof(BlittableStruct))]
        public BlittableStruct SumIntsInStruct_Return(BlittableStruct input) =>
            NativeFunctions.SumIntsInStruct_Return(input);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_Blittable)]
        [ArgumentsSource(nameof(BlittableStruct))]
        public void SumIntsInStruct_Ref(BlittableStruct input) =>
            NativeFunctions.SumIntsInStruct_Ref(ref input);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_NonBlittable)]
        [ArgumentsSource(nameof(NonBlittableStruct))]
        public void UpdateNonBlittableStruct_Manual(NonBlittableStruct input) =>
            NativeFunctions.UpdateNonBlittableStruct_Manual(ref input);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_NonBlittable)]
        [ArgumentsSource(nameof(NonBlittableStruct))]
        public void UpdateNonBlittableStruct_Marshaller(NonBlittableStruct input) =>
            NativeFunctions.UpdateNonBlittableStruct_Marshaller(ref input);
    }

    [ColdStartJob(RuntimeMoniker.Net80)]
    public class LibraryImportCS : BenchmarkBase
    {
        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_{Categories.Void_Empty}")]
        public void EmptyVoid() => NativeFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_{Categories.Arrays_InOut}")]
        [ArgumentsSource(nameof(EmptyIntArray))]
        public void FillIntArray_ByValue(int[] input) => NativeFunctions.FillIntArray(input, input.Length);

        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_{Categories.Structs_Blittable}")]
        [ArgumentsSource(nameof(BlittableStruct))]
        public void SumIntsInStruct_Ref(BlittableStruct input) =>
            NativeFunctions.SumIntsInStruct_Ref(ref input);

        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_{Categories.Structs_NonBlittable}")]
        [ArgumentsSource(nameof(NonBlittableStruct))]
        public void UpdateNonBlittableStruct_Manual(NonBlittableStruct input) =>
            NativeFunctions.UpdateNonBlittableStruct_Manual(ref input);

        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_Mixed")]
        public string Mixed()
        {
            NativeFunctions.Empty_Void();

            var flag = NativeFunctions.NegateBool(false);
            var num = NativeFunctions.ConstantInt();
            var res = NativeFunctions.MultiplyInt(num, flag ? 2 : 3);

            var arr = new int[res];

            NativeFunctions.FillIntArray(arr, arr.Length);
            NativeFunctions.SumIntArray(arr, arr.Length);

            var len8 = NativeFunctions.StringLength_Utf8(Data.NonAsciiString);
            var len16 = NativeFunctions.StringLength_Utf16(Data.NonAsciiString);

            var uppercase = NativeFunctions.StringToUppercase_ByteArray(Data.NonAsciiString);

            var blitStruct = new BlittableStruct { a = len8, b = len16 };

            NativeFunctions.SumIntsInStruct_Ref(ref blitStruct);

            var res2 = NativeFunctions.MultiplyInt(num, blitStruct.result);

            var nonBlitStruct = new NonBlittableStruct
            {
                flag = flag,
                text = uppercase,
                number = res2,
                numberArray = arr
            };

            NativeFunctions.UpdateNonBlittableStruct_Manual(ref nonBlitStruct);

            return nonBlitStruct.text;
        }
    }
}
