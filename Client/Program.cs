using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.HelloWorldServiceReference;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consoleManager = new ConsoleManager();

            var userContinue = true;

            do
            {
                consoleManager.PrintMenu();

                var userSelectionMenu = consoleManager.ReadUserInputAsInt();

                if (userSelectionMenu == 10)
                {
                    userContinue = false;
                }
                else
                {
                    consoleManager.ReadUserSelectionMenu(userSelectionMenu);
                }

                
            } while (userContinue);

        }
    }
}
