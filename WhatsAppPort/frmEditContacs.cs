using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data.OleDb;

namespace WhatsAppPort
{
    public partial class frmEditContacs : Form
    {
        public frmEditContacs()
        {
            InitializeComponent();
        }

        // Load Contact from File Excel

        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
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

                        dataGridView1.DataSource = dt;

                        /*

                        List<KeyValuePair<String, String>> test = new List<KeyValuePair<string, string>>();
                        foreach (DataRow dr in dt.Rows)
                        {
                            test.Add(new KeyValuePair<string, string>(dr[0].ToString(), (dr[1].ToString())));
                        }

                        foreach (var item in test)
                        {

                            var tmpUser = User.UserExists("57" + item.Value, item.Key);
                            this.userList.Add(tmpUser.PhoneNumber, tmpUser);

                            var tmpListUser = new ListViewItem(tmpUser.UserName);
                            tmpListUser.Tag = tmpUser;
                            this.listViewContacts.Items.Add(tmpListUser);
                        }
                        */



                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
