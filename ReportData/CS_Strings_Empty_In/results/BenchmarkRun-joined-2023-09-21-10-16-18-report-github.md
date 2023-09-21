```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-VBTEXK : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-YOSEOA : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-YPAKOL : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    359.3 μs |    NA |    359.3 μs |    359.3 μs |    359.3 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    381.6 μs |    NA |    381.6 μs |    381.6 μs |    381.6 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    490.0 μs |    NA |    490.0 μs |    490.0 μs |    490.0 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,059.0 μs |    NA | 31,059.0 μs | 31,059.0 μs | 31,059.0 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,141.7 μs |    NA | 31,141.7 μs | 31,141.7 μs | 31,141.7 μs |     688 B |
| DllImportCS     | Empty_String | .NET 6.0           | 41,488.0 μs |    NA | 41,488.0 μs | 41,488.0 μs | 41,488.0 μs |     640 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,560.4 μs |    NA | 42,560.4 μs | 42,560.4 μs | 42,560.4 μs |         - |
| DllImportCS     | Empty_String | .NET 8.0           | 42,672.3 μs |    NA | 42,672.3 μs | 42,672.3 μs | 42,672.3 μs |     400 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 43,985.0 μs |    NA | 43,985.0 μs | 43,985.0 μs | 43,985.0 μs |     400 B |