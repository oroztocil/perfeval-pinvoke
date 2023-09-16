using System;
using System.Collections.Generic;
using System.Linq;

using PInvoke.NativeInterface.Models;

namespace PInvoke.Benchmarks
{
    internal static class Data
    {
        private static readonly Random rng = new(42);

        public static IEnumerable<int[]> EmptyIntArrays => new[]
{
            new int[10],
            new int[1000],
        };

        public static IEnumerable<int[]> RandomIntArrays => new[]
        {
            GetRandomIntArray(10),
            GetRandomIntArray(1000),
        };

        public static IEnumerable<BlittableStruct> BlittableStructs => new[]
        {
            new BlittableStruct { a = 1, b = 2 }
        };

        public static IEnumerable<BlittableClass> BlittableClasses => new[]
        {
            new BlittableClass { a = 1, b = 2 }
        };

private static int[] GetRandomIntArray(int size) =>
            Enumerable.Range(0, size)
                .Select(_ => rng.Next())
                .ToArray();
    }
}
