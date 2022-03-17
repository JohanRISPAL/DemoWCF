using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace HelloWorldService
{
    [ServiceContract]
    public interface IHelloWorld
    {
        [OperationContract]
        string SayHello(Person person);
    }
}
