```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-GJDQTU : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-YDCQBO : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-IFGZPO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    362.9 μs |    NA |    362.9 μs |    362.9 μs |    362.9 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    377.5 μs |    NA |    377.5 μs |    377.5 μs |    377.5 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    499.5 μs |    NA |    499.5 μs |    499.5 μs |    499.5 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 30,913.5 μs |    NA | 30,913.5 μs | 30,913.5 μs | 30,913.5 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,000.5 μs |    NA | 31,000.5 μs | 31,000.5 μs | 31,000.5 μs |     688 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 31,747.8 μs |    NA | 31,747.8 μs | 31,747.8 μs | 31,747.8 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 41,589.9 μs |    NA | 41,589.9 μs | 41,589.9 μs | 41,589.9 μs |     640 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 41,843.8 μs |    NA | 41,843.8 μs | 41,843.8 μs | 41,843.8 μs |         - |
| DllImportCS     | Empty_String | .NET 8.0           | 41,916.9 μs |    NA | 41,916.9 μs | 41,916.9 μs | 41,916.9 μs |     400 B |
