```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-WQOKQB : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-DEUKUA : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-BQNIJY : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    358.1 μs |    NA |    358.1 μs |    358.1 μs |    358.1 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    439.7 μs |    NA |    439.7 μs |    439.7 μs |    439.7 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    482.8 μs |    NA |    482.8 μs |    482.8 μs |    482.8 μs |         - |
| FuncPointersCS  | Empty_String | .NET 6.0           | 30,922.6 μs |    NA | 30,922.6 μs | 30,922.6 μs | 30,922.6 μs |     688 B |
| FuncPointersCS  | Empty_String | .NET 8.0           | 30,989.7 μs |    NA | 30,989.7 μs | 30,989.7 μs | 30,989.7 μs |     448 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 31,757.6 μs |    NA | 31,757.6 μs | 31,757.6 μs | 31,757.6 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 41,935.1 μs |    NA | 41,935.1 μs | 41,935.1 μs | 41,935.1 μs |         - |
| DllImportCS     | Empty_String | .NET 8.0           | 42,101.1 μs |    NA | 42,101.1 μs | 42,101.1 μs | 42,101.1 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 42,306.7 μs |    NA | 42,306.7 μs | 42,306.7 μs | 42,306.7 μs |     640 B |
