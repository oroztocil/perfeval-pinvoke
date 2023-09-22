```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-NRYWMF : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TOLOHF : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-LWOIVE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method | Runtime            | Mean     | Error | Median   | Min      | Max      | Allocated |
|---------------- |------- |------------------- |---------:|------:|---------:|---------:|---------:|----------:|
| FuncPointersCS  | Mixed  | .NET 8.0           | 33.12 ms |    NA | 33.12 ms | 33.12 ms | 33.12 ms |    1000 B |
| LibraryImportCS | Mixed  | .NET 8.0           | 33.56 ms |    NA | 33.56 ms | 33.56 ms | 33.56 ms |     952 B |
| FuncPointersCS  | Mixed  | .NET 6.0           | 33.64 ms |    NA | 33.64 ms | 33.64 ms | 33.64 ms |    1240 B |
| DllImportCS     | Mixed  | .NET 6.0           | 45.05 ms |    NA | 45.05 ms | 45.05 ms | 45.05 ms |    1192 B |
| DllImportCS     | Mixed  | .NET 8.0           | 45.96 ms |    NA | 45.96 ms | 45.96 ms | 45.96 ms |     952 B |
| DllImportCS     | Mixed  | .NET Framework 4.8 | 46.90 ms |    NA | 46.90 ms | 46.90 ms | 46.90 ms |         - |