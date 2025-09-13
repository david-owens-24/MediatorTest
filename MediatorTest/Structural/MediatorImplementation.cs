using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTest.Structural
{
    public class MediatorImplementation : Mediator
    {
        private List<Colleague> colleagues = new List<Colleague>();        

        public void RegisterColleague(Colleague colleague)
        {
            if (!colleagues.Contains(colleague))
            {
                colleagues.Add(colleague);
                colleague.SetMediator(this);
            }
        }

        /// <summary>
        /// Hanldes sending messages to the appropriate colleague(s)
        /// </summary>
        /// <param name="message">The message to be sent to each colleague</param>
        /// <param name="colleague">The original sender of the message</param>
        public override void Send(string message, Colleague colleague)
        {
            // Send the message to all colleagues except the sender
            foreach (var col in colleagues)
            {
                if (col != colleague)
                {
                    col.HandleNotification(message);
                }
            }
        }
    }
}
