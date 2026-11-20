# Learning Progress

## Current stage
C# fundamentals — arrays, `for` loops, conditions, accumulators, and introduction to debugging.

## Validated competencies
- Correctly traverse arrays using `for`, including skipping indices with `i += 2`.
- Access array elements by index and distinguish indices from stored values.
- Accumulate values with a running total; implemented and ran an array sum yielding 60.
- Find the maximum element using a `for` and `if`; validated with positive numbers (45) and negative numbers (-7).
- Guard against an empty array before accessing `nums[0]`; confirmed an informative output instead of an exception.
- Diagnose and fix basic compiler errors: CS0029 (`=` versus `==`) and CS0165 (potentially unassigned local variable).
- Distinguish O(n) time from O(1) auxiliary space for a loop using a fixed number of variables; explain O(1) array index access.

## Difficulties and areas to reinforce
- C# syntax recall: array declarations, `if` blocks, semicolons, indexing, and initialization.
- Mental tracing of `for` loops, particularly how often the condition is checked versus how often the body executes.
- Identifying edge cases independently (empty arrays, negative-only data); continue deliberate test design.
- Debugger operation: breakpoint and local-variable inspection worked, but Step Over (F10), Continue (F5), and stopping the session did not respond as expected. Root cause is **not confirmed**.

## Current activity
Paused after implementing and testing the maximum-value exercise. Initial debugging practice was attempted in VS Code with a .NET 11 file-based C# app; the debugger showed `nums`, `i = 0`, and `max = 14` on the breakpoint, but execution controls could not advance. Module loading logs showed no clear failure.

## Next task
Resume debugging **without repeating the completed loop exercises**:
1. Create a minimal conventional console project (`dotnet new console -n DebugPractice -f net11.0`) to determine whether the debugging issue is specific to file-based apps.
2. Copy the existing maximum-value exercise into `Program.cs`, set a breakpoint on the comparison, and test Step Over / Continue.
3. If controls work, trace the changing `i` and `max` through several iterations; otherwise investigate VS Code debugger configuration and extension logs.
4. Only then move to a small exercise combining conditions and loops.

## Environment
- Windows / VS Code with C# Dev Kit installed.
- .NET 11 runtime observed in debugger logs; earlier `dotnet --info` showed SDK 10.0.302 before upgrade.
- Exercises were run as individual `.cs` files via `dotnet run .\\filename.cs`.
- A prior .NET 10 build emitted NU1903 for `Microsoft.DotNet.ILCompiler` 10.0.10; investigate dependencies/updates separately, not during the first debugging exercise.

## Atlas API
Not started.

## Last updated
2026-11-19 (evening, America/Sao_Paulo; session ended shortly after midnight UTC on Nov 20).
