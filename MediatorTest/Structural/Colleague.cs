using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTest.Structural
{
    // Each Colleague class knows its Mediator object.
    // Each Colleague communicates with its Mediator instead of communicating with every Colleague.


    public abstract class Colleague
    {
        protected Mediator mediator;

        //public Colleague(Mediator mediator)
        //{
        //    this.mediator = mediator;
        //}

        internal void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}
