using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTest.ChatApp
{
    public class Chatter : Participant
    {
        public Chatter(string name) : base(name)
        {

        }

        public override void Receive(string from, string message)
        {
            Console.Write($"({nameof(Chatter)}) {this.Name} has received: ");
            base.Receive(from, message);
        }
    }
}
