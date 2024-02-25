using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Helpers
{
    internal static class LoggerHelper
    {
        public static ILoggerFactory loggerFactory = new LoggerFactory();

        public static ILogger GetLogger(string categoryName)
        {
            loggerFactory.AddProvider(new LoggerProvider());

            return loggerFactory.CreateLogger(categoryName);
        }

        public static ILogger GetTextLogger(string categoryName)
        {
            string path =Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
            path = Path.Combine(Path.GetDirectoryName(path), "logs");

            loggerFactory.AddProvider(new TextLoggerProvider(path));

            return loggerFactory.CreateLogger(categoryName);
        }
    }
}
