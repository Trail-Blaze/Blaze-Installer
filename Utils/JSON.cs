using System;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using static BlazeInstaller.Utils.vars;

namespace BlazeInstaller
{
    class JSON
    {
        public static string GetPath()
        {
            var launcherdat = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
            dynamic converted = JsonConvert.DeserializeObject(launcherdat);
            foreach (var appList in converted.InstallationList)
            {
                if (appList.AppName == "Fortnite")
                {
                    FortnitePath = appList.InstallLocation.ToString() + @"\FortniteGame\Binaries\Win64";
                    fnVersion = appList.AppVersion.ToString();
                    return FortnitePath;
                }
                else
                {
                    continue;
                }
            }
            return "hi";
        }
        public static void getFLToken()
        {
            WebClient webClient = new WebClient();
            string FLToken = webClient.DownloadString("https://api.nitestats.com/v1/epic/builds/fltoken"); // Downloads string
            converted = JsonConvert.DeserializeObject<JsonFL>(FLToken); // Makes json into string
            JFLToken = converted.fltoken;
            JFNVer = converted.version;
        }
        public static void compareVers()
        {
            if(fnVersion == converted.version)
            {
                bVerSame = true;
            }
            else
            {
                bVerSame = false;
            }
        }
    }
}
