using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace NespSdkNetFramework.Utils
{
    public sealed class Log
    {
        public static string LogDirectory = "./";
        public static string LogFileName = "App.log";

        public static string LogFilePath = LogDirectory + LogFileName;


        public const int VERBOSE = 2;

        public const int DEBUG = 3;

        public const int INFO = 4;

        public const int WARN = 5;

        public const int ERROR = 6;

        public const int ASSERT = 7;

        public const int LOG_ID_MAIN = 0;

        public const int LOG_ID_RADIO = 1;

        public const int LOG_ID_EVENTS = 2;

        public const int LOG_ID_SYSTEM = 3;

        public const int LOG_ID_CRASH = 4;

        public static int V(string tag, string msg)
        {
            return Println(LOG_ID_MAIN, VERBOSE, tag, msg);
        }
        public static int V(string tag, Exception exception, string msg)
        {
            return Println(LOG_ID_MAIN, VERBOSE, tag, exception, msg);
        }

        public static int V(string tag, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, VERBOSE, tag, null, msg, args);
        }

        public static int V(string tag, Exception exception, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, VERBOSE, tag, exception, msg, args);
        }

        public static int D(string tag, string msg)
        {
            return Println(LOG_ID_MAIN, DEBUG, tag, msg);
        }

        public static int D(string tag, Exception exception, string msg)
        {
            return Println(LOG_ID_MAIN, DEBUG, tag, exception, msg);
        }

        public static int D(string tag, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, DEBUG, tag, null, msg, args);
        }

        public static int D(string tag, Exception exception, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, DEBUG, tag, exception, msg, args);
        }

        public static int I(string tag, string msg)
        {
            return Println(LOG_ID_MAIN, INFO, tag, msg);
        }

        public static int I(string tag, Exception exception, string msg)
        {
            return Println(LOG_ID_MAIN, INFO, tag, exception, msg);
        }

        public static int I(string tag, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, INFO, tag, null, msg, args);
        }

        public static int I(string tag, Exception exception, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, INFO, tag, exception, msg, args);
        }

        public static int W(string tag, string msg)
        {
            return Println(LOG_ID_MAIN, WARN, tag, msg);
        }

        public static int W(string tag, Exception exception, string msg)
        {
            return Println(LOG_ID_MAIN, WARN, tag, exception, msg);
        }

        public static int W(string tag, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, WARN, tag, null, msg, args);
        }

        public static int W(string tag, Exception exception, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, WARN, tag, exception, msg, args);
        }

        public static int E(string tag, string msg)
        {
            return Println(LOG_ID_MAIN, ERROR, tag, msg);
        }

        public static int E(string tag, Exception exception, string msg)
        {
            return Println(LOG_ID_MAIN, ERROR, tag, exception, msg);
        }

        public static int E(string tag, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, ERROR, tag, null, msg, args);
        }

        public static int E(string tag, Exception exception, string msg, params object[] args)
        {
            return Println(LOG_ID_MAIN, ERROR, tag, exception, msg, args);
        }


        private static int Println(int bufID, int priority, string tag, string msg)
        {
            return Println(bufID, priority, tag, null, msg, null);
        }

        private static int Println(int bufID, int priority, string tag, Exception exception, string msg, params object[] args)
        {
            string priorirtName = GetPriorityName(priority);

            if (args != null)
            {
                msg = string.Format(msg, args);
            }

            if (exception != null)
            {
                msg += "\n";
                msg += exception.ToString();
            }

            string logString =
           $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} " +
           $"{Process.GetCurrentProcess().Id}-{Thread.CurrentThread.ManagedThreadId} " +
           $"{priorirtName}/{tag}: {msg}";

            /// ConsoleColor currentForegroundColor = Console.ForegroundColor;
            /// Trace.ForegroundColor = GetConsoleColorWithPriority(priority);
            /// Trace.WriteLine(logString);
            /// Trace.ForegroundColor = currentForegroundColor;

            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }

            if (!File.Exists(LogFilePath))
            {
                File.Create(LogFilePath).Close();
            }

            StreamWriter streamWriter = File.AppendText(LogFilePath);
            streamWriter.WriteLine(logString);
            streamWriter.Flush();
            streamWriter.Close();
            return 0;
        }

        public static void DeleteLogFile()
        {
            if (File.Exists(LogFilePath))
            {
                File.Delete(LogFilePath);
            }
        }

        private static string GetPriorityName(int priority)
        {
            switch (priority)
            {
                case VERBOSE:
                    return "V";
                case DEBUG:
                    return "D";
                case INFO:
                    return "I";
                case WARN:
                    return "W";
                case ERROR:
                    return "E";
                case ASSERT:
                    return "A";
                default:
                    return "V";
            }
        }

        private static ConsoleColor GetConsoleColorWithPriority(int priorty)
        {
            if (priorty == ERROR)
            {
                return ConsoleColor.Red;
            }

            return ConsoleColor.White;
        }

    }
}
