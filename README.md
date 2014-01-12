##Autofac Loggging Module for NLog

Nuget package [available](https://www.nuget.org/packages/Autofac.Extras.NLog/), to install package run the following command;

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
public class SampleClassWithConstructorDependency : ISampleClass
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
public class SampleClassWithPropertyDependency : ISampleClass
{
   public ILogger Logger { get; set; }
}
```
