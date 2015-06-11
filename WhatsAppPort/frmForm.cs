using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WhatsAppApi;
using WhatsAppApi.Helper;
using WhatsAppApi.Parser;


using System.IO;
using System.Data.OleDb;
using System.Reflection;
using ClosedXML.Excel;





namespace WhatsAppPort
{
    public partial class frmForm : Form
    {
        private WhatsMessageHandler messageHandler;
        private BackgroundWorker bgWorker;
        private volatile bool isRunning;
        private Dictionary<string, User> userList;

        private string phoneNum;
        private string phonePass;
        private string phoneNick;

        private string MSJ { get; set; }

        List<KeyValuePair<String, String>> test = new List<KeyValuePair<string, string>>();

        private int consta = 0;
        private int incremento = 0;

        public frmForm(string num, string pass, string nick)
        {
            this.phoneNum = num;
            this.phonePass = pass;
            this.phoneNick = nick;

            InitializeComponent();
            this.userList = new Dictionary<string, User>();
            this.isRunning = true;
            this.bgWorker = new BackgroundWorker();
            this.bgWorker.DoWork += ProcessMessages;
            this.bgWorker.ProgressChanged += NewMessageArrived;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.WorkerReportsProgress = true;
            this.messageHandler = new WhatsMessageHandler();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            using (var tmpAddUser = new frmAddUser())
            {
                tmpAddUser.ShowDialog(this);
                if (tmpAddUser.DialogResult != DialogResult.OK)
                    return;
                if(tmpAddUser.Tag == null || !(tmpAddUser.Tag is User))
                    return;

                var tmpUser = tmpAddUser.Tag as User;
                this.userList.Add(tmpUser.PhoneNumber, tmpUser);

                var tmpListUser = new ListViewItem(tmpUser.UserName);
                tmpListUser.Tag = tmpUser;
                this.listViewContacts.Items.Add(tmpListUser);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WhatSocket.Instance.Connect();
            WhatSocket.Instance.Login();
            this.bgWorker.RunWorkerAsync();
            
        }

        private void ProcessMessages(object sender, DoWorkEventArgs args)
        {
            if(sender == null)
                return;

            while (this.isRunning)
            {
                if (!WhatSocket.Instance.HasMessages())
                {
                    WhatSocket.Instance.PollMessages();
                    Thread.Sleep(100);
                    continue;
                }

                var tmpMessages = WhatSocket.Instance.GetAllMessages();
                (sender as BackgroundWorker).ReportProgress(1, tmpMessages);
            }
        }

        private void NewMessageArrived(object sender, ProgressChangedEventArgs args)
        {
            if (args.UserState == null || !(args.UserState is ProtocolTreeNode[]))
                return;

            var tmpMessages = args.UserState as ProtocolTreeNode[];
            foreach (var protocolNode in tmpMessages)
            {
                this.PopulateNewMessage(protocolNode);
            }
        }

        private void PopulateNewMessage(ProtocolTreeNode protocolNode)
        {
            this.GetMessageType(protocolNode);
            this.GetMessageBody(protocolNode);
            this.GetMessageSender(protocolNode);
        }

        private void GetMessageSender(ProtocolTreeNode protocolNode)
        {
            
        }

        private void GetMessageBody(ProtocolTreeNode protocolNode)
        {
            
        }

        private void GetMessageType(ProtocolTreeNode protocolNode)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.isRunning = false;
            this.bgWorker.CancelAsync();
            this.bgWorker = null;
        }

        private void listViewContacts_DoubleClick(object sender, EventArgs e)
        {
            if (sender == null || !(sender is ListView))
                return;

            var tmpListView = sender as ListView;
            if (tmpListView.SelectedItems.Count == 0)
                return;

            var selItem = tmpListView.SelectedItems[0];
            var tmpUser = selItem.Tag as User;

            var tmpDialog = new frmUserChat(tmpUser);
            //tmpDialog.MessageRecievedEvent += new frmUserChat.ProtocolDelegate(tmpDialog_MessageRecievedEvent);
            tmpDialog.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            this.consta = Monitoreo.m_numero_contactos;
            this.incremento = Monitoreo.m_numero_contactos;



            foreach (ListViewItem item in listViewContacts.Items) {
                count++;
                Monitoreo.num_msj_eviados++;
                var tmpUser = item.Tag as User;
                var tmpDialog = new frmUserChat(tmpUser);
                //tmpDialog.MessageRecievedEvent += new frmUserChat.ProtocolDelegate(tmpDialog_MessageRecievedEvent);
                /*tmpDialog.Show();*/
                tmpDialog.TrasferMsj(MSJ);
                if(count == incremento) { EnviarMensaje(); incremento = this.consta + Monitoreo.num_msj_eviados; }

                Thread.Sleep(Monitoreo.splee_por_mensaje);
            }

            

            Monitoreo.msj_realtime += "Todos los mensajes Enviados";
            /*
            var selItem = listViewContacts.Items[1];
            var tmpUser = selItem.Tag as User;
            var tmpDialog = new frmUserChat(tmpUser);
            //tmpDialog.MessageRecievedEvent += new frmUserChat.ProtocolDelegate(tmpDialog_MessageRecievedEvent);
            tmpDialog.Show();
            tmpDialog.TrasferMsj("hello world");
             */





        }


        // Load Contact from File Excel

        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";


        private void btn_add_contacts_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            string extension = Path.GetExtension(filePath);
            /* string header = rbHeaderYes.Checked ? "YES" : "NO";*/
            string header = "NO";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }

            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();


                       /* List<KeyValuePair<String, String>> test = new List<KeyValuePair<string, string>>();*/
                        foreach (DataRow dr in dt.Rows)
                        {
                            test.Add(new KeyValuePair<string, string>(dr[0].ToString(), (dr[1].ToString())));
                        }

                        foreach (var item in test)
                        {

                            var tmpUser = User.UserExists("57"+item.Value, item.Key);
                            this.userList.Add(tmpUser.PhoneNumber, tmpUser);

                            var tmpListUser = new ListViewItem(tmpUser.UserName);
                            tmpListUser.Tag = tmpUser;
                            this.listViewContacts.Items.Add(tmpListUser);
                        }




                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmEditContacs fr = new frmEditContacs();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSetMessage frm = new frmSetMessage();
            frm.ShowDialog(this);
            this.MSJ = frm.Tag as string;
        }



        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] imgData = File.ReadAllBytes(@"C:\Users\acerpc\Music\music.jpg");

          

            /*foreach (var item in arr) { MessageBox.Show(item.ToString()); }*/

            ListViewItem item = listViewContacts.Items[0];
                var tmpUser = item.Tag as User;
                var tmpDialog = new frmUserChat(tmpUser);
                tmpDialog.TrasferMessageImage(imgData);
            
        


        }



        public void EnviarMensaje()
        {
            

            DataTable table = new DataTable();
            table.Columns.Add("usuario", typeof(string));
            table.Columns.Add("numero", typeof(string));
            table.Columns.Add("estado", typeof(string));

            int count = 0;
            foreach (var item in test) {
                count++;
                table.Rows.Add(item.Key,item.Value,"ok");
                
                if (count == Monitoreo.num_msj_eviados) { break;  }
            }
            



            //Exporting to Excel
            string folderPath = "C:\\Excel\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(table, "Contactos");
                wb.SaveAs(folderPath + "Contactos.xlsx");
            }

           
            int num_start =  Monitoreo.num_msj_eviados - this.consta;
            Monitoreo.msj_realtime += this.consta + " Mensajes enviados del "+num_start+ " al " + Monitoreo.num_msj_eviados+" a las " + DateTime.Now + "\n";

            Thread.Sleep(Monitoreo.m_tiempo_por_envio);
        }



        private void listViewContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void parametrosDeEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigure frm = new frmConfigure();
            frm.ShowDialog();
        }
    }


}
