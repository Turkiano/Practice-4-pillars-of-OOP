namespace Practice
{

  class Program
  {

    static void Main(string[] args)
    {

      ConsoleLogger consoleLogger = new (); //superCLass Object
      PersonManager manager = new (consoleLogger); //DI subclass Object 


      var fileLogger = new FlieLogger(); //superCLass Object
      var manager2 = new  PersonManager(fileLogger); //DI subclass Object 




      manager.AddPerson("Turki");//add the new person using the Console
      manager2.AddPerson("Turki is the best one"); //add the new person using the File generator


    }

  }
}











