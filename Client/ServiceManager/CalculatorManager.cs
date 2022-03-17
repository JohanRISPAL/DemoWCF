using System;
using Client.CalculatorServiceReference;

namespace Client.ServiceManager
{
    internal class CalculatorManager
    {
        private readonly CalculatorClient _client;

        public CalculatorManager()
        {
            _client = new CalculatorClient("NetTcpBinding_ICalculator");
        }

        internal void Addition()
        {
            var n1 = ReadUserInputAsInt("Select the first number");
            var n2 = ReadUserInputAsInt("Select the second number");

            Console.WriteLine(_client.Addition(n1, n2));
        }

        internal void Substraction()
        {
            var n1 = ReadUserInputAsInt("Select the first number");
            var n2 = ReadUserInputAsInt("Select the second number");

            Console.WriteLine(_client.Substraction(n1, n2));
        }

        internal void Multiple()
        {
            var n1 = ReadUserInputAsInt("Select the first number");
            var n2 = ReadUserInputAsInt("Select the second number");

            Console.WriteLine(_client.Multiple(n1, n2));
        }

        internal void Divide()
        {
            var n1 = ReadUserInputAsInt("Select the first number");
            var n2 = ReadUserInputAsInt("Select the second number");

            Console.WriteLine(_client.Divide(n1, n2));
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
