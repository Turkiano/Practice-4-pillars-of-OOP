namespace Practice
{


    class PersonManager
    {
        private Logger _logger; //superClass property

        public PersonManager(Logger logger) //DI constructor 
        {
            _logger = logger;
        }
        



        private string[] _person = []; //property of empty array
        public void AddPerson(string person) //DI method 
        {
            _person.Append(person);
            _logger.log($"{person} is added");
        }

    }


}