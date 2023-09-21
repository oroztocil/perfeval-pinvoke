```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-WVDXFN : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-PUAUDY : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JPLZOU : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method      | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        | Allocated |
|-------------- |------------ |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|----------:|
| Managed       | ConstantInt | .NET 6.0           |  0.6962 ns | 0.0021 ns | 0.0019 ns |  0.6962 ns |  0.6934 ns |  0.7001 ns |         - |
| Managed       | ConstantInt | .NET 8.0           |  0.7140 ns | 0.0052 ns | 0.0049 ns |  0.7155 ns |  0.6978 ns |  0.7173 ns |         - |
| Managed       | ConstantInt | .NET Framework 4.8 |  1.0076 ns | 0.0004 ns | 0.0004 ns |  1.0075 ns |  1.0072 ns |  1.0083 ns |         - |
| FuncPointers  | ConstantInt | .NET 8.0           |  6.8005 ns | 0.0018 ns | 0.0015 ns |  6.7998 ns |  6.7988 ns |  6.8030 ns |         - |
| LibraryImport | ConstantInt | .NET 8.0           |  7.2136 ns | 0.0008 ns | 0.0006 ns |  7.2135 ns |  7.2125 ns |  7.2147 ns |         - |
| FuncPointers  | ConstantInt | .NET 6.0           |  9.0662 ns | 0.0009 ns | 0.0007 ns |  9.0663 ns |  9.0652 ns |  9.0677 ns |         - |
| DllImport     | ConstantInt | .NET 8.0           |  9.4171 ns | 0.0023 ns | 0.0019 ns |  9.4162 ns |  9.4154 ns |  9.4215 ns |         - |
| DllImport     | ConstantInt | .NET 6.0           |  9.4241 ns | 0.0111 ns | 0.0103 ns |  9.4181 ns |  9.4162 ns |  9.4427 ns |         - |
| DllImport     | ConstantInt | .NET Framework 4.8 | 14.6837 ns | 0.0155 ns | 0.0145 ns | 14.6783 ns | 14.6616 ns | 14.7126 ns |         - |
