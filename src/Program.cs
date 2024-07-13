
namespace Practice;


class Program
{

  static void Main(string[] args)
  {
    //Create an object of the dependent class
    UserService userService = new UserService();

    //Create an object of the subclass
    ILogger logger = new ConsoleLogger();


    //Inject the dependency through the property
    userService.Logger = logger;

    //invoke the dependt class
    userService.CreateUser("Dependent");



  }

}









