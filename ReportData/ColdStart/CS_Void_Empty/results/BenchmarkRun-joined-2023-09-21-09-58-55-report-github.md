```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-HTHFFD : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-BXVXMJ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QIHFTU : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    279.1 μs |    NA |    279.1 μs |    279.1 μs |    279.1 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    289.7 μs |    NA |    289.7 μs |    289.7 μs |    289.7 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    365.8 μs |    NA |    365.8 μs |    365.8 μs |    365.8 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 30,514.7 μs |    NA | 30,514.7 μs | 30,514.7 μs | 30,514.7 μs |     400 B |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 30,723.7 μs |    NA | 30,723.7 μs | 30,723.7 μs | 30,723.7 μs |     640 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 31,389.1 μs |    NA | 31,389.1 μs | 31,389.1 μs | 31,389.1 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 8.0           | 40,857.1 μs |    NA | 40,857.1 μs | 40,857.1 μs | 40,857.1 μs |     400 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 41,430.1 μs |    NA | 41,430.1 μs | 41,430.1 μs | 41,430.1 μs |         - |
| DllImportCS     | Empty_Void | .NET 6.0           | 42,239.7 μs |    NA | 42,239.7 μs | 42,239.7 μs | 42,239.7 μs |     640 B |
