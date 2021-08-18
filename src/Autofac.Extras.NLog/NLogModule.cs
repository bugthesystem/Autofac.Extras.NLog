using Autofac.Core;
using Autofac.Core.Registration;
using Autofac.Core.Resolving.Pipeline;

// Adapted from: log4net Integration Middleware
// https://autofaccn.readthedocs.io/en/latest/examples/log4net.html#log4net-integration-middleware

namespace Autofac.Extras.NLog
{
    public class NLogModule : Module
    {
        private readonly IResolveMiddleware middleware;

        public NLogModule()
        {
            middleware = new NLogMiddleware();
        }

        protected override void AttachToComponentRegistration(IComponentRegistryBuilder componentRegistry, IComponentRegistration registration)
        {
            // Attach to the registration's pipeline build.
            registration.PipelineBuilding += (sender, pipeline) =>
            {
                // Add our middleware to the pipeline.
                pipeline.Use(middleware);
            };
        }
    }
}
