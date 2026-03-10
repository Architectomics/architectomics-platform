# architectomics-platform

F# host platform for Architectomics: ingestion, graph materialization, release assembly, and Sounio interop.

## Status

This repository is the initial bootstrap scaffold.

It is currently staged under the `agourakis82` account and is intended to move into the `Architectomics` GitHub organization once that organization exists.

## Purpose

`architectomics-platform` is the executable host layer for the Architectomics program.

It is responsible for:

- ingesting mixed-genome and multi-omics inputs
- normalizing records into shared domain types
- materializing public tables and graph-ready outputs
- orchestrating Sounio contracts and kernels
- staging and consuming Stan model workflows

## Planned Layout

- `src/Atlas.Domain` shared records, unions, and topology-aware types
- `src/Atlas.Pipeline` ingestion, parsing, manifests, and release generation
- `src/Atlas.Interop.Sounio` Sounio process and contract interop
- `src/Atlas.Analysis` posteriors, summaries, QC, and analysis glue
- `src/Atlas.Cli` reproducible command-line entrypoints
- `tests/` unit, integration, and property-based tests

## Stack

- F#
- .NET
- Sounio interop
- Stan workflow orchestration

## Next Steps

1. Create the F# solution and project skeleton.
2. Port the first shared domain contracts.
3. Add topology-aware ingestion and manifest generation.
4. Wire the first Sounio contract calls.
