namespace WhatsAppPort
{
    partial class frmForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm));
            this.listViewContacts = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddContact = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add_contacts = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarContactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosDeEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewContacts
            // 
            this.listViewContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
            this.listViewContacts.Location = new System.Drawing.Point(12, 43);
            this.listViewContacts.MultiSelect = false;
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(660, 410);
            this.listViewContacts.TabIndex = 0;
            this.listViewContacts.UseCompatibleStateImageBehavior = false;
            this.listViewContacts.View = System.Windows.Forms.View.Details;
            this.listViewContacts.SelectedIndexChanged += new System.EventHandler(this.listViewContacts_SelectedIndexChanged);
            this.listViewContacts.DoubleClick += new System.EventHandler(this.listViewContacts_DoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Nombre";
            this.columnHeaderName.Width = 260;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddContact.Location = new System.Drawing.Point(610, 26);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(77, 23);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Agregar Contacto";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Enviar Mensaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add_contacts
            // 
            this.btn_add_contacts.Location = new System.Drawing.Point(78, 465);
            this.btn_add_contacts.Name = "btn_add_contacts";
            this.btn_add_contacts.Size = new System.Drawing.Size(117, 23);
            this.btn_add_contacts.TabIndex = 3;
            this.btn_add_contacts.Text = "&Agregar Contactos";
            this.btn_add_contacts.UseVisualStyleBackColor = true;
            this.btn_add_contacts.Click += new System.EventHandler(this.btn_add_contacts_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit Contacts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "&Establecer Mensaje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(262, 459);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(475, 459);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 40);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.acercaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarContactosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // agregarContactosToolStripMenuItem
            // 
            this.agregarContactosToolStripMenuItem.Name = "agregarContactosToolStripMenuItem";
            this.agregarContactosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarContactosToolStripMenuItem.Text = "Agregar Contactos";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosDeEnvioToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.acercaToolStripMenuItem.Text = "Acerca";
            // 
            // parametrosDeEnvioToolStripMenuItem
            // 
            this.parametrosDeEnvioToolStripMenuItem.Name = "parametrosDeEnvioToolStripMenuItem";
            this.parametrosDeEnvioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.parametrosDeEnvioToolStripMenuItem.Text = "Parametros de envio";
            this.parametrosDeEnvioToolStripMenuItem.Click += new System.EventHandler(this.parametrosDeEnvioToolStripMenuItem_Click);
            // 
            // frmForm
            // 
            this.AcceptButton = this.btnAddContact;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_add_contacts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.listViewContacts);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewContacts;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add_contacts;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarContactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosDeEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
    }
}

