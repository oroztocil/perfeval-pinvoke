using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using PInvoke.NativeInterface.FuncPointers;
using PInvoke.NativeInterface.Models;

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;

namespace PInvoke.Benchmarks
{
    // Function pointers are only supported in .NET 5 and newer
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser]
    public class FuncPointers : BenchmarkBase
    {
        [Benchmark]
        [BenchmarkCategory(Categories.Empty)]
        public void Empty_Void() => NativeFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InArray)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray(int[] array) => NativeFunctions.Empty_IntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Empty, Categories.InString)]
        public void Empty_String() => NativeFunctions.Empty_String(Data.NonAsciiString);

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
        public void FillIntArray_PinnedHandle(int[] array) => NativeFunctions.FillIntArray_Pinned(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.InString)]
        public int StringLength_Utf8() => NativeFunctions.StringLength_Utf8(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.InString)]
        public int StringLength_Utf16() => NativeFunctions.StringLength_Utf16(Data.NonAsciiString);

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
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct)]
        [ArgumentsSource(nameof(BlittableClasses))]
        public void SumIntsInClass_Ref(BlittableClass input) =>
            NativeFunctions.SumIntsInClass_Ref(input);

        [Benchmark]
        [BenchmarkCategory(Categories.InStruct, Categories.OutStruct, Categories.NonBlittable)]
        [ArgumentsSource(nameof(NonBlittableStructs))]
        public void UpdateNonBlittableStruct_Manual(NonBlittableStruct input) =>
            NativeFunctions.UpdateNonBlittableStruct_Manual(ref input);

        [Benchmark]
        [BenchmarkCategory(Categories.Managed)]
        public bool QueryPerformanceCounter5() => QueryPerformanceCounter5(out long value);

        [Benchmark]
        [BenchmarkCategory(Categories.Managed)]
        public bool QueryPerformanceCounter6() => QueryPerformanceCounter6(out long value);

        [SuppressGCTransition]
        [DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceCounter", SetLastError = false, ExactSpelling = true)]
        private static extern bool QueryPerformanceCounter5(out long value);

        [SuppressUnmanagedCodeSecurity]
        [SuppressGCTransition]
        [DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceCounter", SetLastError = false, ExactSpelling = true)]
        private static extern bool QueryPerformanceCounter6(out long value);
    }
}
