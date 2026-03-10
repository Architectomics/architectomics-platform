namespace Architectomics.Atlas.Analysis

open Architectomics.Atlas.Domain

[<RequireQualifiedAccess>]
type EvidenceStatus =
    | Draft
    | Calibrated
    | Rejected

type PosteriorEvidenceRecord =
    { EvidenceId: string
      UnitId: string
      OperatorSpace: OperatorSpace
      ModelName: string
      MeanEffect: float option
      LowerBound: float option
      UpperBound: float option
      Status: EvidenceStatus
      Provenance: string list }

module PosteriorEvidenceRecord =
    let isCalibrated evidence =
        evidence.Status = EvidenceStatus.Calibrated
