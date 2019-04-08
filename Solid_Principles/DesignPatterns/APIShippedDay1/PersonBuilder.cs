using DesignPatterns.APIShiipedWthRecursiveGenericsBuilderPattern;
using DesignPatterns.APIShippedDay1;

namespace DesignPatterns
{
    public abstract class PersonBuilder
    {
        protected Person person = new Person();

      
        public Person Build()
        {
            return person;
        }
    }
}