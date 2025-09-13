namespace MediatorTest.Structural
{
    public class ColleagueImplementation2 : Colleague
    {
        //public ColleagueImplementation2(Mediator mediator) : base(mediator)
        //{

        //}

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague2 received message: {message}");
        }
    }
}
