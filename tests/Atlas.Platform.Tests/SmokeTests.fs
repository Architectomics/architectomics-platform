namespace Architectomics.Atlas.Platform.Tests

open Xunit
open FsCheck.Xunit
open Architectomics.Atlas.Domain
open Architectomics.Atlas.Analysis

module SmokeTests =
    [<Fact>]
    let ``circular topology accepts circular DNA operator space`` () =
        Assert.True(Contracts.operatorSpaceIsAllowed GenomeTopology.Circular OperatorSpace.CircularDna)

    [<Fact>]
    let ``linear topology rejects circular DNA operator space`` () =
        Assert.False(Contracts.operatorSpaceIsAllowed GenomeTopology.Linear OperatorSpace.CircularDna)

    [<Property>]
    let ``architecture aware operator space remains valid for both topologies`` (isCircular: bool) =
        let topology =
            if isCircular then
                GenomeTopology.Circular
            else
                GenomeTopology.Linear

        Contracts.operatorSpaceIsAllowed topology OperatorSpace.ArchitectureAware

    [<Fact>]
    let ``summary counts valid bootstrap selections`` () =
        let selections =
            [ { Topology = GenomeTopology.Circular
                OperatorSpace = OperatorSpace.CircularDna }
              { Topology = GenomeTopology.Linear
                OperatorSpace = OperatorSpace.CircularDna } ]

        let summary = Summary.fromSelections selections

        Assert.Equal(2, summary.TotalSelections)
        Assert.Equal(1, summary.ValidSelections)
