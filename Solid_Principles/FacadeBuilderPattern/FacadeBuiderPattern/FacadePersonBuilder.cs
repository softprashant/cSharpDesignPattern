namespace FacadeBuilderPattern
{
    public class PersonBuilder // Facade means - not actually builing the person but responsible to delegate the creation of the person to small small builders

    {
        protected Person _person = new Person();

        public PersonAddressInformationBuilder PersonAddressInfo => new PersonAddressInformationBuilder(_person);
        public PersonPersonalInformationBuilder PersonalInfo => new PersonPersonalInformationBuilder(_person);

        public Person Build()
        {
            return _person;
        }
    }
}
