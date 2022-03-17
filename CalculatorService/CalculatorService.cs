using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorService
{
    public class CalculatorService : ICalculator
    {
        public string Addition(int n1, int n2)
        {
            var result = n1 + n2;
            return $"{n1} + {n2} = {result}";
        }

        public string Substraction(int n1, int n2)
        {
            var result = n1 - n2;
            return $"{n1} - {n2} = {result}";
        }

        public string Multiple(int n1, int n2)
        {
            var result = n1 * n2;
            return $"{n1} x {n2} = {result}";
        }

        public string Divide(int n1, int n2)
        {
            var result = n1 / n2;
            return $"{n1} ÷ {n2} = {result}";
        }
    }
}
