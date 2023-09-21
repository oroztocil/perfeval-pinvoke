```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-IYMAFS : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ISTRHI : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-RMLFDS : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method | Runtime            | Mean     | Error | Median   | Min      | Max      | Allocated |
|---------------- |------- |------------------- |---------:|------:|---------:|---------:|---------:|----------:|
| DllImportCS     | Mixed  | .NET 6.0           | 30.72 ms |    NA | 30.72 ms | 30.72 ms | 30.72 ms |    1192 B |
| FuncPointersCS  | Mixed  | .NET 8.0           | 33.29 ms |    NA | 33.29 ms | 33.29 ms | 33.29 ms |    1000 B |
| FuncPointersCS  | Mixed  | .NET 6.0           | 34.32 ms |    NA | 34.32 ms | 34.32 ms | 34.32 ms |    1240 B |
| LibraryImportCS | Mixed  | .NET 8.0           | 40.06 ms |    NA | 40.06 ms | 40.06 ms | 40.06 ms |     952 B |
| DllImportCS     | Mixed  | .NET 8.0           | 46.52 ms |    NA | 46.52 ms | 46.52 ms | 46.52 ms |     952 B |
| DllImportCS     | Mixed  | .NET Framework 4.8 | 47.66 ms |    NA | 47.66 ms | 47.66 ms | 47.66 ms |         - |
