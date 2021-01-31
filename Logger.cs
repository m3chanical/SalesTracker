using System;
using System.Collections.Generic;
using System.Windows.Media;
using Clio.Utilities;


using rlogging = ff14bot.Helpers.Logging;

namespace SalesTracker
{

    internal static class LogColors
    {
        internal static Color Error => Colors.OrangeRed;
        internal static Color Info => Colors.MediumOrchid;
        internal static Color Verbose => Colors.BlueViolet;
        internal static Color Warn => Colors.Goldenrod;
    }
    public class Logger
    {
        public static List<string> LogList = new List<string>();
        internal static bool log_verbose = false;
        internal static string Name => "Sales Report";
        internal static string Prefix => $"[{Name}] ";
        private static void Log(Color c, string message, object[] args) {
            rlogging.Write(c, Prefix + string.Format(message, args));

            var logStr = "[" + DateTime.Now + "]" + " " + Prefix + string.Format(message, args);
            if (LogList.Count >= 50)
                LogList.RemoveAt(0);
            if (!LogList.Contains(logStr))
                LogList.Add(logStr);
        }

        [StringFormatMethod("format")]
        internal static void Error(string message, params object[] args) {
            Log(LogColors.Error, message, args);
        }

        public static void Info(string message, params object[] args) {
            Log(LogColors.Info, message, args);
        }
        public static void Verbose(string message, params object[] args) {
            if(log_verbose)
                Log(LogColors.Verbose, message, args);
        }

        public static void Warn(string message, params object[] args) {
            Log(LogColors.Warn, message, args);
        }

    }
}
