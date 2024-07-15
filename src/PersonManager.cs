namespace Practice
{


    class PersonManager
    {
        private ILogger _logger; //superClass property

        public PersonManager(ILogger logger) //DI constructor 
        {
            _logger = logger;
        }
        



        private string[] _person = []; //property of empty array
        public void AddPerson(string person) //DI method 
        {
            _person.Append(person);
            _logger.Log($"{person} is added");
        }

    }


}