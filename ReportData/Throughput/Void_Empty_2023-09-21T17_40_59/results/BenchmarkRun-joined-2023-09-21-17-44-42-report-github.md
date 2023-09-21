```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ULQNBA : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-GMPMCA : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-FDVSAD : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method    | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        | Allocated |
|-------------- |---------- |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|----------:|
| Managed       | EmptyVoid | .NET 6.0           |  0.6718 ns | 0.0009 ns | 0.0008 ns |  0.6720 ns |  0.6703 ns |  0.6729 ns |         - |
| Managed       | EmptyVoid | .NET 8.0           |  0.6965 ns | 0.0002 ns | 0.0002 ns |  0.6966 ns |  0.6963 ns |  0.6968 ns |         - |
| Managed       | EmptyVoid | .NET Framework 4.8 |  1.0449 ns | 0.0008 ns | 0.0006 ns |  1.0448 ns |  1.0443 ns |  1.0461 ns |         - |
| FuncPointers  | EmptyVoid | .NET 8.0           |  6.5146 ns | 0.0111 ns | 0.0087 ns |  6.5090 ns |  6.5069 ns |  6.5277 ns |         - |
| FuncPointers  | EmptyVoid | .NET 6.0           |  6.6601 ns | 0.0429 ns | 0.0401 ns |  6.6365 ns |  6.6288 ns |  6.7267 ns |         - |
| DllImport     | EmptyVoid | .NET 8.0           |  6.8462 ns | 0.0025 ns | 0.0022 ns |  6.8458 ns |  6.8439 ns |  6.8508 ns |         - |
| LibraryImport | EmptyVoid | .NET 8.0           |  6.8752 ns | 0.0415 ns | 0.0388 ns |  6.8598 ns |  6.8426 ns |  6.9396 ns |         - |
| DllImport     | EmptyVoid | .NET 6.0           |  7.0329 ns | 0.0088 ns | 0.0069 ns |  7.0319 ns |  7.0251 ns |  7.0435 ns |         - |
| DllImport     | EmptyVoid | .NET Framework 4.8 | 12.3361 ns | 0.0516 ns | 0.0483 ns | 12.3367 ns | 12.2836 ns | 12.4058 ns |         - |
