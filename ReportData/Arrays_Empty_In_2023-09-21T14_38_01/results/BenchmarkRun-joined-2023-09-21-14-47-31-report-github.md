```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-HSMEJT : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ZHWLJE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ORRZBA : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method                 | Runtime            | input       | Mean       | Error     | StdDev    | Median     | Min        | Max        | Allocated |
|-------------- |----------------------- |------------------- |------------ |-----------:|----------:|----------:|-----------:|-----------:|-----------:|----------:|
| Managed       | EmptyIntArrayManaged   | .NET 8.0           | Int32[1000] |  0.6976 ns | 0.0003 ns | 0.0003 ns |  0.6976 ns |  0.6972 ns |  0.6982 ns |         - |
| Managed       | EmptyIntArrayManaged   | .NET 8.0           | Int32[10]   |  0.6977 ns | 0.0004 ns | 0.0004 ns |  0.6975 ns |  0.6973 ns |  0.6984 ns |         - |
| Managed       | EmptyIntArrayManaged   | .NET 6.0           | Int32[1000] |  1.0475 ns | 0.0006 ns | 0.0005 ns |  1.0472 ns |  1.0468 ns |  1.0483 ns |         - |
| Managed       | EmptyIntArrayManaged   | .NET 6.0           | Int32[10]   |  1.0489 ns | 0.0011 ns | 0.0010 ns |  1.0485 ns |  1.0477 ns |  1.0503 ns |         - |
| Managed       | EmptyIntArrayManaged   | .NET Framework 4.8 | Int32[1000] |  1.3345 ns | 0.0012 ns | 0.0011 ns |  1.3343 ns |  1.3331 ns |  1.3368 ns |         - |
| Managed       | EmptyIntArrayManaged   | .NET Framework 4.8 | Int32[10]   |  1.3350 ns | 0.0006 ns | 0.0005 ns |  1.3350 ns |  1.3340 ns |  1.3357 ns |         - |
| FuncPointers  | Empty_IntArray_Fixed   | .NET 8.0           | Int32[10]   |  7.5328 ns | 0.0110 ns | 0.0103 ns |  7.5266 ns |  7.5246 ns |  7.5503 ns |         - |
| DllImport     | Empty_IntArray_Fixed   | .NET 8.0           | Int32[1000] |  7.8698 ns | 0.0026 ns | 0.0021 ns |  7.8690 ns |  7.8675 ns |  7.8737 ns |         - |
| DllImport     | Empty_IntArray_Fixed   | .NET 8.0           | Int32[10]   |  7.8718 ns | 0.0056 ns | 0.0050 ns |  7.8700 ns |  7.8674 ns |  7.8835 ns |         - |
| LibraryImport | Empty_IntArray_ByValue | .NET 8.0           | Int32[10]   |  7.8775 ns | 0.0024 ns | 0.0020 ns |  7.8773 ns |  7.8755 ns |  7.8828 ns |         - |
| LibraryImport | Empty_IntArray_ByValue | .NET 8.0           | Int32[1000] |  7.8786 ns | 0.0117 ns | 0.0103 ns |  7.8759 ns |  7.8680 ns |  7.8960 ns |         - |
| LibraryImport | Empty_IntArray_Fixed   | .NET 8.0           | Int32[10]   |  7.8877 ns | 0.0268 ns | 0.0251 ns |  7.8715 ns |  7.8680 ns |  7.9292 ns |         - |
| LibraryImport | Empty_IntArray_Fixed   | .NET 8.0           | Int32[1000] |  7.9767 ns | 0.0273 ns | 0.0255 ns |  7.9735 ns |  7.9324 ns |  8.0179 ns |         - |
| DllImport     | Empty_IntArray_ByValue | .NET 8.0           | Int32[10]   |  8.2783 ns | 0.0061 ns | 0.0057 ns |  8.2787 ns |  8.2688 ns |  8.2873 ns |         - |
| FuncPointers  | Empty_IntArray_Fixed   | .NET 6.0           | Int32[10]   |  8.4275 ns | 0.0232 ns | 0.0205 ns |  8.4167 ns |  8.4128 ns |  8.4833 ns |         - |
| DllImport     | Empty_IntArray_Fixed   | .NET 6.0           | Int32[1000] |  8.4631 ns | 0.0031 ns | 0.0024 ns |  8.4637 ns |  8.4589 ns |  8.4677 ns |         - |
| DllImport     | Empty_IntArray_Fixed   | .NET 6.0           | Int32[10]   |  8.4913 ns | 0.0104 ns | 0.0087 ns |  8.4905 ns |  8.4718 ns |  8.5064 ns |         - |
| DllImport     | Empty_IntArray_ByValue | .NET 6.0           | Int32[10]   |  8.7494 ns | 0.0046 ns | 0.0036 ns |  8.7507 ns |  8.7429 ns |  8.7523 ns |         - |
| FuncPointers  | Empty_IntArray_Fixed   | .NET 8.0           | Int32[1000] |  9.7723 ns | 0.0083 ns | 0.0074 ns |  9.7708 ns |  9.7641 ns |  9.7864 ns |         - |
| FuncPointers  | Empty_IntArray_Fixed   | .NET 6.0           | Int32[1000] | 10.1497 ns | 0.0104 ns | 0.0097 ns | 10.1526 ns | 10.1347 ns | 10.1648 ns |         - |
| DllImport     | Empty_IntArray_ByValue | .NET 8.0           | Int32[1000] | 10.4641 ns | 0.0031 ns | 0.0028 ns | 10.4629 ns | 10.4613 ns | 10.4712 ns |         - |
| DllImport     | Empty_IntArray_ByValue | .NET 6.0           | Int32[1000] | 10.8215 ns | 0.0072 ns | 0.0060 ns | 10.8205 ns | 10.8118 ns | 10.8318 ns |         - |
| DllImport     | Empty_IntArray_ByValue | .NET Framework 4.8 | Int32[10]   | 13.3356 ns | 0.0062 ns | 0.0052 ns | 13.3344 ns | 13.3308 ns | 13.3498 ns |         - |
| DllImport     | Empty_IntArray_Fixed   | .NET Framework 4.8 | Int32[1000] | 14.6598 ns | 0.0270 ns | 0.0239 ns | 14.6528 ns | 14.6401 ns | 14.7137 ns |         - |
| DllImport     | Empty_IntArray_Fixed   | .NET Framework 4.8 | Int32[10]   | 14.8242 ns | 0.0222 ns | 0.0197 ns | 14.8164 ns | 14.8075 ns | 14.8681 ns |         - |
| DllImport     | Empty_IntArray_ByValue | .NET Framework 4.8 | Int32[1000] | 15.4214 ns | 0.0316 ns | 0.0295 ns | 15.4271 ns | 15.3699 ns | 15.4646 ns |         - |