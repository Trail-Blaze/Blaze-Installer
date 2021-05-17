using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static BlazeInstaller.Utils.vars;

namespace BlazeInstaller
{
    class Launch
    {
        public static void LaunchGame()
        {
            /*FortniteClient-Win64-Shipping_BE.exe
            -obfuscationid=AqIHXG2ib9xcbISl_E2ui9ctgMCdzw
            -AUTH_LOGIN=unused
            -AUTH_PASSWORD=hah
            -AUTH_TYPE=exchangecode
            -epicapp=Fortnite
            -epicenv=Prod
            -EpicPortal
            -steamimportavailable
            -epicusername=no:)
            -epicuserid=no:)
            -epiclocale=en
            -noeac
            -fromfl=be
            -fltoken=badfltoken
            
            Process beProcess = new Process();
            beProcess.StartInfo.Arguments = "-obfuscationid=AqIHXG2ib9xcbISl_E2ui9ctgMCdzw-AUTH_LOGIN=unused -AUTH_PASSWORD=hah -AUTH_TYPE=exchangecode -epicapp=Fortnite -epicenv=Prod -EpicPortal -steamimportavailable -epicusername=Blazetest -epicuserid=Blaze -epiclocale=en -noeac -fromfl=be- fltoken=" + converted.fltoken;
            beProcess.StartInfo.FileName = @"C:\Program Files\Fortnite\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping_BE.exe";
            beProcess.Start(); */ // NOT WORKING IDK Y
        }
    }
}
