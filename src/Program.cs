
namespace Practice;


class Program
{

  static void Main(string[] args)
  {
    User customer1 = new()
    {

      Name = "Turki",
      Email = "turkiano@gmail.com",
      Password = "3452452"


    };

    UserReadDTO customerRead = customer1.ConvertToRead();
    UserUpdateDTO customerUpdate = customer1.ConverToUpdate("Khalid");

    Console.WriteLine(customerRead.Name);
    Console.WriteLine(customerRead.Email);

    Console.WriteLine("-------------");
    Console.WriteLine($"This is the updated Name: {customerUpdate.Name}");
    Console.WriteLine("-------------");



  }

}









