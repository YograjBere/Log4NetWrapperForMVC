using System;
using log4net;

namespace LoggerLibrary
{
    public class Logger : ILogger
    {
        private ILog _logger;

        public Logger(Type type)
        {
            log4net.Config.XmlConfigurator.Configure();
            _logger = log4net.LogManager.GetLogger(type);
        }

        public bool IsDebugEnalbed
        {
            get
            {
                return _logger.IsDebugEnabled;
            }
        }

        public bool IsErrorEnalbed
        {
            get
            {
                return _logger.IsErrorEnabled;
            }
        }

        public bool IsFatalEnalbed
        {
            get
            {
                return _logger.IsFatalEnabled;
            }
        }

        public bool IsInfoEnalbed
        {
            get
            {
                return _logger.IsInfoEnabled;
            }
        }

        public bool IsWarnEnalbed
        {
            get
            {
                return _logger.IsWarnEnabled;
            }
        }

        public void Debug(object message)
        {
            if (_logger.IsDebugEnabled)
            {
                _logger.Debug(message);
            }
        }

        public void Error(object message)
        {
            if (_logger.IsErrorEnabled)
            {
                _logger.Error(message);
            }
        }

        public void Fatal(object message)
        {
            if (_logger.IsFatalEnabled)
            {
                _logger.Fatal(message);
            }
        }

        public void Info(object message)
        {
            if (_logger.IsInfoEnabled)
            {
                _logger.Info(message);
            }
        }

        public void Warn(object message)
        {
            if (_logger.IsWarnEnabled)
            {
                _logger.Warn(message);
            }
        }
    }

    public class LogManager
    {
        public static ILogger GetLogger()
        {
            return new Logger(typeof(Logger));
        }
    }
}
