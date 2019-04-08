namespace FacadeBuilderPattern
{
    public class PersonPersonalInformationBuilder : PersonBuilder
    {
        public PersonPersonalInformationBuilder(Person p)
        {
            _person = p;
        }

        public PersonPersonalInformationBuilder SetFirstName(string firstName)
        {
            _person.FirstName = firstName;
            return this;
        }

        public PersonPersonalInformationBuilder SetLastName(string lastname)
        {
            _person.LastName = lastname;
            return this;
        }
    }
}
