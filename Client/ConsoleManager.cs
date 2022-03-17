using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    internal class ConsoleManager
    {
        private readonly HelloWorldManager _helloWorldManager;
        private readonly CalculatorManager _calculatorManager;

        public ConsoleManager()
        {
            _helloWorldManager = new HelloWorldManager();
            _calculatorManager = new CalculatorManager();
        }

        internal void PrintMenu()
        {
            Console.WriteLine("Welcome to my wcf demo project !");
            Console.WriteLine("1 - Say hello with your name");
            Console.WriteLine("2 - Add two numbers");
            Console.WriteLine("10 - Exit");
        }

        internal string ReadUserInput()
        {
            return Console.ReadLine();
        }

        internal int ReadUserInputAsInt()
        {
            var userInputAsInt = 0;
            try
            {
                var userInput = Console.ReadLine();

                int.TryParse(userInput, out userInputAsInt);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return userInputAsInt;
        }

        internal void ReadUserSelectionMenu(int userSelectionMenu)
        {
            switch (userSelectionMenu)
            {
                case 1:
                    _helloWorldManager.SayHello();
                    break;

                case 2:
                    _calculatorManager.Addition();
                    break;

            }
                
        }
    }
}
