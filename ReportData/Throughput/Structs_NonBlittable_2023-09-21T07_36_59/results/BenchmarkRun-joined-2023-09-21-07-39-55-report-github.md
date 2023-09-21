```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QYTZJM : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CGZPWV : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-CHWYPY : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method                              | Runtime            | input                | Mean      | Error    | StdDev   | Median    | Min       | Max       | Gen0   | Allocated |
|-------------- |------------------------------------ |------------------- |--------------------- |----------:|---------:|---------:|----------:|----------:|----------:|-------:|----------:|
| Managed       | UpdateNonBlittableStruct_Manual     | .NET 8.0           | PInvo(...)truct [49] |  24.15 ns | 0.040 ns | 0.035 ns |  24.14 ns |  24.10 ns |  24.22 ns | 0.0127 |      80 B |
| Managed       | UpdateNonBlittableStruct_Manual     | .NET 6.0           | PInvo(...)truct [49] |  30.73 ns | 0.136 ns | 0.127 ns |  30.73 ns |  30.46 ns |  30.92 ns | 0.0127 |      80 B |
| Managed       | UpdateNonBlittableStruct_Manual     | .NET Framework 4.8 | PInvo(...)truct [49] |  38.27 ns | 0.087 ns | 0.077 ns |  38.26 ns |  38.19 ns |  38.43 ns | 0.0140 |      88 B |
| LibraryImport | UpdateNonBlittableStruct_Manual     | .NET 8.0           | PInvo(...)truct [49] |  58.98 ns | 0.147 ns | 0.137 ns |  58.94 ns |  58.79 ns |  59.23 ns | 0.0114 |      72 B |
| FuncPointers  | UpdateNonBlittableStruct_Manual     | .NET 8.0           | PInvo(...)truct [49] |  61.53 ns | 0.168 ns | 0.149 ns |  61.53 ns |  61.23 ns |  61.75 ns | 0.0114 |      72 B |
| DllImport     | UpdateNonBlittableStruct_Manual     | .NET 8.0           | PInvo(...)truct [49] |  64.63 ns | 0.181 ns | 0.169 ns |  64.56 ns |  64.43 ns |  64.98 ns | 0.0114 |      72 B |
| FuncPointers  | UpdateNonBlittableStruct_Manual     | .NET 6.0           | PInvo(...)truct [49] |  74.58 ns | 0.149 ns | 0.139 ns |  74.57 ns |  74.44 ns |  74.87 ns | 0.0114 |      72 B |
| DllImport     | UpdateNonBlittableStruct_Manual     | .NET 6.0           | PInvo(...)truct [49] |  78.23 ns | 0.211 ns | 0.197 ns |  78.18 ns |  77.96 ns |  78.57 ns | 0.0114 |      72 B |
| DllImport     | UpdateNonBlittableStruct_Manual     | .NET Framework 4.8 | PInvo(...)truct [49] | 148.65 ns | 0.092 ns | 0.077 ns | 148.64 ns | 148.51 ns | 148.81 ns | 0.0126 |      80 B |
| LibraryImport | UpdateNonBlittableStruct_Marshaller | .NET 8.0           | PInvo(...)truct [49] | 233.58 ns | 0.175 ns | 0.155 ns | 233.51 ns | 233.43 ns | 233.91 ns | 0.0126 |      80 B |
