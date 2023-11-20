using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private enum EConnectionState 
        {
            Connect,
            Disconnect
        }
        EConnectionState _eState;
        Socket _sock = null;

        public Form1()
        {
            InitializeComponent();
            Disconnect_UI();
        }

        private void Connect_UI() 
        {
            btn_connectDisconnect.Text = "Отключиться";
            _eState = EConnectionState.Connect;
            lbl_connectionState.Text = "Есть соединение";
            lbl_connectionState.BackColor = Color.LightGreen;
            groupBox2.Enabled = true;
        }

        private void Disconnect_UI()
        {
            btn_connectDisconnect.Text = "Подключиться";
            _eState = EConnectionState.Disconnect;
            lbl_connectionState.Text = "Нет соединения";
            lbl_connectionState.BackColor = Color.OrangeRed;
            groupBox2.Enabled = false;
        }
        private void ConnectDisconnect_UI() 
        {
            if (_eState == EConnectionState.Disconnect)
                Connect_UI();
            else
                Disconnect_UI();
        }
        void Disconnect_NET(ref Socket sock) 
        {
            if (sock == null)
                return;

            sock.Shutdown(SocketShutdown.Both);
            sock.Close();
            sock = null;
        }
        bool Connect_NET(IPAddress ipAddres, UInt16 port, out Socket sock)
        {
            try
            {
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                if (sock == null)
                {
                    throw new OutOfMemoryException();
                }

                sock.Connect(ipAddres, port);
                if (!sock.Connected) 
                {
                    Disconnect_NET(ref sock);
                    return false;
                }
                return true;
            }
            catch
            {
                sock = null;
                return false;
            }
        }
        void ConnectDisconnect_NET(IPAddress ipAddress, UInt16 port) 
        {
            if (_eState == EConnectionState.Disconnect)
            {
                if (_sock != null)
                    Disconnect_NET(ref _sock);
                Connect_NET(ipAddress, port, out _sock);
            }
            else
            {
                Disconnect_NET(ref _sock);
            }
        }
        void Connect(IPAddress ipAddress, UInt16 port) 
        {
            if (Connect_NET(ipAddress, port, out _sock)) 
            {
                Connect_UI();
            }
        }
        void Disconnect()
        {
            Disconnect_NET(ref _sock);
            Disconnect_UI();
        }
        void ConnectDisconnect(IPAddress ipAddress, UInt16 port) 
        {
            if (_eState == EConnectionState.Disconnect)
            {
                if (_sock != null)
                    Disconnect();
                Connect(ipAddress, port);
            }
            else
            {
                Disconnect();
            }
        }
        private void btn_connectDisconnect_Click(object sender, EventArgs e)
        {
            string strIpAddress;
            string strPort;
            strIpAddress = txb_ipAddress.Text;
            strPort = txb_port.Text;
            bool bIpAddressParseOk, bPortParseOk;
            IPAddress ipAddres;
            UInt16 port;

            bIpAddressParseOk = IPAddress.TryParse(strIpAddress, out ipAddres);

            if (!bIpAddressParseOk) 
            {
                MessageBox.Show("Ошибка: поле \"IP-адрес\"");
                return;
            }

            bPortParseOk = UInt16.TryParse(strPort, out port);

            if (!bPortParseOk) 
            {
                MessageBox.Show("Ошибка: поле \"Порт\"");
                return;
            }
            ConnectDisconnect(ipAddres, port);
        }

        private void btn_sendRequest_Click(object sender, EventArgs e)
        {
            if (_sock.Connected)
            {
                try
                {
                    _sock.Send(new byte[1] { 0 });
                    _sock.ReceiveTimeout = 5000;
                    byte[] buf = new byte[1024];
                    int bytesCountReceive = _sock.Receive(buf);
                    MessageBox.Show(bytesCountReceive.ToString());
                }
                catch(SocketException exc)
                {
                    MessageBox.Show(exc.ErrorCode.ToString());
                    Disconnect();
                }    
            }
            else
            {
                Disconnect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] message = new byte[1024];

            byte[] famBuf = Encoding.UTF8.GetBytes("Иванов");

            message[0] = (byte)famBuf.Length;
            Array.Copy(famBuf, 0, message, 3, famBuf.Length);
            byte[] nameBuf = Encoding.UTF8.GetBytes("Иван");
            message[1] = (byte)nameBuf.Length;
            Array.Copy(nameBuf, 0, message, 3 + famBuf.Length, nameBuf.Length);
            byte[] surnameBuf = Encoding.UTF8.GetBytes("Иванович");
            message[2] = (byte)surnameBuf.Length;
            Array.Copy(surnameBuf, 0, message, 3 + famBuf.Length + nameBuf.Length, surnameBuf.Length);

        }
    }
}
