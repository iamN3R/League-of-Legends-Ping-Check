using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingCheck
{
   public class LoLServer
    {
        public string giveserverip(string Region)
        {
            switch (Region)
            {
                case "NA": return "104.160.131.3";
                case "EUW": return "104.160.141.3";
                case "EUNE": return "104.160.142.3";
                case "OCE": return "104.160.156.1";
                case "LAN": return "104.160.136.3";
                case "JPN": return "104.160.154.199";
                default: return "";
            }
        }
    }
}
