```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-XYDIDH : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-NAQIVC : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-BDRJGA : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method             | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|-------------- |------------------- |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| Managed       | EmptyString        | .NET 8.0           |  0.6864 ns | 0.0007 ns | 0.0006 ns |  0.6861 ns |  0.6856 ns |  0.6874 ns |      - |         - |
| Managed       | EmptyString        | .NET 6.0           |  1.0445 ns | 0.0010 ns | 0.0009 ns |  1.0443 ns |  1.0434 ns |  1.0465 ns |      - |         - |
| Managed       | EmptyString        | .NET Framework 4.8 |  1.0649 ns | 0.0028 ns | 0.0026 ns |  1.0648 ns |  1.0623 ns |  1.0697 ns |      - |         - |
| DllImport     | StringLength_Utf16 | .NET 8.0           | 12.6860 ns | 0.0146 ns | 0.0136 ns | 12.6833 ns | 12.6674 ns | 12.7123 ns |      - |         - |
| DllImport     | StringLength_Utf16 | .NET 6.0           | 12.8979 ns | 0.0480 ns | 0.0449 ns | 12.8905 ns | 12.8357 ns | 12.9828 ns |      - |         - |
| DllImport     | StringLength_Utf16 | .NET Framework 4.8 | 17.6822 ns | 0.0269 ns | 0.0252 ns | 17.6808 ns | 17.6486 ns | 17.7265 ns |      - |         - |
| LibraryImport | EmptyString        | .NET 8.0           | 29.3171 ns | 0.0143 ns | 0.0127 ns | 29.3150 ns | 29.2997 ns | 29.3437 ns |      - |         - |
| DllImport     | EmptyString        | .NET 8.0           | 37.7936 ns | 0.0322 ns | 0.0285 ns | 37.7883 ns | 37.7600 ns | 37.8583 ns |      - |         - |
| FuncPointers  | EmptyString        | .NET 8.0           | 41.8233 ns | 0.0793 ns | 0.0742 ns | 41.8192 ns | 41.6776 ns | 41.9754 ns | 0.0076 |      48 B |
| DllImport     | EmptyString        | .NET 6.0           | 44.5157 ns | 0.1422 ns | 0.1330 ns | 44.4364 ns | 44.3825 ns | 44.7979 ns |      - |         - |
| FuncPointers  | EmptyString        | .NET 6.0           | 47.2360 ns | 0.0606 ns | 0.0567 ns | 47.2489 ns | 47.0740 ns | 47.3258 ns | 0.0076 |      48 B |
| DllImport     | EmptyString        | .NET Framework 4.8 | 77.1456 ns | 0.0229 ns | 0.0192 ns | 77.1380 ns | 77.1239 ns | 77.1812 ns |      - |         - |
