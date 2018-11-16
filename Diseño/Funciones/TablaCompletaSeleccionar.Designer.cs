namespace Diseño.Funciones
{
    partial class TablaCompletaSeleccionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaCompletaSeleccionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSuperior1 = new System.Windows.Forms.Panel();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnSeleccionarTodos = new System.Windows.Forms.Button();
            this.bnEditarSeleccion = new System.Windows.Forms.Button();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.panelInferior3 = new System.Windows.Forms.Panel();
            this.bnCancelar = new System.Windows.Forms.Button();
            this.bnFinalizar = new System.Windows.Forms.Button();
            this.TablaBuscar = new System.Windows.Forms.DataGridView();
            this.TablaSeleccionados = new System.Windows.Forms.DataGridView();
            this.bnDeseleccionar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblN_Select = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FmTablaCompleta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deseleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelSuperior1.SuspendLayout();
            this.panelInferior3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaSeleccionados)).BeginInit();
            this.panel1.SuspendLayout();
            this.FmTablaCompleta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior1
            // 
            this.panelSuperior1.AutoScroll = true;
            this.panelSuperior1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSuperior1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSuperior1.Controls.Add(this.bnBuscar);
            this.panelSuperior1.Controls.Add(this.textBox1);
            this.panelSuperior1.Controls.Add(this.bnSeleccionarTodos);
            this.panelSuperior1.Controls.Add(this.bnEditarSeleccion);
            this.panelSuperior1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior1.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior1.Name = "panelSuperior1";
            this.panelSuperior1.Size = new System.Drawing.Size(486, 40);
            this.panelSuperior1.TabIndex = 2;
            // 
            // bnBuscar
            // 
            this.bnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnBuscar.ForeColor = System.Drawing.Color.White;
            this.bnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bnBuscar.Image")));
            this.bnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnBuscar.Location = new System.Drawing.Point(162, 2);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(72, 34);
            this.bnBuscar.TabIndex = 8;
            this.bnBuscar.Text = "Buscar";
            this.bnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.bnBuscar, "Buscar registro en la tabla por cualquiér atributo de texto.\r\nÉsta acción limpiar" +
        "á la lista de seleccionados.");
            this.bnBuscar.UseVisualStyleBackColor = false;
            this.bnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(11, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // bnSeleccionarTodos
            // 
            this.bnSeleccionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnSeleccionarTodos.BackColor = System.Drawing.SystemColors.Highlight;
            this.bnSeleccionarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSeleccionarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnSeleccionarTodos.ForeColor = System.Drawing.Color.White;
            this.bnSeleccionarTodos.Image = ((System.Drawing.Image)(resources.GetObject("bnSeleccionarTodos.Image")));
            this.bnSeleccionarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnSeleccionarTodos.Location = new System.Drawing.Point(250, 2);
            this.bnSeleccionarTodos.Name = "bnSeleccionarTodos";
            this.bnSeleccionarTodos.Size = new System.Drawing.Size(127, 34);
            this.bnSeleccionarTodos.TabIndex = 7;
            this.bnSeleccionarTodos.Text = "Seleccionar todos";
            this.bnSeleccionarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.bnSeleccionarTodos, "Añadir todos los registros a la lista de seleccionados.");
            this.bnSeleccionarTodos.UseVisualStyleBackColor = false;
            this.bnSeleccionarTodos.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnEditarSeleccion
            // 
            this.bnEditarSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnEditarSeleccion.BackColor = System.Drawing.SystemColors.Highlight;
            this.bnEditarSeleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnEditarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnEditarSeleccion.ForeColor = System.Drawing.Color.White;
            this.bnEditarSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("bnEditarSeleccion.Image")));
            this.bnEditarSeleccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnEditarSeleccion.Location = new System.Drawing.Point(379, 2);
            this.bnEditarSeleccion.Name = "bnEditarSeleccion";
            this.bnEditarSeleccion.Size = new System.Drawing.Size(102, 34);
            this.bnEditarSeleccion.TabIndex = 3;
            this.bnEditarSeleccion.Text = "Seleccionar";
            this.bnEditarSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.bnEditarSeleccion, "Añadir los registros marcados a la lista de seleccionados.");
            this.bnEditarSeleccion.UseVisualStyleBackColor = false;
            this.bnEditarSeleccion.Click += new System.EventHandler(this.bnEditarSeleccion_Click);
            // 
            // lblEntidad
            // 
            this.lblEntidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEntidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEntidad.Location = new System.Drawing.Point(376, 14);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(43, 13);
            this.lblEntidad.TabIndex = 4;
            this.lblEntidad.Tag = "";
            this.lblEntidad.Text = "Entidad";
            // 
            // panelInferior3
            // 
            this.panelInferior3.AutoScroll = true;
            this.panelInferior3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInferior3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInferior3.Controls.Add(this.lblEntidad);
            this.panelInferior3.Controls.Add(this.bnCancelar);
            this.panelInferior3.Controls.Add(this.bnFinalizar);
            this.panelInferior3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior3.Location = new System.Drawing.Point(0, 376);
            this.panelInferior3.Name = "panelInferior3";
            this.panelInferior3.Size = new System.Drawing.Size(797, 40);
            this.panelInferior3.TabIndex = 4;
            // 
            // bnCancelar
            // 
            this.bnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCancelar.ForeColor = System.Drawing.Color.White;
            this.bnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bnCancelar.Image")));
            this.bnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnCancelar.Location = new System.Drawing.Point(6, 3);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(102, 34);
            this.bnCancelar.TabIndex = 5;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnCancelar.UseVisualStyleBackColor = false;
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // bnFinalizar
            // 
            this.bnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnFinalizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnFinalizar.ForeColor = System.Drawing.Color.White;
            this.bnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("bnFinalizar.Image")));
            this.bnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnFinalizar.Location = new System.Drawing.Point(686, 3);
            this.bnFinalizar.Name = "bnFinalizar";
            this.bnFinalizar.Size = new System.Drawing.Size(102, 34);
            this.bnFinalizar.TabIndex = 4;
            this.bnFinalizar.Text = "Finalizar";
            this.bnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnFinalizar.UseVisualStyleBackColor = false;
            this.bnFinalizar.Click += new System.EventHandler(this.bnFinalizar_Click);
            // 
            // TablaBuscar
            // 
            this.TablaBuscar.AllowUserToAddRows = false;
            this.TablaBuscar.AllowUserToDeleteRows = false;
            this.TablaBuscar.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.TablaBuscar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TablaBuscar.BackgroundColor = System.Drawing.Color.White;
            this.TablaBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaBuscar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TablaBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaBuscar.Location = new System.Drawing.Point(0, 40);
            this.TablaBuscar.Name = "TablaBuscar";
            this.TablaBuscar.ReadOnly = true;
            this.TablaBuscar.Size = new System.Drawing.Size(486, 336);
            this.TablaBuscar.TabIndex = 5;
            this.TablaBuscar.DoubleClick += new System.EventHandler(this.bnEditarSeleccion_Click);
            // 
            // TablaSeleccionados
            // 
            this.TablaSeleccionados.AllowUserToAddRows = false;
            this.TablaSeleccionados.AllowUserToDeleteRows = false;
            this.TablaSeleccionados.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.TablaSeleccionados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TablaSeleccionados.BackgroundColor = System.Drawing.Color.White;
            this.TablaSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaSeleccionados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaSeleccionados.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TablaSeleccionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaSeleccionados.Location = new System.Drawing.Point(0, 40);
            this.TablaSeleccionados.Name = "TablaSeleccionados";
            this.TablaSeleccionados.ReadOnly = true;
            this.TablaSeleccionados.Size = new System.Drawing.Size(309, 334);
            this.TablaSeleccionados.TabIndex = 6;
            this.TablaSeleccionados.DoubleClick += new System.EventHandler(this.bnFinalizar_Click);
            // 
            // bnDeseleccionar
            // 
            this.bnDeseleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnDeseleccionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bnDeseleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnDeseleccionar.ForeColor = System.Drawing.Color.White;
            this.bnDeseleccionar.Image = ((System.Drawing.Image)(resources.GetObject("bnDeseleccionar.Image")));
            this.bnDeseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnDeseleccionar.Location = new System.Drawing.Point(186, 2);
            this.bnDeseleccionar.Name = "bnDeseleccionar";
            this.bnDeseleccionar.Size = new System.Drawing.Size(115, 34);
            this.bnDeseleccionar.TabIndex = 3;
            this.bnDeseleccionar.Text = "Deseleccionar";
            this.bnDeseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnDeseleccionar.UseVisualStyleBackColor = false;
            this.bnDeseleccionar.Click += new System.EventHandler(this.bnDeseleccionar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblN_Select);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bnDeseleccionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 40);
            this.panel1.TabIndex = 7;
            // 
            // lblN_Select
            // 
            this.lblN_Select.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblN_Select.AutoSize = true;
            this.lblN_Select.BackColor = System.Drawing.Color.Transparent;
            this.lblN_Select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblN_Select.Location = new System.Drawing.Point(147, 14);
            this.lblN_Select.Name = "lblN_Select";
            this.lblN_Select.Size = new System.Drawing.Size(13, 13);
            this.lblN_Select.TabIndex = 5;
            this.lblN_Select.Tag = "";
            this.lblN_Select.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Tag = "";
            this.label1.Text = "Registros seleccionados: ";
            // 
            // FmTablaCompleta
            // 
            this.FmTablaCompleta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem22,
            this.seleccionarToolStripMenuItem,
            this.deseleccionarToolStripMenuItem,
            this.finalizarToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.FmTablaCompleta.Name = "contextMenuStrip1";
            this.FmTablaCompleta.Size = new System.Drawing.Size(213, 114);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem22.Image")));
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem22.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItem22.Text = "Capturar";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStripMenuItem22_Click);
            // 
            // seleccionarToolStripMenuItem
            // 
            this.seleccionarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seleccionarToolStripMenuItem.Image")));
            this.seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            this.seleccionarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.seleccionarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.seleccionarToolStripMenuItem.Text = "Seleccionar";
            this.seleccionarToolStripMenuItem.Click += new System.EventHandler(this.bnEditarSeleccion_Click);
            // 
            // deseleccionarToolStripMenuItem
            // 
            this.deseleccionarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deseleccionarToolStripMenuItem.Image")));
            this.deseleccionarToolStripMenuItem.Name = "deseleccionarToolStripMenuItem";
            this.deseleccionarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.deseleccionarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.deseleccionarToolStripMenuItem.Text = "Deseleccionar";
            this.deseleccionarToolStripMenuItem.Click += new System.EventHandler(this.bnDeseleccionar_Click);
            // 
            // finalizarToolStripMenuItem
            // 
            this.finalizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("finalizarToolStripMenuItem.Image")));
            this.finalizarToolStripMenuItem.Name = "finalizarToolStripMenuItem";
            this.finalizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.finalizarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.finalizarToolStripMenuItem.Text = "Finalizar";
            this.finalizarToolStripMenuItem.Click += new System.EventHandler(this.bnFinalizar_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelarToolStripMenuItem.Image")));
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TablaSeleccionados);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(486, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 376);
            this.panel2.TabIndex = 8;
            // 
            // TablaCompletaSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 416);
            this.ContextMenuStrip = this.FmTablaCompleta;
            this.Controls.Add(this.TablaBuscar);
            this.Controls.Add(this.panelSuperior1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelInferior3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TablaCompletaSeleccionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica_Completa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Grafica_Completa_Load);
            this.panelSuperior1.ResumeLayout(false);
            this.panelSuperior1.PerformLayout();
            this.panelInferior3.ResumeLayout(false);
            this.panelInferior3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaSeleccionados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FmTablaCompleta.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior1;
        private System.Windows.Forms.Button bnEditarSeleccion;
        private System.Windows.Forms.Panel panelInferior3;
        private System.Windows.Forms.DataGridView TablaBuscar;
        private System.Windows.Forms.DataGridView TablaSeleccionados;
        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.Button bnDeseleccionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblN_Select;
        private System.Windows.Forms.ContextMenuStrip FmTablaCompleta;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem seleccionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deseleccionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.Button bnFinalizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bnSeleccionarTodos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.TextBox textBox1;
    }
}