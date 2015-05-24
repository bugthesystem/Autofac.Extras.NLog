using NLog;
// ReSharper disable RedundantUsingDirective
using Module = Autofac.Module;
// ReSharper restore RedundantUsingDirective

namespace Autofac.Extras.NLog
{
    public class SimpleNLogModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .Register(context => new LoggerAdapter(LogManager.GetCurrentClassLogger()))
                .As<ILogger>()
                .SingleInstance();
        }
    }
}
