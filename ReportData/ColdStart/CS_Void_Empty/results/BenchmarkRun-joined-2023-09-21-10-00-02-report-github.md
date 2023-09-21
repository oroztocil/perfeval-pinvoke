```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-USEZRN : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-UQPBSR : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ULKWXZ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    287.1 μs |    NA |    287.1 μs |    287.1 μs |    287.1 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    287.9 μs |    NA |    287.9 μs |    287.9 μs |    287.9 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    359.8 μs |    NA |    359.8 μs |    359.8 μs |    359.8 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,394.4 μs |    NA | 31,394.4 μs | 31,394.4 μs | 31,394.4 μs |     640 B |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 32,036.1 μs |    NA | 32,036.1 μs | 32,036.1 μs | 32,036.1 μs |     400 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 32,266.3 μs |    NA | 32,266.3 μs | 32,266.3 μs | 32,266.3 μs |     400 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 42,197.4 μs |    NA | 42,197.4 μs | 42,197.4 μs | 42,197.4 μs |         - |
| DllImportCS     | Empty_Void | .NET 8.0           | 42,691.1 μs |    NA | 42,691.1 μs | 42,691.1 μs | 42,691.1 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 42,828.2 μs |    NA | 42,828.2 μs | 42,828.2 μs | 42,828.2 μs |     640 B |
