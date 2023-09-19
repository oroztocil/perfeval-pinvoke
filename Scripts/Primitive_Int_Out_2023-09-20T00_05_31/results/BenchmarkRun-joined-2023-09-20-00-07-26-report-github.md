```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-LGPLTI : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-WOEKLD : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JXCAKT : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=300.0000 ms  WarmupCount=5  

```
| Type          | Method      | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |------------ |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| Managed       | ConstantInt | .NET 6.0           |  0.6781 ns | 0.0011 ns | 0.0009 ns |  0.6780 ns |  0.6764 ns |  0.6798 ns |
| DllImport     | ConstantInt | .NET 6.0           |  7.5180 ns | 0.1073 ns | 0.1003 ns |  7.5195 ns |  7.3570 ns |  7.6578 ns |
| FuncPointers  | ConstantInt | .NET 6.0           |  9.1744 ns | 0.0991 ns | 0.0927 ns |  9.1476 ns |  9.0865 ns |  9.3828 ns |
| Managed       | ConstantInt | .NET 8.0           |  0.7097 ns | 0.0180 ns | 0.0168 ns |  0.6992 ns |  0.6976 ns |  0.7411 ns |
| DllImport     | ConstantInt | .NET 8.0           |  7.2571 ns | 0.0230 ns | 0.0204 ns |  7.2525 ns |  7.2362 ns |  7.3014 ns |
| FuncPointers  | ConstantInt | .NET 8.0           |  9.1746 ns | 0.0963 ns | 0.0901 ns |  9.1509 ns |  9.0993 ns |  9.3412 ns |
| LibraryImport | ConstantInt | .NET 8.0           |  9.4463 ns | 0.0143 ns | 0.0111 ns |  9.4408 ns |  9.4385 ns |  9.4684 ns |
| Managed       | ConstantInt | .NET Framework 4.8 |  1.0075 ns | 0.0055 ns | 0.0043 ns |  1.0054 ns |  1.0036 ns |  1.0161 ns |
| DllImport     | ConstantInt | .NET Framework 4.8 | 12.7646 ns | 0.0458 ns | 0.0358 ns | 12.7461 ns | 12.7423 ns | 12.8456 ns |
