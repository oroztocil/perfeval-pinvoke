```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-LOGJHE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-BZRDXK : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-EGNIMF : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method             | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |------------------- |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | StringLength_Utf16 | .NET 6.0           | 13.6131 ns | 0.0118 ns | 0.0099 ns | 13.6108 ns | 13.6014 ns | 13.6358 ns |
| DllImport     | StringLength_Utf16 | .NET 8.0           | 14.3158 ns | 0.0089 ns | 0.0079 ns | 14.3167 ns | 14.3066 ns | 14.3323 ns |
| DllImport     | StringLength_Utf16 | .NET Framework 4.8 | 19.2983 ns | 0.0297 ns | 0.0263 ns | 19.2962 ns | 19.2514 ns | 19.3537 ns |
| DllImport     | Empty_String       | .NET 6.0           | 41.9765 ns | 0.0607 ns | 0.0507 ns | 41.9603 ns | 41.9041 ns | 42.0880 ns |
| DllImport     | Empty_String       | .NET 8.0           | 34.5240 ns | 0.1133 ns | 0.1004 ns | 34.5615 ns | 34.2881 ns | 34.5983 ns |
| DllImport     | Empty_String       | .NET Framework 4.8 | 74.3670 ns | 0.0219 ns | 0.0183 ns | 74.3660 ns | 74.3362 ns | 74.3993 ns |
| FuncPointers  | Empty_String       | .NET 6.0           | 50.3182 ns | 0.0975 ns | 0.0865 ns | 50.3233 ns | 50.1640 ns | 50.4345 ns |
| FuncPointers  | Empty_String       | .NET 8.0           | 42.5192 ns | 0.0842 ns | 0.0788 ns | 42.5307 ns | 42.3285 ns | 42.6400 ns |
| LibraryImport | Empty_String       | .NET 8.0           | 31.6555 ns | 0.0238 ns | 0.0211 ns | 31.6497 ns | 31.6271 ns | 31.7035 ns |
| Managed       | Empty_String       | .NET 6.0           |  0.6906 ns | 0.0020 ns | 0.0019 ns |  0.6901 ns |  0.6885 ns |  0.6944 ns |
| Managed       | Empty_String       | .NET 8.0           |  0.6974 ns | 0.0004 ns | 0.0003 ns |  0.6975 ns |  0.6969 ns |  0.6980 ns |
| Managed       | Empty_String       | .NET Framework 4.8 |  0.9823 ns | 0.0007 ns | 0.0006 ns |  0.9823 ns |  0.9813 ns |  0.9836 ns |
