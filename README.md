## Autofac Loggging Module for NLog

[![Build status](https://ci.appveyor.com/api/projects/status/vaf2xdm2fupo9f48/branch/master?svg=true)](https://ci.appveyor.com/project/johnnyasantoss/autofac-extras-nlog/branch/master)

Nuget package [available](https://www.nuget.org/packages/Autofac.Extras.NLog/), to install run the following command;

```csharp
Install-Package Autofac.Extras.NLog
```

### Register NLogModule to Autofac

**``It attaches to Component Registration and creates logger for requested type.``**
```csharp
containerBuilder.RegisterModule<NLogModule>();
```

### Register SimpleNLogModule to Autofac
**`` It is useful when ILogger resolved from Service Locator. ``**
```csharp
containerBuilder.RegisterModule<SimpleNLogModule>();
```

#### NLogModule and SimpleNLogModule supports both constructor and property injection.

* Constructor sample

```csharp
public class SampleClassWithConstructorDependency : ISampleInterface
{
    private readonly ILogger _logger;

    public SampleClassWithConstructorDependency(ILogger logger)
    {
      _logger = logger;
  }        
}
```
* Property Sample

```csharp  
public class SampleClassWithPropertyDependency : ISampleInterface
{
   public ILogger Logger { get; set; }
}
```

* Service Locator Sample

```csharp  
 public class SampleClassToResolveLoggerFromServiceLocator : ISampleClass
    {
        private readonly ILogger _logger;
        
        public SampleClassToResolveLoggerFromServiceLocator(ILifetimeScope serviceLocator)
        {
            _logger = serviceLocator.Resolve<ILogger>();
        }
    }
```
