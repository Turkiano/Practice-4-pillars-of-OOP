
namespace Practice;


class Program
{

  static void Main(string[] args)
  {
    User customer1 = new (){

      Name = "Turki",
      Email = "turkiano@gmail.com",
      Password = "3452452"


    };

        UserReadDTO customerRead = customer1.ConvertToRead();

        Console.WriteLine(customerRead.Name);
        Console.WriteLine(customerRead.Email);
        
  }

}









