using System;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazeInstaller.Utils
{
    class Logs
    {
        public static void BlazeLog(string arg, string prefix)
        {
            if (prefix.ToLower() == "blaze")
            {
                prefix = "[BLAZE] ";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (prefix.ToLower() == "switch")
            {
                prefix = "[SWITCH] ";
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (prefix.ToLower() == "credit")
            {
                prefix = "[CREDITS] ";
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if(prefix.ToLower() == "error")
            {
                prefix = "[ERROR] ";
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if(prefix.ToLower() == "debug")
            {
                prefix = "[DEBUG] ";
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            Console.Write(prefix);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(arg);
        }
        public static void BlazeExit()
        {
            BlazeLog("Exiting in 5 seconds.", "blaze");
            Thread.Sleep(5000); // TODO: Put proper method of waiting
            Environment.Exit(0);
        }
    }
}
