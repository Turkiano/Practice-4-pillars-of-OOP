
namespace Practice;


class Program
{

  static void Main(string[] args)
  {
    IMessageService emailService = new EmailService();

    NotiicationService notificationService = new NotiicationService(emailService);

    notificationService.SendNotification("You recieved a package . . .");
  }

}









