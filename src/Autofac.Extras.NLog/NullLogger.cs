﻿using System;
using NLog;

namespace Autofac.Extras.NLog
{
    public class NullLogger :ILogger
    {
        public event EventHandler<EventArgs> LoggerReconfigured;
        public string Name { get; set; }
        public LogFactory Factory { get; set; }
        public bool IsTraceEnabled { get; set; }
        public bool IsDebugEnabled { get; set; }
        public bool IsInfoEnabled { get; set; }
        public bool IsWarnEnabled { get; set; }
        public bool IsErrorEnabled { get; set; }
        public bool IsFatalEnabled { get; set; }

        public bool IsEnabled(LogLevel level)
        {
            return true;
        }

        public void Log(LogEventInfo logEvent)
        {
            
        }

        public void Log(Type wrapperType, LogEventInfo logEvent)
        {
            
        }

        public void Log<T>(LogLevel level, T value)
        {
            
        }

        public void Log<T>(LogLevel level, IFormatProvider formatProvider, T value)
        {
            
        }

        public void LogException(LogLevel level, string message, Exception exception)
        {
            
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, params object[] args)
        {
            
        }

        public void Log(LogLevel level, string message)
        {
            
        }

        public void Log(LogLevel level, string message, params object[] args)
        {
            
        }

        public void Log<TArgument>(LogLevel level, IFormatProvider formatProvider, string message, TArgument argument)
        {
            
        }

        public void Log<TArgument>(LogLevel level, string message, TArgument argument)
        {
            
        }

        public void Log<TArgument1, TArgument2>(LogLevel level, IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            
        }

        public void Log<TArgument1, TArgument2>(LogLevel level, string message, TArgument1 argument1, TArgument2 argument2)
        {
            
        }

        public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, IFormatProvider formatProvider, string message,
            TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            
        }

        public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            
        }

        public void Trace<T>(T value)
        {
            
        }

        public void Trace<T>(IFormatProvider formatProvider, T value)
        {
            
        }

        public void Trace(string message, Exception exception)
        {
            
        }

        public void Trace(IFormatProvider formatProvider, string message, params object[] args)
        {
            
        }

        public void Trace(string message)
        {
            
        }

        public void Trace(string message, params object[] args)
        {
            
        }

        public void Trace<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            
        }

        public void Trace<TArgument>(string message, TArgument argument)
        {
            
        }

        public void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            
        }

        public void Trace<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            
        }

        public void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            
        }

        public void Trace<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            
        }

        public void Debug<T>(T value)
        {
            
        }

        public void Debug<T>(IFormatProvider formatProvider, T value)
        {
            
        }

        public void Debug(string message, Exception exception)
        {
            
        }

        public void Debug(IFormatProvider formatProvider, string message, params object[] args)
        {
            
        }

        public void Debug(string message)
        {
            
        }

        public void Debug(string message, params object[] args)
        {
            
        }

        public void Debug<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            
        }

        public void Debug<TArgument>(string message, TArgument argument)
        {
            
        }

        public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            
        }

        public void Debug<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            
        }

        public void Info<T>(T value)
        {
            
        }

        public void Info<T>(IFormatProvider formatProvider, T value)
        {
            
        }

        public void Info(string message, Exception exception)
        {
            
        }

        public void Info(IFormatProvider formatProvider, string message, params object[] args)
        {
            
        }

        public void Info(string message)
        {
            
        }

        public void Info(string message, params object[] args)
        {
            
        }

        public void Info<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            
        }

        public void Info<TArgument>(string message, TArgument argument)
        {
            
        }

        public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            
        }

        public void Info<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            
        }

        public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            
        }

        public void Info<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            
        }

        public void Warn<T>(T value)
        {
            
        }

        public void Warn<T>(IFormatProvider formatProvider, T value)
        {
            
        }

        public void Warn(string message, Exception exception)
        {
            
        }

        public void Warn(IFormatProvider formatProvider, string message, params object[] args)
        {
            
        }

        public void Warn(string message)
        {
            
        }

        public void Warn(string message, params object[] args)
        {
            
        }

        public void Warn<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            
        }

        public void Warn<TArgument>(string message, TArgument argument)
        {
            
        }

        public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            
        }

        public void Warn<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            
        }

        public void Error<T>(T value)
        {
            
        }

        public void Error<T>(IFormatProvider formatProvider, T value)
        {
            
        }

        public void Error(string message, Exception exception)
        {
            
        }

        public void Error(IFormatProvider formatProvider, string message, params object[] args)
        {
            
        }

        public void Error(string message)
        {
            
        }

        public void Error(string message, params object[] args)
        {
            
        }

        public void Error<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            
        }

        public void Error<TArgument>(string message, TArgument argument)
        {
            
        }

        public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            
        }

        public void Error<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            
        }

        public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            
        }

        public void Error<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            
        }

        public void Fatal<T>(T value)
        {
            
        }

        public void Fatal<T>(IFormatProvider formatProvider, T value)
        {
            
        }

        public void Fatal(string message, Exception exception)
        {
            
        }

        public void Fatal(IFormatProvider formatProvider, string message, params object[] args)
        {
            
        }

        public void Fatal(string message)
        {
            
        }

        public void Fatal(string message, params object[] args)
        {
            
        }

        public void Fatal<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            
        }

        public void Fatal<TArgument>(string message, TArgument argument)
        {
            
        }

        public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2)
        {
            
        }

        public void Fatal<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
            TArgument2 argument2, TArgument3 argument3)
        {
            
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
            TArgument3 argument3)
        {
            
        }

        protected virtual void OnLoggerReconfigured()
        {
            LoggerReconfigured?.Invoke(this, EventArgs.Empty);
        }
    }
}