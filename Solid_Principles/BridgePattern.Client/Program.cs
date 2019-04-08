using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EnvironmentMessage.API;
using static System.Console;

namespace BridgePattern.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageToUser =
                new ExceptionMessageToUser(new ProductionEnvironment(), //Should come from dependency injection container
                "Error is thrown!!");

            messageToUser.ShowConsoleMessage();
            messageToUser.ShowConsoleMessage();
            messageToUser.ShowConsoleMessage();

            ReadKey();
        }
    }


}
