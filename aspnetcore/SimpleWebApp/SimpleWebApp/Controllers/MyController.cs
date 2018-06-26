using SimpleWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Controllers
{
    public class MyController
    {
        private readonly IGreetingService _greetingService;
        public MyController(IGreetingService greetingService)
        {
            _greetingService = greetingService ?? throw new ArgumentNullException(nameof(greetingService));
        }

        public string Index(string name)
        {
            return _greetingService.Greeting(name);
        }
    }
}
