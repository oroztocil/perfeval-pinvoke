```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-SPGWXW : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ENRGCY : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UIQVAQ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method               | Runtime            | input       | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |--------------------- |------------------- |------------ |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | FillIntArray_ByValue | .NET 6.0           | Int32[1000] | 393.629 ns | 0.2420 ns | 0.2021 ns | 393.726 ns | 393.204 ns | 393.802 ns |
| DllImport     | FillIntArray_Fixed   | .NET 6.0           | Int32[1000] | 389.767 ns | 0.0586 ns | 0.0458 ns | 389.772 ns | 389.693 ns | 389.827 ns |
| DllImport     | FillIntArray_OutAttr | .NET 6.0           | Int32[1000] | 389.762 ns | 0.1666 ns | 0.1301 ns | 389.752 ns | 389.458 ns | 389.991 ns |
| DllImport     | FillIntArray_Pinned  | .NET 6.0           | Int32[1000] | 428.124 ns | 0.3026 ns | 0.2830 ns | 428.166 ns | 427.605 ns | 428.665 ns |
| DllImport     | FillIntArray_ByValue | .NET 8.0           | Int32[1000] | 391.691 ns | 0.1867 ns | 0.1655 ns | 391.724 ns | 391.452 ns | 391.939 ns |
| DllImport     | FillIntArray_Fixed   | .NET 8.0           | Int32[1000] | 389.289 ns | 0.0712 ns | 0.0631 ns | 389.272 ns | 389.216 ns | 389.428 ns |
| DllImport     | FillIntArray_OutAttr | .NET 8.0           | Int32[1000] | 389.458 ns | 0.0958 ns | 0.0849 ns | 389.439 ns | 389.315 ns | 389.585 ns |
| DllImport     | FillIntArray_Pinned  | .NET 8.0           | Int32[1000] | 420.194 ns | 0.2535 ns | 0.2372 ns | 420.178 ns | 419.799 ns | 420.685 ns |
| DllImport     | FillIntArray_ByValue | .NET Framework 4.8 | Int32[1000] | 396.872 ns | 0.2417 ns | 0.2143 ns | 396.877 ns | 396.527 ns | 397.237 ns |
| DllImport     | FillIntArray_Fixed   | .NET Framework 4.8 | Int32[1000] | 395.629 ns | 0.0591 ns | 0.0524 ns | 395.628 ns | 395.548 ns | 395.745 ns |
| DllImport     | FillIntArray_OutAttr | .NET Framework 4.8 | Int32[1000] | 395.339 ns | 0.0835 ns | 0.0740 ns | 395.343 ns | 395.153 ns | 395.458 ns |
| DllImport     | FillIntArray_Pinned  | .NET Framework 4.8 | Int32[1000] | 485.290 ns | 0.0679 ns | 0.0567 ns | 485.284 ns | 485.209 ns | 485.403 ns |
| DllImport     | FillIntArray_ByValue | .NET 6.0           | Int32[10]   |  12.279 ns | 0.0030 ns | 0.0025 ns |  12.278 ns |  12.275 ns |  12.284 ns |
| DllImport     | FillIntArray_Fixed   | .NET 6.0           | Int32[10]   |  12.292 ns | 0.0106 ns | 0.0099 ns |  12.295 ns |  12.273 ns |  12.302 ns |
| DllImport     | FillIntArray_OutAttr | .NET 6.0           | Int32[10]   |  12.269 ns | 0.0050 ns | 0.0044 ns |  12.267 ns |  12.265 ns |  12.277 ns |
| DllImport     | FillIntArray_Pinned  | .NET 6.0           | Int32[10]   |  61.944 ns | 0.0254 ns | 0.0225 ns |  61.941 ns |  61.909 ns |  61.979 ns |
| DllImport     | FillIntArray_ByValue | .NET 8.0           | Int32[10]   |  12.744 ns | 0.1729 ns | 0.1617 ns |  12.716 ns |  12.529 ns |  13.033 ns |
| DllImport     | FillIntArray_Fixed   | .NET 8.0           | Int32[10]   |  11.576 ns | 0.0025 ns | 0.0021 ns |  11.576 ns |  11.573 ns |  11.579 ns |
| DllImport     | FillIntArray_OutAttr | .NET 8.0           | Int32[10]   |  12.137 ns | 0.0126 ns | 0.0118 ns |  12.138 ns |  12.112 ns |  12.156 ns |
| DllImport     | FillIntArray_Pinned  | .NET 8.0           | Int32[10]   |  54.480 ns | 0.0146 ns | 0.0129 ns |  54.479 ns |  54.451 ns |  54.504 ns |
| DllImport     | FillIntArray_ByValue | .NET Framework 4.8 | Int32[10]   |  16.965 ns | 0.0025 ns | 0.0022 ns |  16.965 ns |  16.960 ns |  16.968 ns |
| DllImport     | FillIntArray_Fixed   | .NET Framework 4.8 | Int32[10]   |  17.949 ns | 0.0075 ns | 0.0067 ns |  17.949 ns |  17.937 ns |  17.960 ns |
| DllImport     | FillIntArray_OutAttr | .NET Framework 4.8 | Int32[10]   |  16.954 ns | 0.0073 ns | 0.0064 ns |  16.952 ns |  16.948 ns |  16.967 ns |
| DllImport     | FillIntArray_Pinned  | .NET Framework 4.8 | Int32[10]   | 109.907 ns | 0.0169 ns | 0.0132 ns | 109.911 ns | 109.882 ns | 109.925 ns |
| FuncPointers  | FillIntArray_Fixed   | .NET 6.0           | Int32[1000] | 391.718 ns | 0.1677 ns | 0.1400 ns | 391.672 ns | 391.573 ns | 392.008 ns |
| FuncPointers  | FillIntArray_Pinned  | .NET 6.0           | Int32[1000] | 427.249 ns | 0.7934 ns | 0.7421 ns | 426.995 ns | 426.370 ns | 428.442 ns |
| FuncPointers  | FillIntArray_Fixed   | .NET 8.0           | Int32[1000] | 391.275 ns | 0.2238 ns | 0.2093 ns | 391.283 ns | 390.913 ns | 391.628 ns |
| FuncPointers  | FillIntArray_Pinned  | .NET 8.0           | Int32[1000] | 423.081 ns | 0.2997 ns | 0.2803 ns | 423.049 ns | 422.594 ns | 423.589 ns |
| FuncPointers  | FillIntArray_Fixed   | .NET 6.0           | Int32[10]   |  11.745 ns | 0.0067 ns | 0.0059 ns |  11.742 ns |  11.741 ns |  11.759 ns |
| FuncPointers  | FillIntArray_Pinned  | .NET 6.0           | Int32[10]   |  61.962 ns | 0.0281 ns | 0.0235 ns |  61.968 ns |  61.923 ns |  61.994 ns |
| FuncPointers  | FillIntArray_Fixed   | .NET 8.0           | Int32[10]   |  11.233 ns | 0.0020 ns | 0.0017 ns |  11.233 ns |  11.232 ns |  11.236 ns |
| FuncPointers  | FillIntArray_Pinned  | .NET 8.0           | Int32[10]   |  54.362 ns | 0.0148 ns | 0.0123 ns |  54.358 ns |  54.343 ns |  54.384 ns |
| LibraryImport | FillIntArray_ByValue | .NET 8.0           | Int32[1000] | 391.553 ns | 0.2949 ns | 0.2462 ns | 391.641 ns | 391.053 ns | 391.842 ns |
| LibraryImport | FillIntArray_Fixed   | .NET 8.0           | Int32[1000] | 388.596 ns | 0.2069 ns | 0.1935 ns | 388.601 ns | 388.256 ns | 389.007 ns |
| LibraryImport | FillIntArray_Pinned  | .NET 8.0           | Int32[1000] | 421.234 ns | 0.5607 ns | 0.5245 ns | 420.946 ns | 420.634 ns | 422.323 ns |
| LibraryImport | FillIntArray_ByValue | .NET 8.0           | Int32[10]   |  11.527 ns | 0.0029 ns | 0.0027 ns |  11.528 ns |  11.521 ns |  11.531 ns |
| LibraryImport | FillIntArray_Fixed   | .NET 8.0           | Int32[10]   |  11.576 ns | 0.0125 ns | 0.0116 ns |  11.572 ns |  11.560 ns |  11.603 ns |
| LibraryImport | FillIntArray_Pinned  | .NET 8.0           | Int32[10]   |  56.311 ns | 0.0079 ns | 0.0066 ns |  56.313 ns |  56.300 ns |  56.322 ns |
| Managed       | FillIntArray         | .NET 6.0           | Int32[1000] | 614.937 ns | 1.0166 ns | 0.9509 ns | 615.336 ns | 612.900 ns | 615.939 ns |
| Managed       | FillIntArray         | .NET 8.0           | Int32[1000] | 357.950 ns | 0.1485 ns | 0.1316 ns | 357.887 ns | 357.832 ns | 358.221 ns |
| Managed       | FillIntArray         | .NET Framework 4.8 | Int32[1000] | 615.792 ns | 0.7681 ns | 0.7185 ns | 616.030 ns | 614.651 ns | 617.105 ns |
| Managed       | FillIntArray         | .NET 6.0           | Int32[10]   |   5.434 ns | 0.0068 ns | 0.0064 ns |   5.435 ns |   5.420 ns |   5.446 ns |
| Managed       | FillIntArray         | .NET 8.0           | Int32[10]   |   4.991 ns | 0.0017 ns | 0.0014 ns |   4.991 ns |   4.989 ns |   4.995 ns |
| Managed       | FillIntArray         | .NET Framework 4.8 | Int32[10]   |   6.077 ns | 0.0108 ns | 0.0096 ns |   6.079 ns |   6.053 ns |   6.090 ns |
