```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-NRUXQZ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ORSHNP : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-AXUXXB : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method                 | Runtime            | input                | Mean       | Error     | StdDev    | Median     | Min        | Max        | Allocated |
|-------------- |----------------------- |------------------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|----------:|
| Managed       | SumIntsInStruct_Ref    | .NET 6.0           | PInvo(...)truct [46] |  0.6429 ns | 0.0022 ns | 0.0021 ns |  0.6435 ns |  0.6392 ns |  0.6458 ns |         - |
| Managed       | SumIntsInStruct_Ref    | .NET 8.0           | PInvo(...)truct [46] |  0.6963 ns | 0.0004 ns | 0.0004 ns |  0.6962 ns |  0.6958 ns |  0.6971 ns |         - |
| Managed       | SumIntsInStruct_Ref    | .NET Framework 4.8 | PInvo(...)truct [46] |  1.5791 ns | 0.0018 ns | 0.0017 ns |  1.5792 ns |  1.5739 ns |  1.5812 ns |         - |
| FuncPointers  | SumIntsInClass_Ref     | .NET 8.0           | PInvo(...)Class [45] |  8.5678 ns | 0.0017 ns | 0.0016 ns |  8.5677 ns |  8.5656 ns |  8.5709 ns |         - |
| DllImport     | SumIntsInStruct_Ref    | .NET 8.0           | PInvo(...)truct [46] |  9.5669 ns | 0.0074 ns | 0.0065 ns |  9.5645 ns |  9.5602 ns |  9.5807 ns |         - |
| FuncPointers  | SumIntsInStruct_Ref    | .NET 8.0           | PInvo(...)truct [46] |  9.5683 ns | 0.0024 ns | 0.0020 ns |  9.5676 ns |  9.5656 ns |  9.5718 ns |         - |
| FuncPointers  | SumIntsInStruct_Ref    | .NET 6.0           | PInvo(...)truct [46] |  9.6255 ns | 0.0017 ns | 0.0015 ns |  9.6251 ns |  9.6232 ns |  9.6289 ns |         - |
| DllImport     | SumIntsInStruct_Return | .NET 6.0           | PInvo(...)truct [46] |  9.6307 ns | 0.0032 ns | 0.0025 ns |  9.6299 ns |  9.6275 ns |  9.6364 ns |         - |
| DllImport     | SumIntsInStruct_Ref    | .NET 6.0           | PInvo(...)truct [46] |  9.6977 ns | 0.0031 ns | 0.0027 ns |  9.6968 ns |  9.6945 ns |  9.7035 ns |         - |
| FuncPointers  | SumIntsInStruct_Return | .NET 8.0           | PInvo(...)truct [46] | 10.0410 ns | 0.0035 ns | 0.0030 ns | 10.0404 ns | 10.0368 ns | 10.0479 ns |         - |
| DllImport     | SumIntsInStruct_Return | .NET 8.0           | PInvo(...)truct [46] | 10.5835 ns | 0.0328 ns | 0.0307 ns | 10.5823 ns | 10.5377 ns | 10.6352 ns |         - |
| LibraryImport | SumIntsInStruct_Return | .NET 8.0           | PInvo(...)truct [46] | 10.5859 ns | 0.0288 ns | 0.0269 ns | 10.5926 ns | 10.5347 ns | 10.6407 ns |         - |
| FuncPointers  | SumIntsInClass_Ref     | .NET 6.0           | PInvo(...)Class [45] | 10.8117 ns | 0.0014 ns | 0.0012 ns | 10.8115 ns | 10.8099 ns | 10.8144 ns |         - |
| DllImport     | SumIntsInClass_Ref     | .NET 6.0           | PInvo(...)Class [45] | 10.8181 ns | 0.0078 ns | 0.0073 ns | 10.8163 ns | 10.8111 ns | 10.8348 ns |         - |
| DllImport     | SumIntsInClass_Ref     | .NET 8.0           | PInvo(...)Class [45] | 10.8184 ns | 0.0102 ns | 0.0095 ns | 10.8119 ns | 10.8104 ns | 10.8362 ns |         - |
| LibraryImport | SumIntsInStruct_Ref    | .NET 8.0           | PInvo(...)truct [46] | 11.5357 ns | 0.0387 ns | 0.0362 ns | 11.5112 ns | 11.5067 ns | 11.5973 ns |         - |
| FuncPointers  | SumIntsInStruct_Return | .NET 6.0           | PInvo(...)truct [46] | 13.4379 ns | 0.0014 ns | 0.0013 ns | 13.4376 ns | 13.4358 ns | 13.4401 ns |         - |
| DllImport     | SumIntsInStruct_Ref    | .NET Framework 4.8 | PInvo(...)truct [46] | 15.6266 ns | 0.0355 ns | 0.0315 ns | 15.6200 ns | 15.5838 ns | 15.6902 ns |         - |
| DllImport     | SumIntsInClass_Ref     | .NET Framework 4.8 | PInvo(...)Class [45] | 15.8487 ns | 0.0035 ns | 0.0028 ns | 15.8476 ns | 15.8459 ns | 15.8549 ns |         - |
| DllImport     | SumIntsInStruct_Return | .NET Framework 4.8 | PInvo(...)truct [46] | 22.5400 ns | 0.0040 ns | 0.0036 ns | 22.5384 ns | 22.5357 ns | 22.5457 ns |         - |
