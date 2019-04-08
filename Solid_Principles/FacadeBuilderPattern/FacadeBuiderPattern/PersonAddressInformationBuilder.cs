namespace FacadeBuilderPattern
{
    public class PersonAddressInformationBuilder : PersonBuilder
    {
        public PersonAddressInformationBuilder(Person p)
        {
            _person = p;
        }

        public PersonAddressInformationBuilder SetStreet(string street)
        {
            _person.Street = street;
            return this;
        }

        public PersonAddressInformationBuilder SetAddress(string address)
        {
            _person.Address = address;
            return this;
        }

    }
}