```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ZFKPLD : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-CVBLIW : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-VUUPEG : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    282.0 μs |    NA |    282.0 μs |    282.0 μs |    282.0 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    294.9 μs |    NA |    294.9 μs |    294.9 μs |    294.9 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    358.7 μs |    NA |    358.7 μs |    358.7 μs |    358.7 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,095.7 μs |    NA | 31,095.7 μs | 31,095.7 μs | 31,095.7 μs |     640 B |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 31,651.5 μs |    NA | 31,651.5 μs | 31,651.5 μs | 31,651.5 μs |     400 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 31,773.4 μs |    NA | 31,773.4 μs | 31,773.4 μs | 31,773.4 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 42,086.0 μs |    NA | 42,086.0 μs | 42,086.0 μs | 42,086.0 μs |     640 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 42,216.9 μs |    NA | 42,216.9 μs | 42,216.9 μs | 42,216.9 μs |         - |
| DllImportCS     | Empty_Void | .NET 8.0           | 42,585.1 μs |    NA | 42,585.1 μs | 42,585.1 μs | 42,585.1 μs |     400 B |
