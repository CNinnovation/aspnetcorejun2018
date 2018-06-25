using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new HelloService();
            var controller = new HomeController(service);
            string greeting = controller.Index("Stephanie");
            Console.WriteLine(greeting);
        }
    }
}
