```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JCCRQY : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-AZSKIE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-TBGPNZ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method | Runtime            | Mean     | Error | Median   | Min      | Max      | Allocated |
|---------------- |------- |------------------- |---------:|------:|---------:|---------:|---------:|----------:|
| FuncPointersCS  | Mixed  | .NET 8.0           | 33.46 ms |    NA | 33.46 ms | 33.46 ms | 33.46 ms |    1000 B |
| FuncPointersCS  | Mixed  | .NET 6.0           | 33.48 ms |    NA | 33.48 ms | 33.48 ms | 33.48 ms |    1240 B |
| LibraryImportCS | Mixed  | .NET 8.0           | 39.63 ms |    NA | 39.63 ms | 39.63 ms | 39.63 ms |     952 B |
| DllImportCS     | Mixed  | .NET 6.0           | 45.20 ms |    NA | 45.20 ms | 45.20 ms | 45.20 ms |    1192 B |
| DllImportCS     | Mixed  | .NET 8.0           | 45.26 ms |    NA | 45.26 ms | 45.26 ms | 45.26 ms |     952 B |
| DllImportCS     | Mixed  | .NET Framework 4.8 | 46.60 ms |    NA | 46.60 ms | 46.60 ms | 46.60 ms |         - |
