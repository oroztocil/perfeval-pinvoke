### Abstract

Evaluate common interop patterns: - passing in and returning strings, arrays and structures - mutating passed in data in native code - in and out parameters

### Native method calls

- DllImport
- LibaryImport
- function pointers
- delegates?
- C# method call (force no inlining?)

### SuppressGCTransitionAttribute

When executing a P/Invoke, the runtime switches the GC mode from cooperative to preemptive mode. Depending on the scenario, this transition, which also includes an additional frame, can lead to the setup of a P/Invoke being more expensive than the native function that is invoked.

SuppressGCTransitionAttribute provides a way for developers to indicate that a P/Invoke should avoid the GC transition. The ability to reduce this interop overhead enables high-performance P/Invoke calls in both runtime libraries and third-party libraries. This is similar in spirit to internal FCalls into the runtime itself.

This attribute effectively circumvents the safeguards normally provided by the runtime around memory management with P/Invokes. As such, it is important to abide by the conditions under which its usage is valid. The native function being called must:

- Always execute for a trivial amount of time (less than 1 microsecond)
- Not perform a blocking syscall (e.g. any type of I/O)
- Not call back into the runtime (e.g. Reverse P/Invoke)
- Not throw exceptions
- Not manipulate locks or other concurrency primitives

### Function pointers

https://air-richter.livejournal.com/66589.html
https://rendered-obsolete.github.io/2021/05/22/net_benchmark.html

### SuppressUnmanagedCodeSecurityAttribute

### Marshal.PrelinkAll to preload DLL

https://learn.microsoft.com/en-us/cpp/dotnet/calling-native-functions-from-managed-code?view=msvc-170&redirectedfrom=MSDN#performance-considerations

PInvoke has an overhead of between 10 and 30 x86 instructions per call. In addition to this fixed cost, marshaling creates additional overhead. There is no marshaling cost between blittable types that have the same representation in managed and unmanaged code. For example, there is no cost to translate between int and Int32.

You can call LoadLibrary before using your DllImports and DllImport will use the Module you already loaded

When we often call unmanaged code from our application we should think about amount of context switching from managed to unmanaged code because it is performance bottleneck. That's mainly due to security checks which .Net runtime performs before each call of unmanaged function. It goes through call stack and checks if every caller has appropriate rights. We can suppress this kind of behaviour by using SuppressUnmanagedCodeSecurity attribute. This can really help us improve performance when we need to do a lot of context switching.

```csharp
[SuppressUnmanagedCodeSecurity]
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
delegate void MyUnmanagedDelegate(float a, float b, float* result);
```

When you use [DllImport] (and for other scenarios), under the hood a 'stub' is generated to handle the interop/marshalling/error-handling/etc for you