namespace Architectomics.Atlas.Domain

module Labels =
    let topology = function
        | GenomeTopology.Circular -> "circular"
        | GenomeTopology.Linear -> "linear"

    let domain = function
        | GenomeDomain.Bacteria -> "bacteria"
        | GenomeDomain.Plasmid -> "plasmid"
        | GenomeDomain.Virus -> "virus"
        | GenomeDomain.Organelle -> "organelle"
        | GenomeDomain.EukChromosome -> "euk-chromosome"

    let operatorSpace = function
        | OperatorSpace.CircularDna -> "circular-dna"
        | OperatorSpace.LinearDna -> "linear-dna"
        | OperatorSpace.ArchitectureAware -> "architecture-aware"
