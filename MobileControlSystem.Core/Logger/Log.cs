using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlSystem.Core.Logger
{

    public class Log
    {
        public static void Info(string msg, string category = null)
        {
            Console(category, msg, ConsoleColor.White);
        }

        public static void Success(string msg, string category = null)
        {
            Console(category, msg, ConsoleColor.Green);
        }

        public static void Fail(string msg, string category = null)
        {
            Console(category, msg, ConsoleColor.Yellow);
        }

        public static void Error(string msg, string category = null)
        {
            Console(category, msg, ConsoleColor.Red);
        }

        public static void Console(string category, string msg, ConsoleColor color = ConsoleColor.White, int newline = 1)
        {
            System.Console.ForegroundColor = color;
            var c = string.IsNullOrEmpty(category) ? "" : $"[{category.ToUpper()}] ";
            System.Console.WriteLine($"{DateTime.Now.ToString("MM-dd HH:mm:ss.ff")} : {c}{msg}");
            if (newline != 0)
            {
                for (int i = 0; i < newline; i++)
                {
                    System.Console.WriteLine("");
                }
            }
        }
    }
}
