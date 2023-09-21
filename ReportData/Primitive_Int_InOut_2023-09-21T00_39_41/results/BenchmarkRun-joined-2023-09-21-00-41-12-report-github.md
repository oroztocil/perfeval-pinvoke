```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-LSIIOG : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-PPLXHW : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-OODRSV : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method      | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |------------ |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | MultiplyInt | .NET 6.0           |  9.4259 ns | 0.0031 ns | 0.0027 ns |  9.4250 ns |  9.4231 ns |  9.4313 ns |
| DllImport     | MultiplyInt | .NET 8.0           |  9.4311 ns | 0.0081 ns | 0.0067 ns |  9.4306 ns |  9.4205 ns |  9.4456 ns |
| DllImport     | MultiplyInt | .NET Framework 4.8 | 14.7009 ns | 0.0065 ns | 0.0058 ns | 14.7027 ns | 14.6855 ns | 14.7100 ns |
| FuncPointers  | MultiplyInt | .NET 6.0           |  9.0702 ns | 0.0045 ns | 0.0042 ns |  9.0683 ns |  9.0663 ns |  9.0789 ns |
| FuncPointers  | MultiplyInt | .NET 8.0           |  9.0727 ns | 0.0050 ns | 0.0044 ns |  9.0727 ns |  9.0670 ns |  9.0827 ns |
| LibraryImport | MultiplyInt | .NET 8.0           |  9.4205 ns | 0.0046 ns | 0.0043 ns |  9.4216 ns |  9.4155 ns |  9.4272 ns |
| Managed       | MultiplyInt | .NET 6.0           |  0.7226 ns | 0.0009 ns | 0.0008 ns |  0.7224 ns |  0.7217 ns |  0.7241 ns |
| Managed       | MultiplyInt | .NET 8.0           |  0.6970 ns | 0.0013 ns | 0.0012 ns |  0.6961 ns |  0.6958 ns |  0.6988 ns |
| Managed       | MultiplyInt | .NET Framework 4.8 |  0.9865 ns | 0.0003 ns | 0.0003 ns |  0.9864 ns |  0.9861 ns |  0.9870 ns |
