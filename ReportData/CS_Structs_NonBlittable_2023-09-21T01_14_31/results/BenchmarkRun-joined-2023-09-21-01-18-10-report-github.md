```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-PSJMGE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-IMRMJU : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-RRQHUO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

InvocationCount=1  IterationCount=1  IterationTime=250.0000 ms  
LaunchCount=100  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean       | Error       | StdDev      | Median     | Min        | Max         |
|---------------- |-------------------------------- |------------------- |--------------------- |-----------:|------------:|------------:|-----------:|-----------:|------------:|
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 2,041.7 μs | 1,440.63 μs | 4,247.73 μs | 1,609.3 μs | 1,562.5 μs | 44,090.5 μs |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 2,037.4 μs | 1,362.35 μs | 4,016.93 μs | 1,631.9 μs | 1,584.5 μs | 41,804.0 μs |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 2,625.9 μs | 1,369.64 μs | 4,038.41 μs | 2,211.2 μs | 2,168.4 μs | 42,604.0 μs |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 2,162.4 μs | 1,122.53 μs | 3,309.81 μs | 1,823.8 μs | 1,798.3 μs | 34,928.8 μs |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 2,172.2 μs | 1,029.10 μs | 3,034.32 μs | 1,863.3 μs | 1,812.5 μs | 32,209.7 μs |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 1,862.5 μs | 1,074.42 μs | 3,167.95 μs | 1,545.8 μs | 1,496.3 μs | 33,224.1 μs |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |   665.5 μs |     2.05 μs |     6.03 μs |   665.7 μs |   651.5 μs |    683.5 μs |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |   498.4 μs |     3.05 μs |     8.98 μs |   497.1 μs |   484.5 μs |    549.0 μs |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |   746.5 μs |     3.02 μs |     8.91 μs |   746.8 μs |   727.9 μs |    769.0 μs |
