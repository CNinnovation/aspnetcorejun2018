using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Services
{
    public class GreetingService : IGreetingService
    {
        public string Greeting(string name) => $"Hello, {name}";
    }
}
