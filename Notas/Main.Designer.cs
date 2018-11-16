namespace Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.openDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.saveDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapaDeCaracteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alineaciónDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstádoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Linea = new System.Windows.Forms.ToolStripStatusLabel();
            this.Columna = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.textBox2,
            this.herramientasToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(733, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolStripSeparator5,
            this.openDialogToolStripMenuItem,
            this.browseDialogToolStripMenuItem,
            this.toolStripSeparator2,
            this.colorDialogToolStripMenuItem,
            this.toolStripSeparator4,
            this.printDialogToolStripMenuItem,
            this.toolStripSeparator6,
            this.saveDialogToolStripMenuItem,
            this.toolStripSeparator7,
            this.exToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.fileToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(170, 6);
            // 
            // openDialogToolStripMenuItem
            // 
            this.openDialogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openDialogToolStripMenuItem.Image")));
            this.openDialogToolStripMenuItem.Name = "openDialogToolStripMenuItem";
            this.openDialogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.openDialogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openDialogToolStripMenuItem.Text = "Abrir";
            this.openDialogToolStripMenuItem.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // browseDialogToolStripMenuItem
            // 
            this.browseDialogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("browseDialogToolStripMenuItem.Image")));
            this.browseDialogToolStripMenuItem.Name = "browseDialogToolStripMenuItem";
            this.browseDialogToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F18;
            this.browseDialogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.browseDialogToolStripMenuItem.Text = "Abrir carpeta";
            this.browseDialogToolStripMenuItem.Click += new System.EventHandler(this.Carpeta_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // colorDialogToolStripMenuItem
            // 
            this.colorDialogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorDialogToolStripMenuItem.Image")));
            this.colorDialogToolStripMenuItem.Name = "colorDialogToolStripMenuItem";
            this.colorDialogToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F16;
            this.colorDialogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.colorDialogToolStripMenuItem.Text = "Color de texto";
            this.colorDialogToolStripMenuItem.Click += new System.EventHandler(this.Color_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // printDialogToolStripMenuItem
            // 
            this.printDialogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printDialogToolStripMenuItem.Image")));
            this.printDialogToolStripMenuItem.Name = "printDialogToolStripMenuItem";
            this.printDialogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.printDialogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.printDialogToolStripMenuItem.Text = "Imprimir";
            this.printDialogToolStripMenuItem.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(170, 6);
            // 
            // saveDialogToolStripMenuItem
            // 
            this.saveDialogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveDialogToolStripMenuItem.Image")));
            this.saveDialogToolStripMenuItem.Name = "saveDialogToolStripMenuItem";
            this.saveDialogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.saveDialogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveDialogToolStripMenuItem.Text = "Guardar";
            this.saveDialogToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveDialogToolStripMenuItem.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(170, 6);
            // 
            // exToolStripMenuItem
            // 
            this.exToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exToolStripMenuItem.Image")));
            this.exToolStripMenuItem.Name = "exToolStripMenuItem";
            this.exToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exToolStripMenuItem.Text = "Salir";
            this.exToolStripMenuItem.Click += new System.EventHandler(this.exToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.Text = "Nuevo";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapaDeCaracteresToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // mapaDeCaracteresToolStripMenuItem
            // 
            this.mapaDeCaracteresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mapaDeCaracteresToolStripMenuItem.Image")));
            this.mapaDeCaracteresToolStripMenuItem.Name = "mapaDeCaracteresToolStripMenuItem";
            this.mapaDeCaracteresToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mapaDeCaracteresToolStripMenuItem.Text = "Mapa de caracteres";
            this.mapaDeCaracteresToolStripMenuItem.Click += new System.EventHandler(this.mapaDeCaracteresToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontDialogToolStripMenuItem,
            this.alineaciónDeTextoToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // fontDialogToolStripMenuItem
            // 
            this.fontDialogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontDialogToolStripMenuItem.Image")));
            this.fontDialogToolStripMenuItem.Name = "fontDialogToolStripMenuItem";
            this.fontDialogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontDialogToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fontDialogToolStripMenuItem.Text = "Fuente";
            this.fontDialogToolStripMenuItem.Click += new System.EventHandler(this.Fuente_Click);
            // 
            // alineaciónDeTextoToolStripMenuItem
            // 
            this.alineaciónDeTextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.derechaToolStripMenuItem,
            this.izquierdaToolStripMenuItem,
            this.centroToolStripMenuItem});
            this.alineaciónDeTextoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alineaciónDeTextoToolStripMenuItem.Image")));
            this.alineaciónDeTextoToolStripMenuItem.Name = "alineaciónDeTextoToolStripMenuItem";
            this.alineaciónDeTextoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.alineaciónDeTextoToolStripMenuItem.Text = "Alineación de texto";
            // 
            // derechaToolStripMenuItem
            // 
            this.derechaToolStripMenuItem.Checked = true;
            this.derechaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.derechaToolStripMenuItem.Name = "derechaToolStripMenuItem";
            this.derechaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.derechaToolStripMenuItem.Text = "Derecha";
            this.derechaToolStripMenuItem.Click += new System.EventHandler(this.derechaToolStripMenuItem_Click);
            // 
            // izquierdaToolStripMenuItem
            // 
            this.izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            this.izquierdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.izquierdaToolStripMenuItem.Text = "Izquierda";
            this.izquierdaToolStripMenuItem.Click += new System.EventHandler(this.izquierdaToolStripMenuItem_Click);
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.centroToolStripMenuItem.Text = "Centro";
            this.centroToolStripMenuItem.Click += new System.EventHandler(this.centroToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Checked = true;
            this.verToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraDeEstádoToolStripMenuItem,
            this.editorToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 23);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // barraDeEstádoToolStripMenuItem
            // 
            this.barraDeEstádoToolStripMenuItem.Checked = true;
            this.barraDeEstádoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraDeEstádoToolStripMenuItem.Name = "barraDeEstádoToolStripMenuItem";
            this.barraDeEstádoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.barraDeEstádoToolStripMenuItem.Text = "Barra de estádo";
            this.barraDeEstádoToolStripMenuItem.Click += new System.EventHandler(this.barraDeEstádoToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Checked = true;
            this.editorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de Editor de texto";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(733, 429);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Title = "Save file";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "select a directory";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.ShowHelp = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fontDialog1.ShowColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Linea,
            this.Columna});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(733, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Linea
            // 
            this.Linea.BackColor = System.Drawing.Color.White;
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(52, 17);
            this.Linea.Text = "Lineas: 0";
            // 
            // Columna
            // 
            this.Columna.BackColor = System.Drawing.Color.White;
            this.Columna.Name = "Columna";
            this.Columna.Size = new System.Drawing.Size(74, 17);
            this.Columna.Text = "Carácteres: 0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(733, 478);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(454, 516);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".::Editor de texto::.";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripTextBox textBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Linea;
        private System.Windows.Forms.ToolStripStatusLabel Columna;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapaDeCaracteresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeEstádoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alineaciónDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
    }
}

