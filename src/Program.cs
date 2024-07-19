namespace Practice
{

  class Program
  {

    static void Main(string[] args)
    {

      var consoleLogger = new ConsoleLogger(); //superCLass Object
      var manager = new PersonManager(consoleLogger); //DI subclass Object 


      var fileLogger = new FlieLogger(); //superCLass Object
      var manager2 = new  PersonManager(fileLogger); //DI subclass Object 

      PersonManager testing = new (fileLogger);

      manager.AddPerson("Turki");//add the new person
      manager2.AddPerson("Turki is the best one");

      testing.AddPerson("Satam in the building");

    }

  }
}











