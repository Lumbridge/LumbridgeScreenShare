using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LumbridgeScreenShare.Classes
{
    class Globals
    {
        public static System.Windows.Forms.PictureBox p1 { get; set; }

        public static string SaveFileLocation { get; set; }

        public static bool isConnected { get; set; }
        public static bool streamData { get; set; }

        public static IPAddress PartnerIP
        {
            get { return Common.StringToIPAddress(PartnerIPString); }
        }
        public static IPEndPoint PartnerEndPoint
        {
            get { return Common.StringToIPEndPoint(PartnerIPString); }
        }

        public static IPAddress LocalIP
        {
            get { return Common.StringToIPAddress(LocalIPString); }
        }
        public static IPEndPoint LocalEndPoint
        {
            get { return Common.StringToIPEndPoint(LocalIPString); }
        }

        public static string PartnerIPString { get; set; }
        public static string LocalIPString { get; set; }
    }
}
