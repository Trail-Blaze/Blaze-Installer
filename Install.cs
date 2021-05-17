using System;
using System.IO;
using static BlazeInstaller.Utils.vars;
using static BlazeInstaller.Utils.Logs;
using System.Diagnostics;
using System.Net;
using BlazeInstaller.Utils;
using System.IO.Compression;

namespace BlazeInstaller
{
    class Install
    {
        public static void Start()
        {
            if (Directory.Exists(tempFolder))
            {
                BlazeLog("Would you like to convert back to normal fortnite?: ", "switch");
                string ans = Console.ReadLine().ToLower();
                if (ans == "yes")
                {
                    BlazeLog("Switching back now!\n", "switch");
                    File.Move(binEAC, tempEAC + ".bypass");
                    File.Move(binBE, tempBE + ".bypass");
                    File.Move(tempEAC + ".original", binEAC);
                    File.Move(tempBE + ".original", binBE);
                    foreach (FileInfo file in tempDI.GetFiles())
                    {
                        file.Delete();
                    }
                    Directory.Delete(tempFolder);
                    File.Delete(JSON.GetPath() + @"\SSLBypass.dll");
                    BlazeExit();
                }
                else
                {
                    BlazeLog("Would you like to launch?: ", "blaze"); // ad Launch
                    string ans2 = Console.ReadLine().ToLower();
                    if(ans2 == "yes")
                    {
                        Process runBat = new Process();
                        runBat.StartInfo.FileName = cmdDir; 
                        runBat.StartInfo.WorkingDirectory = cD + @"dyna-core-beta-main\";
                        runBat.StartInfo.Arguments = "/c start launch.bat";
                        runBat.StartInfo.UseShellExecute = false;
                        runBat.StartInfo.CreateNoWindow = false;
                        Process fnProcess = new Process();
                        fnProcess.StartInfo.FileName = "cmd.exe";
                        fnProcess.StartInfo.Arguments = "/c start com.epicgames.launcher://apps/Fortnite?action=launch&silent=true";
                        runBat.Start();
                        fnProcess.Start();
                        fnProcess.WaitForExit();
                        BlazeExit();
                    }
                    else
                    {
                        BlazeExit();
                    }
                }
            }
            else
            {
                if (!File.Exists(JSON.GetPath() + @"\SSLBypass.dll"))
                {
                    Logs.BlazeLog("Would you like to switch to fake anticheats?: ", "blaze");
                    var ans = Console.ReadLine().ToLower();
                    if (ans == "yes")
                    {
                        Directory.CreateDirectory(tempFolder);
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile(new Uri("https://cdn.discordapp.com/attachments/819303503226208286/843579786156965888/FortniteClient-Win64-Shipping_EAC.exe"), tempEAC);
                        webClient.DownloadFile(new Uri("https://cdn.discordapp.com/attachments/819303503226208286/843579878925139968/FortniteClient-Win64-Shipping_BE.exe"), tempBE);
                        webClient.DownloadFile(new Uri("https://cdn.discordapp.com/attachments/819303503226208286/843579466017144852/SSLBypass.dll"), JSON.GetPath() + @"\SSLBypass.dll");
                        File.Move(binEAC, tempEAC + ".original");
                        File.Move(binBE, tempBE + ".original");
                        File.Move(tempEAC, binEAC);
                        File.Move(tempBE, binBE);
                        Logs.BlazeLog("Done switching!\n", "switch");
                        Logs.BlazeLog("Finished downloading SSLBypass.dll!\n", "blaze");
                        Logs.BlazeExit();
                    }
                    else
                    {
                        BlazeExit();
                    }
                }
            }
        }
        public static void backendInstall()
        {
            if(!Directory.Exists(cD + @"\dyna-core-beta-main"))
            {
                Logs.BlazeLog("Would you like to install the backend? (yes or no): ", "blaze");
                var ans = Console.ReadLine().ToLower();
                if (ans == "yes")
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://github.com/Trail-Blaze/dyna-core-beta/archive/refs/heads/main.zip", @".\blazebackend.zip");
                    ZipFile.ExtractToDirectory(cD + @"\blazebackend.zip", cD);
                    File.Delete(cD + @"\blazebackend.zip");
                    Process installBat = new Process();
                    installBat.StartInfo.FileName = cmdDir;
                    installBat.StartInfo.WorkingDirectory = cD + @"dyna-core-beta-main"; // This took so long to find
                    installBat.StartInfo.Arguments = "/c start install.bat";
                    installBat.StartInfo.UseShellExecute = false;
                    installBat.StartInfo.CreateNoWindow = false;
                    installBat.Start();
                }
            }
        }
    }
}
