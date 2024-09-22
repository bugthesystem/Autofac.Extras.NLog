﻿using NUnit.Framework;

namespace Autofac.Extras.NLog.Tests
{
    public class NLogModuleTests
    {
        private IContainer _container;

        [SetUp]
        public void FinalizeSetUp()
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
            Assert.That(sampleClass.GetLogger(), Is.Not.Null);
        }

        [Test]
        public void Inject_Logger_To_Property_Test()
        {
            ISampleClass sampleClass = _container.ResolveNamed<ISampleClass>("property");
            Assert.That(sampleClass.GetLogger(), Is.Not.Null);
        }
    }
}