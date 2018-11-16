namespace Server
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.clientList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatWithClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txIP = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientList
            // 
            this.clientList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.clientList.ContextMenuStrip = this.menu;
            this.clientList.FullRowSelect = true;
            this.clientList.GridLines = true;
            this.clientList.Location = new System.Drawing.Point(340, 34);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(429, 156);
            this.clientList.TabIndex = 0;
            this.toolTip1.SetToolTip(this.clientList, "Usuariosen el chat");
            this.clientList.UseCompatibleStateImageBehavior = false;
            this.clientList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 138;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estado";
            this.columnHeader3.Width = 146;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.chatWithClientToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(181, 48);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disconnectToolStripMenuItem.Image")));
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "Desconectar Cliente";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // chatWithClientToolStripMenuItem
            // 
            this.chatWithClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chatWithClientToolStripMenuItem.Image")));
            this.chatWithClientToolStripMenuItem.Name = "chatWithClientToolStripMenuItem";
            this.chatWithClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chatWithClientToolStripMenuItem.Text = "Chatear Con Cliente";
            this.chatWithClientToolStripMenuItem.Click += new System.EventHandler(this.chatWithClientToolStripMenuItem_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(340, 203);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(348, 35);
            this.txtInput.TabIndex = 2;
            this.txtInput.Text = "Admin dice: Hey";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInput, "Mensaje");
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(694, 203);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 35);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Enviar";
            this.toolTip1.SetToolTip(this.btnSend, "Enviar mensaje");
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceive.BackColor = System.Drawing.Color.White;
            this.txtReceive.HideSelection = false;
            this.txtReceive.Location = new System.Drawing.Point(12, 11);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.Size = new System.Drawing.Size(322, 227);
            this.txtReceive.TabIndex = 4;
            this.txtReceive.Text = "";
            this.toolTip1.SetToolTip(this.txtReceive, "Conversación");
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            // 
            // txIP
            // 
            this.txIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txIP.Location = new System.Drawing.Point(340, 12);
            this.txIP.Name = "txIP";
            this.txIP.Size = new System.Drawing.Size(429, 20);
            this.txIP.TabIndex = 5;
            this.txIP.Text = "Dirección IP:";
            this.txIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txIP_KeyPress);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(777, 250);
            this.Controls.Add(this.txIP);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.clientList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SILA Chat - Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.VisibleChanged += new System.EventHandler(this.Main_VisibleChanged);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatWithClientToolStripMenuItem;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RichTextBox txtReceive;
        public System.Windows.Forms.ListView clientList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txIP;
    }
}

