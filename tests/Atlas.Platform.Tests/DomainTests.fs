namespace Architectomics.Atlas.Platform.Tests

open Architectomics.Atlas.Domain
open Xunit

type DomainTests() =
    [<Fact>]
    member _.``GenomeUnitRecord empty seeds a circular placeholder``() =
        let unitRecord = GenomeUnitRecord.empty "unit-001"

        Assert.Equal("unit-001", unitRecord.UnitId)
        Assert.Equal("unknown", unitRecord.MoleculeClass)
        Assert.Equal(GenomeTopology.Circular, unitRecord.Topology)
