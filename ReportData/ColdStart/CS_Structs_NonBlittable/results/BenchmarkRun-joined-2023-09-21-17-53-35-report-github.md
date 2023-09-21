```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-FIUPYW : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CYWZBO : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-BACWVM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    494.8 μs |    NA |    494.8 μs |    494.8 μs |    494.8 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    663.7 μs |    NA |    663.7 μs |    663.7 μs |    663.7 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    976.5 μs |    NA |    976.5 μs |    976.5 μs |    976.5 μs |         - |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 18,717.6 μs |    NA | 18,717.6 μs | 18,717.6 μs | 18,717.6 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 18,969.7 μs |    NA | 18,969.7 μs | 18,969.7 μs | 18,969.7 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 19,048.6 μs |    NA | 19,048.6 μs | 19,048.6 μs | 19,048.6 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 30,612.8 μs |    NA | 30,612.8 μs | 30,612.8 μs | 30,612.8 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 30,862.1 μs |    NA | 30,862.1 μs | 30,862.1 μs | 30,862.1 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 36,369.6 μs |    NA | 36,369.6 μs | 36,369.6 μs | 36,369.6 μs |     472 B |
