```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QNMDZC : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-NMZKOM : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-VFEYWQ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method                          | Runtime            | Mean     | Error   | StdDev  | Median   | Min      | Max      |
|-------------- |-------------------------------- |------------------- |---------:|--------:|--------:|---------:|---------:|---------:|
| DllImport     | StringToUppercase_ByteArray     | .NET 6.0           | 150.3 ns | 0.30 ns | 0.27 ns | 150.3 ns | 149.6 ns | 150.7 ns |
| DllImport     | StringToUppercase_Fixed         | .NET 6.0           | 136.0 ns | 0.19 ns | 0.15 ns | 135.9 ns | 135.7 ns | 136.2 ns |
| DllImport     | StringToUppercase_StringBuilder | .NET 6.0           | 182.4 ns | 0.23 ns | 0.20 ns | 182.3 ns | 182.1 ns | 182.9 ns |
| DllImport     | StringToUppercase_ByteArray     | .NET 8.0           | 127.5 ns | 0.19 ns | 0.18 ns | 127.5 ns | 127.3 ns | 127.8 ns |
| DllImport     | StringToUppercase_Fixed         | .NET 8.0           | 125.5 ns | 0.63 ns | 0.59 ns | 125.2 ns | 124.6 ns | 126.6 ns |
| DllImport     | StringToUppercase_StringBuilder | .NET 8.0           | 176.2 ns | 0.28 ns | 0.23 ns | 176.2 ns | 175.8 ns | 176.6 ns |
| DllImport     | StringToUppercase_ByteArray     | .NET Framework 4.8 | 282.5 ns | 0.38 ns | 0.33 ns | 282.4 ns | 282.0 ns | 283.2 ns |
| DllImport     | StringToUppercase_Fixed         | .NET Framework 4.8 | 275.6 ns | 0.18 ns | 0.16 ns | 275.7 ns | 275.4 ns | 276.0 ns |
| DllImport     | StringToUppercase_StringBuilder | .NET Framework 4.8 | 278.5 ns | 3.51 ns | 3.11 ns | 277.8 ns | 273.7 ns | 284.1 ns |
| FuncPointers  | StringToUppercase_Fixed         | .NET 6.0           | 140.3 ns | 0.23 ns | 0.21 ns | 140.3 ns | 139.9 ns | 140.7 ns |
| FuncPointers  | StringToUppercase_Fixed         | .NET 8.0           | 126.9 ns | 0.29 ns | 0.27 ns | 126.9 ns | 126.5 ns | 127.3 ns |
| LibraryImport | StringToUppercase_ByteArray     | .NET 8.0           | 129.4 ns | 0.28 ns | 0.22 ns | 129.4 ns | 129.0 ns | 129.8 ns |
| LibraryImport | StringToUppercase_Fixed         | .NET 8.0           | 123.9 ns | 0.36 ns | 0.30 ns | 123.9 ns | 123.7 ns | 124.8 ns |
