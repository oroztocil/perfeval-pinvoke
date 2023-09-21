```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-OHFBCW : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-GYDABO : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-NORVVF : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method                 | Runtime            | input       | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |----------------------- |------------------- |------------ |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | Empty_IntArray_Fixed   | .NET 6.0           | Int32[1000] | 10.4704 ns | 0.0049 ns | 0.0044 ns | 10.4705 ns | 10.4649 ns | 10.4797 ns |
| DllImport     | Empty_IntArray_Fixed   | .NET 8.0           | Int32[1000] | 10.1240 ns | 0.0040 ns | 0.0035 ns | 10.1228 ns | 10.1208 ns | 10.1317 ns |
| DllImport     | Empty_IntArray_Fixed   | .NET Framework 4.8 | Int32[1000] | 16.6318 ns | 0.0056 ns | 0.0050 ns | 16.6322 ns | 16.6231 ns | 16.6391 ns |
| DllImport     | Empty_IntArray_Fixed   | .NET 6.0           | Int32[10]   |  8.4070 ns | 0.0073 ns | 0.0069 ns |  8.4028 ns |  8.4007 ns |  8.4192 ns |
| DllImport     | Empty_IntArray_Fixed   | .NET 8.0           | Int32[10]   |  7.8791 ns | 0.0027 ns | 0.0023 ns |  7.8791 ns |  7.8761 ns |  7.8836 ns |
| DllImport     | Empty_IntArray_Fixed   | .NET Framework 4.8 | Int32[10]   | 14.5029 ns | 0.0040 ns | 0.0031 ns | 14.5037 ns | 14.4956 ns | 14.5077 ns |
| DllImport     | Empty_IntArray_ByValue | .NET 6.0           | Int32[1000] |  9.0727 ns | 0.2194 ns | 0.3076 ns |  8.9127 ns |  8.7522 ns |  9.5899 ns |
| DllImport     | Empty_IntArray_ByValue | .NET 8.0           | Int32[1000] |  8.8176 ns | 0.1522 ns | 0.1424 ns |  8.8317 ns |  8.5753 ns |  9.0176 ns |
| DllImport     | Empty_IntArray_ByValue | .NET Framework 4.8 | Int32[1000] | 13.5896 ns | 0.0017 ns | 0.0014 ns | 13.5893 ns | 13.5876 ns | 13.5928 ns |
| DllImport     | Empty_IntArray_ByValue | .NET 6.0           | Int32[10]   |  8.7519 ns | 0.0024 ns | 0.0020 ns |  8.7517 ns |  8.7489 ns |  8.7566 ns |
| DllImport     | Empty_IntArray_ByValue | .NET 8.0           | Int32[10]   |  8.2666 ns | 0.0013 ns | 0.0011 ns |  8.2663 ns |  8.2650 ns |  8.2688 ns |
| DllImport     | Empty_IntArray_ByValue | .NET Framework 4.8 | Int32[10]   | 13.3006 ns | 0.0032 ns | 0.0028 ns | 13.3003 ns | 13.2940 ns | 13.3050 ns |
| FuncPointers  | Empty_IntArray_Fixed   | .NET 6.0           | Int32[1000] | 10.1228 ns | 0.0025 ns | 0.0023 ns | 10.1223 ns | 10.1184 ns | 10.1276 ns |
| FuncPointers  | Empty_IntArray_Fixed   | .NET 8.0           | Int32[1000] |  9.8338 ns | 0.0856 ns | 0.0758 ns |  9.8109 ns |  9.7652 ns | 10.0351 ns |
| FuncPointers  | Empty_IntArray_Fixed   | .NET 6.0           | Int32[10]   |  8.0541 ns | 0.0021 ns | 0.0020 ns |  8.0534 ns |  8.0510 ns |  8.0577 ns |
| FuncPointers  | Empty_IntArray_Fixed   | .NET 8.0           | Int32[10]   |  7.5248 ns | 0.0014 ns | 0.0012 ns |  7.5246 ns |  7.5232 ns |  7.5274 ns |
| LibraryImport | Empty_IntArray_Fixed   | .NET 8.0           | Int32[1000] | 10.1206 ns | 0.0033 ns | 0.0029 ns | 10.1209 ns | 10.1137 ns | 10.1239 ns |
| LibraryImport | Empty_IntArray_Fixed   | .NET 8.0           | Int32[10]   |  7.8716 ns | 0.0069 ns | 0.0054 ns |  7.8681 ns |  7.8665 ns |  7.8795 ns |
| LibraryImport | Empty_IntArray_ByValue | .NET 8.0           | Int32[1000] |  7.8712 ns | 0.0047 ns | 0.0044 ns |  7.8691 ns |  7.8649 ns |  7.8796 ns |
| LibraryImport | Empty_IntArray_ByValue | .NET 8.0           | Int32[10]   |  7.8736 ns | 0.0014 ns | 0.0013 ns |  7.8736 ns |  7.8710 ns |  7.8754 ns |
| Managed       | Empty_IntArray         | .NET 6.0           | Int32[1000] |  0.6748 ns | 0.0013 ns | 0.0012 ns |  0.6749 ns |  0.6729 ns |  0.6770 ns |
| Managed       | Empty_IntArray         | .NET 8.0           | Int32[1000] |  0.6988 ns | 0.0010 ns | 0.0008 ns |  0.6989 ns |  0.6970 ns |  0.6998 ns |
| Managed       | Empty_IntArray         | .NET Framework 4.8 | Int32[1000] |  1.1002 ns | 0.0018 ns | 0.0015 ns |  1.1005 ns |  1.0970 ns |  1.1023 ns |
| Managed       | Empty_IntArray         | .NET 6.0           | Int32[10]   |  0.6724 ns | 0.0017 ns | 0.0013 ns |  0.6724 ns |  0.6705 ns |  0.6752 ns |
| Managed       | Empty_IntArray         | .NET 8.0           | Int32[10]   |  0.6978 ns | 0.0009 ns | 0.0007 ns |  0.6979 ns |  0.6959 ns |  0.6985 ns |
| Managed       | Empty_IntArray         | .NET Framework 4.8 | Int32[10]   |  1.0996 ns | 0.0012 ns | 0.0010 ns |  1.0998 ns |  1.0979 ns |  1.1012 ns |
