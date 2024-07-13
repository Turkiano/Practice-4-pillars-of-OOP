namespace Practice
{



  public class NotiicationService
  {

    private readonly IMessageService _messageService;
    public NotiicationService(IMessageService messageService)
    {
      _messageService = messageService;
    }

  }
}