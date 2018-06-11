using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace InterestRateCalculator.Services.Implementations
{
    public class WriterService : ILogger, IDisposable
    {
        private readonly StreamWriter _writer;

        public WriterService(StreamWriter writer)
        {
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return this;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            try
            {
                _writer.WriteLine($"{formatter(state, exception)}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Dispose()
        {

        }
    }
}
