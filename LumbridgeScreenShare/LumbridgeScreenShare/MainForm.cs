using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using static LumbridgeScreenShare.Classes.Globals;
using static LumbridgeScreenShare.Classes.Server.TCPServer;
using LumbridgeScreenShare.Classes;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Drawing.Imaging;

namespace LumbridgeScreenShare
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            p1 = new PictureBox()
            {
                Location = new Point(50, 50),
                Name = "pBoxTest",
                Size = new Size(500, 281),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            page_PartnerView.Controls.Add(p1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            streamData = false;
            StartScreenCapture();
        }

        private void button_ConnectToPartner_Click(object sender, EventArgs e)
        {
            streamData = true;
        }

        void StartScreenCapture()
        {
            var screenCapture = new ScreenCapture();
            screenCapture.ScreenRefreshed += (sender, data) =>
            {
                if(streamData)
                    Classes.Client.TCPClient.SendDataToTCPServer(PartnerIPString, compressImg(data));
                Thread.Sleep(17);
            };
            screenCapture.Start();
        }

        byte[] compressImg(byte[] inputBytes)
        {
            int jpegQuality = 20;
            Image image;
            using (var inputStream = new MemoryStream(inputBytes))
            {
                image = Image.FromStream(inputStream);
                var jpegEncoder = ImageCodecInfo.GetImageDecoders()
                  .First(c => c.FormatID == ImageFormat.Jpeg.Guid);
                var encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, jpegQuality);
                Byte[] outputBytes;
                using (var outputStream = new MemoryStream())
                {
                    image.Save(outputStream, jpegEncoder, encoderParameters);
                    return outputBytes = outputStream.ToArray();
                }
            }
        }

        private void textbox_partnerIP_TextChanged(object sender, EventArgs e)
        {
            PartnerIPString = textbox_partnerIP.Text;
        }

        private void textbox_LocalIP_TextChanged(object sender, EventArgs e)
        {
            LocalIPString = textbox_LocalIP.Text;
        }

        private void button_StartServer_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(StartTcpServer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            textBox1.Text = op.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(textBox1.Text);

                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(PartnerEndPoint);

                byte[] buffer = new byte[1500];
                long bytesSent = 0;

                while (bytesSent < sr.BaseStream.Length)
                {
                    int bytesRead = sr.BaseStream.Read(buffer, 0, 1500);
                    tcpClient.GetStream().Write(buffer, 0, bytesRead);

                    bytesSent += bytesRead;
                }

                tcpClient.Close();

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TcpListener filelistener = new TcpListener(IPAddress.Parse(LocalIPString), 8085);
                filelistener.Start();

                TcpClient client = filelistener.AcceptTcpClient();

                byte[] buffer = new byte[4];
                int bytesread = 1;

                StreamWriter writer = new StreamWriter(SaveFileLocation);

                while (bytesread > 0)
                {
                    bytesread = client.GetStream().Read(buffer, 0, buffer.Length);
                    if (bytesread == 0)
                        break;
                    writer.BaseStream.Write(buffer, 0, buffer.Length);
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            SaveFileLocation = op.FileName;
            textBox2.Text = op.FileName;
        }
    }
}
