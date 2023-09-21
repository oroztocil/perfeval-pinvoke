```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ATOTKJ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-FTUIVZ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-SLCGEQ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    454.1 μs |    NA |    454.1 μs |    454.1 μs |    454.1 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    513.6 μs |    NA |    513.6 μs |    513.6 μs |    513.6 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    584.6 μs |    NA |    584.6 μs |    584.6 μs |    584.6 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 31,000.9 μs |    NA | 31,000.9 μs | 31,000.9 μs | 31,000.9 μs |     640 B |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 31,166.8 μs |    NA | 31,166.8 μs | 31,166.8 μs | 31,166.8 μs |     400 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 41,444.5 μs |    NA | 41,444.5 μs | 41,444.5 μs | 41,444.5 μs |         - |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 41,527.0 μs |    NA | 41,527.0 μs | 41,527.0 μs | 41,527.0 μs |     400 B |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 41,622.9 μs |    NA | 41,622.9 μs | 41,622.9 μs | 41,622.9 μs |     640 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 43,905.0 μs |    NA | 43,905.0 μs | 43,905.0 μs | 43,905.0 μs |     400 B |
