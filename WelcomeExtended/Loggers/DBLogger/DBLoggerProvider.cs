using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers.DBLogger
{
    public class DBLoggerProvider
    {
        public DBLoggerProvider()
        {
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DBLogger();
        }

        public void Dispose()
        {
        }
    }
}
