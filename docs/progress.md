# Learning Progress

## Current stage
C# fundamentals — `for`, arrays, conditionals and introductory debugging practiced. **Next: `break` and `continue`; revisit `while` with changing initial values.**

## Validated evidence
- Traversed arrays with `for`, including index skips, sum and counter.
- Found the maximum element; tests returned 45 and -7, with a guard for empty arrays.
- Investigated compiler errors CS0029 and CS0165 and runtime `IndexOutOfRangeException`.
- Explained O(n) traversal and O(1) auxiliary space.
- Debugged in a conventional .NET 11 Console project in VS Code: read Locals, advanced with F10, used F5 to jump between loop iterations and F11 to enter a called method.
- Traced an incorrect discount calculation, verified the intermediate value 400 and corrected it to 40 for 20% of 200.
- In the multi-order discount exercise, located the logic that overwrote percentage discounts for rates >= 50 and confirmed the cause using the debugger. The student reported the exercise ready; full final output for all four orders was not provided.

- Implemented a countdown using `while (countdown != 0)` with `countdown--`, printing 10 through 1 and `Decolando!`; runtime output confirmed on 2026-11-20.

## Areas to reinforce
- Syntax recall, especially conditions, indexes, delimiters and type initialization.
- Predicting loop conditions versus body executions.
- Independent breakpoint selection, tracing between methods, and systematic regression testing.

## Debugger environment
- Windows, VS Code, C# Dev Kit, .NET 11.
- Single-file `.cs` debugging initially stalled after pausing on a breakpoint; the cause was not established.
- A conventional `DebugPractice` Console project enabled successful step-through debugging.
- Earlier .NET 10 build produced NU1903 warning for `Microsoft.DotNet.ILCompiler` 10.0.10; review package updates separately.

## Next task
Begin a short practical exercise with **`break` and `continue`**. Review the `while` stopping condition (`!= 0` versus `> 0`) in a later edge-case test; avoid repeating today's completed countdown. Continue one task at a time.

## Atlas API
Not started.

## Last updated
2026-11-20.
