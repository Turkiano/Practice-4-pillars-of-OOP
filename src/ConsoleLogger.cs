namespace Practice
{

    public class ConsoleLogger : ILogger
    {

        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");

        }
    }
}