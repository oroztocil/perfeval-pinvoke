```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-LJRXNE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-YHTUYA : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-IRNSOT : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    370.9 μs |    NA |    370.9 μs |    370.9 μs |    370.9 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    382.5 μs |    NA |    382.5 μs |    382.5 μs |    382.5 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    494.3 μs |    NA |    494.3 μs |    494.3 μs |    494.3 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,554.9 μs |    NA | 31,554.9 μs | 31,554.9 μs | 31,554.9 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,626.9 μs |    NA | 31,626.9 μs | 31,626.9 μs | 31,626.9 μs |     688 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 32,718.1 μs |    NA | 32,718.1 μs | 32,718.1 μs | 32,718.1 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,127.2 μs |    NA | 42,127.2 μs | 42,127.2 μs | 42,127.2 μs |         - |
| DllImportCS     | Empty_String | .NET 6.0           | 42,554.0 μs |    NA | 42,554.0 μs | 42,554.0 μs | 42,554.0 μs |     640 B |
| DllImportCS     | Empty_String | .NET 8.0           | 43,008.9 μs |    NA | 43,008.9 μs | 43,008.9 μs | 43,008.9 μs |     400 B |
