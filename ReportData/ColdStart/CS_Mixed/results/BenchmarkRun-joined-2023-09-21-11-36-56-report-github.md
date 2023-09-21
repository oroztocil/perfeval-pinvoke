```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-XXFLBJ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-XELTBZ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-STRVXN : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method | Runtime            | Mean     | Error | Median   | Min      | Max      | Allocated |
|---------------- |------- |------------------- |---------:|------:|---------:|---------:|---------:|----------:|
| FuncPointersCS  | Mixed  | .NET 8.0           | 33.41 ms |    NA | 33.41 ms | 33.41 ms | 33.41 ms |    1000 B |
| FuncPointersCS  | Mixed  | .NET 6.0           | 34.38 ms |    NA | 34.38 ms | 34.38 ms | 34.38 ms |    1240 B |
| LibraryImportCS | Mixed  | .NET 8.0           | 34.42 ms |    NA | 34.42 ms | 34.42 ms | 34.42 ms |     952 B |
| DllImportCS     | Mixed  | .NET 6.0           | 46.74 ms |    NA | 46.74 ms | 46.74 ms | 46.74 ms |    1192 B |
| DllImportCS     | Mixed  | .NET 8.0           | 46.77 ms |    NA | 46.77 ms | 46.77 ms | 46.77 ms |     952 B |
| DllImportCS     | Mixed  | .NET Framework 4.8 | 47.47 ms |    NA | 47.47 ms | 47.47 ms | 47.47 ms |         - |
