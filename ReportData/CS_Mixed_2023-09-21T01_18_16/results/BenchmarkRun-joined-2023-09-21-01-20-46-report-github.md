```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-XPYLXC : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-HXCHKU : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-EGRASW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

InvocationCount=1  IterationCount=1  IterationTime=250.0000 ms  
LaunchCount=100  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method | Runtime            | Mean     | Error    | StdDev   | Median   | Min      | Max      |
|---------------- |------- |------------------- |---------:|---------:|---------:|---------:|---------:|---------:|
| DllImportCS     | Mixed  | .NET 6.0           | 4.508 ms | 1.448 ms | 4.270 ms | 4.076 ms | 4.014 ms | 46.78 ms |
| DllImportCS     | Mixed  | .NET 8.0           | 5.068 ms | 1.374 ms | 4.052 ms | 4.666 ms | 4.543 ms | 45.18 ms |
| DllImportCS     | Mixed  | .NET Framework 4.8 | 6.196 ms | 1.430 ms | 4.215 ms | 5.772 ms | 5.674 ms | 47.92 ms |
| FuncPointersCS  | Mixed  | .NET 6.0           | 4.093 ms | 1.015 ms | 2.992 ms | 3.786 ms | 3.745 ms | 33.71 ms |
| FuncPointersCS  | Mixed  | .NET 8.0           | 4.172 ms | 1.100 ms | 3.242 ms | 3.848 ms | 3.771 ms | 36.27 ms |
| LibraryImportCS | Mixed  | .NET 8.0           | 3.667 ms | 1.080 ms | 3.183 ms | 3.346 ms | 3.257 ms | 35.18 ms |
