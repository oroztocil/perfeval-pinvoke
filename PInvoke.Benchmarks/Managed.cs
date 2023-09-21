using System;
using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;

using Microsoft.Diagnostics.Runtime.Utilities;

using PInvoke.NativeInterface.Models;

namespace PInvoke.Benchmarks
{
    // .NET 4.8 is Windows-only
#if OS_WINDOWS
    [SimpleJob(RuntimeMoniker.Net48)]
#endif
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net80)]
    public class Managed : BenchmarkBase
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Void_Empty)]
        public void EmptyVoid() => ManagedFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_Empty_In)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void EmptyIntArrayManaged(int[] input) => ManagedFunctions.Empty_IntArray(input, input.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_Empty_In)]
        public void EmptyString() => ManagedFunctions.Empty_String(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Int_Out)]
        public int ConstantInt() => ManagedFunctions.ConstantInt();

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Int_InOut)]
        public int MultiplyInt() => ManagedFunctions.MultiplyInt(1234, 4321);

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Bool_InOut)]
        public bool NegateBool() => ManagedFunctions.NegateBool(false);

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_In)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public int SumIntArray(int[] input) => ManagedFunctions.SumIntArray(input, input.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_InOut)]
        [ArgumentsSource(nameof(EmptyIntArrays))]
        public void FillIntArray(int[] input) => ManagedFunctions.FillIntArray(input, input.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_Blittable)]
        [ArgumentsSource(nameof(BlittableStruct))]
        public void SumIntsInStruct(BlittableStruct input) =>
            ManagedFunctions.SumIntsInStruct(ref input);

        [Benchmark]
        [BenchmarkCategory(Categories.Structs_NonBlittable)]
        [ArgumentsSource(nameof(NonBlittableStruct))]
        public void UpdateNonBlittableStruct(NonBlittableStruct input) =>
            ManagedFunctions.UpdateNonBlittableStruct(ref input);
    }

#if OS_WINDOWS
    [ColdStartJob(RuntimeMoniker.Net48)]
#endif
    [ColdStartJob(RuntimeMoniker.Net60)]
    [ColdStartJob(RuntimeMoniker.Net80)]
    public class ManagedCS : BenchmarkBase
    {
        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_{Categories.Void_Empty}")]
        public void Empty_Void() => ManagedFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_{Categories.Strings_Empty_In}")]
        public void Empty_String() => ManagedFunctions.Empty_String(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_{Categories.Arrays_InOut}")]
        [ArgumentsSource(nameof(EmptyIntArray))]
        public void FillIntArray(int[] input) => ManagedFunctions.FillIntArray(input, input.Length);

        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_{Categories.Structs_Blittable}")]
        [ArgumentsSource(nameof(BlittableStruct))]
        public void SumIntsInStruct_Ref(BlittableStruct input) =>
            ManagedFunctions.SumIntsInStruct(ref input);

        [Benchmark]
        [BenchmarkCategory($"{Categories.CS}_{Categories.Structs_NonBlittable}")]
        [ArgumentsSource(nameof(NonBlittableStruct))]
        public void UpdateNonBlittableStruct_Manual(NonBlittableStruct input) =>
            ManagedFunctions.UpdateNonBlittableStruct(ref input);
    }

    internal static class ManagedFunctions
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Empty_Void()
        {
            // Method intentionally left empty.
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Empty_IntArray(int[] array, int length)
        {
            // Method intentionally left empty.
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Empty_String(string str)
        {
            // Method intentionally left empty.
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int ConstantInt() => 42;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int MultiplyInt(int a, int b) => a * b;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static bool NegateBool(bool value) => !value;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int SumIntArray(int[] input, int length)
        {
            int result = 0;

            for (int i = 0; i < length; i++)
            {
                result += input[i];
            }

            return result;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void FillIntArray(int[] input, int length)
        {
            for (int i = 0; i < length; i++)
            {
                input[i] = i;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void SumIntsInStruct(ref BlittableStruct input)
        {
            input.result = input.a + input.b;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void UpdateNonBlittableStruct(ref NonBlittableStruct input)
        {
            input.number++;
            input.flag = !input.flag;

            if (input.text.Length > 0)
            {
                input.text = 'X' + input.text.Substring(1);
            }

            for (int i = 0; i < input.numberArray.Length; i++)
            {
                input.numberArray[i]++;
            }
        }
    }
}
