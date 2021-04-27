using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.Contracts
{
   public interface ILoggerService
    {
        void LogInfo(string messege);
        void LogWarning(string messege);
        void LogDebug(string messege);
        void LogError(string messege);


    }
}
