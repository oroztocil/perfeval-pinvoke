```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-SZSVZK : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-UVOKGP : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JLOBCW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    371.3 μs |    NA |    371.3 μs |    371.3 μs |    371.3 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    374.7 μs |    NA |    374.7 μs |    374.7 μs |    374.7 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    486.5 μs |    NA |    486.5 μs |    486.5 μs |    486.5 μs |         - |
| FuncPointersCS  | Empty_String | .NET 6.0           | 30,911.3 μs |    NA | 30,911.3 μs | 30,911.3 μs | 30,911.3 μs |     688 B |
| FuncPointersCS  | Empty_String | .NET 8.0           | 32,176.8 μs |    NA | 32,176.8 μs | 32,176.8 μs | 32,176.8 μs |     448 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 32,692.5 μs |    NA | 32,692.5 μs | 32,692.5 μs | 32,692.5 μs |     400 B |
| DllImportCS     | Empty_String | .NET 8.0           | 43,190.2 μs |    NA | 43,190.2 μs | 43,190.2 μs | 43,190.2 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 43,196.1 μs |    NA | 43,196.1 μs | 43,196.1 μs | 43,196.1 μs |     640 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 43,621.8 μs |    NA | 43,621.8 μs | 43,621.8 μs | 43,621.8 μs |         - |
