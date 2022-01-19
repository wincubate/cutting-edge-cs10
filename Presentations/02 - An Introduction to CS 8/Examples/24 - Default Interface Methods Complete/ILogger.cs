using System;

namespace Wincubate.CS8.Slide24
{
    enum LogLevel
    {
        Error,
        Info,
        Debug
    }

    interface ILogger
    {
        void Log(LogLevel level, string message);
        void Log(Exception exception) => Log(LogLevel.Error, exception.ToString());
    }
}
