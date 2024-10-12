// See https://aka.ms/new-console-template for more information

// The client code.
using CustomMediator.Example;
using Mediator.Net;
using Mediator.Net.Interfaces;
using Microsoft.Extensions.DependencyInjection;
ServiceCollection services = new ();
services.AddScoped<IMediator, MediatorNet>();

BaseComponent baseComponent = new BaseComponent ();
baseComponent.SetMediator(new MediatorNet());
baseComponent.Test();

Componenent1 component1 = new Componenent1();
Componenent2 component2 = new Componenent2();
//new ConcreteMediator(component1, component2);

Console.WriteLine("Client triggers operation A.");
component1.DoA();

Console.WriteLine();

Console.WriteLine("Client triggers operation D.");
component2.DoD();
Console.WriteLine("Hello, World!");
