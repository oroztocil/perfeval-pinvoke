```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QXJBPQ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-DHMXPY : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-BGELHQ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method      | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |------------ |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | ConstantInt | .NET 6.0           |  9.4275 ns | 0.0041 ns | 0.0038 ns |  9.4263 ns |  9.4234 ns |  9.4363 ns |
| DllImport     | ConstantInt | .NET 8.0           |  9.4314 ns | 0.0042 ns | 0.0032 ns |  9.4311 ns |  9.4275 ns |  9.4387 ns |
| DllImport     | ConstantInt | .NET Framework 4.8 | 14.6997 ns | 0.0221 ns | 0.0196 ns | 14.6979 ns | 14.6725 ns | 14.7248 ns |
| FuncPointers  | ConstantInt | .NET 6.0           |  9.1102 ns | 0.0492 ns | 0.0460 ns |  9.1013 ns |  9.0654 ns |  9.1955 ns |
| FuncPointers  | ConstantInt | .NET 8.0           |  9.0747 ns | 0.0022 ns | 0.0018 ns |  9.0740 ns |  9.0722 ns |  9.0779 ns |
| LibraryImport | ConstantInt | .NET 8.0           |  9.4247 ns | 0.0027 ns | 0.0023 ns |  9.4251 ns |  9.4212 ns |  9.4278 ns |
| Managed       | ConstantInt | .NET 6.0           |  0.6986 ns | 0.0015 ns | 0.0012 ns |  0.6986 ns |  0.6955 ns |  0.7007 ns |
| Managed       | ConstantInt | .NET 8.0           |  0.6992 ns | 0.0003 ns | 0.0002 ns |  0.6993 ns |  0.6989 ns |  0.6997 ns |
| Managed       | ConstantInt | .NET Framework 4.8 |  1.0250 ns | 0.0009 ns | 0.0007 ns |  1.0248 ns |  1.0241 ns |  1.0269 ns |
