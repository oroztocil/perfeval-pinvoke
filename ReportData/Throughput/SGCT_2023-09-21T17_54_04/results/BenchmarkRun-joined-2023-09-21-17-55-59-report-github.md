```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-GPOJUT : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-TTIPIB : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method         | Runtime  | Mean     | Error     | StdDev    | Median   | Min      | Max      | Allocated |
|-------------- |--------------- |--------- |---------:|----------:|----------:|---------:|---------:|---------:|----------:|
| FuncPointers  | EmptyVoid_SGCT | .NET 6.0 | 3.488 ns | 0.0010 ns | 0.0009 ns | 3.488 ns | 3.487 ns | 3.489 ns |         - |
| FuncPointers  | EmptyVoid_SGCT | .NET 8.0 | 4.185 ns | 0.0008 ns | 0.0007 ns | 4.185 ns | 4.184 ns | 4.186 ns |         - |
| LibraryImport | EmptyVoid_SGCT | .NET 8.0 | 4.540 ns | 0.0100 ns | 0.0094 ns | 4.534 ns | 4.533 ns | 4.553 ns |         - |
| FuncPointers  | EmptyVoid      | .NET 8.0 | 6.520 ns | 0.0431 ns | 0.0403 ns | 6.495 ns | 6.493 ns | 6.588 ns |         - |
| FuncPointers  | EmptyVoid      | .NET 6.0 | 6.656 ns | 0.0020 ns | 0.0015 ns | 6.655 ns | 6.655 ns | 6.659 ns |         - |
| LibraryImport | EmptyVoid      | .NET 8.0 | 6.876 ns | 0.0437 ns | 0.0409 ns | 6.845 ns | 6.843 ns | 6.928 ns |         - |
