// See https://aka.ms/new-console-template for more information
using CustomMediator.Examples;
using CustomMediator.Net.Extensions;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
var services = new ServiceCollection();
services.AddCustomMediator(configuration =>
{
    configuration.RegisterServicesFromAssemblyContaining(typeof(Program));
});
