namespace Practice
{


    class Logger //the superClass
    { 

        public void log(string message) //method property
        {
            // Console.WriteLine($"{message}");
            File.WriteAllText("./logs.txt", message); //export a file 

        }
    }
}