namespace FacadeBuilderPattern
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Street { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return $"FirstName : {FirstName} LastName : {LastName} , Address : {Address} Street  : {Street}";
        }
    }
}