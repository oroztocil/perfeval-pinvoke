```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-FGBRNT : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-GOVKES : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-EZNYWF : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method      | Runtime            | input       | Mean       | Error     | StdDev    | Median     | Min        | Max        | Allocated |
|-------------- |------------ |------------------- |------------ |-----------:|----------:|----------:|-----------:|-----------:|-----------:|----------:|
| Managed       | SumIntArray | .NET 8.0           | Int32[10]   |   5.221 ns | 0.0270 ns | 0.0252 ns |   5.206 ns |   5.200 ns |   5.265 ns |         - |
| Managed       | SumIntArray | .NET 6.0           | Int32[10]   |   6.071 ns | 0.0305 ns | 0.0285 ns |   6.069 ns |   6.022 ns |   6.111 ns |         - |
| Managed       | SumIntArray | .NET Framework 4.8 | Int32[10]   |   9.239 ns | 0.0031 ns | 0.0028 ns |   9.239 ns |   9.235 ns |   9.245 ns |         - |
| DllImport     | SumIntArray | .NET 8.0           | Int32[10]   |  10.964 ns | 0.0245 ns | 0.0230 ns |  10.959 ns |  10.919 ns |  11.012 ns |         - |
| LibraryImport | SumIntArray | .NET 8.0           | Int32[10]   |  11.896 ns | 0.0018 ns | 0.0016 ns |  11.896 ns |  11.894 ns |  11.900 ns |         - |
| FuncPointers  | SumIntArray | .NET 8.0           | Int32[10]   |  11.957 ns | 0.0047 ns | 0.0044 ns |  11.958 ns |  11.950 ns |  11.963 ns |         - |
| DllImport     | SumIntArray | .NET 6.0           | Int32[10]   |  12.081 ns | 0.0391 ns | 0.0366 ns |  12.069 ns |  12.017 ns |  12.154 ns |         - |
| FuncPointers  | SumIntArray | .NET 6.0           | Int32[10]   |  12.308 ns | 0.0079 ns | 0.0066 ns |  12.311 ns |  12.295 ns |  12.313 ns |         - |
| DllImport     | SumIntArray | .NET Framework 4.8 | Int32[10]   |  16.093 ns | 0.0354 ns | 0.0313 ns |  16.096 ns |  16.043 ns |  16.148 ns |         - |
| FuncPointers  | SumIntArray | .NET 8.0           | Int32[1000] | 461.914 ns | 0.2069 ns | 0.1935 ns | 461.925 ns | 461.588 ns | 462.353 ns |         - |
| DllImport     | SumIntArray | .NET 8.0           | Int32[1000] | 462.444 ns | 0.8935 ns | 0.8358 ns | 462.407 ns | 461.233 ns | 463.588 ns |         - |
| LibraryImport | SumIntArray | .NET 8.0           | Int32[1000] | 462.693 ns | 0.3691 ns | 0.3453 ns | 462.618 ns | 462.245 ns | 463.376 ns |         - |
| DllImport     | SumIntArray | .NET 6.0           | Int32[1000] | 465.049 ns | 3.0215 ns | 2.8263 ns | 463.201 ns | 462.835 ns | 469.016 ns |         - |
| Managed       | SumIntArray | .NET 8.0           | Int32[1000] | 465.267 ns | 0.5825 ns | 0.5449 ns | 465.261 ns | 464.243 ns | 466.089 ns |         - |
| FuncPointers  | SumIntArray | .NET 6.0           | Int32[1000] | 468.296 ns | 2.0816 ns | 1.9471 ns | 469.208 ns | 465.501 ns | 470.038 ns |         - |
| DllImport     | SumIntArray | .NET Framework 4.8 | Int32[1000] | 470.261 ns | 0.3664 ns | 0.3428 ns | 470.238 ns | 469.753 ns | 470.828 ns |         - |
| Managed       | SumIntArray | .NET 6.0           | Int32[1000] | 741.172 ns | 1.1999 ns | 1.1224 ns | 741.525 ns | 739.231 ns | 743.005 ns |         - |
| Managed       | SumIntArray | .NET Framework 4.8 | Int32[1000] | 741.433 ns | 0.6917 ns | 0.6132 ns | 741.336 ns | 740.489 ns | 742.557 ns |         - |
