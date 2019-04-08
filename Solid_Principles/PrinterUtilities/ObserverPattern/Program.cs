using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Person
    {
        public void CatchACold()
        {
            FallsIll?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler<EventArgs> FallsIll;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FallsIll += Person_FallsIll;
            person.CatchACold();
        }

        private static void Person_FallsIll(object sender, EventArgs e)
        {

        }
    }
}
