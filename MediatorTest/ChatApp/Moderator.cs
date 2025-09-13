namespace MediatorTest.ChatApp
{
    public class Moderator : Participant
    {
        public Moderator(string name) : base(name)
        {

        }
        public override void Receive(string from, string message)
        {
            Console.Write($"({nameof(Moderator)}) {this.Name} has received: ");
            base.Receive(from, message);
        }
    }
}
