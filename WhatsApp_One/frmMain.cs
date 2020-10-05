﻿using System;
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
using System.Threading;
using Google.Apis.Drive.v3;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Services;

namespace WhatsApp_One
{

    public partial class frmMain : Form
    {

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
        private void frmMain_Load(object sender, EventArgs e)
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
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get user IP
            txtLocalIp.Text = GerLocalIP();
            txtRemoteIp.Text = GerLocalIP();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            int iretcode = 0;

            if ((txtLocalPort.Text == "") || (txtRemotePort.Text == ""))
                return;

            try
            {
                // binding Socket
                epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIp.Text), Convert.ToInt32(txtLocalPort.Text));

                try
                {
                    sck.Bind(epLocal);
                }
                catch (System.Net.Sockets.SocketException ex)
                {
                    iretcode = 1;
                    MessageBox.Show(ex.Message);
                }

                // Connectinf to remote IP
                epRemote = new IPEndPoint(IPAddress.Parse(txtRemoteIp.Text), Convert.ToInt32(txtRemotePort.Text));

                try
                {
                    sck.Connect(epRemote);
                }
                catch (System.Net.Sockets.SocketException ex)
                {
                    iretcode = 1;
                    MessageBox.Show(ex.Message);
                }

                // Listening the special port
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (System.FormatException ex1)
            {
                iretcode = 1;
                MessageBox.Show(ex1.Message);
            }

            if (iretcode == 0)
            {
                btnConnect.Enabled = false;
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

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                Application.DoEvents();
              
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


                if (conversationCtrl1.InvokeRequired)
                {
                    conversationCtrl1.Invoke(new ThreadStart(delegate
                    {
                        conversationCtrl1.Rebind();

                    }));
                }
                else
                {
                    conversationCtrl1.Rebind();
                }

                Application.DoEvents();



            }
            catch (Exception ex)
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

                Application.DoEvents();

                btnSendMessage.Enabled = false;

                Thread.Sleep(1000);

                newRow = table.NewConversationMessagesRow();
                newRow.time = DateTime.Now;
                newRow.text = "Me: " + txtSendMessage.Text;
                newRow.incoming = true;
                table.AddConversationMessagesRow(newRow);

                conversationCtrl1.DataSource = table;
                conversationCtrl1.MessageColumnName = table.textColumn.ColumnName;
                conversationCtrl1.IdColumnName = table.idColumn.ColumnName;
                conversationCtrl1.DateColumnName = table.timeColumn.ColumnName;
                conversationCtrl1.IsIncomingColumnName = table.incomingColumn.ColumnName;

                conversationCtrl1.Rebind();

                Application.DoEvents();

                btnSendMessage.Enabled = true;

            }
            catch (System.Net.Sockets.SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Connect to Google
            var service = AuthenticateOauth(@"credentials.json", "tatanka056");
            //List the files with the word 'make' in the name.
            var files = DriveListExample.ListFiles(service,new DriveListExample.FilesListOptionalParms() { Q = "name contains '500L'", Fields = "*" });
            foreach (var item in files.Files)
            {
                // download each file
                DownloadFile(service, item, string.Format(@"{0}", item.Name));
                // creare progressivo di invio e di ricezione.

            }
        }

        private string GerLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }

            return "127.0.0.1";
        }

        public static DriveService AuthenticateOauth(string clientSecretJson, string userName)
        {
            try
            {
                if (string.IsNullOrEmpty(userName))
                    throw new ArgumentNullException("userName");
                if (string.IsNullOrEmpty(clientSecretJson))
                    throw new ArgumentNullException("clientSecretJson");
                if (!File.Exists(clientSecretJson))
                    throw new Exception("clientSecretJson file does not exist.");

               
                string[] scopes = new string[] { DriveService.Scope.DriveReadonly };         	                                                 
                UserCredential credential;
                using (var stream = new FileStream(clientSecretJson, FileMode.Open, FileAccess.Read))
                {
                    string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    credPath = Path.Combine(credPath, ".credentials/", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);

                   
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                                                                             scopes,
                                                                             userName,
                                                                             CancellationToken.None,
                                                                             new FileDataStore(credPath, true)).Result;
                }

                return new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive Oauth2 Authentication Sample"
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Oauth2 account DriveService failed" + ex.Message);
                throw new Exception("CreateServiceAccountDriveFailed", ex);
            }
        }


        private static void DownloadFile(Google.Apis.Drive.v3.DriveService service, Google.Apis.Drive.v3.Data.File file, string saveTo)
        {

            var request = service.Files.Get(file.Id);
            var stream = new System.IO.MemoryStream();

            request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
            {
                switch (progress.Status)
                {
                    case Google.Apis.Download.DownloadStatus.Downloading:
                        {
                            Console.WriteLine(progress.BytesDownloaded);
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Completed:
                        {
                            Console.WriteLine("Download complete.");
                            SaveStream(stream, saveTo);
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Failed:
                        {
                            Console.WriteLine("Download failed.");
                            break;
                        }
                }
            };
            request.Download(stream);

        }

        private static void SaveStream(MemoryStream stream, string saveTo)
        {
            using (System.IO.FileStream file = new System.IO.FileStream(saveTo, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                stream.WriteTo(file);
            }
        }


    }

}
