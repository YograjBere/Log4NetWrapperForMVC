using System.Collections.Generic;

namespace LoggerLibrary
{
    public interface ILogger
    {
        bool IsDebugEnalbed { get; }
        bool IsWarnEnalbed { get; }
        bool IsErrorEnalbed { get; }
        bool IsInfoEnalbed { get; }
        bool IsFatalEnalbed { get; }

        void Debug(object message);
        void Warn(object message);
        void Error(object message);
        void Info(object message);
        void Fatal(object message);
    }
}
