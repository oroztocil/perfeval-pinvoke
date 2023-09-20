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
    [WarmupCount(Settings.ThroughputWarmupCount)]
    [IterationTime(Settings.ThroughputTargetIterationTime)]
    public abstract class BenchmarkBase
    {
        public static IEnumerable<int[]> EmptyIntArray => Data.EmptyIntArray;
        public static IEnumerable<int[]> EmptyIntArrays => Data.EmptyIntArrays;
        public static IEnumerable<int[]> RandomIntArray => Data.RandomIntArray;
        public static IEnumerable<int[]> RandomIntArrays => Data.RandomIntArrays;
        public static IEnumerable<BlittableStruct> BlittableStruct => Data.BlittableStructs;
        public static IEnumerable<BlittableClass> BlittableClasses => Data.BlittableClasses;
        public static IEnumerable<NonBlittableStruct> NonBlittableStruct => Data.NonBlittableStructs;
    }
}
