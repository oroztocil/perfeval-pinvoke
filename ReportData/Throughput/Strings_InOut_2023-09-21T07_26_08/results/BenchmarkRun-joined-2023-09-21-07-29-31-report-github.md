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
| Type          | Method                          | Runtime            | Mean     | Allocated |
|-------------- |-------------------------------- |------------------- |---------:|----------:|
| LibraryImport | StringToUppercase_ByteArray     | .NET 8.0           | 123.7 ns |      96 B |
| LibraryImport | StringToUppercase_Fixed         | .NET 8.0           | 124.3 ns |      96 B |
| DllImport     | StringToUppercase_Fixed         | .NET 8.0           | 124.6 ns |      96 B |
| DllImport     | StringToUppercase_ByteArray     | .NET 8.0           | 126.7 ns |      96 B |
| FuncPointers  | StringToUppercase_Fixed         | .NET 8.0           | 127.4 ns |      96 B |
| DllImport     | StringToUppercase_Fixed         | .NET 6.0           | 139.8 ns |      96 B |
| FuncPointers  | StringToUppercase_Fixed         | .NET 6.0           | 140.2 ns |      96 B |
| DllImport     | StringToUppercase_ByteArray     | .NET 6.0           | 146.5 ns |      96 B |
| DllImport     | StringToUppercase_StringBuilder | .NET 6.0           | 177.9 ns |     240 B |
| DllImport     | StringToUppercase_StringBuilder | .NET 8.0           | 181.0 ns |     240 B |
| DllImport     | StringToUppercase_StringBuilder | .NET Framework 4.8 | 272.8 ns |     313 B |
| DllImport     | StringToUppercase_ByteArray     | .NET Framework 4.8 | 279.3 ns |     104 B |
| DllImport     | StringToUppercase_Fixed         | .NET Framework 4.8 | 283.7 ns |     104 B |
