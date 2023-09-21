```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-KSGZJN : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ZNMLKR : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-NGOIBS : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method    | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        | Allocated |
|-------------- |---------- |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|----------:|
| Managed       | EmptyVoid | .NET 8.0           |  0.6981 ns | 0.0012 ns | 0.0011 ns |  0.6987 ns |  0.6964 ns |  0.7001 ns |         - |
| Managed       | EmptyVoid | .NET 6.0           |  0.7035 ns | 0.0018 ns | 0.0016 ns |  0.7028 ns |  0.7020 ns |  0.7065 ns |         - |
| Managed       | EmptyVoid | .NET Framework 4.8 |  1.0741 ns | 0.0079 ns | 0.0074 ns |  1.0696 ns |  1.0682 ns |  1.0871 ns |         - |
| FuncPointers  | EmptyVoid | .NET 8.0           |  6.4936 ns | 0.0041 ns | 0.0032 ns |  6.4921 ns |  6.4915 ns |  6.4993 ns |         - |
| FuncPointers  | EmptyVoid | .NET 6.0           |  6.6525 ns | 0.0024 ns | 0.0020 ns |  6.6513 ns |  6.6506 ns |  6.6563 ns |         - |
| DllImport     | EmptyVoid | .NET 8.0           |  9.0694 ns | 0.0019 ns | 0.0016 ns |  9.0693 ns |  9.0674 ns |  9.0723 ns |         - |
| LibraryImport | EmptyVoid | .NET 8.0           |  9.0712 ns | 0.0059 ns | 0.0056 ns |  9.0688 ns |  9.0651 ns |  9.0839 ns |         - |
| DllImport     | EmptyVoid | .NET 6.0           |  9.1901 ns | 0.0067 ns | 0.0056 ns |  9.1912 ns |  9.1731 ns |  9.1945 ns |         - |
| DllImport     | EmptyVoid | .NET Framework 4.8 | 14.3429 ns | 0.0474 ns | 0.0444 ns | 14.3181 ns | 14.3096 ns | 14.4241 ns |         - |
