// See https://aka.ms/new-console-template for more information

using KitCli;
using KitCli.Commands.Abstractions.Extensions;
using KitCli.HelloWorld;
using KitCli.Instructions.Abstractions;

var app = new CliAppBuilder()
    .WithCli<HelloWorldCliApp>()
    .WithUserSecretSettings<HelloWorldCliApp>()
    .WithSettings<InstructionSettings>()
    .WithServices(services => services
        .AddCommandsFromAssembly(typeof(HelloWorldCliCommand).Assembly));

await app.Run();