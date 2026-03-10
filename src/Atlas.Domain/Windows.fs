namespace Architectomics.Atlas.Domain

type ArchitectureWindowResult =
    { UnitId: string
      WindowLength: int
      WindowStart: int64
      Topology: GenomeTopology
      OperatorSpace: OperatorSpace
      OrbitSize: int option
      OrbitRatio: float option
      Dmin: int option
      DminOverLength: float option
      NearestTransformFamily: string option
      IsFixedReverse: bool option
      IsFixedReverseComplement: bool option
      ArchitectureScore: float option }
