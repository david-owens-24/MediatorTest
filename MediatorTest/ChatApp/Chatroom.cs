using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTest.ChatApp
{
    /// <summary>
    /// Abstract Mediator for the Chat Application
    /// </summary>
    public abstract class Chatroom
    {
        public abstract void RegisterParticipant(Participant participant);
        public abstract void SendMessage(string name, string message);
        public abstract void SendMessageTo<T>(string name, string message) where T : Participant;
    }
}
