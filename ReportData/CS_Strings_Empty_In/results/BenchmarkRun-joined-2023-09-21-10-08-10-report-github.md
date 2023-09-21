```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-YEWQVE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-GQLIHJ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-DKQSEW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    359.1 μs |    NA |    359.1 μs |    359.1 μs |    359.1 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    391.3 μs |    NA |    391.3 μs |    391.3 μs |    391.3 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    496.0 μs |    NA |    496.0 μs |    496.0 μs |    496.0 μs |         - |
| FuncPointersCS  | Empty_String | .NET 6.0           | 32,014.3 μs |    NA | 32,014.3 μs | 32,014.3 μs | 32,014.3 μs |     688 B |
| FuncPointersCS  | Empty_String | .NET 8.0           | 32,065.2 μs |    NA | 32,065.2 μs | 32,065.2 μs | 32,065.2 μs |     448 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 32,936.7 μs |    NA | 32,936.7 μs | 32,936.7 μs | 32,936.7 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 43,316.2 μs |    NA | 43,316.2 μs | 43,316.2 μs | 43,316.2 μs |         - |
| DllImportCS     | Empty_String | .NET 6.0           | 43,326.0 μs |    NA | 43,326.0 μs | 43,326.0 μs | 43,326.0 μs |     640 B |
| DllImportCS     | Empty_String | .NET 8.0           | 43,829.8 μs |    NA | 43,829.8 μs | 43,829.8 μs | 43,829.8 μs |     400 B |
