namespace Architectomics.Atlas.Interop.Sounio

type SounioExecutable =
    { Command: string
      WorkingDirectory: string option
      DefaultArgs: string list }

type KernelInvocation =
    { Kernel: KernelName
      Transport: SounioTransport
      Arguments: string list }

module KernelInvocation =
    let bootstrap kernel =
        { Kernel = kernel
          Transport = SounioTransport.ProcessBoundary
          Arguments = [] }

    let toProcessArgs executable invocation =
        executable.Command, executable.DefaultArgs @ invocation.Arguments
