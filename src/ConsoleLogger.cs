namespace Practice
{


    class ConsoleLogger : ILogger //subClass 02
    {
        public void Log(string message)
        {

            Console.WriteLine(message);

        }
    }
}