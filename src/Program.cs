
namespace Practice;


class Program
{

  static void Main(string[] args)
  {
    
  Logger logger = new(); //superCLass Object
  PersonManager manager = new(logger); //supclass Object

  manager.AddPerson("John");//invok supclass method


  }

}









