using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var personBuilder = new PersonBuilder();
            Console.WriteLine(personBuilder.PersonalInfo.SetFirstName("Prashant").SetLastName("Verma")
                .PersonAddressInfo.SetAddress("Marteen Lutherweg").SetStreet("Amstelveen").Build());
            Console.ReadKey();
        }
    }
}
