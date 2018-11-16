namespace Diseño.Funciones
{
    partial class PantallaCompleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCompleta));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.imagenSiguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.toolStripSeparator3,
            this.imagenSiguienteToolStripMenuItem,
            this.imagenAnteriorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 76);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // imagenSiguienteToolStripMenuItem
            // 
            this.imagenSiguienteToolStripMenuItem.Name = "imagenSiguienteToolStripMenuItem";
            this.imagenSiguienteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.imagenSiguienteToolStripMenuItem.Text = "Imagen siguiente >";
            this.imagenSiguienteToolStripMenuItem.Click += new System.EventHandler(this.imagenSiguienteToolStripMenuItem_Click);
            // 
            // imagenAnteriorToolStripMenuItem
            // 
            this.imagenAnteriorToolStripMenuItem.Name = "imagenAnteriorToolStripMenuItem";
            this.imagenAnteriorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.imagenAnteriorToolStripMenuItem.Text = "<Imagen anterior";
            this.imagenAnteriorToolStripMenuItem.Click += new System.EventHandler(this.imagenAnteriorToolStripMenuItem_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(1, 1);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Pantallazo(1)";
            this.toolTip1.SetToolTip(this.lblNombre, "Nombre");
            this.lblNombre.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Black;
            this.pbImagen.ContextMenuStrip = this.contextMenuStrip1;
            this.pbImagen.ForeColor = System.Drawing.Color.Black;
            this.pbImagen.Location = new System.Drawing.Point(332, 208);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(100, 50);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 4;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PantallaCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 467);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbImagen);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PantallaCompleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imágen - ";
            this.toolTip1.SetToolTip(this, "Click para salir");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pantalla_Completa_FormClosing);
            this.Load += new System.EventHandler(this.pantalla_Completa_Load);
            this.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pantalla_Completa_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem imagenSiguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenAnteriorToolStripMenuItem;

    }
}