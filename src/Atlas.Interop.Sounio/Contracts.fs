namespace Architectomics.Atlas.Interop.Sounio

open Architectomics.Atlas.Domain

[<RequireQualifiedAccess>]
type SounioTransport =
    | ProcessBoundary
    | SharedLibrary

[<RequireQualifiedAccess>]
type KernelName =
    | VerifyKnowledge
    | ExactWindowMetrics
    | ApproximateWindowMetrics

type SupportedContract =
    { Topology: GenomeTopology
      OperatorSpaces: OperatorSpace list }

module SupportedContract =
    let bootstrap =
        [ { Topology = GenomeTopology.Circular
            OperatorSpaces = [ OperatorSpace.CircularDna; OperatorSpace.ArchitectureAware ] }
          { Topology = GenomeTopology.Linear
            OperatorSpaces = [ OperatorSpace.LinearDna; OperatorSpace.ArchitectureAware ] } ]
