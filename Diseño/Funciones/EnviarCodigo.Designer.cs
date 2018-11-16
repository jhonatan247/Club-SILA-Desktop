namespace Diseño.Funciones
{
    partial class EnviarCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarCodigo));
            this.FmTablaCompleta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.bnFinalizar = new System.Windows.Forms.Button();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbSalir = new System.Windows.Forms.Label();
            this.lbUsut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pBarra = new System.Windows.Forms.Panel();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.FmTablaCompleta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FmTablaCompleta
            // 
            this.FmTablaCompleta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem22,
            this.finalizarToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.FmTablaCompleta.Name = "contextMenuStrip1";
            this.FmTablaCompleta.Size = new System.Drawing.Size(192, 70);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem22.Image")));
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem22.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem22.Text = "Capturar";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStripMenuItem22_Click);
            // 
            // finalizarToolStripMenuItem
            // 
            this.finalizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("finalizarToolStripMenuItem.Image")));
            this.finalizarToolStripMenuItem.Name = "finalizarToolStripMenuItem";
            this.finalizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.finalizarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.finalizarToolStripMenuItem.Text = "Confirmar";
            this.finalizarToolStripMenuItem.Click += new System.EventHandler(this.bnFinalizar_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelarToolStripMenuItem.Image")));
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enviar código";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bnFinalizar
            // 
            this.bnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.bnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnFinalizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFinalizar.ForeColor = System.Drawing.Color.White;
            this.bnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnFinalizar.Location = new System.Drawing.Point(0, 130);
            this.bnFinalizar.Name = "bnFinalizar";
            this.bnFinalizar.Size = new System.Drawing.Size(332, 32);
            this.bnFinalizar.TabIndex = 3;
            this.bnFinalizar.Text = "Enviar";
            this.bnFinalizar.UseVisualStyleBackColor = false;
            this.bnFinalizar.Click += new System.EventHandler(this.bnFinalizar_Click);
            this.bnFinalizar.MouseLeave += new System.EventHandler(this.bnFinalizar_MouseLeave);
            this.bnFinalizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bnFinalizar_MouseMove);
            // 
            // txUsuario
            // 
            this.txUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txUsuario.Location = new System.Drawing.Point(22, 10);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(288, 22);
            this.txUsuario.TabIndex = 1;
            this.txUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txUsuario, "Nombre de usuario, nombre de usuario alternativo, correo, o documento.");
            this.txUsuario.Click += new System.EventHandler(this.usu_Click);
            this.txUsuario.TextChanged += new System.EventHandler(this.txUsuario_TextChanged);
            this.txUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txContraseña_KeyDown);
            // 
            // lbSalir
            // 
            this.lbSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSalir.AutoSize = true;
            this.lbSalir.ForeColor = System.Drawing.Color.Gray;
            this.lbSalir.Location = new System.Drawing.Point(318, 0);
            this.lbSalir.Name = "lbSalir";
            this.lbSalir.Size = new System.Drawing.Size(16, 16);
            this.lbSalir.TabIndex = 15;
            this.lbSalir.Text = "X";
            this.toolTip1.SetToolTip(this.lbSalir, "Cancelar");
            this.lbSalir.Click += new System.EventHandler(this.bnCancelar_Click);
            this.lbSalir.MouseLeave += new System.EventHandler(this.lbSalir_MouseLeave);
            this.lbSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbSalir_MouseMove);
            // 
            // lbUsut
            // 
            this.lbUsut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsut.AutoSize = true;
            this.lbUsut.BackColor = System.Drawing.Color.White;
            this.lbUsut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lbUsut.Location = new System.Drawing.Point(135, 11);
            this.lbUsut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsut.Name = "lbUsut";
            this.lbUsut.Size = new System.Drawing.Size(64, 20);
            this.lbUsut.TabIndex = 17;
            this.lbUsut.Text = "Usuario";
            this.toolTip1.SetToolTip(this.lbUsut, "Nombre de usuario, nombre de usuario alternativo, correo, o documento.");
            this.lbUsut.Click += new System.EventHandler(this.usu_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Por favor, ingresa tu nombre de usuario, correo electrónico o número de documento" +
    " para continuar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pBarra
            // 
            this.pBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.pBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.pBarra.Location = new System.Drawing.Point(0, 29);
            this.pBarra.Name = "pBarra";
            this.pBarra.Size = new System.Drawing.Size(260, 3);
            this.pBarra.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbUsut);
            this.panel1.Controls.Add(this.txUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 43);
            this.panel1.TabIndex = 18;
            // 
            // EnviarCodigo
            // 
            this.AcceptButton = this.bnFinalizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 162);
            this.ContextMenuStrip = this.FmTablaCompleta;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSalir);
            this.Controls.Add(this.pBarra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnFinalizar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EnviarCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Sila - Enviar código";
            this.Load += new System.EventHandler(this.Grafica_Completa_Load);
            this.FmTablaCompleta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip FmTablaCompleta;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem finalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnFinalizar;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pBarra;
        private System.Windows.Forms.Label lbSalir;
        private System.Windows.Forms.Label lbUsut;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Panel panel1;
    }
}