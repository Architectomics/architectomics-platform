namespace Architectomics.Atlas.Cli

[<RequireQualifiedAccess>]
type CliCommand =
    | BootstrapManifest
    | DescribeContracts
    | Help

module CliCommand =
    let parse (argv: string array) =
        match Array.toList argv with
        | "bootstrap-manifest" :: _ -> CliCommand.BootstrapManifest
        | "describe-contracts" :: _ -> CliCommand.DescribeContracts
        | _ -> CliCommand.Help

    let usage =
        [ "Usage: architectomics-platform <command>"
          ""
          "Commands:"
          "  bootstrap-manifest   Print the initial pipeline stage plan"
          "  describe-contracts   Print the topology/operator-space contract map" ]
