using Microsoft.Extensions.DependencyInjection;
using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();

            var controller = Container.GetService<HomeController>();
            string greeting = controller.Index("Matthias");
            Console.WriteLine(greeting);
        }

        static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IHelloService, HelloService>();
            services.AddTransient<HomeController>();
            Container = services.BuildServiceProvider();
        }

        public static ServiceProvider Container { get; private set; }
    }
}
