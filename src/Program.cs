
namespace Practice
{



  class Program
  {

    static void Main(string[] args)
    {

      var consoleLogger = new ConsoleLogger(); //superCLass Object
      var manager = new(consoleLogger); //DI subclass Object 


      var fileLogger = new FlieLogger(); //superCLass Object
      var manager2 = new(fileLogger); //DI subclass Object 

      manager.AddPerson("Turki");//add the new person


    }

  }
}











