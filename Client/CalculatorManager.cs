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
            var parseFailed = true;
            var n1 = 0;
            var n2 = 0;

            do
            {
                Console.WriteLine("Select the first number");
                var n1AsString = Console.ReadLine();

                try
                {
                    parseFailed = int.TryParse(n1AsString, out n1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!parseFailed);

            do
            {
                Console.WriteLine("Select the second number");
                var n2AsString = Console.ReadLine();

                try
                {
                    parseFailed = int.TryParse(n2AsString, out n2);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!parseFailed);

            Console.WriteLine(client.Addition(n1, n2));
        }
    }
}
