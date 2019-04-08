namespace DesignPatterns.APIShippedDay1
{
    public class PersonNameBuilder : PersonBuilder
    {
        public PersonNameBuilder SetName(string name)
        {
            person.Name = name;
            return this;
        }
    }
}