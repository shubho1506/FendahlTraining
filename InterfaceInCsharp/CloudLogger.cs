using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCsharp
{
    class CloudLogger : ILogger
    {
        private readonly string logFilePath;

        public CloudLogger(string filePath)
        {
            logFilePath = filePath;
        }
        public void LogError(string msg)
        {
            LogToFile("[CLOUD ERROR]" + msg);
        }

        public void LogInfo(string msg)
        {
            LogToFile("[CLOUD INFO]" + msg);
        }

        public void LogWarning(string msg)
        {
            LogToFile("[CLOUD WARNING]" + msg);
        }

        private void LogToFile(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now} {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Logging failed: {ex.Message}");
            }
        }
    }
}
