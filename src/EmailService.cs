namespace Practice
{



    //subclass inheriting the interface
    class EmailService : ILogger
    {

        //implementing the interface contract
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }


}