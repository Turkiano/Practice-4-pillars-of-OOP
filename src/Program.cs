
namespace Practice;


public class Student : Person
{// subclass(Student) inheriting from superclass(Person)



}

internal class Program
{

    static void Main(string[] args)
    {

        Student student = new(); //new object
        student.name = "Turkiano"; //using the inherited field from superclass
        Console.WriteLine(student.greeting()); //using the inherited method from superclass


    }
}








