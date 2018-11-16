namespace Diseño.Funciones
{
    partial class EntidadCompleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntidadCompleta));
            this.FmEntidad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.FmEntidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // FmEntidad
            // 
            this.FmEntidad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem22});
            this.FmEntidad.Name = "contextMenuStrip1";
            this.FmEntidad.Size = new System.Drawing.Size(229, 26);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem22.Image")));
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem22.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItem22.Text = "Capturar entidad";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStripMenuItem22_Click);
            // 
            // EntidadCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(439, 415);
            this.ContextMenuStrip = this.FmEntidad;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntidadCompleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Grafica_Completa_Load);
            this.Click += new System.EventHandler(this.chart1_Click);
            this.FmEntidad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip FmEntidad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
    }
}