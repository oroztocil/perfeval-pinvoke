```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-PIRARE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-MRBACG : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-OEMBIW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

InvocationCount=1  IterationCount=1  IterationTime=250.0000 ms  
LaunchCount=100  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean       | Error       | StdDev      | Median     | Min        | Max         |
|---------------- |----------- |------------------- |-----------:|------------:|------------:|-----------:|-----------:|------------:|
| DllImportCS     | Empty_Void | .NET 6.0           | 1,495.8 μs | 1,372.84 μs | 4,047.85 μs | 1,083.5 μs | 1,054.2 μs | 41,568.8 μs |
| DllImportCS     | Empty_Void | .NET 8.0           | 1,540.9 μs | 1,368.77 μs | 4,035.85 μs | 1,139.0 μs | 1,092.7 μs | 41,495.3 μs |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 1,943.9 μs | 1,346.39 μs | 3,969.86 μs | 1,541.3 μs | 1,503.1 μs | 41,243.6 μs |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 1,670.9 μs | 1,150.39 μs | 3,391.96 μs | 1,326.3 μs | 1,301.4 μs | 35,250.7 μs |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 1,682.5 μs | 1,048.18 μs | 3,090.57 μs | 1,373.7 μs | 1,316.0 μs | 32,278.5 μs |
| LibraryImportCS | Empty_Void | .NET 8.0           | 1,474.1 μs | 1,081.15 μs | 3,187.79 μs | 1,156.5 μs | 1,110.9 μs | 33,032.7 μs |
| ManagedCS       | Empty_Void | .NET 6.0           |   278.4 μs |     2.04 μs |     6.03 μs |   280.6 μs |   268.2 μs |    290.0 μs |
| ManagedCS       | Empty_Void | .NET 8.0           |   282.5 μs |     2.17 μs |     6.41 μs |   284.4 μs |   272.0 μs |    296.4 μs |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |   362.6 μs |     1.94 μs |     5.72 μs |   362.9 μs |   349.0 μs |    376.5 μs |
