```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-PQYWLC : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-OHVTDA : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-MXYHLS : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    359.4 μs |    NA |    359.4 μs |    359.4 μs |    359.4 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    381.3 μs |    NA |    381.3 μs |    381.3 μs |    381.3 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    483.6 μs |    NA |    483.6 μs |    483.6 μs |    483.6 μs |         - |
| FuncPointersCS  | Empty_String | .NET 6.0           | 30,936.2 μs |    NA | 30,936.2 μs | 30,936.2 μs | 30,936.2 μs |     688 B |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,595.1 μs |    NA | 31,595.1 μs | 31,595.1 μs | 31,595.1 μs |     448 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 31,878.1 μs |    NA | 31,878.1 μs | 31,878.1 μs | 31,878.1 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 41,660.5 μs |    NA | 41,660.5 μs | 41,660.5 μs | 41,660.5 μs |         - |
| DllImportCS     | Empty_String | .NET 8.0           | 42,344.8 μs |    NA | 42,344.8 μs | 42,344.8 μs | 42,344.8 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 43,244.1 μs |    NA | 43,244.1 μs | 43,244.1 μs | 43,244.1 μs |     640 B |
