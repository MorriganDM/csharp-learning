# Learning Log — C# / .NET

## 2026-11-19 — Initial setup

### Activities
- Established the learning methodology.
- Created the `csharp-learning` GitHub repository.
- Started organizing permanent study documentation.
- Practiced reading a `for` loop involving array bounds.

### Observations
- Identified a potential boundary problem in array iteration.
- Further practice was needed to distinguish valid indices, loop conditions, and runtime exceptions.

### Next session
Continue the array-boundary debugging exercise, then progress according to demonstrated understanding.

## 2026-11-19 — Fundamentals: arrays, loops, conditions, and debugging setup

### Activities and evidence
- Practiced predicting `for` loop iteration counts, indices, and outputs; corrected misunderstandings about loop conditions and increments.
- **Exercise 02 — every other array element:** implemented and ran a loop over `{ 5, 10, 15, 20, 25, 30 }`, printing `5, 15, 25` and a counter of `3`.
- **Exercise 03 — array sum:** implemented an accumulator in a `for` loop over `{ 4, 8, 12, 16, 20 }`; execution returned `Total = 60`.
- **Exercise 04 — maximum element:** implemented a running maximum; execution returned `45` for the original data and `-7` for a negative-only array. Added a length guard; an empty array returned `O array está vazio.`.
- Fixed compiler errors `CS0029` and `CS0165` through small changes and recompilation.
- Observed `IndexOutOfRangeException` when accessing `nums[0]` in an empty array, and distinguished that runtime error from compiler diagnostics.
- Discussed O(1) index access, O(n) traversal, and O(1) auxiliary space for a fixed set of local variables.
- Installed .NET 11 and C# Dev Kit; VS Code debugger stopped at a breakpoint and exposed local values (`i = 0`, `max = 14`).

### Difficulties observed
- Inconsistent syntax recall (`=` vs `==`, array indexing, block delimiters, statement terminators, and variable initialization).
- Initial incorrect predictions of `for` iterations; improved after tracing the actual condition and index changes.
- Needed explanation to distinguish time complexity from auxiliary space complexity, then explained the constant-space accumulator correctly.
- VS Code debugging controls (F10 / Step Over, F5 / Continue) did not advance after the breakpoint. A window reload and attempted controls did not resolve it. No confirmed root cause.

### Next session
- Isolate debugger behavior using a normal `net11.0` console project (`DebugPractice`) rather than a single-file C# app.
- Trace `i`, `max`, branch decisions, and control flow using breakpoints once the debugger advances.
- Continue fundamentals only after the debugging workflow is usable.

### Scope note
The source code exercises were completed by the student locally. This log records the observed terminal outputs and discussion; the repository exercise files were not modified by this documentation update.
