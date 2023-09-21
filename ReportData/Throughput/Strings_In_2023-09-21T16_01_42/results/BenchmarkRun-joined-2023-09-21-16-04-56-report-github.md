```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-PYVSBU : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-UISHJL : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TZUODU : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method             | Runtime            | Mean      | Error    | StdDev   | Median    | Min       | Max       | Allocated |
|-------------- |------------------- |------------------- |----------:|---------:|---------:|----------:|----------:|----------:|----------:|
| FuncPointers  | StringLength_Utf16 | .NET 6.0           |  12.45 ns | 0.023 ns | 0.022 ns |  12.45 ns |  12.41 ns |  12.48 ns |         - |
| FuncPointers  | StringLength_Utf16 | .NET 8.0           |  13.07 ns | 0.046 ns | 0.043 ns |  13.08 ns |  12.95 ns |  13.12 ns |         - |
| LibraryImport | StringLength_Utf16 | .NET 8.0           |  13.28 ns | 0.032 ns | 0.030 ns |  13.30 ns |  13.24 ns |  13.32 ns |         - |
| LibraryImport | StringLength_Utf8  | .NET 8.0           |  35.67 ns | 0.372 ns | 0.348 ns |  35.67 ns |  35.06 ns |  36.04 ns |         - |
| DllImport     | StringLength_Utf8  | .NET 8.0           |  41.20 ns | 0.019 ns | 0.015 ns |  41.20 ns |  41.16 ns |  41.22 ns |         - |
| DllImport     | StringLength_Utf8  | .NET 6.0           |  51.28 ns | 0.383 ns | 0.358 ns |  51.08 ns |  50.93 ns |  52.07 ns |         - |
| DllImport     | StringLength_Utf8  | .NET Framework 4.8 |  81.61 ns | 0.197 ns | 0.185 ns |  81.60 ns |  81.38 ns |  82.01 ns |         - |
| FuncPointers  | StringLength_Utf8  | .NET 8.0           | 113.23 ns | 0.029 ns | 0.024 ns | 113.23 ns | 113.20 ns | 113.29 ns |         - |
| FuncPointers  | StringLength_Utf8  | .NET 6.0           | 132.41 ns | 0.078 ns | 0.065 ns | 132.40 ns | 132.32 ns | 132.58 ns |         - |
