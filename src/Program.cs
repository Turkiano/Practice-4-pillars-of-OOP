
using System.Security.Cryptography.X509Certificates;

namespace Practice;


class Program
{

  static void Main(string[] args)
  {
    Program myProgram = new();
    myProgram.DoSomething();

  }

  public void DoSomething()
  {
    Student newStudent = new();
    newStudent.FirstName = "Turkiano";
    newStudent.Verified = true;
    newStudent.Greeting();

  }



}









