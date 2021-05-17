using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazeInstaller.Utils
{
    class Initialize
    {
        public static void InitializeMain()
        {
            RegFinder.nodeFinder();
            JSON.getFLToken();
            JSON.compareVers();
            Install.backendInstall();
            Install.Start();
        }
    }
}
