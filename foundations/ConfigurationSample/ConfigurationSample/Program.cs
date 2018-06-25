using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConfigurationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.staging.json")
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();


            string val1 = config["MySetting1"];
            Console.WriteLine(val1);

            var conn1 = config.GetSection("ConnectionStrings")["Connection1"];
            Console.WriteLine(conn1);

            var conn2 = config.GetConnectionString("Connection1");
            Console.WriteLine(conn2);
        }
    }
}
