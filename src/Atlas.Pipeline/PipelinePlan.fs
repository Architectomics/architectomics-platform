namespace Architectomics.Atlas.Pipeline

[<RequireQualifiedAccess>]
type PipelineStage =
    | DiscoverInputs
    | NormalizeRecords
    | MaterializeCatalog
    | ExportRelease

type PipelinePlan =
    { Stages: PipelineStage list
      MaxUnits: int option
      Seed: int option }

module StageLabels =
    let name = function
        | PipelineStage.DiscoverInputs -> "discover-inputs"
        | PipelineStage.NormalizeRecords -> "normalize-records"
        | PipelineStage.MaterializeCatalog -> "materialize-catalog"
        | PipelineStage.ExportRelease -> "export-release"

module PipelinePlan =
    let bootstrap maxUnits seed =
        { Stages =
            [ PipelineStage.DiscoverInputs
              PipelineStage.NormalizeRecords
              PipelineStage.MaterializeCatalog
              PipelineStage.ExportRelease ]
          MaxUnits = maxUnits
          Seed = seed }
