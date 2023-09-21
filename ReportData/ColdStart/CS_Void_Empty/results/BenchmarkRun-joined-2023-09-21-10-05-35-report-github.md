```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ENXPBW : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-YUBZFD : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-YWUJFE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    285.5 μs |    NA |    285.5 μs |    285.5 μs |    285.5 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    296.8 μs |    NA |    296.8 μs |    296.8 μs |    296.8 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    350.6 μs |    NA |    350.6 μs |    350.6 μs |    350.6 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 30,786.6 μs |    NA | 30,786.6 μs | 30,786.6 μs | 30,786.6 μs |     400 B |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,410.4 μs |    NA | 31,410.4 μs | 31,410.4 μs | 31,410.4 μs |     640 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 31,675.2 μs |    NA | 31,675.2 μs | 31,675.2 μs | 31,675.2 μs |     400 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 41,583.9 μs |    NA | 41,583.9 μs | 41,583.9 μs | 41,583.9 μs |         - |
| DllImportCS     | Empty_Void | .NET 8.0           | 41,986.6 μs |    NA | 41,986.6 μs | 41,986.6 μs | 41,986.6 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 42,115.6 μs |    NA | 42,115.6 μs | 42,115.6 μs | 42,115.6 μs |     640 B |
