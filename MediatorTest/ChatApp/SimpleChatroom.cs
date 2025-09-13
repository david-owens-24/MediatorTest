using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTest.ChatApp
{
    public class SimpleChatroom : Chatroom
    {
        private List<Participant> participants = new List<Participant>();   

        public override void RegisterParticipant(Participant participant)
        {
            participant.SetChatroom(this);
            this.participants.Add(participant);
        }

        public override void SendMessage(string from, string message)
        {
            //it's a chatroom, so needs to be sent to everyone including the sender
            this.participants.ForEach(p => p.Receive(from, message));
        }

        public override void SendMessageTo<T>(string from, string message)
        {
            //it's a chatroom, so needs to be sent to everyone including the sender
            this.participants.OfType<T>().ToList().ForEach(p => p.Receive(from, message));
        }

        public void RegisterParticipants(Participant[] participants)
        {
            foreach (var participant in participants)
            {
                this.RegisterParticipant(participant);
            }
        }
    }
}
