using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PointFactory.MakeNormalPoint(1, 2);
            PointFactory.MakeTrigonometryPoint(12, 3);
        }
    }
}
