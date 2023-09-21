```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JQLZVG : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-TEBTRS : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TTPDBJ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    276.2 μs |    NA |    276.2 μs |    276.2 μs |    276.2 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    293.5 μs |    NA |    293.5 μs |    293.5 μs |    293.5 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    360.7 μs |    NA |    360.7 μs |    360.7 μs |    360.7 μs |         - |
| LibraryImportCS | Empty_Void | .NET 8.0           | 31,308.6 μs |    NA | 31,308.6 μs | 31,308.6 μs | 31,308.6 μs |     400 B |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,567.5 μs |    NA | 31,567.5 μs | 31,567.5 μs | 31,567.5 μs |     640 B |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 31,768.5 μs |    NA | 31,768.5 μs | 31,768.5 μs | 31,768.5 μs |     400 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 41,615.7 μs |    NA | 41,615.7 μs | 41,615.7 μs | 41,615.7 μs |         - |
| DllImportCS     | Empty_Void | .NET 6.0           | 42,350.4 μs |    NA | 42,350.4 μs | 42,350.4 μs | 42,350.4 μs |     640 B |
| DllImportCS     | Empty_Void | .NET 8.0           | 42,910.7 μs |    NA | 42,910.7 μs | 42,910.7 μs | 42,910.7 μs |     400 B |
