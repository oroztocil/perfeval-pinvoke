```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UGAYWM : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ZSYMEP : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ELJXMD : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 8.0           |    279.6 μs |    NA |    279.6 μs |    279.6 μs |    279.6 μs |     400 B |
| ManagedCS       | Empty_Void | .NET 6.0           |    283.5 μs |    NA |    283.5 μs |    283.5 μs |    283.5 μs |     640 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    367.1 μs |    NA |    367.1 μs |    367.1 μs |    367.1 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,214.9 μs |    NA | 31,214.9 μs | 31,214.9 μs | 31,214.9 μs |     640 B |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 31,752.5 μs |    NA | 31,752.5 μs | 31,752.5 μs | 31,752.5 μs |     400 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 32,582.6 μs |    NA | 32,582.6 μs | 32,582.6 μs | 32,582.6 μs |     400 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 41,909.1 μs |    NA | 41,909.1 μs | 41,909.1 μs | 41,909.1 μs |         - |
| DllImportCS     | Empty_Void | .NET 8.0           | 42,104.5 μs |    NA | 42,104.5 μs | 42,104.5 μs | 42,104.5 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 42,182.6 μs |    NA | 42,182.6 μs | 42,182.6 μs | 42,182.6 μs |     640 B |