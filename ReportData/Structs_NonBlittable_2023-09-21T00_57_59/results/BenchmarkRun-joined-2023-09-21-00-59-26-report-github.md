```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-GIMMLF : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-WOGTQP : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-NTZPBQ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method                              | Runtime            | input                | Mean      | Error    | StdDev   | Median    | Min       | Max       |
|-------------- |------------------------------------ |------------------- |--------------------- |----------:|---------:|---------:|----------:|----------:|----------:|
| DllImport     | UpdateNonBlittableStruct_Manual     | .NET 6.0           | PInvo(...)truct [49] |  78.92 ns | 0.164 ns | 0.146 ns |  78.91 ns |  78.65 ns |  79.15 ns |
| DllImport     | UpdateNonBlittableStruct_Manual     | .NET 8.0           | PInvo(...)truct [49] |  63.51 ns | 0.282 ns | 0.250 ns |  63.51 ns |  63.20 ns |  63.96 ns |
| DllImport     | UpdateNonBlittableStruct_Manual     | .NET Framework 4.8 | PInvo(...)truct [49] | 151.82 ns | 0.119 ns | 0.105 ns | 151.82 ns | 151.63 ns | 152.01 ns |
| FuncPointers  | UpdateNonBlittableStruct_Manual     | .NET 6.0           | PInvo(...)truct [49] |  78.92 ns | 0.174 ns | 0.163 ns |  78.86 ns |  78.65 ns |  79.21 ns |
| FuncPointers  | UpdateNonBlittableStruct_Manual     | .NET 8.0           | PInvo(...)truct [49] |  66.10 ns | 0.281 ns | 0.263 ns |  66.09 ns |  65.70 ns |  66.66 ns |
| LibraryImport | UpdateNonBlittableStruct_Manual     | .NET 8.0           | PInvo(...)truct [49] |  62.10 ns | 0.235 ns | 0.219 ns |  61.99 ns |  61.85 ns |  62.56 ns |
| LibraryImport | UpdateNonBlittableStruct_Marshaller | .NET 8.0           | PInvo(...)truct [49] | 227.30 ns | 0.180 ns | 0.141 ns | 227.29 ns | 227.09 ns | 227.54 ns |
| Managed       | UpdateNonBlittableStruct_Manual     | .NET 6.0           | PInvo(...)truct [49] |  30.93 ns | 0.215 ns | 0.201 ns |  30.84 ns |  30.64 ns |  31.31 ns |
| Managed       | UpdateNonBlittableStruct_Manual     | .NET 8.0           | PInvo(...)truct [49] |  22.85 ns | 0.047 ns | 0.039 ns |  22.86 ns |  22.75 ns |  22.90 ns |
| Managed       | UpdateNonBlittableStruct_Manual     | .NET Framework 4.8 | PInvo(...)truct [49] |  38.88 ns | 0.068 ns | 0.056 ns |  38.90 ns |  38.73 ns |  38.93 ns |
