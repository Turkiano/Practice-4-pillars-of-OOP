
namespace Practice;


public class Program
{

  static void Main(string[] args)
  {

    Math total = new(); //new object

    var result = total.Multiply(1, 3); //1st method
    var result2 = total.Multiply(1, 3, 4); //2nd method


    Console.WriteLine($"the first result is: {result}");
    Console.WriteLine($"the second result is: {result2}");




  }


}








