using DesignPatterns.APIShiipedWthRecursiveGenericsBuilderPattern;
using DesignPatterns.APIShippedDay1;
using DesignPatterns.APIShippedDay5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new PersonNameBuilder().SetName("Prashant").Build());

            //Console.ReadLine();

            // new PersonPositionBuilder().SetName("Prashant"). <Can't access the SetPosition since the return type is 
            // PersonNameBuilder so there should be a change needed to make sure it give me this method
            // We have to recursive generrics

            //Console.WriteLine(new PersonNameBuilder().New.SetName("Prashant").Build());

            Console.WriteLine(Person.New.SetName("Prashant").AddPosition("software engineer").Build());
            Console.ReadLine();
        }
    }
}