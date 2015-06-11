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
    public partial class frmConfigure : Form
    {
        public frmConfigure()
        {
            InitializeComponent();
        }

        private void frmConfigure_Load(object sender, EventArgs e)
        {
            txt_lote_msj.Text = Monitoreo.m_numero_contactos.ToString();
            txt_wait_lote.Text = (Monitoreo.m_tiempo_por_envio/1000).ToString();
            txt_wait_msj.Text = (Monitoreo.splee_por_mensaje/1000).ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Monitoreo.m_numero_contactos = Convert.ToInt32(txt_lote_msj.Text.Trim());
            Monitoreo.m_tiempo_por_envio = 1000*Convert.ToInt32(txt_wait_lote.Text.Trim());
            Monitoreo.splee_por_mensaje = 1000 * Convert.ToInt32(txt_wait_msj.Text.Trim());
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
