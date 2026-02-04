using KitCli.Abstractions.Io;
using KitCli.Workflow.Abstractions;

namespace KitCli.Example.HelloWorld;

public class HelloWorldCliApp : CliApp
{
    public HelloWorldCliApp(ICliWorkflow workflow, ICliIo io) : base(workflow, io)
    {
    }
}