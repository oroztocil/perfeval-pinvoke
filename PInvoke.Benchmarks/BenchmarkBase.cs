using System.Collections.Generic;

using PInvoke.NativeInterface.Models;

namespace PInvoke.Benchmarks
{
    public abstract class BenchmarkBase
    {
        public static IEnumerable<int[]> RandomIntArrays => Data.RandomIntArrays;
        public static IEnumerable<int[]> EmptyIntArrays => Data.EmptyIntArrays;
        public static IEnumerable<BlittableStruct> BlittableStructs => Data.BlittableStructs;
        public static IEnumerable<BlittableClass> BlittableClasses => Data.BlittableClasses;
        public static IEnumerable<NonBlittableStruct> NonBlittableStructs => Data.NonBlittableStructs;
    }
}
