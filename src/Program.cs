
namespace Practice;


class Program
{

  static void Main(string[] args)
  {
    Console.WriteLine("Write your name: ");
    string? inputName = Console.ReadLine();


    if (inputName is not null)
    {


      Person person = new Person(inputName);

      string? result = person.GetName();
      Console.WriteLine("This is your name is: " + result);
    }

    else
    {

      Console.WriteLine("input can not be impty");


    }


  }

}









