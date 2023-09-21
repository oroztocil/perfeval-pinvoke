```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-FNMOSL : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-LHOBQM : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-NQYTEZ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    268.0 μs |    NA |    268.0 μs |    268.0 μs |    268.0 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    291.0 μs |    NA |    291.0 μs |    291.0 μs |    291.0 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    363.8 μs |    NA |    363.8 μs |    363.8 μs |    363.8 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 30,974.5 μs |    NA | 30,974.5 μs | 30,974.5 μs | 30,974.5 μs |     640 B |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 31,059.8 μs |    NA | 31,059.8 μs | 31,059.8 μs | 31,059.8 μs |     400 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 32,213.4 μs |    NA | 32,213.4 μs | 32,213.4 μs | 32,213.4 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 8.0           | 41,015.9 μs |    NA | 41,015.9 μs | 41,015.9 μs | 41,015.9 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 41,530.9 μs |    NA | 41,530.9 μs | 41,530.9 μs | 41,530.9 μs |     640 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 42,880.6 μs |    NA | 42,880.6 μs | 42,880.6 μs | 42,880.6 μs |         - |
