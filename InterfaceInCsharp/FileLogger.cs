﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCsharp
{
    class FileLogger : ILogger
    {
        private readonly string logFilePath;

        public FileLogger(string filePath)
        {
            logFilePath = filePath;
        }
        public void LogError(string msg)
        {
            LogToFile("[FILE ERROR]" + msg);
        }

        public void LogInfo(string msg)
        {
            LogToFile("[FILE INFO]" + msg);
        }

        public void LogWarning(string msg)
        {
            LogToFile("[FILE WARNING]" + msg);
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
