```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-WKCRIW : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-OQRZYR : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-SYQDLP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    269.4 μs |    NA |    269.4 μs |    269.4 μs |    269.4 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    289.8 μs |    NA |    289.8 μs |    289.8 μs |    289.8 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    364.8 μs |    NA |    364.8 μs |    364.8 μs |    364.8 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 31,052.7 μs |    NA | 31,052.7 μs | 31,052.7 μs | 31,052.7 μs |     400 B |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,303.4 μs |    NA | 31,303.4 μs | 31,303.4 μs | 31,303.4 μs |     640 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 32,148.9 μs |    NA | 32,148.9 μs | 32,148.9 μs | 32,148.9 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 8.0           | 41,612.1 μs |    NA | 41,612.1 μs | 41,612.1 μs | 41,612.1 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 42,146.5 μs |    NA | 42,146.5 μs | 42,146.5 μs | 42,146.5 μs |     640 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 42,169.5 μs |    NA | 42,169.5 μs | 42,169.5 μs | 42,169.5 μs |         - |
