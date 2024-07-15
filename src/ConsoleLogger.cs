namespace Practice
{


    class ConsoleLogger : ILogger //the superClass
    {
        public void Log(string message)
        {

            Console.WriteLine(message);

        }
    }
}