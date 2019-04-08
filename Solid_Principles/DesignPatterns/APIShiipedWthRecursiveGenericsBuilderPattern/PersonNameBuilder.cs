using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.APIShiipedWthRecursiveGenericsBuilderPattern
{
    public class PersonNameBuilder<self> : PersonBuilder where
        self : PersonNameBuilder<self>
    {
        public self SetName(string name)
        {
            person.Name = name;
            return (self)this;
        }

    }
}
