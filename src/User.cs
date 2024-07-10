namespace Practice
{




    public class User
    { //class with fields & methods


        public string? Name { get; set; }//public field
        public string? Email { get; set; }  //public field
        public string? Password { get; set; } //public field
        public UserReadDTO ConvertToRead() //method to talk to ReadDTO
        {
            return new UserReadDTO { Name = Name, Email = Email };
        }

        public UserUpdateDTO ConverToUpdate(string name) //method to talk to UpdateDTO 
        {
            return new UserUpdateDTO { Name = name, };
        }
    }


}

