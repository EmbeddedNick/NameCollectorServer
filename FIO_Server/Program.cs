using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FIO_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SendFamily(60034);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static bool clientConnect = true;
        static void SendFamily(int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Bind(new IPEndPoint(IPAddress.Parse("192.168.2.194"), port));
            socket.Listen(10);

            
            while(clientConnect)
            {
                var tcpClient = socket.Accept();
                if(tcpClient != null)
                {
                    new Thread((object sender) =>
                        {
                            Socket clientSocket = sender as Socket;
                            byte[] buf = new byte[1024];
                            byte[] rec = new byte[512];
                            var Fam = "Чехов";
                            var Nam = "Антон";
                            var Par = "Павлович";
                            
                            byte[] tmp1 = Encoding.UTF8.GetBytes(Fam);
                            Array.Copy(tmp1, 0, buf, 3, tmp1.Length);
                            buf[0] = (byte)tmp1.Length;
                            byte[] tmp2 = Encoding.UTF8.GetBytes(Nam);
                            Array.Copy(tmp2, 0, buf, 3 + tmp1.Length, tmp2.Length);
                            buf[1] = (byte)tmp2.Length;
                            byte[] tmp3 = Encoding.UTF8.GetBytes(Par);
                            Array.Copy(tmp3, 0, buf, 3 + tmp1.Length + tmp2.Length, tmp3.Length);
                            buf[2] = (byte)tmp3.Length;

                            bool ServerIsWork = true;
                            while (clientConnect && ServerIsWork)
                            {
                                try
                                {
                                    clientSocket.Receive(rec);

                                    
                                    clientSocket.Send(buf);
                                }
                                catch
                                {
                                    ServerIsWork = false;
                                }


                            }
                            clientSocket.Shutdown(SocketShutdown.Both);
                            clientSocket.Close();

                        }).Start(tcpClient);
                }
            }
        }
    }
}
