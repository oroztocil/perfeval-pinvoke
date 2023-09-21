```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-HVJEHJ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-LDOSTN : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-QJTTWC : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method             | Runtime            | Mean      | Error    | StdDev   | Median    | Min       | Max       | Allocated |
|-------------- |------------------- |------------------- |----------:|---------:|---------:|----------:|----------:|----------:|----------:|
| LibraryImport | StringLength_Utf16 | .NET 8.0           |  11.90 ns | 0.091 ns | 0.085 ns |  11.95 ns |  11.80 ns |  12.00 ns |         - |
| FuncPointers  | StringLength_Utf16 | .NET 6.0           |  12.42 ns | 0.015 ns | 0.013 ns |  12.42 ns |  12.40 ns |  12.45 ns |         - |
| FuncPointers  | StringLength_Utf16 | .NET 8.0           |  13.10 ns | 0.018 ns | 0.017 ns |  13.10 ns |  13.06 ns |  13.12 ns |         - |
| LibraryImport | StringLength_Utf8  | .NET 8.0           |  35.74 ns | 0.020 ns | 0.018 ns |  35.74 ns |  35.70 ns |  35.76 ns |         - |
| DllImport     | StringLength_Utf8  | .NET 8.0           |  41.21 ns | 0.061 ns | 0.057 ns |  41.18 ns |  41.15 ns |  41.30 ns |         - |
| DllImport     | StringLength_Utf8  | .NET 6.0           |  49.40 ns | 0.087 ns | 0.081 ns |  49.37 ns |  49.29 ns |  49.56 ns |         - |
| DllImport     | StringLength_Utf8  | .NET Framework 4.8 |  80.73 ns | 0.031 ns | 0.029 ns |  80.73 ns |  80.67 ns |  80.77 ns |         - |
| FuncPointers  | StringLength_Utf8  | .NET 8.0           | 112.19 ns | 0.024 ns | 0.019 ns | 112.20 ns | 112.14 ns | 112.21 ns |         - |
| FuncPointers  | StringLength_Utf8  | .NET 6.0           | 131.40 ns | 0.068 ns | 0.053 ns | 131.40 ns | 131.29 ns | 131.47 ns |         - |
