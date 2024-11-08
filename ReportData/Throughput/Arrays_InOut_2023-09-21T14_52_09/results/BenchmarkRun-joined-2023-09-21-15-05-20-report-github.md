```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-PSYAIB : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QCGQZJ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ISITMA : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method               | Runtime            | input       | Mean       | Error     | StdDev    | Median     | Min        | Max        | Allocated |
|-------------- |--------------------- |------------------- |------------ |-----------:|----------:|----------:|-----------:|-----------:|-----------:|----------:|
| Managed       | FillIntArray         | .NET 8.0           | Int32[10]   |   4.969 ns | 0.0012 ns | 0.0010 ns |   4.969 ns |   4.968 ns |   4.972 ns |         - |
| Managed       | FillIntArray         | .NET 6.0           | Int32[10]   |   5.653 ns | 0.0043 ns | 0.0038 ns |   5.653 ns |   5.647 ns |   5.659 ns |         - |
| Managed       | FillIntArray         | .NET Framework 4.8 | Int32[10]   |   6.366 ns | 0.0031 ns | 0.0026 ns |   6.366 ns |   6.361 ns |   6.371 ns |         - |
| FuncPointers  | FillIntArray_Fixed   | .NET 8.0           | Int32[10]   |  11.196 ns | 0.0098 ns | 0.0092 ns |  11.190 ns |  11.187 ns |  11.210 ns |         - |
| LibraryImport | FillIntArray_ByValue | .NET 8.0           | Int32[10]   |  11.471 ns | 0.0036 ns | 0.0034 ns |  11.470 ns |  11.467 ns |  11.478 ns |         - |
| DllImport     | FillIntArray_Fixed   | .NET 8.0           | Int32[10]   |  11.576 ns | 0.0019 ns | 0.0016 ns |  11.576 ns |  11.574 ns |  11.579 ns |         - |
| LibraryImport | FillIntArray_Fixed   | .NET 8.0           | Int32[10]   |  11.623 ns | 0.0036 ns | 0.0030 ns |  11.622 ns |  11.620 ns |  11.629 ns |         - |
| FuncPointers  | FillIntArray_Fixed   | .NET 6.0           | Int32[10]   |  11.729 ns | 0.0069 ns | 0.0064 ns |  11.728 ns |  11.722 ns |  11.743 ns |         - |
| DllImport     | FillIntArray_ByValue | .NET 8.0           | Int32[10]   |  12.039 ns | 0.0139 ns | 0.0130 ns |  12.041 ns |  12.011 ns |  12.058 ns |         - |
| DllImport     | FillIntArray_Fixed   | .NET 6.0           | Int32[10]   |  12.129 ns | 0.0055 ns | 0.0049 ns |  12.130 ns |  12.119 ns |  12.136 ns |         - |
| DllImport     | FillIntArray_ByValue | .NET 6.0           | Int32[10]   |  12.312 ns | 0.0043 ns | 0.0038 ns |  12.311 ns |  12.308 ns |  12.322 ns |         - |
| DllImport     | FillIntArray_ByValue | .NET Framework 4.8 | Int32[10]   |  17.263 ns | 0.0080 ns | 0.0067 ns |  17.259 ns |  17.258 ns |  17.279 ns |         - |
| DllImport     | FillIntArray_Fixed   | .NET Framework 4.8 | Int32[10]   |  18.176 ns | 0.0205 ns | 0.0191 ns |  18.169 ns |  18.144 ns |  18.214 ns |         - |
| DllImport     | FillIntArray_Pinned  | .NET 8.0           | Int32[10]   |  55.152 ns | 0.0199 ns | 0.0166 ns |  55.155 ns |  55.128 ns |  55.184 ns |         - |
| FuncPointers  | FillIntArray_Pinned  | .NET 8.0           | Int32[10]   |  55.228 ns | 0.0085 ns | 0.0075 ns |  55.227 ns |  55.212 ns |  55.242 ns |         - |
| LibraryImport | FillIntArray_Pinned  | .NET 8.0           | Int32[10]   |  55.381 ns | 0.0205 ns | 0.0182 ns |  55.386 ns |  55.352 ns |  55.412 ns |         - |
| DllImport     | FillIntArray_Pinned  | .NET 6.0           | Int32[10]   |  62.098 ns | 0.0261 ns | 0.0231 ns |  62.093 ns |  62.063 ns |  62.152 ns |         - |
| FuncPointers  | FillIntArray_Pinned  | .NET 6.0           | Int32[10]   |  62.184 ns | 0.0279 ns | 0.0261 ns |  62.168 ns |  62.161 ns |  62.249 ns |         - |
| DllImport     | FillIntArray_Pinned  | .NET Framework 4.8 | Int32[10]   | 111.590 ns | 0.0823 ns | 0.0729 ns | 111.556 ns | 111.532 ns | 111.782 ns |         - |
| Managed       | FillIntArray         | .NET 8.0           | Int32[1000] | 358.394 ns | 0.1292 ns | 0.1209 ns | 358.368 ns | 358.226 ns | 358.646 ns |         - |
| LibraryImport | FillIntArray_Fixed   | .NET 8.0           | Int32[1000] | 387.815 ns | 0.1010 ns | 0.0843 ns | 387.835 ns | 387.659 ns | 387.919 ns |         - |
| DllImport     | FillIntArray_Fixed   | .NET 8.0           | Int32[1000] | 388.279 ns | 0.3016 ns | 0.2821 ns | 388.133 ns | 388.001 ns | 388.938 ns |         - |
| DllImport     | FillIntArray_Fixed   | .NET 6.0           | Int32[1000] | 389.723 ns | 0.2248 ns | 0.1877 ns | 389.638 ns | 389.564 ns | 390.116 ns |         - |
| DllImport     | FillIntArray_ByValue | .NET 8.0           | Int32[1000] | 391.488 ns | 0.2152 ns | 0.2013 ns | 391.401 ns | 391.290 ns | 391.885 ns |         - |
| FuncPointers  | FillIntArray_Fixed   | .NET 6.0           | Int32[1000] | 392.143 ns | 0.1776 ns | 0.1574 ns | 392.226 ns | 391.874 ns | 392.318 ns |         - |
| FuncPointers  | FillIntArray_Fixed   | .NET 8.0           | Int32[1000] | 392.270 ns | 0.0415 ns | 0.0368 ns | 392.262 ns | 392.217 ns | 392.350 ns |         - |
| LibraryImport | FillIntArray_ByValue | .NET 8.0           | Int32[1000] | 392.346 ns | 1.0702 ns | 1.0011 ns | 391.764 ns | 391.476 ns | 394.275 ns |         - |
| DllImport     | FillIntArray_ByValue | .NET 6.0           | Int32[1000] | 393.126 ns | 0.0753 ns | 0.0667 ns | 393.121 ns | 392.991 ns | 393.233 ns |         - |
| DllImport     | FillIntArray_Fixed   | .NET Framework 4.8 | Int32[1000] | 395.629 ns | 0.1045 ns | 0.0873 ns | 395.632 ns | 395.473 ns | 395.815 ns |         - |
| DllImport     | FillIntArray_ByValue | .NET Framework 4.8 | Int32[1000] | 397.229 ns | 0.0595 ns | 0.0557 ns | 397.232 ns | 397.112 ns | 397.313 ns |         - |
| FuncPointers  | FillIntArray_Pinned  | .NET 8.0           | Int32[1000] | 420.244 ns | 0.1437 ns | 0.1274 ns | 420.198 ns | 420.078 ns | 420.510 ns |         - |
| DllImport     | FillIntArray_Pinned  | .NET 8.0           | Int32[1000] | 420.323 ns | 0.2543 ns | 0.2379 ns | 420.327 ns | 419.767 ns | 420.666 ns |         - |
| LibraryImport | FillIntArray_Pinned  | .NET 8.0           | Int32[1000] | 421.031 ns | 0.2517 ns | 0.2355 ns | 421.030 ns | 420.656 ns | 421.565 ns |         - |
| FuncPointers  | FillIntArray_Pinned  | .NET 6.0           | Int32[1000] | 427.671 ns | 0.2681 ns | 0.2376 ns | 427.661 ns | 427.258 ns | 428.029 ns |         - |
| DllImport     | FillIntArray_Pinned  | .NET 6.0           | Int32[1000] | 427.834 ns | 0.1249 ns | 0.1043 ns | 427.835 ns | 427.684 ns | 428.020 ns |         - |
| DllImport     | FillIntArray_Pinned  | .NET Framework 4.8 | Int32[1000] | 483.684 ns | 0.1473 ns | 0.1306 ns | 483.642 ns | 483.559 ns | 483.990 ns |         - |
| Managed       | FillIntArray         | .NET 6.0           | Int32[1000] | 614.694 ns | 0.7558 ns | 0.7070 ns | 614.600 ns | 613.406 ns | 615.939 ns |         - |
| Managed       | FillIntArray         | .NET Framework 4.8 | Int32[1000] | 614.763 ns | 0.7675 ns | 0.7179 ns | 614.707 ns | 613.776 ns | 615.868 ns |         - |
