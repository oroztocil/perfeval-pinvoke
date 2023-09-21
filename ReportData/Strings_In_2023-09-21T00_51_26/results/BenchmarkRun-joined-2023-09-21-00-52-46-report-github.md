```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-MMOXRK : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ZUTYXH : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-URVYTK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method             | Runtime            | Mean      | Error    | StdDev   | Median    | Min       | Max       |
|-------------- |------------------- |------------------- |----------:|---------:|---------:|----------:|----------:|----------:|
| DllImport     | StringLength_Utf8  | .NET 6.0           |  50.35 ns | 0.040 ns | 0.038 ns |  50.35 ns |  50.29 ns |  50.42 ns |
| DllImport     | StringLength_Utf8  | .NET 8.0           |  40.99 ns | 0.022 ns | 0.019 ns |  40.98 ns |  40.97 ns |  41.03 ns |
| DllImport     | StringLength_Utf8  | .NET Framework 4.8 |  81.32 ns | 0.058 ns | 0.051 ns |  81.31 ns |  81.22 ns |  81.42 ns |
| FuncPointers  | StringLength_Utf16 | .NET 6.0           |  13.04 ns | 0.017 ns | 0.013 ns |  13.04 ns |  13.01 ns |  13.06 ns |
| FuncPointers  | StringLength_Utf8  | .NET 6.0           | 133.10 ns | 0.029 ns | 0.026 ns | 133.08 ns | 133.06 ns | 133.14 ns |
| FuncPointers  | StringLength_Utf16 | .NET 8.0           |  13.36 ns | 0.023 ns | 0.022 ns |  13.37 ns |  13.32 ns |  13.39 ns |
| FuncPointers  | StringLength_Utf8  | .NET 8.0           | 112.99 ns | 0.117 ns | 0.110 ns | 112.96 ns | 112.83 ns | 113.24 ns |
| LibraryImport | StringLength_Utf16 | .NET 8.0           |  13.08 ns | 0.063 ns | 0.059 ns |  13.06 ns |  12.96 ns |  13.16 ns |
| LibraryImport | StringLength_Utf8  | .NET 8.0           |  33.43 ns | 0.027 ns | 0.026 ns |  33.43 ns |  33.39 ns |  33.49 ns |
