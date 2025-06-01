using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Logger
    {
        public void Log(string messagee)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[LOG]: {messagee}");
            Console.ResetColor();
        }
        public void Error(string messagee)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[Error]: {messagee}");
            Console.ResetColor();
        }
        public void Warn(string messagee)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"[Warn]: {messagee}");
            Console.ResetColor();
        }

    }
}
