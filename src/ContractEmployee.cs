using System.Net.WebSockets;

namespace Practice
{


    class ContractEmployee : IEmpolyee //subClass 
    {
        public string GetManager() //implementing the interface methods 1
        {
            throw new NotImplementedException();
        }

        public string[] GetTeamMate() //implementing the interface methods 2
        {
            throw new NotImplementedException();
        }
    }
}