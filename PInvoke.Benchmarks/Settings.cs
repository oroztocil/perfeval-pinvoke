namespace PInvoke.Benchmarks
{
    internal static class Settings
    {
        public const int ThroughputWarmupCount = 5;
        public const int ThroughputTargetIterationTime = 250;

        public const int ColdStartLaunchCount = 100;
        public const int ColdStartIterationCount = 1;
        public const int ColdStartInvocationCount = 1;
    }
}
