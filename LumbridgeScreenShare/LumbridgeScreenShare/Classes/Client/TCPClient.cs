using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumbridgeScreenShare.Classes.Client
{
    class TCPClient
    {
        public static void SendDataToTCPServer(string ipAddress, byte[] data)
        {
            try
            {
                MemoryStream sr = new MemoryStream(data);

                TcpClient client = new TcpClient();

                client.Connect(Globals.PartnerEndPoint); // send to partner server

                byte[] buffer = new byte[65535];
                long bytesSent = 0;

                while (bytesSent < data.Length)
                {
                    int bytesRead = sr.Read(buffer, 0, buffer.Length);
                    client.GetStream().Write(buffer, 0, bytesRead);

                    bytesSent += bytesRead;
                }
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
