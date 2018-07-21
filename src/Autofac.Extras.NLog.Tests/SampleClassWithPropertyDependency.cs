using NLog;

namespace Autofac.Extras.NLog.Tests
{
    public class SampleClassWithPropertyDependency : ISampleClass
    {
        public ILogger Logger { get; set; }

        public void SampleMessage(string message)
        {
            Logger.Debug(message);
        }

        public ILogger GetLogger()
        {
            return Logger;
        }
    }
}