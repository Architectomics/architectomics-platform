namespace Architectomics.Atlas.Interop.Sounio

open Architectomics.Atlas.Domain

type SounioCommand =
    { Executable: string
      WorkingDirectory: string
      Arguments: string list }

type ContractCheckRequest =
    { Selection: ContractSelection option
      Intervention: InterventionSpec option }

[<RequireQualifiedAccess>]
module SounioInterop =
    let topologyContractCheck repoRoot =
        { Executable = "souc"
          WorkingDirectory = repoRoot
          Arguments = [ "check"; "sounio/src/topology_contracts.sio" ] }

    let selectionIsValid selection =
        Contracts.operatorSpaceIsAllowed selection.Topology selection.OperatorSpace

    let interventionIsValid intervention =
        Contracts.interventionIsAllowed intervention.Topology intervention.Kind
