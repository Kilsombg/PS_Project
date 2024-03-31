using DataLayer.Database;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers.DBLogger
{
    public class DBLogger : ILogger
    {
        public DBLogger(DBLogContext context)
        {
            this.context = context;
        }

        public DBLogContext context { get; }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            context.Add(new DBLog()
            {
                Message = formatter(state, exception),
                LogLevel = logLevel
            });
            context.SaveChanges();
        }
    }
}
