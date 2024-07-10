
namespace Practice;


class Program
{

  static void Main(string[] args)
  {
    User customer1 = new() //this is how to test your User Data
    {

      Name = "Turki",
      Email = "turkiano@gmail.com",
      Password = "3452452"


    };

    UserReadDTO customerRead = customer1.ConvertToRead(); //to implement ReadDTO
    UserUpdateDTO customerUpdate = customer1.ConverToUpdate("Khalid"); //to implement UpdaeDTO





    Console.WriteLine(customerRead.Name);
    Console.WriteLine(customerRead.Email);

    Console.WriteLine("-------------");
    Console.WriteLine($"This is the updated Name: {customerUpdate.Name}");
    Console.WriteLine("-------------");



  }

}









