```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-YZHRAF : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-IEWZHE : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TWDLST : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    267.6 μs |    NA |    267.6 μs |    267.6 μs |    267.6 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    281.2 μs |    NA |    281.2 μs |    281.2 μs |    281.2 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    369.1 μs |    NA |    369.1 μs |    369.1 μs |    369.1 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 30,418.6 μs |    NA | 30,418.6 μs | 30,418.6 μs | 30,418.6 μs |     640 B |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 31,563.5 μs |    NA | 31,563.5 μs | 31,563.5 μs | 31,563.5 μs |     400 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 31,894.7 μs |    NA | 31,894.7 μs | 31,894.7 μs | 31,894.7 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 40,948.1 μs |    NA | 40,948.1 μs | 40,948.1 μs | 40,948.1 μs |     640 B |
| DllImportCS     | Empty_Void | .NET 8.0           | 41,050.6 μs |    NA | 41,050.6 μs | 41,050.6 μs | 41,050.6 μs |     400 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 41,563.1 μs |    NA | 41,563.1 μs | 41,563.1 μs | 41,563.1 μs |         - |
