namespace Autofac.Extras.NLog.Tests
{
    public class SampleClassToResolveLoggerFromServiceLocator : ISampleClass
    {
        private readonly ILogger _logger;
        public SampleClassToResolveLoggerFromServiceLocator(ILifetimeScope serviceLocator)
        {
            _logger = serviceLocator.Resolve<ILogger>();
        }

        public void SampleMessage(string message)
        {
            _logger.Debug(message);
        }

        public ILogger GetLogger()
        {
            return _logger;
        }
    }
}
