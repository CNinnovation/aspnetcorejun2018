using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace LoggingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();
            var d = Container.GetService<Demo>();
            d.DoSomething();
            d.SomeError();
            Console.ReadLine();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddLogging(config =>
            {
                config.AddConsole().AddDebug();
            });
            services.AddTransient<Demo>();
            Container = services.BuildServiceProvider();
        }
        public static IServiceProvider Container { get; private set; }
    }
}
