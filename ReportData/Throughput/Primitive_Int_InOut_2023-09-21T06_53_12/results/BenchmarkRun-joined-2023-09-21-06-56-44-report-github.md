```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-RWLLXN : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-VRIUDQ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-PGQHWM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method      | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        | Allocated |
|-------------- |------------ |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|----------:|
| Managed       | MultiplyInt | .NET 6.0           |  0.6957 ns | 0.0016 ns | 0.0013 ns |  0.6960 ns |  0.6930 ns |  0.6970 ns |         - |
| Managed       | MultiplyInt | .NET 8.0           |  0.6968 ns | 0.0004 ns | 0.0003 ns |  0.6969 ns |  0.6964 ns |  0.6975 ns |         - |
| Managed       | MultiplyInt | .NET Framework 4.8 |  1.0491 ns | 0.0004 ns | 0.0003 ns |  1.0491 ns |  1.0485 ns |  1.0498 ns |         - |
| FuncPointers  | MultiplyInt | .NET 6.0           |  7.0074 ns | 0.0092 ns | 0.0086 ns |  7.0031 ns |  7.0003 ns |  7.0238 ns |         - |
| LibraryImport | MultiplyInt | .NET 8.0           |  7.2145 ns | 0.0021 ns | 0.0019 ns |  7.2139 ns |  7.2127 ns |  7.2179 ns |         - |
| FuncPointers  | MultiplyInt | .NET 8.0           |  9.0679 ns | 0.0023 ns | 0.0021 ns |  9.0671 ns |  9.0661 ns |  9.0719 ns |         - |
| DllImport     | MultiplyInt | .NET 8.0           |  9.4168 ns | 0.0019 ns | 0.0016 ns |  9.4164 ns |  9.4154 ns |  9.4208 ns |         - |
| DllImport     | MultiplyInt | .NET 6.0           |  9.4240 ns | 0.0095 ns | 0.0084 ns |  9.4206 ns |  9.4167 ns |  9.4393 ns |         - |
| DllImport     | MultiplyInt | .NET Framework 4.8 | 14.6932 ns | 0.0122 ns | 0.0114 ns | 14.6935 ns | 14.6758 ns | 14.7129 ns |         - |
