using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    public class TextLoggerProvider : ILoggerProvider
    {
        private string path;
        public TextLoggerProvider(string _path)
        {
            path = _path;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new TextLogger(path);
        }

        public void Dispose()
        {
        }
    }
}
