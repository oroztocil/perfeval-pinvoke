```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JYTTJU : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-MRCXPV : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-IEKGTP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    276.9 μs |    NA |    276.9 μs |    276.9 μs |    276.9 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    327.7 μs |    NA |    327.7 μs |    327.7 μs |    327.7 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    355.0 μs |    NA |    355.0 μs |    355.0 μs |    355.0 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 30,766.7 μs |    NA | 30,766.7 μs | 30,766.7 μs | 30,766.7 μs |     400 B |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 30,866.6 μs |    NA | 30,866.6 μs | 30,866.6 μs | 30,866.6 μs |     640 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 40,902.0 μs |    NA | 40,902.0 μs | 40,902.0 μs | 40,902.0 μs |     640 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 41,430.9 μs |    NA | 41,430.9 μs | 41,430.9 μs | 41,430.9 μs |         - |
| DllImportCS     | Empty_Void | .NET 8.0           | 41,695.6 μs |    NA | 41,695.6 μs | 41,695.6 μs | 41,695.6 μs |     400 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 43,067.0 μs |    NA | 43,067.0 μs | 43,067.0 μs | 43,067.0 μs |     400 B |
