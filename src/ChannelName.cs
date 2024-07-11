using System.Net.WebSockets;

namespace Practice
{


    class ChannelName : ChName //subClass 
    {

            public string? name;

            public override string Name{
                get { return name;}
                set {name = value;}
            }

    }
}