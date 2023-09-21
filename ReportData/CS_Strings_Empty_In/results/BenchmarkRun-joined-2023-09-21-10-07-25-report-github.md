```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-VPYQYE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-XCKBGX : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-WBLIOI : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    356.7 μs |    NA |    356.7 μs |    356.7 μs |    356.7 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    390.0 μs |    NA |    390.0 μs |    390.0 μs |    390.0 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    488.8 μs |    NA |    488.8 μs |    488.8 μs |    488.8 μs |         - |
| LibraryImportCS | Empty_String | .NET 8.0           |  1,630.1 μs |    NA |  1,630.1 μs |  1,630.1 μs |  1,630.1 μs |     400 B |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,084.2 μs |    NA | 31,084.2 μs | 31,084.2 μs | 31,084.2 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,594.5 μs |    NA | 31,594.5 μs | 31,594.5 μs | 31,594.5 μs |     688 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,279.5 μs |    NA | 42,279.5 μs | 42,279.5 μs | 42,279.5 μs |         - |
| DllImportCS     | Empty_String | .NET 8.0           | 42,734.5 μs |    NA | 42,734.5 μs | 42,734.5 μs | 42,734.5 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 43,086.6 μs |    NA | 43,086.6 μs | 43,086.6 μs | 43,086.6 μs |     640 B |
