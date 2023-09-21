```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UQWOIG : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-KHVUNI : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-DKIWSP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method      | Runtime            | input       | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |------------ |------------------- |------------ |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | SumIntArray | .NET 6.0           | Int32[1000] | 463.908 ns | 1.0273 ns | 0.9609 ns | 464.091 ns | 462.491 ns | 465.174 ns |
| DllImport     | SumIntArray | .NET 8.0           | Int32[1000] | 462.757 ns | 0.8360 ns | 0.7820 ns | 462.763 ns | 461.429 ns | 464.004 ns |
| DllImport     | SumIntArray | .NET Framework 4.8 | Int32[1000] | 469.298 ns | 0.6308 ns | 0.5592 ns | 469.089 ns | 468.605 ns | 470.276 ns |
| DllImport     | SumIntArray | .NET 6.0           | Int32[10]   |  11.874 ns | 0.0183 ns | 0.0163 ns |  11.875 ns |  11.842 ns |  11.901 ns |
| DllImport     | SumIntArray | .NET 8.0           | Int32[10]   |  11.040 ns | 0.0100 ns | 0.0094 ns |  11.040 ns |  11.028 ns |  11.060 ns |
| DllImport     | SumIntArray | .NET Framework 4.8 | Int32[10]   |  16.285 ns | 0.0277 ns | 0.0260 ns |  16.300 ns |  16.248 ns |  16.315 ns |
| FuncPointers  | SumIntArray | .NET 6.0           | Int32[1000] | 466.576 ns | 1.9834 ns | 1.8553 ns | 465.727 ns | 464.614 ns | 469.636 ns |
| FuncPointers  | SumIntArray | .NET 8.0           | Int32[1000] | 463.238 ns | 0.8602 ns | 0.8047 ns | 463.605 ns | 461.646 ns | 463.989 ns |
| FuncPointers  | SumIntArray | .NET 6.0           | Int32[10]   |  12.125 ns | 0.0060 ns | 0.0056 ns |  12.126 ns |  12.115 ns |  12.133 ns |
| FuncPointers  | SumIntArray | .NET 8.0           | Int32[10]   |  12.225 ns | 0.0052 ns | 0.0046 ns |  12.226 ns |  12.217 ns |  12.231 ns |
| LibraryImport | SumIntArray | .NET 8.0           | Int32[1000] | 461.106 ns | 0.5633 ns | 0.4703 ns | 461.011 ns | 460.442 ns | 462.074 ns |
| LibraryImport | SumIntArray | .NET 8.0           | Int32[10]   |  12.071 ns | 0.0073 ns | 0.0068 ns |  12.068 ns |  12.064 ns |  12.082 ns |
| Managed       | SumIntArray | .NET 6.0           | Int32[1000] | 740.850 ns | 1.2577 ns | 1.0503 ns | 740.834 ns | 738.316 ns | 742.783 ns |
| Managed       | SumIntArray | .NET 8.0           | Int32[1000] | 463.719 ns | 1.1053 ns | 1.0339 ns | 463.716 ns | 461.866 ns | 465.319 ns |
| Managed       | SumIntArray | .NET Framework 4.8 | Int32[1000] | 741.477 ns | 1.7129 ns | 1.6022 ns | 741.304 ns | 738.531 ns | 744.187 ns |
| Managed       | SumIntArray | .NET 6.0           | Int32[10]   |   6.712 ns | 0.0092 ns | 0.0082 ns |   6.712 ns |   6.699 ns |   6.725 ns |
| Managed       | SumIntArray | .NET 8.0           | Int32[10]   |   5.172 ns | 0.0026 ns | 0.0022 ns |   5.172 ns |   5.169 ns |   5.176 ns |
| Managed       | SumIntArray | .NET Framework 4.8 | Int32[10]   |   9.241 ns | 0.0031 ns | 0.0027 ns |   9.242 ns |   9.236 ns |   9.245 ns |
