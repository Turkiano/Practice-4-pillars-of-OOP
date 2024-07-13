namespace Practice
{



//subclass inheriting the interface
    class EmailService : IMessageService
    {

 //implementing the interface contract
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending email: {message}");
            ;
        }
    }


}