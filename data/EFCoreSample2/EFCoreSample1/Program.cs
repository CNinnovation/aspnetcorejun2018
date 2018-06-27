using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreSample1
{
    class Program
    {
        private const string ConnectionString = @"server=(localdb)\mssqllocaldb;database=Books3;trusted_connection=true";
        static void Main(string[] args)
        {
            AppServices = RegisterServices();
            SampleData();
        }

        private static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<BooksContext>(options =>
            {
                options.UseSqlServer(ConnectionString);
            });
            services.AddTransient<MyController>();
            return services.BuildServiceProvider();
        }

        public static IServiceProvider AppServices { get; private set; }

        private static void SampleData()
        {
            var controller = AppServices.GetService<MyController>();
            controller.AddABook();
        }
    }
}
