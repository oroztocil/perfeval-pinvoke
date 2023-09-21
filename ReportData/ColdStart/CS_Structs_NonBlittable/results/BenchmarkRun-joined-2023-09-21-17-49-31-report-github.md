```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-VAGPYT : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ACREEZ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-UJISJH : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    493.3 μs |    NA |    493.3 μs |    493.3 μs |    493.3 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    661.6 μs |    NA |    661.6 μs |    661.6 μs |    661.6 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    758.2 μs |    NA |    758.2 μs |    758.2 μs |    758.2 μs |         - |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 18,591.5 μs |    NA | 18,591.5 μs | 18,591.5 μs | 18,591.5 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 18,599.2 μs |    NA | 18,599.2 μs | 18,599.2 μs | 18,599.2 μs |         - |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 18,885.6 μs |    NA | 18,885.6 μs | 18,885.6 μs | 18,885.6 μs |     712 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 30,424.4 μs |    NA | 30,424.4 μs | 30,424.4 μs | 30,424.4 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 30,476.2 μs |    NA | 30,476.2 μs | 30,476.2 μs | 30,476.2 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 30,759.5 μs |    NA | 30,759.5 μs | 30,759.5 μs | 30,759.5 μs |     472 B |
