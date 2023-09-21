```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-NZRJBE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-OSGYBQ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-RHAKIY : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    281.7 μs |    NA |    281.7 μs |    281.7 μs |    281.7 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    292.7 μs |    NA |    292.7 μs |    292.7 μs |    292.7 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    357.4 μs |    NA |    357.4 μs |    357.4 μs |    357.4 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 31,080.1 μs |    NA | 31,080.1 μs | 31,080.1 μs | 31,080.1 μs |     400 B |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,130.7 μs |    NA | 31,130.7 μs | 31,130.7 μs | 31,130.7 μs |     640 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 31,845.1 μs |    NA | 31,845.1 μs | 31,845.1 μs | 31,845.1 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 8.0           | 41,861.8 μs |    NA | 41,861.8 μs | 41,861.8 μs | 41,861.8 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 42,661.7 μs |    NA | 42,661.7 μs | 42,661.7 μs | 42,661.7 μs |     640 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 43,118.9 μs |    NA | 43,118.9 μs | 43,118.9 μs | 43,118.9 μs |         - |
