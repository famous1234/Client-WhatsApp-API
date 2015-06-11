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
    public partial class frmSetMessage : Form
    {
        public frmSetMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Tag = richTextBox1.Text;
            this.Close();
            Monitoreo.mensaje = richTextBox1.Text;
        }

        private void frmSetMessage_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = Monitoreo.mensaje;
        }
    }
}
