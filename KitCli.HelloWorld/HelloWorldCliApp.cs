using KitCli;
using KitCli.Commands.Abstractions.Io.Outcomes;
using KitCli.Workflow.Abstractions;

public class HelloWorldCliApp : CliApp
{
    public HelloWorldCliApp(ICliWorkflow workflow, ICliCommandOutcomeIo io) : base(workflow, io)
    {
    }
}