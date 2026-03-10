namespace Architectomics.Atlas.Analysis

open Architectomics.Atlas.Domain

type ArchitectureSummary =
    { TotalSelections: int
      CircularSelections: int
      LinearSelections: int
      ValidSelections: int }

[<RequireQualifiedAccess>]
module Summary =
    let fromSelections (selections: ContractSelection list) =
        let isValid (selection: ContractSelection) =
            Contracts.operatorSpaceIsAllowed selection.Topology selection.OperatorSpace

        { TotalSelections = selections.Length
          CircularSelections =
            selections
            |> List.filter (fun (selection: ContractSelection) -> selection.Topology = GenomeTopology.Circular)
            |> List.length
          LinearSelections =
            selections
            |> List.filter (fun (selection: ContractSelection) -> selection.Topology = GenomeTopology.Linear)
            |> List.length
          ValidSelections =
            selections
            |> List.filter isValid
            |> List.length }
