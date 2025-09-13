// See https://aka.ms/new-console-template for more information
using MediatorTest.Structural;

Console.WriteLine("Hello, World!");

var mediator = new MediatorImplementation();

var colleague1 = new ColleagueImplementation(mediator);
var colleague2 = new ColleagueImplementation2(mediator);

mediator.SetColleague1(colleague1);
mediator.SetColleague2(colleague2);

colleague1.Send("Hi, from c1");
colleague2.Send("Hello, from c2");