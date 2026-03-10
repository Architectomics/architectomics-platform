namespace Architectomics.Atlas.Analysis

open Architectomics.Atlas.Domain

type TopologySummary =
    { CircularUnits: int
      LinearUnits: int }

module Summaries =
    let topologyBreakdown (units: seq<GenomeUnitRecord>) =
        units
        |> Seq.fold
            (fun summary unitRecord ->
                match unitRecord.Topology with
                | GenomeTopology.Circular -> { summary with CircularUnits = summary.CircularUnits + 1 }
                | GenomeTopology.Linear -> { summary with LinearUnits = summary.LinearUnits + 1 })
            { CircularUnits = 0
              LinearUnits = 0 }
