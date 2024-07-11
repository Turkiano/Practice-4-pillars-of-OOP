namespace Practice
{

    public abstract class User //this is the superclass (parent)
    {


        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool Verified { get; set; } = false;

        public abstract void Greeting(); //this is abstract method
        // {
        //     // Console.WriteLine($"Hi, my name is{FullName}" );
            
        // }
        public string FullName
        {
            get{return FirstName + " " + LastName;}
        }
    }


}

