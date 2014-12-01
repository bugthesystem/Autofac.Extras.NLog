##Autofac Loggging Module for NLog

Nuget package [available](https://www.nuget.org/packages/Autofac.Extras.NLog/), to install run the following command;

```csharp
Install-Package Autofac.Extras.NLog
```

###Register NLogModule to Autofac

```csharp
ContainerBuilder containerBuilder = new ContainerBuilder();
   
containerBuilder.RegisterModule<NLogModule>();
  
Container _container = containerBuilder.Build();
```

###It supports both constructor and property injection.

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
