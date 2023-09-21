```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UKBWME : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JZCWVC : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-SUVJGR : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    519.1 μs |    NA |    519.1 μs |    519.1 μs |    519.1 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    670.0 μs |    NA |    670.0 μs |    670.0 μs |    670.0 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    736.7 μs |    NA |    736.7 μs |    736.7 μs |    736.7 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 31,569.7 μs |    NA | 31,569.7 μs | 31,569.7 μs | 31,569.7 μs |     712 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 31,838.0 μs |    NA | 31,838.0 μs | 31,838.0 μs | 31,838.0 μs |     472 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 32,092.3 μs |    NA | 32,092.3 μs | 32,092.3 μs | 32,092.3 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 42,093.3 μs |    NA | 42,093.3 μs | 42,093.3 μs | 42,093.3 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 42,108.5 μs |    NA | 42,108.5 μs | 42,108.5 μs | 42,108.5 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 42,753.7 μs |    NA | 42,753.7 μs | 42,753.7 μs | 42,753.7 μs |         - |
