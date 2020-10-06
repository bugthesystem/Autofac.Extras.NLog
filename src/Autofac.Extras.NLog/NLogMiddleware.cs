using Autofac.Core;
using Autofac.Core.Resolving.Pipeline;
using NLog;
using System.Linq;
using System.Reflection;

// Adapted from: log4net Integration Middleware
// https://autofaccn.readthedocs.io/en/latest/examples/log4net.html#log4net-integration-middleware

namespace Autofac.Extras.NLog
{
    internal class NLogMiddleware : IResolveMiddleware
    {
        public PipelinePhase Phase => PipelinePhase.ParameterSelection;

        public void Execute(ResolveRequestContext context, System.Action<ResolveRequestContext> next)
        {
            // Add our parameters.
            context.ChangeParameters(context.Parameters.Union(
                new[]
                {
                    new ResolvedParameter(
                        (p, i) => p.ParameterType == typeof (ILogger),
                        (p, i) => LogManager.GetLogger(p.Member.DeclaringType.FullName))
                }));

            // Continue the resolve.
            next(context);

            // Has an instance been activated?
            if (context.NewInstanceActivated)
            {
                var instanceType = context.Instance.GetType();

                // Get all the injectable properties to set.
                // If you wanted to ensure the properties were only UNSET properties,
                // here's where you'd do it.
                var properties = instanceType
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.PropertyType == typeof(ILogger) && p.CanWrite && p.GetIndexParameters().Length == 0);

                // Set the properties located.
                foreach (var propToSet in properties)
                {
                    propToSet.SetValue(context.Instance, LogManager.GetLogger(instanceType.FullName), null);
                }
            }
        }
    }
}
