```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-WWEAEP : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-KTAPRV : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CXMWHH : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    361.3 μs |    NA |    361.3 μs |    361.3 μs |    361.3 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    422.5 μs |    NA |    422.5 μs |    422.5 μs |    422.5 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    490.6 μs |    NA |    490.6 μs |    490.6 μs |    490.6 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 30,923.0 μs |    NA | 30,923.0 μs | 30,923.0 μs | 30,923.0 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,556.5 μs |    NA | 31,556.5 μs | 31,556.5 μs | 31,556.5 μs |     688 B |
| DllImportCS     | Empty_String | .NET 6.0           | 41,566.3 μs |    NA | 41,566.3 μs | 41,566.3 μs | 41,566.3 μs |     640 B |
| DllImportCS     | Empty_String | .NET 8.0           | 42,013.3 μs |    NA | 42,013.3 μs | 42,013.3 μs | 42,013.3 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,801.9 μs |    NA | 42,801.9 μs | 42,801.9 μs | 42,801.9 μs |         - |
| LibraryImportCS | Empty_String | .NET 8.0           | 44,009.2 μs |    NA | 44,009.2 μs | 44,009.2 μs | 44,009.2 μs |     400 B |
