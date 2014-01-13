using NLog;

namespace Autofac.Extras.NLog.Tests
{
    public interface ISampleClass
    {
        void SampleMessage(string message);
        Logger GetLogger();
    }
}