namespace Architectomics.Atlas.Domain

type GenomeTopology =
    | Circular
    | Linear

type GenomeDomain =
    | Bacteria
    | Plasmid
    | Virus
    | Organelle
    | EukChromosome

type OperatorSpace =
    | CircularDna
    | LinearDna
    | ArchitectureAware

type InterventionKind =
    | ShiftOrigin
    | InvertSegment
    | ReplichoreSwap
    | Linearize
    | Circularize

type GenomeUnitRecord =
    { UnitId: string
      Domain: GenomeDomain
      Topology: GenomeTopology
      MoleculeClass: string
      LengthBp: int64
      TaxonomyId: int64 option
      TaxonomyName: string option
      SourceDb: string
      AssemblyAccession: string option
      ChecksumSha256: string option }

type ContractSelection =
    { Topology: GenomeTopology
      OperatorSpace: OperatorSpace }

type InterventionSpec =
    { Topology: GenomeTopology
      Kind: InterventionKind }

[<RequireQualifiedAccess>]
module Contracts =
    let operatorSpaceIsAllowed topology operatorSpace =
        match topology, operatorSpace with
        | GenomeTopology.Circular, OperatorSpace.CircularDna -> true
        | GenomeTopology.Circular, OperatorSpace.ArchitectureAware -> true
        | GenomeTopology.Linear, OperatorSpace.LinearDna -> true
        | GenomeTopology.Linear, OperatorSpace.ArchitectureAware -> true
        | _ -> false

    let interventionIsAllowed topology kind =
        match topology, kind with
        | GenomeTopology.Circular, InterventionKind.ShiftOrigin -> true
        | GenomeTopology.Circular, InterventionKind.InvertSegment -> true
        | GenomeTopology.Circular, InterventionKind.ReplichoreSwap -> true
        | GenomeTopology.Circular, InterventionKind.Linearize -> true
        | GenomeTopology.Linear, InterventionKind.InvertSegment -> true
        | GenomeTopology.Linear, InterventionKind.Circularize -> true
        | _ -> false
