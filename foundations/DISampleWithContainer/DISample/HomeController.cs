using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class HomeController
    {
        private readonly IHelloService _helloService;
        public HomeController(IHelloService helloService)
        {
            _helloService = helloService ?? throw new ArgumentNullException(nameof(helloService));
        }
        public string Index(string name)
        {
            //var helloService = new HelloService();
            //return helloService.Greeting(name);
            return _helloService.Greeting(name);
        }
    }
}
