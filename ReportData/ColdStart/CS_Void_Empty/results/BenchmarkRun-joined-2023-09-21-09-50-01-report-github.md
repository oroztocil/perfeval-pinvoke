```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-WJOYRF : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-BALTOP : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-XWGOCO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    278.8 μs |    NA |    278.8 μs |    278.8 μs |    278.8 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    282.7 μs |    NA |    282.7 μs |    282.7 μs |    282.7 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    362.9 μs |    NA |    362.9 μs |    362.9 μs |    362.9 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 30,443.0 μs |    NA | 30,443.0 μs | 30,443.0 μs | 30,443.0 μs |     400 B |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,495.5 μs |    NA | 31,495.5 μs | 31,495.5 μs | 31,495.5 μs |     640 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 32,436.5 μs |    NA | 32,436.5 μs | 32,436.5 μs | 32,436.5 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 41,385.2 μs |    NA | 41,385.2 μs | 41,385.2 μs | 41,385.2 μs |     640 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 41,850.2 μs |    NA | 41,850.2 μs | 41,850.2 μs | 41,850.2 μs |         - |
| DllImportCS     | Empty_Void | .NET 8.0           | 42,015.1 μs |    NA | 42,015.1 μs | 42,015.1 μs | 42,015.1 μs |     400 B |
