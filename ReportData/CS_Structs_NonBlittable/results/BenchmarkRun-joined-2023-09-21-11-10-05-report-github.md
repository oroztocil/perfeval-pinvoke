```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-DQLXQK : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-KPDLMZ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-JIGJPP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    505.5 μs |    NA |    505.5 μs |    505.5 μs |    505.5 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    672.9 μs |    NA |    672.9 μs |    672.9 μs |    672.9 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    772.4 μs |    NA |    772.4 μs |    772.4 μs |    772.4 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 31,230.8 μs |    NA | 31,230.8 μs | 31,230.8 μs | 31,230.8 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 31,906.7 μs |    NA | 31,906.7 μs | 31,906.7 μs | 31,906.7 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 41,896.9 μs |    NA | 41,896.9 μs | 41,896.9 μs | 41,896.9 μs |         - |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 41,935.0 μs |    NA | 41,935.0 μs | 41,935.0 μs | 41,935.0 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 43,620.1 μs |    NA | 43,620.1 μs | 43,620.1 μs | 43,620.1 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 44,217.7 μs |    NA | 44,217.7 μs | 44,217.7 μs | 44,217.7 μs |     472 B |
