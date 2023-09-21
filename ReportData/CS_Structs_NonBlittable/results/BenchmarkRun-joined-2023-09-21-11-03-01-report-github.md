```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-AVNFMA : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-LTOFPX : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ABRYXM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    515.4 μs |    NA |    515.4 μs |    515.4 μs |    515.4 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    649.1 μs |    NA |    649.1 μs |    649.1 μs |    649.1 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    768.9 μs |    NA |    768.9 μs |    768.9 μs |    768.9 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 31,243.4 μs |    NA | 31,243.4 μs | 31,243.4 μs | 31,243.4 μs |     712 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 31,330.1 μs |    NA | 31,330.1 μs | 31,330.1 μs | 31,330.1 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 41,912.4 μs |    NA | 41,912.4 μs | 41,912.4 μs | 41,912.4 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 42,018.2 μs |    NA | 42,018.2 μs | 42,018.2 μs | 42,018.2 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 42,467.4 μs |    NA | 42,467.4 μs | 42,467.4 μs | 42,467.4 μs |         - |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 48,924.5 μs |    NA | 48,924.5 μs | 48,924.5 μs | 48,924.5 μs |     472 B |
