using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhatsAppPort
{
    public partial class frmRegister : Form
    {
        public string number;
        protected string cc;
        protected string phone;
        public string password;

        

        public frmRegister(string number)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(number))
            {
                this.number = number;
                this.cc = this.number.Substring(0, 2);
                this.phone = this.number.Substring(2);
                this.txtPhoneNumber.Text = number;
            }
        }

        public void btnCodeRequest_Click(object sender, EventArgs e)
        {
            ObtenerCodigo();
        }

        public void ObtenerCodigo()
        {
            if (!String.IsNullOrEmpty(this.txtPhoneNumber.Text))
            {
                string method = "sms";
                if (this.radVoice.Checked)
                {
                    method = "voice";
                }
                this.number = this.txtPhoneNumber.Text;
                this.cc = this.number.Substring(0, 2);
                this.phone = this.number.Substring(2);
                if (WhatsAppApi.Register.WhatsRegisterV2.RequestCode(this.number, out password, method))
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        //password received
                        this.OnReceivePassword();
                    }
                    else
                    {
                        this.grpStep1.Enabled = false;
                        this.grpStep2.Enabled = true;
                    }
                }
            }
        }


        private void btnRegisterCode_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtCode.Text) && this.txtCode.Text.Length == 6)
            {
                string code = this.txtCode.Text;
                password = WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(this.number, code);
                if (!String.IsNullOrEmpty(password))
                {
                    this.OnReceivePassword();
                }
            }
        }

        private void OnReceivePassword()
        {
            this.txtOutput.Text = String.Format("Found password:\r\n{0}\r\n\r\nWrite it down and exit the program", password);
            this.grpStep1.Enabled = false;
            this.grpStep2.Enabled = false;
            this.grpResult.Enabled = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public string getPassword()
           {

            return this.password; }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtPhoneNumber.Enabled = false;
        }
    }
}
