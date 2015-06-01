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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtBxNick.Text.Length == 0 || this.txtBxPhoneNum.Text.Length == 0)
                return;
            var user = User.UserExists(this.txtBxPhoneNum.Text.Trim(), this.txtBxNick.Text.Trim());
            this.Tag = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addContact(string nick,string NumPhone,object sender) {
            EventArgs e = new EventArgs();
            btn_add_users_Click(sender,e);
        }

        private void btn_add_users_Click(object sender, EventArgs e)
        {
            this.txtBxNick.Text = "andres";
            this.txtBxPhoneNum.Text = "573205829846";
            btnOK_Click(sender,e);
        }
    }    
}
