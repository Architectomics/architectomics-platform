namespace Architectomics.Atlas.Pipeline

open System
open Architectomics.Atlas.Domain

type PipelineManifest =
    { RunId: string
      CreatedAtUtc: DateTimeOffset
      Inputs: string list
      Notes: string list }

[<RequireQualifiedAccess>]
module Bootstrap =
    let createManifest runId inputs =
        { RunId = runId
          CreatedAtUtc = DateTimeOffset.UtcNow
          Inputs = inputs
          Notes = [ "bootstrap-manifest" ] }

    let selectionForUnit (unitRecord: GenomeUnitRecord) =
        let operatorSpace =
            match unitRecord.Topology with
            | GenomeTopology.Circular -> OperatorSpace.CircularDna
            | GenomeTopology.Linear -> OperatorSpace.LinearDna

        { Topology = unitRecord.Topology
          OperatorSpace = operatorSpace }
