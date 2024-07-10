namespace Practice;


public class User
{ //class with fields & methods


    public string? Name {get; set;}//public field
    public string? Email {get; set;}  //public field
    public string? Password {get; set;} //private field
    public UserReadDTO ConvertToRead(){ //method to talk to DTO 
        return new UserReadDTO {Name = Name, Email = Email};
    }









}

