namespace Architectomics.Atlas.Domain

module GenomeUnitRecords =
    let empty unitId =
        { UnitId = unitId
          Domain = GenomeDomain.Bacteria
          Topology = GenomeTopology.Circular
          MoleculeClass = "unknown"
          LengthBp = 0L
          TaxonomyId = None
          TaxonomyName = None
          SourceDb = "unspecified"
          AssemblyAccession = None
          ChecksumSha256 = None }
