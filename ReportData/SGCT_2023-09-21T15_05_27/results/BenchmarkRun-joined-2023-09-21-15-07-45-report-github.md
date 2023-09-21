```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ZRWKKM : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-FSXSCH : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method         | Runtime  | Mean     | Error     | StdDev    | Median   | Min      | Max      | Allocated |
|-------------- |--------------- |--------- |---------:|----------:|----------:|---------:|---------:|---------:|----------:|
| LibraryImport | EmptyVoid_SGCT | .NET 8.0 | 1.391 ns | 0.0018 ns | 0.0017 ns | 1.391 ns | 1.388 ns | 1.393 ns |         - |
| FuncPointers  | EmptyVoid_SGCT | .NET 6.0 | 3.487 ns | 0.0006 ns | 0.0004 ns | 3.487 ns | 3.487 ns | 3.488 ns |         - |
| FuncPointers  | EmptyVoid_SGCT | .NET 8.0 | 4.184 ns | 0.0002 ns | 0.0002 ns | 4.184 ns | 4.184 ns | 4.185 ns |         - |
| FuncPointers  | EmptyVoid      | .NET 8.0 | 6.496 ns | 0.0011 ns | 0.0010 ns | 6.496 ns | 6.494 ns | 6.498 ns |         - |
| FuncPointers  | EmptyVoid      | .NET 6.0 | 6.659 ns | 0.0007 ns | 0.0006 ns | 6.659 ns | 6.658 ns | 6.659 ns |         - |
| LibraryImport | EmptyVoid      | .NET 8.0 | 6.849 ns | 0.0020 ns | 0.0018 ns | 6.849 ns | 6.848 ns | 6.853 ns |         - |
