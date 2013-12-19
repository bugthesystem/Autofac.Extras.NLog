using NLog;

namespace Autofac.Extras.NLog.Tests
{
    public class SampleHandlerWithConstructorDependency : ISampleHandler
    {
        private readonly Logger _logger;

        public SampleHandlerWithConstructorDependency(Logger logger)
        {
            _logger = logger;
        }

        public void SampleMessage(string message)
        {
            _logger.Debug(message);
        }
    }
}