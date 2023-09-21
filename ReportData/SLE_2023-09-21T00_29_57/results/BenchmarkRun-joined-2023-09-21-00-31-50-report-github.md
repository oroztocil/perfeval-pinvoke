```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TUOLVW : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-RPDXIF : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TGJNEI : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method         | Runtime            | Mean      | Error     | StdDev    | Median    | Min       | Max       |
|-------------- |--------------- |------------------- |----------:|----------:|----------:|----------:|----------:|----------:|
| DllImport     | MultiplyInt    | .NET 6.0           |  9.435 ns | 0.0046 ns | 0.0038 ns |  9.436 ns |  9.430 ns |  9.440 ns |
| DllImport     | MultiplyInt    | .NET 8.0           |  9.582 ns | 0.1822 ns | 0.1789 ns |  9.478 ns |  9.424 ns |  9.846 ns |
| DllImport     | MultiplyInt    | .NET Framework 4.8 | 14.939 ns | 0.2934 ns | 0.3492 ns | 14.718 ns | 14.695 ns | 15.654 ns |
| DllImport     | Empty_VoidSLE  | .NET 6.0           | 13.817 ns | 0.0177 ns | 0.0157 ns | 13.809 ns | 13.800 ns | 13.843 ns |
| DllImport     | Empty_VoidSLE  | .NET 8.0           | 14.631 ns | 0.3213 ns | 0.3700 ns | 14.808 ns | 14.078 ns | 15.078 ns |
| DllImport     | Empty_VoidSLE  | .NET Framework 4.8 | 15.651 ns | 0.0629 ns | 0.0525 ns | 15.640 ns | 15.592 ns | 15.783 ns |
| DllImport     | Empty_Void     | .NET 6.0           |  7.006 ns | 0.0178 ns | 0.0139 ns |  7.000 ns |  6.999 ns |  7.047 ns |
| DllImport     | Empty_Void     | .NET 8.0           |  6.849 ns | 0.0022 ns | 0.0017 ns |  6.849 ns |  6.848 ns |  6.854 ns |
| DllImport     | Empty_Void     | .NET Framework 4.8 | 13.288 ns | 0.0248 ns | 0.0194 ns | 13.289 ns | 13.245 ns | 13.315 ns |
| LibraryImport | Empty_VoidSLE  | .NET 8.0           | 14.550 ns | 0.0158 ns | 0.0148 ns | 14.552 ns | 14.531 ns | 14.578 ns |
| LibraryImport | MultiplyIntSLE | .NET 8.0           | 11.699 ns | 0.0258 ns | 0.0241 ns | 11.705 ns | 11.653 ns | 11.721 ns |
| LibraryImport | Empty_Void     | .NET 8.0           |  6.851 ns | 0.0018 ns | 0.0014 ns |  6.850 ns |  6.849 ns |  6.853 ns |
