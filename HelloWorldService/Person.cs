using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HelloWorldService
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string First;

        [DataMember]
        public string Last;
    }
}
