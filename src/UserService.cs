namespace Practice
{



  public class UserService 
  {

//Property Injector
    public  ILogger Logger {get; set;}



  public void CreateUser(string userName){
    //Perform user Creation Logic
    Logger.Log($"User '{userName}' created successfully.");
  }




  }
}