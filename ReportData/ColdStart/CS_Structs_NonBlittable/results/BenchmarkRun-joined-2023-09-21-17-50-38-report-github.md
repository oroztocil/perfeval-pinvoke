```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TBINMU : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-MUXUOA : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-KLVVSC : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    496.5 μs |    NA |    496.5 μs |    496.5 μs |    496.5 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    666.8 μs |    NA |    666.8 μs |    666.8 μs |    666.8 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    752.9 μs |    NA |    752.9 μs |    752.9 μs |    752.9 μs |         - |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 18,852.6 μs |    NA | 18,852.6 μs | 18,852.6 μs | 18,852.6 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 19,061.4 μs |    NA | 19,061.4 μs | 19,061.4 μs | 19,061.4 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 19,147.3 μs |    NA | 19,147.3 μs | 19,147.3 μs | 19,147.3 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 30,654.1 μs |    NA | 30,654.1 μs | 30,654.1 μs | 30,654.1 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 30,810.7 μs |    NA | 30,810.7 μs | 30,810.7 μs | 30,810.7 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 31,150.2 μs |    NA | 31,150.2 μs | 31,150.2 μs | 31,150.2 μs |     472 B |
