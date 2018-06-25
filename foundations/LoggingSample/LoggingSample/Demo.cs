using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingSample
{
    public class Demo
    {
        private readonly ILogger<Demo> _logger;
        public Demo(ILoggerFactory loggerFactory)
        {
            if (loggerFactory == null) throw new ArgumentNullException(nameof(loggerFactory));
            _logger = loggerFactory.CreateLogger<Demo>();
        }

        public void DoSomething()
        {
            _logger.LogInformation("DoSomething invoked");
        }

        public void SomeError()
        {
            _logger.LogError("an error occurred");
        }
    }
}
