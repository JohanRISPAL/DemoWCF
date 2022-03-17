using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.CalculatorServiceReference;

namespace Client
{
    internal class CalculatorManager
    {
        CalculatorClient client;

        public CalculatorManager()
        {
            client = new CalculatorClient("NetTcpBinding_ICalculator");
        }

        internal void Addition()
        {
            var n1 = ReadUserInputAsInt("Select the first number");
            var n2 = ReadUserInputAsInt("Select the second number");

            Console.WriteLine(client.Addition(n1, n2));
        }

        private int ReadUserInputAsInt(string message)
        {
            var parseFailed = true;

            var number = 0;
            do
            {
                Console.WriteLine(message);
                var n1AsString = Console.ReadLine();

                try
                {
                    parseFailed = int.TryParse(n1AsString, out number);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!parseFailed);

            return number;
        }
    }
}
