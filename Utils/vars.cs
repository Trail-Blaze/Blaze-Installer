using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BlazeInstaller.Utils
{
    class vars
    {
        public static string cD = AppDomain.CurrentDomain.BaseDirectory;
        public static string tempFolder = cD + @"\temp";
        public static string tempEAC = tempFolder + @"\FortniteClient-Win64-Shipping_BE.exe";
        public static string tempBE = tempFolder + @"\FortniteClient-Win64-Shipping_EAC.exe";
        public static string binEAC = JSON.GetPath() + @"\FortniteClient-Win64-Shipping_BE.exe";
        public static string binBE = JSON.GetPath() + @"\FortniteClient-Win64-Shipping_EAC.exe";
        public static string FortnitePath;
        public static string fnVersion;
        public static bool bHasNode;
        public static JsonFL converted;
        public static bool bVerSame;
        public static string driveLetter = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        public static string cmdDir = driveLetter + @"Windows\System32\cmd.exe";
        public static string JFLToken; //= converted.fltoken;
        public static string JFNVer; //= converted.version;
        public static DirectoryInfo tempDI = new DirectoryInfo(tempFolder);
        public class JsonFL
        {

            public string version { get; set; }
            public string fltoken { get; set; }

        }
    }
}
