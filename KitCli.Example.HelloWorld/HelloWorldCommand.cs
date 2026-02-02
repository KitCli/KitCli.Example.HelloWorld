using KitCli.Commands.Abstractions;
using KitCli.Commands.Abstractions.Artefacts;
using KitCli.Commands.Abstractions.Factories;
using KitCli.Commands.Abstractions.Handlers;
using KitCli.Commands.Abstractions.Outcomes;
using KitCli.Instructions.Abstractions;

namespace KitCli.Example.HelloWorld;

public record HelloWorldCliCommand : CliCommand;

public class HelloWorldCliCommandFactory : ICliCommandFactory<HelloWorldCliCommand>
{
    public CliCommand Create(CliInstruction instruction, List<CliCommandArtefact> artefacts)
        => new HelloWorldCliCommand();
}

public class HelloWorldCliCommandHandler : CliCommandHandler, ICliCommandHandler<HelloWorldCliCommand>
{
    public Task<CliCommandOutcome[]> Handle(HelloWorldCliCommand request, CancellationToken cancellationToken)
        => AsyncOutcomeAs("Hello, World!");
}