
using System.Security.Cryptography.X509Certificates;

namespace Practice;


class Program //implementation file
{

  static void Main(string[] args)
  {

    ChannelName newChannel = new();
    newChannel.Name = "MBC";
    Console.WriteLine($"THis is the new CHannel: {newChannel.Name}");


  }




}









