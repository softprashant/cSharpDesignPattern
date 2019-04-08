using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Point.Factory.MakeNormalPoint(1, 3);
            Point.Factory.MakeTrigonometryPoint(23, 23);
        }
    }
}
