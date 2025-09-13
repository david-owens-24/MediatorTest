using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTest.Structural
{
    public class MediatorImplementation : Mediator
    {
        private Colleague Colleague1;
        private Colleague Colleague2;

        public void SetColleague1(Colleague colleague)
        {
            Colleague1 = colleague;
        }
        public void SetColleague2(Colleague colleague)
        {
            Colleague2 = colleague;
        }

        public override void Send(string message, Colleague colleague)
        {
            // Determine which colleague should receive the message
            // (the opposite of the sender)
            if (colleague == Colleague1)
            {
                Colleague2.HandleNotification(message);
            }
            else
            {
                Colleague1.HandleNotification(message);
            }
        }
    }
}
