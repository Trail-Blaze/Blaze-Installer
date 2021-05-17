using System;
using Microsoft.Win32;
using static BlazeInstaller.Utils.vars;

namespace BlazeInstaller.Utils
{
    class RegFinder
    {
        public static string regFinder(string path)
        {
            var key = Registry.LocalMachine.OpenSubKey(path);
            if (key == null)
            {
                return "False";
            }
            else
            {
                return "True";
            }
        }
        public static void nodeFinder()
        {
            var NodeJS = RegFinder.regFinder(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{D6F88D78-7F46-4394-9E57-5CAF6669195C}");
            if (NodeJS == "True")
            {
                bHasNode = true;
            }
            else if (NodeJS == "False")
            {
                bHasNode = false;
            }
        }
    }
}
