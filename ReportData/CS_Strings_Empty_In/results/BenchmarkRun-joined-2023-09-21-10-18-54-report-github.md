```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UGUVWX : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ENHDKP : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-YFZZXZ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    367.1 μs |    NA |    367.1 μs |    367.1 μs |    367.1 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    377.4 μs |    NA |    377.4 μs |    377.4 μs |    377.4 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    500.5 μs |    NA |    500.5 μs |    500.5 μs |    500.5 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,493.4 μs |    NA | 31,493.4 μs | 31,493.4 μs | 31,493.4 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,632.6 μs |    NA | 31,632.6 μs | 31,632.6 μs | 31,632.6 μs |     688 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 32,314.2 μs |    NA | 32,314.2 μs | 32,314.2 μs | 32,314.2 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 42,572.9 μs |    NA | 42,572.9 μs | 42,572.9 μs | 42,572.9 μs |     640 B |
| DllImportCS     | Empty_String | .NET 8.0           | 42,897.2 μs |    NA | 42,897.2 μs | 42,897.2 μs | 42,897.2 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 43,205.4 μs |    NA | 43,205.4 μs | 43,205.4 μs | 43,205.4 μs |         - |
