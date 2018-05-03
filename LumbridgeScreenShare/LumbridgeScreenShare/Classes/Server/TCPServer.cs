using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static LumbridgeScreenShare.Classes.Globals;

namespace LumbridgeScreenShare.Classes.Server
{
    class TCPServer
    {
        public static void StartTcpServer(object state)
        {
            try
            {
                TcpListener filelistener = new TcpListener(IPAddress.Parse(LocalIPString), 8085);
                filelistener.Start();

                while (true)
                {
                    using (TcpClient client = filelistener.AcceptTcpClient())
                    {
                        using (var ms = new MemoryStream())
                        {
                            client.GetStream().CopyTo(ms);
                            p1.Image = Common.ByteToImage(ms.ToArray());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static Image RecieveData(TcpClient client)
        {
            NetworkStream nNetStream = client.GetStream();
            return Image.FromStream(nNetStream);            

            //NetworkStream clientStream = client.GetStream();
            //MemoryStream messageStream = new MemoryStream();
            //byte[] inbuffer = new byte[65535];

            //if (clientStream.CanRead)
            //{
            //    do
            //    {
            //        var bytesRead = clientStream.Read(inbuffer, 0, inbuffer.Length);
            //        messageStream.Write(inbuffer, 0, bytesRead);
            //    } while (clientStream.DataAvailable);
            //}

            //messageStream.Position = 0;
            //var completeMessage = new byte[messageStream.Length];
            //messageStream.Write(completeMessage, 0, (int)messageStream.Length);
            //return messageStream.ToArray();
            //byte[] buffer = new byte[1500];
            //int bytesread = 1;

            //MemoryStream writer = new MemoryStream(buffer);

            //using (var ms = new MemoryStream())
            //{
            //  //  Do your thing, for example:

            //   client.GetStream().CopyTo(ms);

            //    return ms.ToArray(); // This gives you the byte array you want.
            //}

            //while (bytesread > 0)
            //{
            //    bytesread = client.GetStream().Read(buffer, 0, buffer.Length);
            //    if (bytesread == 0)
            //        break;
            //    writer.Write(buffer, 0, buffer.Length);
            //}
            //writer.Close();

            //return Common.StreamToByteArray(writer);
        }
    }
}
