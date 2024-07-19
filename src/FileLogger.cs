namespace Practice
{

    class FlieLogger : ILogger //subClass 01
    {

        public void Log(string message)
        {
            File.WriteAllText("./logs.txt", message);
        }
    }

}