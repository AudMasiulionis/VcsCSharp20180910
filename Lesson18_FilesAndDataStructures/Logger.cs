using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_FilesAndDataStructures
{
    public static class Logger
    {
        private static string logPath = "c:/temp/logs";

        public static void Log(string content)
        {
            //checking if directory exists
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            var logName = $"log-{DateTime.Now.ToString("yyyy-MM-dd")}.log";
            if (!File.Exists(logPath + "/" + logName))
            {
                File.Create(logPath + "/" + logName);
            }

            using (var writer = new StreamWriter(logPath + "/" + logName, true))
            {
                writer.WriteLine(content);
            }
        }
    }
}
