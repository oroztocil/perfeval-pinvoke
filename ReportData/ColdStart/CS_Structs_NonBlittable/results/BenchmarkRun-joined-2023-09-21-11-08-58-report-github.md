```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ACBBRE : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-OOQTPK : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-XIYWCJ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    511.5 μs |    NA |    511.5 μs |    511.5 μs |    511.5 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    667.2 μs |    NA |    667.2 μs |    667.2 μs |    667.2 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    734.9 μs |    NA |    734.9 μs |    734.9 μs |    734.9 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 31,052.3 μs |    NA | 31,052.3 μs | 31,052.3 μs | 31,052.3 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 31,295.3 μs |    NA | 31,295.3 μs | 31,295.3 μs | 31,295.3 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 31,816.0 μs |    NA | 31,816.0 μs | 31,816.0 μs | 31,816.0 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 41,532.9 μs |    NA | 41,532.9 μs | 41,532.9 μs | 41,532.9 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 41,910.5 μs |    NA | 41,910.5 μs | 41,910.5 μs | 41,910.5 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 42,211.9 μs |    NA | 42,211.9 μs | 42,211.9 μs | 42,211.9 μs |         - |
