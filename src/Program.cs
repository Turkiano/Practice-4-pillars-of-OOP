
namespace Practice;


class Program
{

  static void Main(string[] args)
  {
    
  Logger logger = new(); //superCLass Object
  PersonManager manager = new(logger); //DI subclass Object 

  manager.AddPerson("Turki");//add the new person


  }

}









