using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        string Addition(int n1, int n2);

        [OperationContract]
        string Substraction(int n1, int n2);

        [OperationContract]
        string Multiple(int n1, int n2);

        [OperationContract]
        string Divide(int n1, int n2);
    }
}
