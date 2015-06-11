using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WhatsAppPort
{
    public partial class frmMonitor : Form
    {
        public frmMonitor()
        {
            InitializeComponent();
        }

        private void frmMonitor_Load(object sender, EventArgs e)
        {
            tmrMonitor.Enabled = true;
            tmrMonitor.Start();
            StartPosition = FormStartPosition.CenterScreen;
            
            Location = new Point(1000,800);
            
            
            
            
            
            
        }

        

        private void tmrMonitor_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text = Monitoreo.msj_realtime;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
            richTextBox1.ScrollToCaret(); //Now scroll it automatically
        }
    }
}
