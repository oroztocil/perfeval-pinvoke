```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CGENOF : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CZJXKH : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-PQTRGW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=100  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method | Runtime            | Mean     | Error     | StdDev   | Median   | Min      | Max      | Allocated |
|---------------- |------- |------------------- |---------:|----------:|---------:|---------:|---------:|---------:|----------:|
| LibraryImportCS | Mixed  | .NET 8.0           | 3.547 ms | 1.1495 ms | 3.389 ms | 3.204 ms | 3.158 ms | 37.10 ms |     952 B |
| FuncPointersCS  | Mixed  | .NET 6.0           | 4.028 ms | 1.0125 ms | 2.985 ms | 3.727 ms | 3.685 ms | 33.58 ms |    1240 B |
| FuncPointersCS  | Mixed  | .NET 8.0           | 4.063 ms | 0.9805 ms | 2.891 ms | 3.770 ms | 3.708 ms | 32.68 ms |    1000 B |
| DllImportCS     | Mixed  | .NET 6.0           | 4.429 ms | 1.3850 ms | 4.084 ms | 4.016 ms | 3.980 ms | 44.86 ms |    1192 B |
| DllImportCS     | Mixed  | .NET 8.0           | 4.943 ms | 1.3475 ms | 3.973 ms | 4.545 ms | 4.420 ms | 44.27 ms |     952 B |
| DllImportCS     | Mixed  | .NET Framework 4.8 | 6.067 ms | 1.3863 ms | 4.087 ms | 5.654 ms | 5.595 ms | 46.53 ms |         - |
