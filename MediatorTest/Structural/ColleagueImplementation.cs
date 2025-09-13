using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTest.Structural
{
    public class ColleagueImplementation : Colleague
    {
        public ColleagueImplementation(Mediator mediator) : base(mediator)
        {

        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague1 received message: {message}");
        }
    }
}
