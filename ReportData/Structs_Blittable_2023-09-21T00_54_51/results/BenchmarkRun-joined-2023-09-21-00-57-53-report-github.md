```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-HEYXUX : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-RZNOGP : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-OGDWTZ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method                 | Runtime            | input                | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |----------------------- |------------------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | SumIntsInClass_Ref     | .NET 6.0           | PInvo(...)Class [45] | 10.8217 ns | 0.0106 ns | 0.0082 ns | 10.8221 ns | 10.8110 ns | 10.8346 ns |
| DllImport     | SumIntsInClass_Ref     | .NET 8.0           | PInvo(...)Class [45] | 10.8159 ns | 0.0063 ns | 0.0056 ns | 10.8177 ns | 10.8085 ns | 10.8251 ns |
| DllImport     | SumIntsInClass_Ref     | .NET Framework 4.8 | PInvo(...)Class [45] | 16.9359 ns | 0.0108 ns | 0.0101 ns | 16.9350 ns | 16.9230 ns | 16.9595 ns |
| DllImport     | SumIntsInStruct_Ref    | .NET 6.0           | PInvo(...)truct [46] |  9.6989 ns | 0.0056 ns | 0.0049 ns |  9.6971 ns |  9.6944 ns |  9.7082 ns |
| DllImport     | SumIntsInStruct_Return | .NET 6.0           | PInvo(...)truct [46] |  9.6156 ns | 0.0029 ns | 0.0023 ns |  9.6153 ns |  9.6118 ns |  9.6203 ns |
| DllImport     | SumIntsInStruct_Ref    | .NET 8.0           | PInvo(...)truct [46] |  9.7143 ns | 0.0069 ns | 0.0062 ns |  9.7164 ns |  9.7019 ns |  9.7220 ns |
| DllImport     | SumIntsInStruct_Return | .NET 8.0           | PInvo(...)truct [46] | 10.7720 ns | 0.0628 ns | 0.0588 ns | 10.7896 ns | 10.6705 ns | 10.8814 ns |
| DllImport     | SumIntsInStruct_Ref    | .NET Framework 4.8 | PInvo(...)truct [46] | 14.5105 ns | 0.0138 ns | 0.0115 ns | 14.5140 ns | 14.4816 ns | 14.5273 ns |
| DllImport     | SumIntsInStruct_Return | .NET Framework 4.8 | PInvo(...)truct [46] | 22.5572 ns | 0.0038 ns | 0.0036 ns | 22.5560 ns | 22.5528 ns | 22.5645 ns |
| FuncPointers  | SumIntsInClass_Ref     | .NET 6.0           | PInvo(...)Class [45] | 10.8189 ns | 0.0026 ns | 0.0023 ns | 10.8187 ns | 10.8164 ns | 10.8245 ns |
| FuncPointers  | SumIntsInClass_Ref     | .NET 8.0           | PInvo(...)Class [45] | 10.8179 ns | 0.0032 ns | 0.0025 ns | 10.8185 ns | 10.8119 ns | 10.8202 ns |
| FuncPointers  | SumIntsInStruct_Ref    | .NET 6.0           | PInvo(...)truct [46] |  9.6235 ns | 0.0009 ns | 0.0007 ns |  9.6233 ns |  9.6221 ns |  9.6249 ns |
| FuncPointers  | SumIntsInStruct_Return | .NET 6.0           | PInvo(...)truct [46] | 13.4688 ns | 0.0068 ns | 0.0056 ns | 13.4679 ns | 13.4618 ns | 13.4765 ns |
| FuncPointers  | SumIntsInStruct_Ref    | .NET 8.0           | PInvo(...)truct [46] |  9.5685 ns | 0.0042 ns | 0.0035 ns |  9.5674 ns |  9.5655 ns |  9.5771 ns |
| FuncPointers  | SumIntsInStruct_Return | .NET 8.0           | PInvo(...)truct [46] | 10.0632 ns | 0.0028 ns | 0.0023 ns | 10.0638 ns | 10.0575 ns | 10.0655 ns |
| LibraryImport | SumIntsInStruct_Ref    | .NET 8.0           | PInvo(...)truct [46] | 11.5157 ns | 0.0040 ns | 0.0035 ns | 11.5158 ns | 11.5075 ns | 11.5201 ns |
| LibraryImport | SumIntsInStruct_Return | .NET 8.0           | PInvo(...)truct [46] | 10.6811 ns | 0.1535 ns | 0.1435 ns | 10.6199 ns | 10.5388 ns | 10.9722 ns |
| Managed       | SumIntsInStruct_Ref    | .NET 6.0           | PInvo(...)truct [46] |  0.6638 ns | 0.0009 ns | 0.0008 ns |  0.6642 ns |  0.6618 ns |  0.6645 ns |
| Managed       | SumIntsInStruct_Ref    | .NET 8.0           | PInvo(...)truct [46] |  0.6963 ns | 0.0004 ns | 0.0003 ns |  0.6963 ns |  0.6957 ns |  0.6967 ns |
| Managed       | SumIntsInStruct_Ref    | .NET Framework 4.8 | PInvo(...)truct [46] |  1.6622 ns | 0.0009 ns | 0.0009 ns |  1.6621 ns |  1.6607 ns |  1.6635 ns |
