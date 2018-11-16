namespace Diseño.Interfaz_de_usuario
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.tTransparencia = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnAceptar = new System.Windows.Forms.Button();
            this.bnCopiar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tImagenes = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tTransparencia
            // 
            this.tTransparencia.Tick += new System.EventHandler(this.tTransparencia_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 66);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(382, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Información de licencia del producto.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(240, 66);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bnAceptar);
            this.panel2.Controls.Add(this.bnCopiar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lstProductos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 309);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detalles del producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 249);
            this.label2.MaximumSize = new System.Drawing.Size(450, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // bnAceptar
            // 
            this.bnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAceptar.Location = new System.Drawing.Point(488, 274);
            this.bnAceptar.Name = "bnAceptar";
            this.bnAceptar.Size = new System.Drawing.Size(103, 23);
            this.bnAceptar.TabIndex = 5;
            this.bnAceptar.Text = "Aceptar";
            this.bnAceptar.UseVisualStyleBackColor = true;
            this.bnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnCopiar
            // 
            this.bnCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCopiar.Location = new System.Drawing.Point(488, 94);
            this.bnCopiar.Name = "bnCopiar";
            this.bnCopiar.Size = new System.Drawing.Size(103, 23);
            this.bnCopiar.TabIndex = 4;
            this.bnCopiar.Text = "Copiar información";
            this.bnCopiar.UseVisualStyleBackColor = true;
            this.bnCopiar.Click += new System.EventHandler(this.bnCopiar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblDescripcion);
            this.panel3.Controls.Add(this.pbIcono);
            this.panel3.Location = new System.Drawing.Point(32, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 62);
            this.panel3.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(66, 5);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(370, 450);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(370, 26);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Advertencia: este programa está protegido por las leyes de derecho de autor y otr" +
    "os tratados internacionales.";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.White;
            this.pbIcono.Location = new System.Drawing.Point(5, 5);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(50, 50);
            this.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcono.TabIndex = 0;
            this.pbIcono.TabStop = false;
            // 
            // lstProductos
            // 
            this.lstProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.HorizontalScrollbar = true;
            this.lstProductos.Items.AddRange(new object[] {
            "Microsoft SQL Server 2012",
            "Club Sila x86",
            "Microsoft.NET Framework 4.6.00081"});
            this.lstProductos.Location = new System.Drawing.Point(32, 97);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(450, 67);
            this.lstProductos.TabIndex = 2;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Club Sila\r\nVersión: 1.4.5\r\n© Encrypt Code Corporation.\r\nReservados todos los dere" +
    "chos.\r\n\r\nProductos instalados:";
            // 
            // tImagenes
            // 
            this.tImagenes.Interval = 200;
            this.tImagenes.Tick += new System.EventHandler(this.tImagenes_Tick);
            // 
            // AcercaDe
            // 
            this.AcceptButton = this.bnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcercaDe";
            this.Opacity = 0.5D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de Club Sila";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AcercaDe_FormClosing);
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tTransparencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnAceptar;
        private System.Windows.Forms.Button bnCopiar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Timer tImagenes;
    }
}