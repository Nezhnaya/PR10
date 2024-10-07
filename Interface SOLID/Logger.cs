using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface_SOLID
{
    // Single Responsibility Principle (SRP)
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }
    public class FileLogger : Logger
    {
        public void LogToFile(string message)
        {
            Console.WriteLine($"Logging to file: {message}");
        }
    }

    public class DatabaseLogger : Logger
    {
        public void LogToDatabase(string message)
        {
            Console.WriteLine($"Logging to database: {message}");
        }
    }
}
