using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class HelloService : IHelloService
    {
        public string Greeting(string name) => $"Hello, {name}";
    }
}
