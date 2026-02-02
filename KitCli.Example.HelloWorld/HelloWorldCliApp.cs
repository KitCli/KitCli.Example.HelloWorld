using KitCli.Commands.Abstractions.Io.Outcomes;
using KitCli.Workflow.Abstractions;

namespace KitCli.Example.HelloWorld;

public class HelloWorldCliApp : CliApp
{
    public HelloWorldCliApp(ICliWorkflow workflow, ICliCommandOutcomeIo io) : base(workflow, io)
    {
    }
}