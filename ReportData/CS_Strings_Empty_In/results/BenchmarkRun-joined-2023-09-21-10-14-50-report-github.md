```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ADPYJI : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ZIDSER : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TNIUON : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    357.3 μs |    NA |    357.3 μs |    357.3 μs |    357.3 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    411.8 μs |    NA |    411.8 μs |    411.8 μs |    411.8 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    492.8 μs |    NA |    492.8 μs |    492.8 μs |    492.8 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 32,114.7 μs |    NA | 32,114.7 μs | 32,114.7 μs | 32,114.7 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 32,322.6 μs |    NA | 32,322.6 μs | 32,322.6 μs | 32,322.6 μs |     688 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 32,721.2 μs |    NA | 32,721.2 μs | 32,721.2 μs | 32,721.2 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,500.4 μs |    NA | 42,500.4 μs | 42,500.4 μs | 42,500.4 μs |         - |
| DllImportCS     | Empty_String | .NET 6.0           | 43,258.4 μs |    NA | 43,258.4 μs | 43,258.4 μs | 43,258.4 μs |     640 B |
| DllImportCS     | Empty_String | .NET 8.0           | 43,528.6 μs |    NA | 43,528.6 μs | 43,528.6 μs | 43,528.6 μs |     400 B |
