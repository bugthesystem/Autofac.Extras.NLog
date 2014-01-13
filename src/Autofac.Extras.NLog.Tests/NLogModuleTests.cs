using NLog;
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
            containerBuilder.RegisterType<SampleClassWithConstructorDependency>().Keyed<ISampleClass>("constructor");
            containerBuilder.RegisterType<SampleClassWithPropertyDependency>().Keyed<ISampleClass>("property");
            _container = containerBuilder.Build();
        }

        [Test]
        public void Inject_Logger_To_Constructor_Test()
        {
            ISampleClass sampleClass = _container.ResolveKeyed<ISampleClass>("constructor");

            Assert.NotNull(sampleClass.GetLogger());
        }

        [Test]
        public void Inject_Logger_To_Property_Test()
        {
            ISampleClass sampleClass = _container.ResolveKeyed<ISampleClass>("property");

            Assert.NotNull(sampleClass.GetLogger());
        }
    }
}
