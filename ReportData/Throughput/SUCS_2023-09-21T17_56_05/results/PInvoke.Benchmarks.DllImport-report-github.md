```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-XBXNFR : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-AYTIJD : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-GTQUQA : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Method         | Runtime            | Mean      | Error     | StdDev    | Median    | Min       | Max       | Allocated |
|--------------- |------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|
| EmptyVoid_SUCS | .NET 8.0           |  6.846 ns | 0.0021 ns | 0.0017 ns |  6.845 ns |  6.844 ns |  6.850 ns |         - |
| EmptyVoid      | .NET 8.0           |  7.023 ns | 0.0714 ns | 0.0633 ns |  7.052 ns |  6.890 ns |  7.089 ns |         - |
| EmptyVoid_SUCS | .NET 6.0           |  7.029 ns | 0.0035 ns | 0.0027 ns |  7.027 ns |  7.025 ns |  7.035 ns |         - |
| EmptyVoid      | .NET 6.0           |  7.372 ns | 0.0015 ns | 0.0012 ns |  7.371 ns |  7.370 ns |  7.374 ns |         - |
| EmptyVoid_SUCS | .NET Framework 4.8 |  8.442 ns | 0.0372 ns | 0.0348 ns |  8.420 ns |  8.414 ns |  8.500 ns |         - |
| EmptyVoid      | .NET Framework 4.8 | 12.314 ns | 0.0475 ns | 0.0445 ns | 12.288 ns | 12.283 ns | 12.386 ns |         - |
