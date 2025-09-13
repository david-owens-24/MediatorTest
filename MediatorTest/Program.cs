// See https://aka.ms/new-console-template for more information
using MediatorTest.ChatApp;
using MediatorTest.Structural;


var simpleChatroom = new SimpleChatroom();

var bill = new Moderator("Bill");
var jane = new Chatter("Jane");
var john = new Chatter("John");
var emily = new Moderator("Emily");
var tom = new Chatter("Tom");

simpleChatroom.RegisterParticipants(new Participant[] { bill, jane, john, emily, tom });

bill.Send("Hi, everyone!");
jane.Send("Hello Bill!");

bill.SendTo<Moderator>("Any other mods on?");


static void StructuralExample()
{
    var mediator = new MediatorImplementation();

    //var colleague1 = new ColleagueImplementation();
    //var colleague2 = new ColleagueImplementation2();
    //mediator.RegisterColleague(colleague1);
    //mediator.RegisterColleague(colleague2);

    var colleague1 = mediator.CreateColleague<ColleagueImplementation>();
    var colleague2 = mediator.CreateColleague<ColleagueImplementation2>();

    colleague1.Send("Hi, from c1");
    colleague2.Send("Hello, from c2");
}




