using DesignPatterns.APIShiipedWthRecursiveGenericsBuilderPattern;

namespace DesignPatterns.APIShippedDay1
{
    public class Person
    {

        public static Builder New => new Builder();

        public string Name { get; set; }
        public string Position { get; set; }
        public class Builder : PersonPositionBuilder<Builder>
        {

        }
        public override string ToString()
        {
            return $"Your name is {Name} and you hold {Position} ";
        }
    }
}