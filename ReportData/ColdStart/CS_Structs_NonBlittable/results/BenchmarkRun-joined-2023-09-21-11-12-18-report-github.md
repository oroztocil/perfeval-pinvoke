```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-FEVWOU : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ORUQOI : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ZYVMOR : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    511.3 μs |    NA |    511.3 μs |    511.3 μs |    511.3 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    723.4 μs |    NA |    723.4 μs |    723.4 μs |    723.4 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    732.9 μs |    NA |    732.9 μs |    732.9 μs |    732.9 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 31,231.2 μs |    NA | 31,231.2 μs | 31,231.2 μs | 31,231.2 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 31,406.9 μs |    NA | 31,406.9 μs | 31,406.9 μs | 31,406.9 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 32,082.6 μs |    NA | 32,082.6 μs | 32,082.6 μs | 32,082.6 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 41,596.5 μs |    NA | 41,596.5 μs | 41,596.5 μs | 41,596.5 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 41,785.5 μs |    NA | 41,785.5 μs | 41,785.5 μs | 41,785.5 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 42,132.3 μs |    NA | 42,132.3 μs | 42,132.3 μs | 42,132.3 μs |         - |
