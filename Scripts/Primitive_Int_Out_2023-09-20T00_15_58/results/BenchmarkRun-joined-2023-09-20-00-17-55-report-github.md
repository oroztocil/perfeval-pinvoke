```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-DYOXOY : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-VFQQKA : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-DEOSBA : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=300.0000 ms  WarmupCount=5  

```
| Type          | Method      | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |------------ |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | ConstantInt | .NET 6.0           |  7.3103 ns | 0.0096 ns | 0.0085 ns |  7.3075 ns |  7.3028 ns |  7.3302 ns |
| DllImport     | ConstantInt | .NET 8.0           |  7.2467 ns | 0.0751 ns | 0.0703 ns |  7.2274 ns |  7.1528 ns |  7.3749 ns |
| DllImport     | ConstantInt | .NET Framework 4.8 | 14.5498 ns | 0.2053 ns | 0.1921 ns | 14.4467 ns | 14.3575 ns | 14.9757 ns |
| FuncPointers  | ConstantInt | .NET 6.0           |  9.0043 ns | 0.0188 ns | 0.0167 ns |  8.9958 ns |  8.9905 ns |  9.0430 ns |
| FuncPointers  | ConstantInt | .NET 8.0           |  9.0182 ns | 0.0101 ns | 0.0084 ns |  9.0159 ns |  9.0068 ns |  9.0323 ns |
| LibraryImport | ConstantInt | .NET 8.0           |  9.3577 ns | 0.0355 ns | 0.0297 ns |  9.3441 ns |  9.3373 ns |  9.4374 ns |
| Managed       | ConstantInt | .NET 6.0           |  0.7161 ns | 0.0038 ns | 0.0032 ns |  0.7146 ns |  0.7132 ns |  0.7242 ns |
| Managed       | ConstantInt | .NET 8.0           |  0.7563 ns | 0.0492 ns | 0.0736 ns |  0.7308 ns |  0.6894 ns |  0.9347 ns |
| Managed       | ConstantInt | .NET Framework 4.8 |  0.9928 ns | 0.0015 ns | 0.0011 ns |  0.9933 ns |  0.9910 ns |  0.9943 ns |
