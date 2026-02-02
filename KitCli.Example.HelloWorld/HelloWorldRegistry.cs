using KitCli.Abstractions;
using KitCli.Commands.Abstractions.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace KitCli.Example.HelloWorld;

public class HelloWorldRegistry : ICliAppBuilderRegistry
{
    public void Register(IServiceCollection services)
    {
        services.AddCommandsFromAssembly(typeof(HelloWorldCliCommand).Assembly);
    }
}