using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ComplexModelBinderBug
{
    public class Logger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            Serilog.Log.Debug(state.ToString());
            // Console.WriteLine(state.ToString());
            if (exception != null)
            {
                Serilog.Log.Error(exception, "Log");
                // Console.WriteLine(exception.ToString());
            }
        }
    }
}
