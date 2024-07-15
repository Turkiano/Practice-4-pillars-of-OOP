namespace Practice
{

    class FlieLogger : ILogger
    {


        public void Log(string message)
        {
            File.WriteAllText("./logs.txt", message);
        }
    }

}