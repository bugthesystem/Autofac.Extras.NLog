using NLog;

namespace Autofac.Extras.NLog.Tests
{
    public class SampleHandlerWithPropertyDependency : ISampleHandler
    {
        public Logger Logger { get; set; }

        public void SampleMessage(string message)
        {
            Logger.Debug(message);
        }
    }
}