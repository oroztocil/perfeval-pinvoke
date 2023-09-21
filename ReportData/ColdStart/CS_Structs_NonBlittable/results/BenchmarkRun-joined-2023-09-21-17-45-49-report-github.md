```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-EUYTCV : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ISGUSF : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ZGUBTH : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    542.6 μs |    NA |    542.6 μs |    542.6 μs |    542.6 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    672.4 μs |    NA |    672.4 μs |    672.4 μs |    672.4 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    739.8 μs |    NA |    739.8 μs |    739.8 μs |    739.8 μs |         - |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 18,590.2 μs |    NA | 18,590.2 μs | 18,590.2 μs | 18,590.2 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 18,897.8 μs |    NA | 18,897.8 μs | 18,897.8 μs | 18,897.8 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 19,750.1 μs |    NA | 19,750.1 μs | 19,750.1 μs | 19,750.1 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 30,090.4 μs |    NA | 30,090.4 μs | 30,090.4 μs | 30,090.4 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 30,402.8 μs |    NA | 30,402.8 μs | 30,402.8 μs | 30,402.8 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 44,856.2 μs |    NA | 44,856.2 μs | 44,856.2 μs | 44,856.2 μs |     472 B |
