using Common.Testing.NUnit;
using NUnit.Framework;

namespace Autofac.Extras.NLog.Tests
{
    public class NLogModuleTests : TestBase
    {
        private IContainer _container;
        protected override void FinalizeSetUp()
        {
            BuildSampleContainer();
        }

        private void BuildSampleContainer()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<NLogModule>();
            containerBuilder.RegisterType<SampleClassWithConstructorDependency>().Named<ISampleClass>("constructor");
            containerBuilder.RegisterType<SampleClassWithPropertyDependency>().Named<ISampleClass>("property");
            _container = containerBuilder.Build();
        }

        [Test]
        public void Inject_Logger_To_Constructor_Test()
        {
            ISampleClass sampleClass = _container.ResolveNamed<ISampleClass>("constructor");

            Assert.NotNull(sampleClass.GetLogger());
        }

        [Test]
        public void Inject_Logger_To_Property_Test()
        {
            ISampleClass sampleClass = _container.ResolveNamed<ISampleClass>("property");

            Assert.NotNull(sampleClass.GetLogger());
        }
    }
}
