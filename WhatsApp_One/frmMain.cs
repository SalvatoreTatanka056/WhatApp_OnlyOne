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
using System.Threading;
using Google.Apis.Drive.v3;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Services;
using System.Windows.Forms.VisualStyles;
using System.Web;
using System.Net.Mime;

namespace WhatsApp_One
{
    public partial class frmMain : Form
    {
        //private string strUsername = "";
        private string contentType = "application/txt";
        private string FolderConnectId = "1-Q6sgSBOIARyu6yoTfZkrgffTI3VE87R";
        private string FolderId = "1B1PcGntR3RbwektTijuoePbt3NXzv5i_";
        private string FolderPathUser = "";
        private string HostName = "";
        private DriveService service;

        public static DataSet1.ConversationMessagesDataTable table = new DataSet1.ConversationMessagesDataTable();
        public DataSet1.ConversationMessagesRow newRow = table.NewConversationMessagesRow();

        //Socket sck;
        //EndPoint epLocal, epRemote;
        //byte[] buffer;

        public frmMain()
        {
            InitializeComponent();
            if (DesignMode)
                return;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            btnSendMessage.Enabled = false;
            newRow.time = DateTime.Now;
            newRow.text = "Hi!";
            newRow.incoming = true;
            table.AddConversationMessagesRow(newRow);
            conversationCtrl1.DataSource = table;
            conversationCtrl1.MessageColumnName = table.textColumn.ColumnName;
            conversationCtrl1.IdColumnName = table.idColumn.ColumnName;
            conversationCtrl1.DateColumnName = table.timeColumn.ColumnName;
            conversationCtrl1.IsIncomingColumnName = table.incomingColumn.ColumnName;

            txtSendMessage.Enabled = false;

            //sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //txtLocalIp.Text = GerLocalIP();
            //txtRemoteIp.Text = GerLocalIP();
            //strUsername = Dns.GetHostName();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "")
            {
                MessageBox.Show("Inserire un nikname a piacimento Grazie!", "Attenzione Username Mancante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            txtUserName.Text = txtUserName.Text.Replace("\r\n", "");

            /**/

            HostName = Dns.GetHostName();
            service = AuthenticateOauth(@"credentials.json", "dueinchat");
            int nUTentiConnessi = 0;

            var files = DriveListExample.ListFiles(service, new DriveListExample.FilesListOptionalParms() { Q = "'1-Q6sgSBOIARyu6yoTfZkrgffTI3VE87R' in parents and trashed=false", Fields = "*" });

            foreach (var item in files.Files)
            {
                    nUTentiConnessi++;
            }

            /**/

            if(nUTentiConnessi == 2)
            {
                MessageBox.Show("Attendere Conversazione in Corso, riprova più tardi...", "Attenzione Conversazione in Corso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            WriteMessaggioFileDownload(HostName + "_" + txtUserName.Text + "C", "Connesso.");

            var FileMetaData = new Google.Apis.Drive.v3.Data.File();
            FileMetaData.Name = HostName + "_" + txtUserName.Text + "C";
            FileMetaData.Parents = new List<string> { FolderConnectId };

            FilesResource.CreateMediaUpload request;

            using (var stream = new System.IO.FileStream(FolderPathUser + HostName + "_" + txtUserName.Text + "C", System.IO.FileMode.Open))
            {
                request = service.Files.Create(FileMetaData, stream, contentType);
                request.Upload();
                Application.DoEvents();
            }

            var file = request.ResponseBody;

            File.Delete(FolderPathUser + HostName + "_" + txtUserName.Text + "C");

            tsslblMain.Text = "Connessione in corso ...";

            tstsPrg.Value = 10;

            btnSendMessage.Enabled = true;

            if (txtUserName.Text != "")
            {
                btnConnect.Enabled = false;
                txtUserName.Enabled = false;
            }

            tstsPrg.Value = 50;

           

            FolderPathUser = string.Format(Application.StartupPath + "\\{0}_{1}", HostName, txtUserName.Text);

            if (Directory.Exists(FolderPathUser))
            {
                Console.WriteLine("That path exists already.");
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(FolderPathUser);
            }

            tstsPrg.Value = 100;
            tsslblMain.Text = "Connesso.";


            // creare un'altra cartella per scrivere i file di connessione che alla fine veranno cancellati
            // se l'applicazione ne trova >= 2 non si collega, si collega solamente se ne trova files di connessione < 2

            timer1.Enabled = true;
            txtSendMessage.Enabled = true;

            //int iretcode = 0;

            //if ((txtLocalPort.Text == "") || (txtRemotePort.Text == ""))
            //    return;

            //try
            //{
            //    // binding Socket
            //    epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIp.Text), Convert.ToInt32(txtLocalPort.Text));

            //    try
            //    {
            //        sck.Bind(epLocal);
            //    }
            //    catch (System.Net.Sockets.SocketException ex)
            //    {
            //        iretcode = 1;
            //        MessageBox.Show(ex.Message);
            //    }

            //    // Connectinf to remote IP
            //    epRemote = new IPEndPoint(IPAddress.Parse(txtRemoteIp.Text), Convert.ToInt32(txtRemotePort.Text));

            //    try
            //    {
            //        sck.Connect(epRemote);
            //    }
            //    catch (System.Net.Sockets.SocketException ex)
            //    {
            //        iretcode = 1;
            //        MessageBox.Show(ex.Message);
            //    }

            //    // Listening the special port
            //    buffer = new byte[1500];
            //    sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            //}
            //catch (System.FormatException ex1)
            //{
            //    iretcode = 1;
            //    MessageBox.Show(ex1.Message);
            //}

            //if (iretcode == 0)
            //{
            //    btnConnect.Enabled = false;
            //}

        }

        /*private static string GetMimeType(string uploadFile)
        {
            throw new NotImplementedException();
        }*/

        private void MessageCallBack(IAsyncResult ar)
        {
            /*try
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
            }*/
        }

 
        private void frmMain_Shown(object sender, EventArgs e)
        {
            conversationCtrl1.Rebind();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            /* ASCIIEncoding aEncoding = new ASCIIEncoding();
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
            }*/

            if (txtUserName.Text == "")
                return;

            if (txtSendMessage.Text == "")
                return;

            try
            {
                // Caricare Files su Drive ...
                // var service = AuthenticateOauth(@"credentials.json", "tatanka056");

                string sNomeFile = string.Format("{0}_{1}", HostName , txtUserName.Text);

                Application.DoEvents();
                btnSendMessage.Enabled = false;
                txtSendMessage.Enabled = false;

                tsslblMain.Text = "Invio messaggio in corso ...";
                tstsPrg.Value = 10;

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

                WriteMessaggioFileDownload(sNomeFile, txtSendMessage.Text);

                tstsPrg.Value = 30;

                //var service = AuthenticateOauth(@"credentials.json", "dueinchat");

                var FileMetaData = new Google.Apis.Drive.v3.Data.File();
                FileMetaData.Name = sNomeFile;
                FileMetaData.Parents = new List<string> { FolderId };

                FilesResource.CreateMediaUpload request;

                using (var stream = new System.IO.FileStream(FolderPathUser + sNomeFile, System.IO.FileMode.Open))
                {
                    request = service.Files.Create(FileMetaData, stream, contentType);
                    request.Upload();

                    tstsPrg.Value = 60;
                   Application.DoEvents();
                    
                }

                var file = request.ResponseBody;

                File.Delete(FolderPathUser + sNomeFile);

                tstsPrg.Value = 90;
                tsslblMain.Text = "Messaggio inviato.";

            }
            catch (System.Net.Sockets.SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Thread.Sleep(1000);

            tstsPrg.Value = 100;

            btnSendMessage.Enabled = true;
            txtSendMessage.Enabled = true;
        }

        private void WriteMessaggioFileDownload(string NomeFile, string Messaggio)
        {
              // Create a file to write to.
                using (StreamWriter sw = File.CreateText(FolderPathUser + NomeFile))
                {
                    sw.WriteLine(Messaggio);
                    sw.Close();
                }

                Application.DoEvents();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            /*var service = AuthenticateOauth(@"credentials.json", "tatanka056");

            iTotMessaggiDownload = GetLastIdFilesDownload();

            string sNomeFile = string.Format("500L_download_{0}.txt", iTotMessaggiUpload);

            var files = DriveListExample.ListFiles(service,new DriveListExample.FilesListOptionalParms() { Q = "not name contains '" +sNomeFile + "'", Fields = "*" });
            foreach (var item in files.Files)
            {
                
               DownloadFile(service, item, string.Format(@"{0}", item.Name));
                
            }*/
        }

        /*private string GerLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }

            return "127.0.0.1";
        }*/

        public static DriveService AuthenticateOauth(string clientSecretJson, string userName)
        {
            try
            {
                if (string.IsNullOrEmpty(userName))
                    throw new ArgumentNullException("userName");
                if (string.IsNullOrEmpty(clientSecretJson))
                    throw new ArgumentNullException("clientSecretJson");
                if (!System.IO.File.Exists(clientSecretJson))
                    throw new Exception("clientSecretJson file does not exist.");

                string[] scopes = new string[] { DriveService.Scope.Drive };
                UserCredential credential;
                using (var stream = new FileStream(clientSecretJson, FileMode.Open, FileAccess.Read))
                {
                    // string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    //credPath = Path.Combine(credPath, ".credentials/", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
                        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                                                                             scopes,
                                                                             userName,
                                                                             CancellationToken.None,
                                                                             new FileDataStore(".", true)).Result;
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

                            Thread.Sleep(500);
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

            Application.DoEvents();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tstsPrg.Value = 0;

            if (txtUserName.Text == "")
                return;

            timer1.Enabled = false;

            try
            {
                string strMessaggio = "";
                int iTrovato = 0;
                //var service = AuthenticateOauth(@"credentials.json", "dueinchat");
                var fileId = "";

                var files = DriveListExample.ListFiles(service, new DriveListExample.FilesListOptionalParms() { Q = "'1B1PcGntR3RbwektTijuoePbt3NXzv5i_' in parents and trashed=false", Fields = "*" });

                foreach (var item in files.Files)
                {

                    if (item.Name.CompareTo(HostName + "_" + txtUserName.Text) != 0)
                    {
                        tstsPrg.Value = 10;
                        tsslblMain.Text = "Ricezione messaggio in corso...";

                        DownloadFile(service, item, FolderPathUser + "\\" + string.Format(@"{0}", item.Name));

                        using (StreamReader sr = File.OpenText(FolderPathUser + "\\" + item.Name))
                        {
                            string s = "";
                            while ((s = sr.ReadLine()) != null)
                            {
                                strMessaggio += " " + s;
                                iTrovato = 1;
                                fileId = item.Id;
                            }

                            tstsPrg.Value = 30;

                            sr.Close();
                            break;
                        }
                    }
                    if (iTrovato == 1)
                    {
                        File.Delete(FolderPathUser + "\\" + item.Name);
                        break;
                    }
                }

                if (iTrovato == 0)
                {
                    timer1.Enabled = true;
                    return;
                }

                var request = service.Files.Delete(fileId);
                var file = request.Execute();

                tstsPrg.Value = 80;
                Application.DoEvents();

                newRow = table.NewConversationMessagesRow();
                newRow.time = DateTime.Now;
                newRow.text = "Friend: " + strMessaggio;
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

            tstsPrg.Value = 100;
            tsslblMain.Text = "Messaggio ricevuto";
            timer1.Enabled = true;

        }
        private static void SaveStream(MemoryStream stream, string saveTo)
        {
            try
            {
                using (System.IO.FileStream file = new System.IO.FileStream(saveTo, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    stream.WriteTo(file);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private string Messaggio = "";

        private void txtSendMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (Messaggio != "")
                return;

            if (txtUserName.Text == "")
                return;

            if (e.KeyCode == Keys.Enter)
            {
                txtSendMessage.Enabled = false;

                Messaggio = txtSendMessage.Text;

                btnSendMessage_Click(btnSendMessage, new EventArgs());

                txtSendMessage.Text = "";
                Messaggio = "";

                txtSendMessage.Enabled = true;

                e.Handled = true;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HostName.CompareTo("") == 0)
                return;

            if (txtUserName.Text.CompareTo("") == 0)
                return;

            //var service = AuthenticateOauth(@"credentials.json", "dueinchat");
           
            var files = DriveListExample.ListFiles(service, new DriveListExample.FilesListOptionalParms() { Q = "'1-Q6sgSBOIARyu6yoTfZkrgffTI3VE87R' in parents and trashed=false", Fields = "*" });

            foreach (var item in files.Files)
            {

                if (item.Name.CompareTo(HostName + "_" + txtUserName.Text + "C") == 0)
                {
                    var request = service.Files.Delete(item.Id);
                    var file = request.Execute();

                }
            }
        }

        private void btnAllegaFile_Click(object sender, EventArgs e)
        {
            // Upload file da inviare e inviare link per scaricare files.
            // Gestione terza cartella ...
        }
    }
}
