using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LumbridgeScreenShare.Classes
{
    class Common
    {
        public static IPEndPoint StringToIPEndPoint(string IpAddress)
        {
            return new IPEndPoint(IPAddress.Parse(IpAddress), 8085);
        }
        public static IPAddress StringToIPAddress(string IpAddress)
        {
            return IPAddress.Parse(IpAddress);
        }
        
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, pData.Length);
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public static string GetLocalIP()
        {
            string name = Dns.GetHostName();
            IPHostEntry entry = Dns.GetHostEntry(name);
            IPAddress[] addr = entry.AddressList;
            if (addr[1].ToString().Split('.').Length == 4)
            {
                return addr[1].ToString();
            }
            return addr[2].ToString();
        }
    }
}
