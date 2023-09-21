```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CCXUKP : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-KFUYKN : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-UPCMJC : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    508.8 μs |    NA |    508.8 μs |    508.8 μs |    508.8 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    661.4 μs |    NA |    661.4 μs |    661.4 μs |    661.4 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    721.3 μs |    NA |    721.3 μs |    721.3 μs |    721.3 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 31,148.8 μs |    NA | 31,148.8 μs | 31,148.8 μs | 31,148.8 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 31,383.1 μs |    NA | 31,383.1 μs | 31,383.1 μs | 31,383.1 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 32,125.3 μs |    NA | 32,125.3 μs | 32,125.3 μs | 32,125.3 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 42,087.3 μs |    NA | 42,087.3 μs | 42,087.3 μs | 42,087.3 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 42,629.9 μs |    NA | 42,629.9 μs | 42,629.9 μs | 42,629.9 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 42,946.1 μs |    NA | 42,946.1 μs | 42,946.1 μs | 42,946.1 μs |         - |
