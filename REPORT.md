# .NET Native Interop Performance Report

The following report evaluates the performance overhead of calling native C/C++ functions from managed C# code using the built-in interoperability capabilities of .NET known as P/Invoke (short for Platform Invocation Services). The report presents benchmarks of common interop scenarios that invole marshalling and passing values of primitive types, strings, arrays, and structures, in both directions (i.e. as both function parameters and return values or out parameters). Several ways of implementing the interop calls that have been added to the .NET framework throughout the years, namely the `DllImport` attribute, the source-generator backed `LibraryImport` attribute, and unmanaged function pointers are compared.

The benchmarks were executed on three .NET runtime versions as permitted by their respective supported feature sets: .NET Framework 4.8 (the last major version of the classic Windows-only runtime), .NET 6 (current LTS version of the portable .NET Core runtime) and the latest .NET 8 Preview. Results from Windows and Linux (x64) platforms are compared for the latter two runtimes.

## Overview of P/Invoke

Data type is called blittable if it has the same representation in managed and unmanaged memory. Such types therefore do not need conversion when passed between .NET and native code. In the case of reference types (or value types passed as `ref` parameters) this means that instead of copying the value to the unmanaged memory a pointer to the value's location in the managed memory can be passed where it can be accessed by the native code directly. This saves one copy for *in* parameters and up to two copies for *out copies *

Non-blittable types are conversely types that do need special marshalling during interop. These types include:

- Strings
- Bools
- Arrays other than one-dimensional arrays of blittable types
- Structures and classes containing any non-blittable field, including array fields (with the exception of arrays with compile-time constant size) 

### LibraryImport attribute

### Function pointers

### Interop settings

## Benchmark platform

## Running the benchmarks

## Experiments

### Overhead baseline

- empty void functions
- compare with managed call

### Passing primitive types

- int input params
- int return values

### Marshalling strings

- UTF8 conversion
- UTF16 pinning
- returning strings as out params

### Marshalling arrays

- blittable arrays
- pinning managed arrays

### Marshalling structures

- non-blittable fields
- manual marshalling
- custom marshaller
- unions

### Effect of interop settings

- `SetLastError`
- `SuppressUnmanagedCodeSecurity`
- `SuppressGCTransition`

### Cold start performance

## Summary

### Platforms and runtime versions

Win vs Linux, Net48 vs 6 vs 8

### Interop methods

DllImport vs LibraryImport vs func pointers

### Interop settings