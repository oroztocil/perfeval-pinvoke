```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-DJQJES : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-MCKLHT : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-BXHGQK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=300.0000 ms  WarmupCount=5  

```
| Type          | Method               | Runtime            | array       | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |--------------------- |------------------- |------------ |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | Empty_IntArray       | .NET 6.0           | Int32[1000] |  8.8045 ns | 0.0845 ns | 0.0659 ns |  8.7791 ns |  8.7657 ns |  9.0061 ns |
| DllImport     | Empty_IntArray_Fixed | .NET 6.0           | Int32[1000] |  8.9050 ns | 0.1430 ns | 0.1338 ns |  8.8624 ns |  8.7575 ns |  9.1348 ns |
| DllImport     | Empty_IntArray       | .NET 8.0           | Int32[1000] |  8.3829 ns | 0.0128 ns | 0.0120 ns |  8.3767 ns |  8.3727 ns |  8.4075 ns |
| DllImport     | Empty_IntArray_Fixed | .NET 8.0           | Int32[1000] |  7.9479 ns | 0.0125 ns | 0.0104 ns |  7.9435 ns |  7.9393 ns |  7.9739 ns |
| DllImport     | Empty_IntArray       | .NET Framework 4.8 | Int32[1000] | 13.8150 ns | 0.0741 ns | 0.0579 ns | 13.7947 ns | 13.7544 ns | 13.9661 ns |
| DllImport     | Empty_IntArray_Fixed | .NET Framework 4.8 | Int32[1000] | 15.7889 ns | 0.3464 ns | 0.7959 ns | 15.3966 ns | 15.2571 ns | 18.2220 ns |
| DllImport     | Empty_IntArray       | .NET 6.0           | Int32[10]   |  8.7654 ns | 0.0120 ns | 0.0094 ns |  8.7622 ns |  8.7564 ns |  8.7867 ns |
| DllImport     | Empty_IntArray_Fixed | .NET 6.0           | Int32[10]   |  8.9432 ns | 0.0822 ns | 0.0729 ns |  8.9258 ns |  8.8777 ns |  9.1324 ns |
| DllImport     | Empty_IntArray       | .NET 8.0           | Int32[10]   |  8.3847 ns | 0.0985 ns | 0.0874 ns |  8.3642 ns |  8.2801 ns |  8.5295 ns |
| DllImport     | Empty_IntArray_Fixed | .NET 8.0           | Int32[10]   |  8.2374 ns | 0.1672 ns | 0.1564 ns |  8.2039 ns |  8.0588 ns |  8.5152 ns |
| DllImport     | Empty_IntArray       | .NET Framework 4.8 | Int32[10]   | 13.6029 ns | 0.1175 ns | 0.1099 ns | 13.5877 ns | 13.4554 ns | 13.8199 ns |
| DllImport     | Empty_IntArray_Fixed | .NET Framework 4.8 | Int32[10]   | 14.8210 ns | 0.1664 ns | 0.1475 ns | 14.7647 ns | 14.6777 ns | 15.1687 ns |
| FuncPointers  | Empty_IntArray       | .NET 6.0           | Int32[1000] | 12.0407 ns | 0.1304 ns | 0.1018 ns | 12.0415 ns | 11.9135 ns | 12.2276 ns |
| FuncPointers  | Empty_IntArray       | .NET 8.0           | Int32[1000] |  9.9280 ns | 0.1546 ns | 0.1587 ns |  9.8746 ns |  9.7787 ns | 10.2249 ns |
| FuncPointers  | Empty_IntArray       | .NET 6.0           | Int32[10]   |  8.2448 ns | 0.1337 ns | 0.1186 ns |  8.1989 ns |  8.1103 ns |  8.4851 ns |
| FuncPointers  | Empty_IntArray       | .NET 8.0           | Int32[10]   |  7.6625 ns | 0.1367 ns | 0.1278 ns |  7.6178 ns |  7.5361 ns |  7.9065 ns |
| LibraryImport | Empty_IntArray       | .NET 8.0           | Int32[1000] | 10.1801 ns | 0.0534 ns | 0.0500 ns | 10.1704 ns | 10.1246 ns | 10.2805 ns |
| LibraryImport | Empty_IntArray_Fixed | .NET 8.0           | Int32[1000] |  7.8937 ns | 0.0116 ns | 0.0097 ns |  7.8933 ns |  7.8794 ns |  7.9100 ns |
| LibraryImport | Empty_IntArray       | .NET 8.0           | Int32[10]   |  7.9498 ns | 0.0867 ns | 0.0811 ns |  7.9082 ns |  7.8782 ns |  8.1062 ns |
| LibraryImport | Empty_IntArray_Fixed | .NET 8.0           | Int32[10]   |  8.0050 ns | 0.1689 ns | 0.1580 ns |  7.9335 ns |  7.8858 ns |  8.3647 ns |
| Managed       | Empty_IntArray       | .NET 6.0           | Int32[1000] |  0.7240 ns | 0.0519 ns | 0.0485 ns |  0.6963 ns |  0.6866 ns |  0.8322 ns |
| Managed       | Empty_IntArray       | .NET 8.0           | Int32[1000] |  0.6972 ns | 0.0026 ns | 0.0022 ns |  0.6963 ns |  0.6951 ns |  0.7024 ns |
| Managed       | Empty_IntArray       | .NET Framework 4.8 | Int32[1000] |  1.1193 ns | 0.0089 ns | 0.0074 ns |  1.1170 ns |  1.1132 ns |  1.1376 ns |
| Managed       | Empty_IntArray       | .NET 6.0           | Int32[10]   |  0.6928 ns | 0.0079 ns | 0.0062 ns |  0.6911 ns |  0.6835 ns |  0.7033 ns |
| Managed       | Empty_IntArray       | .NET 8.0           | Int32[10]   |  0.7031 ns | 0.0050 ns | 0.0041 ns |  0.7009 ns |  0.6990 ns |  0.7109 ns |
| Managed       | Empty_IntArray       | .NET Framework 4.8 | Int32[10]   |  1.1221 ns | 0.0084 ns | 0.0066 ns |  1.1200 ns |  1.1163 ns |  1.1373 ns |
