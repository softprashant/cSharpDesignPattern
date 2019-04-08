using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.APIShiipedWthRecursiveGenericsBuilderPattern
{
    public class PersonPositionBuilder<self> : PersonNameBuilder<self>
        where self : PersonPositionBuilder<self>
    {
        public self AddPosition(string position)
        {
            person.Position = position;
            return (self)this;
        }
    }
}
