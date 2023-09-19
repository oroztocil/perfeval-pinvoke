using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

using PInvoke.NativeInterface.Models;

namespace PInvoke.Benchmarks
{
#if OS_WINDOWS
    // ETW profiler is only available on Windows
    //using BenchmarkDotNet.Diagnostics.Windows.Configs;
    //[NativeMemoryProfiler]
#endif
    //[MemoryDiagnoser]
    [WarmupCount(5)]
    [IterationTime(300)]
    //[Orderer(SummaryOrderPolicy.Declared, MethodOrderPolicy.Alphabetical)]
    public abstract class BenchmarkBase
    {
        public static IEnumerable<int[]> RandomIntArrays => Data.RandomIntArrays;
        public static IEnumerable<int[]> EmptyIntArrays => Data.EmptyIntArrays;
        public static IEnumerable<BlittableStruct> BlittableStructs => Data.BlittableStructs;
        public static IEnumerable<BlittableClass> BlittableClasses => Data.BlittableClasses;
        public static IEnumerable<NonBlittableStruct> NonBlittableStructs => Data.NonBlittableStructs;
    }
}
