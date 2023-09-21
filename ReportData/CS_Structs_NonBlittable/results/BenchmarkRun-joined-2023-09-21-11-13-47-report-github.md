```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-GJNVCK : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-BZJPXU : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-RMMJYH : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    510.0 μs |    NA |    510.0 μs |    510.0 μs |    510.0 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    658.6 μs |    NA |    658.6 μs |    658.6 μs |    658.6 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    742.7 μs |    NA |    742.7 μs |    742.7 μs |    742.7 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 32,297.3 μs |    NA | 32,297.3 μs | 32,297.3 μs | 32,297.3 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 32,412.6 μs |    NA | 32,412.6 μs | 32,412.6 μs | 32,412.6 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 32,919.0 μs |    NA | 32,919.0 μs | 32,919.0 μs | 32,919.0 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 43,168.1 μs |    NA | 43,168.1 μs | 43,168.1 μs | 43,168.1 μs |         - |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 43,725.7 μs |    NA | 43,725.7 μs | 43,725.7 μs | 43,725.7 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 44,626.5 μs |    NA | 44,626.5 μs | 44,626.5 μs | 44,626.5 μs |     712 B |
