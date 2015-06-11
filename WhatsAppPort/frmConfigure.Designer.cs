namespace WhatsAppPort
{
    partial class frmConfigure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_wait_msj = new System.Windows.Forms.TextBox();
            this.txt_lote_msj = new System.Windows.Forms.TextBox();
            this.txt_wait_lote = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo de espera por mensaje (seg.) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de mensajes por lote :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo de espera por lote (seg.) :";
            // 
            // txt_wait_msj
            // 
            this.txt_wait_msj.Location = new System.Drawing.Point(275, 41);
            this.txt_wait_msj.Name = "txt_wait_msj";
            this.txt_wait_msj.Size = new System.Drawing.Size(100, 20);
            this.txt_wait_msj.TabIndex = 3;
            // 
            // txt_lote_msj
            // 
            this.txt_lote_msj.Location = new System.Drawing.Point(275, 77);
            this.txt_lote_msj.Name = "txt_lote_msj";
            this.txt_lote_msj.Size = new System.Drawing.Size(100, 20);
            this.txt_lote_msj.TabIndex = 4;
            // 
            // txt_wait_lote
            // 
            this.txt_wait_lote.Location = new System.Drawing.Point(275, 110);
            this.txt_wait_lote.Name = "txt_wait_lote";
            this.txt_wait_lote.Size = new System.Drawing.Size(100, 20);
            this.txt_wait_lote.TabIndex = 5;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(172, 163);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(264, 163);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frmConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 208);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_wait_lote);
            this.Controls.Add(this.txt_lote_msj);
            this.Controls.Add(this.txt_wait_msj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConfigure";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frmConfigure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_wait_msj;
        private System.Windows.Forms.TextBox txt_lote_msj;
        private System.Windows.Forms.TextBox txt_wait_lote;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}