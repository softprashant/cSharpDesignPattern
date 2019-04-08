using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawing = new ShapeGroup("My Drawing");
            drawing.Shapes.Value.Add(new Circle(2));
            drawing.Shapes.Value.Add(new Triangle(1, 2, 3));
            drawing.PrintToBoard();
            Console.ReadKey();
        }
    }

    internal class Triangle : Shape
    {
        private readonly int _i;
        private readonly int _i1;
        private readonly int _i2;

        public Triangle(int i, int i1, int i2)
        {
            _i = i;
            _i1 = i1;
            _i2 = i2;
        }

        public override void PrintToBoard()
        {
            Console.WriteLine($"Printed circle with dimension {_i} ," +
                              $" {_i1},{_i2}");

        }
    }


    internal class Circle : Shape
    {
        private readonly int _i;

        public Circle(int i)
        {
            _i = i;
        }

        public override void PrintToBoard()
        {
            Console.WriteLine($"Printed circle with radius {_i}");
        }
    }

    public abstract class Shape
    {
        public abstract void PrintToBoard();
    }

    public class ShapeGroup
    {
        public ShapeGroup(string name)
        {
            Console.WriteLine($"Group Name : {name}");
        }

        public Lazy<List<Shape>> Shapes  = new Lazy<List<Shape>>();

        public void PrintToBoard()
        {
            foreach (var shape in Shapes.Value)
            {
                shape.PrintToBoard();
            }
        }
    }
}
