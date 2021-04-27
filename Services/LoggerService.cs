using ApiDemo.Contracts;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.Services
{
    public class LoggerService : ILoggerService
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string messege)
        {
            logger.Debug(messege);
        }

        public void LogError(string messege)
        {
            logger.Error(messege);
        }

        public void LogInfo(string messege)
        {
            logger.Info(messege);
        }

        public void LogWarning(string messege)
        {
            logger.Warn(messege);
        }
    }
}
