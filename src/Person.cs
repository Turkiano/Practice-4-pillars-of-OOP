namespace Practice;


public class Person
{

    public string? name; //public field
                         // public Person(string Name) //this is the constructor
                         // { _name = Name; }



    public virtual string greeting() //this is the greeting method
    { return $"Hello {name}"; }




}


