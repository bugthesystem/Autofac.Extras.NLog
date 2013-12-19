using NUnit.Framework;

namespace Autofac.Extras.NLog.Tests
{
    public class NLogModuleTests : TestBase
    {
        private IContainer _container;
        protected override void FinalizeSetUp()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<LoggingModule>();
            containerBuilder.RegisterType<SampleHandlerWithConstructorDependency>().Keyed<ISampleHandler>("constructor");
            containerBuilder.RegisterType<SampleHandlerWithPropertyDependency>().Keyed<ISampleHandler>("property");
            _container = containerBuilder.Build();
        }

        [Test]
        public void Inject_Logger_To_Constructor_Test()
        {
            ISampleHandler sampleHandler = _container.ResolveKeyed<ISampleHandler>("constructor");
            sampleHandler.SampleMessage("test");
        }
        
        [Test]
        public void Inject_Logger_To_Property_Test()
        {
            ISampleHandler sampleHandler = _container.ResolveKeyed<ISampleHandler>("property");
            sampleHandler.SampleMessage("test");
        }
    }
}
