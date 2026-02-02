using KitCli;
using KitCli.Example.HelloWorld;

var app = new CliAppBuilder()
    .WithCli<HelloWorldCliApp>()
    .WithRegistry<HelloWorldRegistry>();

await app.Run();