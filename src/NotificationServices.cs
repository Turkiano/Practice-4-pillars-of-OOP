namespace Practice
{



  public class NotiicationService
  {

//superClass Property
    private readonly IMessageService _messageService;



  //Constructor Injection
    public NotiicationService(IMessageService messageService)
    {
      _messageService = messageService;
    }



//Injecting the superClass property inside the method body

    public void SendNotification(string message)
    {
      _messageService.SendMessage(message);
    }

  }
}