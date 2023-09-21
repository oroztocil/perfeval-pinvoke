```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-XIOOOV : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-RBBBWB : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-PIAPPJ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Method         | Runtime            | Mean      | Error     | StdDev    | Median    | Min       | Max       | Allocated |
|--------------- |------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|
| EmptyVoid      | .NET 8.0           |  6.844 ns | 0.0018 ns | 0.0016 ns |  6.843 ns |  6.843 ns |  6.848 ns |         - |
| EmptyVoid      | .NET 6.0           |  7.065 ns | 0.0137 ns | 0.0128 ns |  7.064 ns |  7.038 ns |  7.086 ns |         - |
| EmptyVoid_SUCS | .NET 8.0           |  9.066 ns | 0.0007 ns | 0.0005 ns |  9.066 ns |  9.066 ns |  9.067 ns |         - |
| EmptyVoid_SUCS | .NET 6.0           |  9.070 ns | 0.0035 ns | 0.0033 ns |  9.069 ns |  9.066 ns |  9.076 ns |         - |
| EmptyVoid_SUCS | .NET Framework 4.8 | 10.462 ns | 0.0023 ns | 0.0019 ns | 10.461 ns | 10.461 ns | 10.466 ns |         - |
| EmptyVoid      | .NET Framework 4.8 | 12.329 ns | 0.0081 ns | 0.0072 ns | 12.326 ns | 12.319 ns | 12.346 ns |         - |
