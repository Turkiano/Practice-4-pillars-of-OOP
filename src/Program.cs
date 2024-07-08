
namespace Practice;


public class Student : Person {// subclass(Student) inheriting from superclass(Person)
    public override string greeting()
    {
        return $"Hello {name}, you are a Student";
    }

    public class Employee : Person {// subclass(Employee) inheriting from superclass(Person)
    public override string greeting()
    {
        return $"Hello {name}, you are an employee now!! ";
    }

}

internal class Program
{

  static void Main(string[] args)
  {
  
  Employee student = new(); //new object
  student.name = "Turkiano"; //using the inherited field from superclass
  Console.WriteLine(student.greeting()); //using the inherited method from superclass
  
  
 }} }








