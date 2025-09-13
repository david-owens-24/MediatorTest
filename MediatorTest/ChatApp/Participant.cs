using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTest.ChatApp
{
    /// <summary>
    /// Abstract Colleague for the Chat Application
    /// </summary>
    public abstract class Participant
    {
        private Chatroom chatroom;

        public Participant(string name)
        {
            this.Name = name;
        }

        public string Name { get; }


        internal void SetChatroom(Chatroom chatroom)
        {
            this.chatroom = chatroom;
        }

        public void Send(string message)
        {
            chatroom.SendMessage(this.Name, message);
        }   

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"from {from}: {message}");
        }

        // somewhat unrealistic for this example as it will allow basic chatters to send messages to only other basic chatters
        // which would stop moderators from being able to see those messages
        // but it is just to illustrate the generic method in the mediator
        public void SendTo<T>(string message) where T : Participant
        {
            chatroom.SendMessageTo<T>(this.Name, message);
        }
    }
}
