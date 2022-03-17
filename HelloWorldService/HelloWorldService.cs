using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloWorldService
{
    public class HelloWorldService : IHelloWorld
    {
        public string SayHello(Person person)
        {
            return $"Hello {person.First} {person.Last}";
        }
    }
}
