using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSB.AkkaNet.TwoActors.ConsoleUtils
{
    public static class ConsoleUtil
    {
        private static readonly object _sync = new object();

        public static void PrintMsg(string message, bool success = true)
        {
            var foreGroundColor = (success) ? ConsoleColor.Green : ConsoleColor.Red;
            lock (_sync)
            {
                Console.ForegroundColor = foreGroundColor;
                Console.WriteLine($"{DateTime.Now:o} => {message}");
            }
        }
    }
}
