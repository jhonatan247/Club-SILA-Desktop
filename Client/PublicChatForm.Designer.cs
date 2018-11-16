namespace Client
{
    partial class PublicChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicChatForm));
            this.ListarUsuarios = new System.Windows.Forms.ListBox();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.privateChat = new System.Windows.Forms.ToolStripMenuItem();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListarUsuarios
            // 
            this.ListarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListarUsuarios.BackColor = System.Drawing.Color.White;
            this.ListarUsuarios.ContextMenuStrip = this.menu;
            this.ListarUsuarios.FormattingEnabled = true;
            this.ListarUsuarios.Location = new System.Drawing.Point(354, 12);
            this.ListarUsuarios.Name = "ListarUsuarios";
            this.ListarUsuarios.Size = new System.Drawing.Size(173, 342);
            this.ListarUsuarios.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ListarUsuarios, "Usuarios conectados");
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateChat});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(143, 26);
            // 
            // privateChat
            // 
            this.privateChat.Image = global::Client.Properties.Resources.Chat_128;
            this.privateChat.Name = "privateChat";
            this.privateChat.Size = new System.Drawing.Size(142, 22);
            this.privateChat.Text = "Chat Privado";
            this.privateChat.Click += new System.EventHandler(this.privateChat_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceive.BackColor = System.Drawing.Color.White;
            this.txtReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive.HideSelection = false;
            this.txtReceive.Location = new System.Drawing.Point(9, 12);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.Size = new System.Drawing.Size(339, 305);
            this.txtReceive.TabIndex = 1;
            this.txtReceive.Text = "";
            this.toolTip1.SetToolTip(this.txtReceive, "Conversación");
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(9, 323);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(242, 32);
            this.txtInput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtInput, "Mensaje");
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(257, 322);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 32);
            this.btnSend.TabIndex = 3;
            this.btnSend.Tag = "Enviar mensaje";
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // PublicChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(537, 361);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.ListarUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PublicChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SILA Chat - ip - (Connected as: user)";
            this.Load += new System.EventHandler(this.PublicChatForm_Load);
            this.VisibleChanged += new System.EventHandler(this.PublicChatForm_VisibleChanged);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtReceive;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem privateChat;
        private System.Windows.Forms.ListBox ListarUsuarios;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}