```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-OWFJPT : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-HXZMXH : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JASJFC : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    280.3 μs |    NA |    280.3 μs |    280.3 μs |    280.3 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    280.8 μs |    NA |    280.8 μs |    280.8 μs |    280.8 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    360.3 μs |    NA |    360.3 μs |    360.3 μs |    360.3 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 30,317.9 μs |    NA | 30,317.9 μs | 30,317.9 μs | 30,317.9 μs |     400 B |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 30,709.9 μs |    NA | 30,709.9 μs | 30,709.9 μs | 30,709.9 μs |     640 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 31,561.1 μs |    NA | 31,561.1 μs | 31,561.1 μs | 31,561.1 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 8.0           | 40,620.9 μs |    NA | 40,620.9 μs | 40,620.9 μs | 40,620.9 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 40,708.4 μs |    NA | 40,708.4 μs | 40,708.4 μs | 40,708.4 μs |     640 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 42,208.9 μs |    NA | 42,208.9 μs | 42,208.9 μs | 42,208.9 μs |         - |
