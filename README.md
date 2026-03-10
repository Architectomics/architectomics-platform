# architectomics-platform

F# host platform for Architectomics: ingestion, graph materialization, release assembly, and Sounio interop.

## Status

This repository now contains the first manual .NET/F# solution scaffold.

It was authored without a local `dotnet` toolchain on this machine, so the structure is commit-ready but not build-validated in place yet.

## Solution Layout

- `Architectomics.Platform.sln` root solution file for all platform projects
- `Directory.Build.props` shared SDK defaults for every project
- `Directory.Packages.props` centralized package versions for test dependencies
- `src/Atlas.Domain` shared topology, genome-unit, and window-level domain contracts
- `src/Atlas.Pipeline` ingestion-manifest and pipeline-plan skeletons
- `src/Atlas.Interop.Sounio` process-boundary contract and invocation models for Sounio
- `src/Atlas.Analysis` evidence and summary helpers for downstream reporting
- `src/Atlas.Cli` minimal executable entrypoint for bootstrap inspection commands
- `tests/Atlas.Platform.Tests` unit-test skeleton covering domain and pipeline primitives

## Intended Commands

When a .NET 8 SDK is available, the expected first commands are:

```bash
dotnet restore Architectomics.Platform.sln
dotnet build Architectomics.Platform.sln
dotnet test Architectomics.Platform.sln
```

## Project Boundaries

`Atlas.Domain` is the shared contract surface for topology-aware records.

`Atlas.Pipeline` owns ingestion staging, manifest generation, and release-path planning.

`Atlas.Interop.Sounio` models the boundary to Sounio kernels and contract validation.

`Atlas.Analysis` holds evidence-level summaries that sit above the raw pipeline outputs.

`Atlas.Cli` is the thin executable layer for reproducible entrypoints.

## Next Steps

1. Restore and build the solution once `dotnet` is available.
2. Replace placeholder records with the first real normalized genome-unit contracts.
3. Add file-system, FASTA, and manifest adapters under `Atlas.Pipeline`.
4. Wire the first concrete Sounio process calls under `Atlas.Interop.Sounio`.
