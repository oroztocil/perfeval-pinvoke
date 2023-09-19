using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

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
        public void Empty_Void() => ManagedFunctions.Empty_Void();

        [Benchmark]
        [BenchmarkCategory(Categories.Arrays_Empty_In)]
        [ArgumentsSource(nameof(RandomIntArrays))]
        public void Empty_IntArray(int[] array) => ManagedFunctions.Empty_IntArray(array, array.Length);

        [Benchmark]
        [BenchmarkCategory(Categories.Strings_Empty_In)]
        public void Empty_String() => ManagedFunctions.Empty_String(Data.NonAsciiString);

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Int_Out)]
        public int ConstantInt() => ManagedFunctions.ConstantInt();

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Int_InOut)]
        public int MultiplyInt() => ManagedFunctions.MultiplyInt(1234, 4321);

        [Benchmark]
        [BenchmarkCategory(Categories.Primitive_Bool_InOut)]
        public bool NegateBool() => ManagedFunctions.NegateBool(false);
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
    }
}
