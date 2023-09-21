namespace PInvoke.Benchmarks
{
    internal static class Settings
    {
        public const int ThroughputWarmupCount = 5;
        public const int ThroughputTargetIterationTime = 250;
        public const double ThroughputMaxRelativeError = 0.01;

        public const int ColdStartLaunchCount = 1;
        public const int ColdStartIterationCount = 1;
        public const int ColdStartInvocationCount = 1;
    }
}
