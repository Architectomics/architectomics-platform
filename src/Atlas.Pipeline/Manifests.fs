namespace Architectomics.Atlas.Pipeline

open Architectomics.Atlas.Domain

[<RequireQualifiedAccess>]
type ManifestSource =
    | RefSeq
    | GenBank
    | Custom of string

type IngestionManifest =
    { ManifestId: string
      Source: ManifestSource
      UnitIds: string list
      Topologies: Set<GenomeTopology>
      Notes: string list }

module IngestionManifest =
    let empty manifestId =
        { ManifestId = manifestId
          Source = ManifestSource.Custom "bootstrap"
          UnitIds = []
          Topologies = Set.empty
          Notes = [] }
