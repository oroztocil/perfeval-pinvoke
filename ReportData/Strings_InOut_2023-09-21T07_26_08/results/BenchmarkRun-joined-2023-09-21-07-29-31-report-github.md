```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QNWXYQ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-SIRCNU : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-FPXKRW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method                          | Runtime            | Mean     | Error   | StdDev  | Median   | Min      | Max      | Gen0   | Allocated |
|-------------- |-------------------------------- |------------------- |---------:|--------:|--------:|---------:|---------:|---------:|-------:|----------:|
| LibraryImport | StringToUppercase_ByteArray     | .NET 8.0           | 123.7 ns | 0.19 ns | 0.18 ns | 123.7 ns | 123.5 ns | 124.2 ns | 0.0153 |      96 B |
| LibraryImport | StringToUppercase_Fixed         | .NET 8.0           | 124.3 ns | 0.16 ns | 0.13 ns | 124.3 ns | 124.2 ns | 124.6 ns | 0.0153 |      96 B |
| DllImport     | StringToUppercase_Fixed         | .NET 8.0           | 124.6 ns | 0.09 ns | 0.07 ns | 124.6 ns | 124.5 ns | 124.7 ns | 0.0153 |      96 B |
| DllImport     | StringToUppercase_ByteArray     | .NET 8.0           | 126.7 ns | 0.20 ns | 0.17 ns | 126.7 ns | 126.6 ns | 127.1 ns | 0.0153 |      96 B |
| FuncPointers  | StringToUppercase_Fixed         | .NET 8.0           | 127.4 ns | 0.17 ns | 0.16 ns | 127.4 ns | 127.2 ns | 127.8 ns | 0.0153 |      96 B |
| DllImport     | StringToUppercase_Fixed         | .NET 6.0           | 139.8 ns | 0.25 ns | 0.20 ns | 139.8 ns | 139.3 ns | 139.9 ns | 0.0153 |      96 B |
| FuncPointers  | StringToUppercase_Fixed         | .NET 6.0           | 140.2 ns | 0.21 ns | 0.19 ns | 140.2 ns | 139.8 ns | 140.6 ns | 0.0153 |      96 B |
| DllImport     | StringToUppercase_ByteArray     | .NET 6.0           | 146.5 ns | 0.26 ns | 0.24 ns | 146.5 ns | 146.1 ns | 147.0 ns | 0.0153 |      96 B |
| DllImport     | StringToUppercase_StringBuilder | .NET 6.0           | 177.9 ns | 0.08 ns | 0.06 ns | 177.9 ns | 177.8 ns | 178.1 ns | 0.0381 |     240 B |
| DllImport     | StringToUppercase_StringBuilder | .NET 8.0           | 181.0 ns | 0.37 ns | 0.35 ns | 180.9 ns | 180.5 ns | 181.8 ns | 0.0381 |     240 B |
| DllImport     | StringToUppercase_StringBuilder | .NET Framework 4.8 | 272.8 ns | 1.31 ns | 1.22 ns | 272.8 ns | 270.9 ns | 274.9 ns | 0.0496 |     313 B |
| DllImport     | StringToUppercase_ByteArray     | .NET Framework 4.8 | 279.3 ns | 0.45 ns | 0.40 ns | 279.1 ns | 278.9 ns | 280.2 ns | 0.0162 |     104 B |
| DllImport     | StringToUppercase_Fixed         | .NET Framework 4.8 | 283.7 ns | 0.05 ns | 0.05 ns | 283.7 ns | 283.7 ns | 283.8 ns | 0.0162 |     104 B |
