using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers.LoginLogger
{
    public class LoginLoggerProvider : ILoggerProvider
    {

        private string path;
        public LoginLoggerProvider(string _path)
        {
            path = _path;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new LoginLogger(path);
        }

        public void Dispose()
        {
        }
    }
}
