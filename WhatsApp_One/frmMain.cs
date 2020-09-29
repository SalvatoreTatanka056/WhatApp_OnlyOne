using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace WhatsApp_One
{

    public partial class frmMain : Form
    {

        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress,true);


            // get user IP
            txtLocalIp.Text = GerLocalIP();
            txtRemoteIp.Text = GerLocalIP();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIp.Text), Convert.ToInt32(txtLocalPort.Text));
            sck.Bind(epLocal);

            // Connectinf to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(txtRemoteIp.Text), Convert.ToInt32(txtRemotePort.Text));
            sck.Connect(epRemote);

            // Listening the special port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

        }

        private void MessageCallBack(IAsyncResult ar)
        {
            try
            {
                byte[] receiveData = new byte[1500];
                receiveData = (byte[])ar.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receiveMessage = aEncoding.GetString(receiveData);

                //Adding this Message into listbox
                lstMain.Items.Add("Friend: " + receiveMessage);

                buffer = new byte[1500];

                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(txtSendMessage.Text);

            sck.Send(sendingMessage);

            //Adding this Message into listbox
            lstMain.Items.Add("Me: " + txtSendMessage.Text);

        }

        private string GerLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }

            return "127.0.0.1";
        }
    }
}
