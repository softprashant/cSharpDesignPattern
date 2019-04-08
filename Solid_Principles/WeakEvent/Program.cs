using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakEvent
{
    class Button
    {
        public event EventHandler Clicked;

        public void Fire()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }

    class Window
    {
        public Window(Button button)
        {
            button.Clicked += Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked");
        }

        ~Window() // Destructor
        {
            Console.WriteLine("Destructor called : Window()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button();
            var window = new Window(button);

            button.Fire();
            Console.WriteLine("Setting window to null");
            window = null;
            FireGC();
        }

        private static void FireGC()
        {
            Console.WriteLine("Starting GC");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Console.WriteLine("GC Done");
            //   Console.Read();
        }
    }
}
