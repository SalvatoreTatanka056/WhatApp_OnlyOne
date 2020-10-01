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
        //load some data to table and setup the conversation control
        public static DataSet1.ConversationMessagesDataTable table = new DataSet1.ConversationMessagesDataTable();
        public DataSet1.ConversationMessagesRow newRow = table.NewConversationMessagesRow();

        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public frmMain()
        {
            InitializeComponent();
            if (DesignMode)
                return;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        
            newRow.time = DateTime.Now;
            newRow.text = "Hi!";
            newRow.incoming = true;
            table.AddConversationMessagesRow(newRow);

            conversationCtrl1.DataSource = table;
            conversationCtrl1.MessageColumnName = table.textColumn.ColumnName;
            conversationCtrl1.IdColumnName = table.idColumn.ColumnName;
            conversationCtrl1.DateColumnName = table.timeColumn.ColumnName;
            conversationCtrl1.IsIncomingColumnName = table.incomingColumn.ColumnName;


            // set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress,true);


            // get user IP
            txtLocalIp.Text = GerLocalIP();
            txtRemoteIp.Text = GerLocalIP();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            try
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
            catch (System.FormatException ex1)
            {

                MessageBox.Show(ex1.Message);
            }

    
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

                newRow = table.NewConversationMessagesRow();
                newRow.time = DateTime.Now;
                newRow.text = "Friend: " + receiveMessage;
                newRow.incoming = false;
                table.AddConversationMessagesRow(newRow);

                conversationCtrl1.DataSource = table;
                conversationCtrl1.MessageColumnName = table.textColumn.ColumnName;
                conversationCtrl1.IdColumnName = table.idColumn.ColumnName;
                conversationCtrl1.DateColumnName = table.timeColumn.ColumnName;
                conversationCtrl1.IsIncomingColumnName = table.incomingColumn.ColumnName;

                conversationCtrl1.Rebind();

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
       

        }

        private void conversationCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
                conversationCtrl1.Rebind();
        }

        private void btnSendMessage_Click_1(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(txtSendMessage.Text);


            try
            {
                sck.Send(sendingMessage);

            }
            catch (System.Net.Sockets.SocketException ex)
            {


                MessageBox.Show(ex.Message);

            }

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
