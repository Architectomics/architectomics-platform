namespace Architectomics.Atlas.Platform.Tests

open Architectomics.Atlas.Pipeline
open Xunit

type PipelineTests() =
    [<Fact>]
    member _.``Bootstrap plan keeps the release stages in order``() =
        let plan = PipelinePlan.bootstrap (Some 100) (Some 42)
        let expectedStages =
            [ PipelineStage.DiscoverInputs
              PipelineStage.NormalizeRecords
              PipelineStage.MaterializeCatalog
              PipelineStage.ExportRelease ]

        Assert.Equal<PipelineStage list>(expectedStages, plan.Stages)
        Assert.Equal(Some 100, plan.MaxUnits)
        Assert.Equal(Some 42, plan.Seed)
