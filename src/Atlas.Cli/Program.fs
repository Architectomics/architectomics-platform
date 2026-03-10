namespace Architectomics.Atlas.Cli

open Architectomics.Atlas.Domain
open Architectomics.Atlas.Interop.Sounio
open Architectomics.Atlas.Pipeline

module Program =
    let private printBootstrapPlan () =
        let plan = PipelinePlan.bootstrap None None

        printfn "Architectomics platform bootstrap plan"

        plan.Stages
        |> List.iter (fun stage -> printfn "- %s" (StageLabels.name stage))

    let private printContracts () =
        printfn "Sounio contract bootstrap"

        SupportedContract.bootstrap
        |> List.iter (fun contract ->
            let spaces =
                contract.OperatorSpaces
                |> List.map Labels.operatorSpace
                |> String.concat ", "

            printfn "- %s: %s" (Labels.topology contract.Topology) spaces)

    [<EntryPoint>]
    let main argv =
        match CliCommand.parse argv with
        | CliCommand.BootstrapManifest ->
            printBootstrapPlan ()
            0
        | CliCommand.DescribeContracts ->
            printContracts ()
            0
        | CliCommand.Help ->
            CliCommand.usage |> List.iter (printfn "%s")
            0
