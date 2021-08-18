using Autofac;
using Autofac.Extras.NLog;
using NLog;
using System;

namespace Sample.ConsoleApp
{
    class Program
    {
        private static IContainer Container { get; set; }

        private readonly ILogger _logger;

        static void Main(string[] args)
        {
            try
            {
                var builder = new ContainerBuilder();
                builder.RegisterModule<NLogModule>();
                builder.RegisterType<Program>();
                Container = builder.Build();

                // Create a scope to resolve dependencies rather than resolving
                // from the container itself.
                //
                // See https://autofac.readthedocs.io/en/latest/best-practices/index.html#always-resolve-dependencies-from-nested-lifetimes
                //
                using var scope = Container.BeginLifetimeScope();
                var program = scope.Resolve<Program>();
                program.Run();
            }
            finally
            {
                LogManager.Shutdown();
            }

            Console.Write("\nPress [Enter] to continue...");
            Console.ReadLine();
        }

        public Program(ILogger logger)
        {
            _logger = logger;
        }

        void Run()
        {
            _logger.Info("Hello World");
        }
    }
}
