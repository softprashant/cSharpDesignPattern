using DesignPatterns.APIShippedDay1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.APIShippedDay5
{
    class PersonPositionBuilder : PersonNameBuilder
    {
        public PersonPositionBuilder SetPosition(string position)
        {
            person.Position = position;
            return this;
            // ISSUE : 
        }
    }
}
