// See https://aka.ms/new-console-template for more information
using MediatorTest.Structural;

Console.WriteLine("Hello, World!");

var mediator = new MediatorImplementation();

var colleague1 = new ColleagueImplementation();
var colleague2 = new ColleagueImplementation2();

mediator.RegisterColleague(colleague1);
mediator.RegisterColleague(colleague2);

colleague1.Send("Hi, from c1");
colleague2.Send("Hello, from c2");