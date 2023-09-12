using System;
using System.Collections.Generic;
using System.Linq;

namespace PInvoke.Benchmarks
{
    internal static class Data
    {
        private static readonly Random rng = new(42);

        public static readonly IEnumerable<int[]> RandomIntArrays = new[]
        {
            GetRandomIntArray(10),
            GetRandomIntArray(1000)
        };

        private static int[] GetRandomIntArray(int size) =>
            Enumerable.Range(0, size)
                .Select(_ => rng.Next())
                .ToArray();
    }
}
