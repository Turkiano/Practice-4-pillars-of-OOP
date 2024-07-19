using System.CodeDom.Compiler;

namespace Practice
{

    class Client  
    {
        private ISet? _Iset; //superClass property

        public void run(ISet iset) //inject the superclass as param
        {

            _Iset = iset; //assign the property to the DI
            Console.WriteLine("Start");
            _Iset.print(); //run the method from the subClass

        }
    }

}