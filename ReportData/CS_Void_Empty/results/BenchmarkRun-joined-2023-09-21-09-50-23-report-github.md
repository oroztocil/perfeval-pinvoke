```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UDTLEI : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-YYXWJP : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UEEPRN : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    277.5 μs |    NA |    277.5 μs |    277.5 μs |    277.5 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    289.8 μs |    NA |    289.8 μs |    289.8 μs |    289.8 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    346.7 μs |    NA |    346.7 μs |    346.7 μs |    346.7 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,848.2 μs |    NA | 31,848.2 μs | 31,848.2 μs | 31,848.2 μs |     640 B |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 32,025.6 μs |    NA | 32,025.6 μs | 32,025.6 μs | 32,025.6 μs |     400 B |
| DllImportCS     | Empty_Void | .NET 6.0           | 41,081.1 μs |    NA | 41,081.1 μs | 41,081.1 μs | 41,081.1 μs |     640 B |
| DllImportCS     | Empty_Void | .NET 8.0           | 41,261.3 μs |    NA | 41,261.3 μs | 41,261.3 μs | 41,261.3 μs |     400 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 42,387.0 μs |    NA | 42,387.0 μs | 42,387.0 μs | 42,387.0 μs |         - |
| LibraryImportCS | Empty_Void | .NET 8.0           | 44,698.9 μs |    NA | 44,698.9 μs | 44,698.9 μs | 44,698.9 μs |     400 B |
