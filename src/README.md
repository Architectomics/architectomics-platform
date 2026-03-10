# src

The platform solution is split into small, responsibility-focused F# projects:

- `Atlas.Domain` shared records and enums for topology-aware genome architecture work
- `Atlas.Pipeline` ingestion and release-path planning primitives
- `Atlas.Interop.Sounio` the explicit boundary to Sounio contracts and kernels
- `Atlas.Analysis` evidence and summary helpers layered above raw pipeline outputs
- `Atlas.Cli` the thin executable wrapper for reproducible commands
