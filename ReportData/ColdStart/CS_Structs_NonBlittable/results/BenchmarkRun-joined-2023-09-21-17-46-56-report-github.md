```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-OCNONU : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-VVKPUW : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-KRFTRR : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    496.8 μs |    NA |    496.8 μs |    496.8 μs |    496.8 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    662.9 μs |    NA |    662.9 μs |    662.9 μs |    662.9 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    757.0 μs |    NA |    757.0 μs |    757.0 μs |    757.0 μs |         - |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 18,677.5 μs |    NA | 18,677.5 μs | 18,677.5 μs | 18,677.5 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 18,751.8 μs |    NA | 18,751.8 μs | 18,751.8 μs | 18,751.8 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 19,269.6 μs |    NA | 19,269.6 μs | 19,269.6 μs | 19,269.6 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 30,206.5 μs |    NA | 30,206.5 μs | 30,206.5 μs | 30,206.5 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 30,301.4 μs |    NA | 30,301.4 μs | 30,301.4 μs | 30,301.4 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 30,564.4 μs |    NA | 30,564.4 μs | 30,564.4 μs | 30,564.4 μs |     472 B |
