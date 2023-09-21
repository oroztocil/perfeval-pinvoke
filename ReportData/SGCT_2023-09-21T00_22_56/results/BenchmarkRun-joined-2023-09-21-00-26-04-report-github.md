```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-YVMHFI : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ESROTZ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method                     | Runtime  | input       | Mean      | Error     | StdDev    | Median    | Min       | Max       |
|-------------- |--------------------------- |--------- |------------ |----------:|----------:|----------:|----------:|----------:|----------:|
| FuncPointers  | Empty_IntArray_Fixed       | .NET 6.0 | Int32[1000] | 10.128 ns | 0.0032 ns | 0.0027 ns | 10.129 ns | 10.123 ns | 10.132 ns |
| FuncPointers  | Empty_IntArray_Fixed       | .NET 8.0 | Int32[1000] |  9.788 ns | 0.0255 ns | 0.0213 ns |  9.777 ns |  9.772 ns |  9.840 ns |
| FuncPointers  | Empty_IntArray_Fixed       | .NET 6.0 | Int32[10]   |  8.058 ns | 0.0056 ns | 0.0047 ns |  8.057 ns |  8.054 ns |  8.070 ns |
| FuncPointers  | Empty_IntArray_Fixed       | .NET 8.0 | Int32[10]   |  8.332 ns | 0.0075 ns | 0.0070 ns |  8.330 ns |  8.323 ns |  8.345 ns |
| FuncPointers  | Empty_VoidSGCT             | .NET 6.0 | ?           |  1.404 ns | 0.0012 ns | 0.0010 ns |  1.404 ns |  1.403 ns |  1.406 ns |
| FuncPointers  | Empty_VoidSGCT             | .NET 8.0 | ?           |  1.387 ns | 0.0019 ns | 0.0016 ns |  1.387 ns |  1.385 ns |  1.390 ns |
| FuncPointers  | Empty_IntArray_FixedSGCT   | .NET 6.0 | Int32[1000] |  3.151 ns | 0.0457 ns | 0.0405 ns |  3.127 ns |  3.123 ns |  3.227 ns |
| FuncPointers  | Empty_IntArray_FixedSGCT   | .NET 8.0 | Int32[1000] |  2.429 ns | 0.0026 ns | 0.0022 ns |  2.428 ns |  2.427 ns |  2.434 ns |
| FuncPointers  | Empty_IntArray_FixedSGCT   | .NET 6.0 | Int32[10]   |  5.180 ns | 0.0007 ns | 0.0007 ns |  5.180 ns |  5.179 ns |  5.181 ns |
| FuncPointers  | Empty_IntArray_FixedSGCT   | .NET 8.0 | Int32[10]   |  4.834 ns | 0.0020 ns | 0.0017 ns |  4.833 ns |  4.831 ns |  4.837 ns |
| LibraryImport | Empty_IntArray_ByValue     | .NET 8.0 | Int32[1000] | 10.515 ns | 0.0074 ns | 0.0058 ns | 10.514 ns | 10.510 ns | 10.529 ns |
| LibraryImport | Empty_IntArray_ByValue     | .NET 8.0 | Int32[10]   |  7.802 ns | 0.0143 ns | 0.0119 ns |  7.796 ns |  7.789 ns |  7.830 ns |
| LibraryImport | Empty_VoidSGCT             | .NET 8.0 | ?           |  1.384 ns | 0.0262 ns | 0.0232 ns |  1.378 ns |  1.363 ns |  1.437 ns |
| LibraryImport | Empty_IntArray_ByValueSGCT | .NET 8.0 | Int32[1000] |  2.962 ns | 0.1686 ns | 0.4972 ns |  2.967 ns |  2.422 ns |  4.208 ns |
| LibraryImport | Empty_IntArray_ByValueSGCT | .NET 8.0 | Int32[10]   |  2.423 ns | 0.0003 ns | 0.0002 ns |  2.423 ns |  2.422 ns |  2.423 ns |
| LibraryImport | Empty_String               | .NET 8.0 | ?           | 28.940 ns | 0.3207 ns | 0.2843 ns | 28.801 ns | 28.752 ns | 29.524 ns |
| LibraryImport | Empty_Void                 | .NET 8.0 | ?           |  6.779 ns | 0.0029 ns | 0.0025 ns |  6.779 ns |  6.776 ns |  6.784 ns |