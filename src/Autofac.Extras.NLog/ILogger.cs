using System;

namespace Autofac.Extras.NLog
{
    public interface ILogger
    {
        void Debug(string message);
        void DebugException(string message, Exception exception);

        void Error(string message);
        void ErrorException(string message, Exception exception);

        void Info(string message);
        void InfoException(string message, Exception exception);

        void Warn(string message);
        void WarnException(string message, Exception exception);

        void Fatal(string message);
        void FatalException(string message, Exception exception);
    }
}
