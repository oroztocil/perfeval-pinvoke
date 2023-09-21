```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-XLPLHN : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-RPRIPO : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UWQZDP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

InvocationCount=1  IterationCount=1  IterationTime=250.0000 ms  
LaunchCount=100  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean       | Error       | StdDev      | Median     | Min        | Max         |
|---------------- |------------- |------------------- |---------- |-----------:|------------:|------------:|-----------:|-----------:|------------:|
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 1,704.0 μs | 1,371.25 μs | 4,043.16 μs | 1,294.3 μs | 1,262.2 μs | 41,730.5 μs |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 1,744.4 μs | 1,350.19 μs | 3,981.07 μs | 1,346.2 μs | 1,306.4 μs | 41,156.6 μs |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 2,087.9 μs | 1,393.38 μs | 4,108.43 μs | 1,675.3 μs | 1,630.4 μs | 42,760.8 μs |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 1,707.4 μs | 1,005.27 μs | 2,964.06 μs | 1,404.3 μs | 1,382.9 μs | 31,051.0 μs |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 1,742.6 μs |   991.99 μs | 2,924.89 μs | 1,449.2 μs | 1,406.8 μs | 30,698.4 μs |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 1,770.6 μs | 1,184.44 μs | 3,492.35 μs | 1,428.9 μs | 1,338.1 μs | 36,343.1 μs |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |   485.7 μs |     1.83 μs |     5.40 μs |   483.8 μs |   476.1 μs |    505.2 μs |
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |   373.6 μs |     1.58 μs |     4.65 μs |   373.9 μs |   357.5 μs |    382.8 μs |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |   588.1 μs |     2.41 μs |     7.10 μs |   587.0 μs |   577.3 μs |    605.8 μs |
