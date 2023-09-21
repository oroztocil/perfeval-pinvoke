```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-MMLHGL : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UOMINR : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ODLOES : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    516.0 μs |    NA |    516.0 μs |    516.0 μs |    516.0 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    671.1 μs |    NA |    671.1 μs |    671.1 μs |    671.1 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    729.1 μs |    NA |    729.1 μs |    729.1 μs |    729.1 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 32,120.2 μs |    NA | 32,120.2 μs | 32,120.2 μs | 32,120.2 μs |     472 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 32,740.6 μs |    NA | 32,740.6 μs | 32,740.6 μs | 32,740.6 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 33,365.6 μs |    NA | 33,365.6 μs | 33,365.6 μs | 33,365.6 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 43,127.2 μs |    NA | 43,127.2 μs | 43,127.2 μs | 43,127.2 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 43,395.9 μs |    NA | 43,395.9 μs | 43,395.9 μs | 43,395.9 μs |         - |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 43,572.3 μs |    NA | 43,572.3 μs | 43,572.3 μs | 43,572.3 μs |     472 B |
