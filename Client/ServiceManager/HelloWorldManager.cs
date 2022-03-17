using Client.HelloWorldServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.ServiceManager
{
    internal class HelloWorldManager
    {
        private readonly HelloWorldClient _client;

        public HelloWorldManager()
        {
            _client = new HelloWorldClient("NetTcpBinding_IHelloWorld");
        }

        internal void SayHello()
        {
            Name person = new Name();

            Console.WriteLine("What's your firstname ?");
            person.First = Console.ReadLine();

            Console.WriteLine("What's your name ?");
            person.Last = Console.ReadLine();


            Console.WriteLine(_client.SayHello(person));
        }
    }
}
