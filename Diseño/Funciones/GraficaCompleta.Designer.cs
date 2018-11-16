namespace Diseño.Funciones
{
    partial class GraficaCompleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraficaCompleta));
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chGraficar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ípoDeGráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbForma = new System.Windows.Forms.ToolStripComboBox();
            this.paletaDeColoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbPaleta = new System.Windows.Forms.ToolStripComboBox();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chGraficar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // chGraficar
            // 
            this.chGraficar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem22,
            this.toolStripSeparator1,
            this.ípoDeGráficaToolStripMenuItem,
            this.paletaDeColoresToolStripMenuItem});
            this.chGraficar.Name = "contextMenuStrip1";
            this.chGraficar.Size = new System.Drawing.Size(225, 76);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem22.Image")));
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem22.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItem22.Text = "Capturar gráfica";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStripMenuItem22_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // ípoDeGráficaToolStripMenuItem
            // 
            this.ípoDeGráficaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbForma});
            this.ípoDeGráficaToolStripMenuItem.Name = "ípoDeGráficaToolStripMenuItem";
            this.ípoDeGráficaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.ípoDeGráficaToolStripMenuItem.Text = "Típo de gráfica";
            // 
            // cbForma
            // 
            this.cbForma.Items.AddRange(new object[] {
            "Point",
            "FastPoint",
            "Bubble",
            "Line",
            "Spline",
            "StepLine",
            "FastLine",
            "Bar",
            "StackedBar",
            "StackedBar100",
            "Column",
            "StackedColumn",
            "StackedColumn100",
            "Area",
            "SplineArea",
            "StackedArea",
            "StackedArea100",
            "Pie",
            "Doughnut",
            "Stock",
            "Candlestick",
            "Range",
            "SplineRange",
            "RangeBar",
            "RangeColumn",
            "Radar",
            "Polar",
            "ErrorBar",
            "BoxPlot",
            "Renko",
            "ThreeLineBreak",
            "Kagi",
            "PonitAndFigure",
            "Funnel",
            "Pyramid"});
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(121, 23);
            this.cbForma.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // paletaDeColoresToolStripMenuItem
            // 
            this.paletaDeColoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbPaleta});
            this.paletaDeColoresToolStripMenuItem.Name = "paletaDeColoresToolStripMenuItem";
            this.paletaDeColoresToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.paletaDeColoresToolStripMenuItem.Text = "Paleta de colores";
            // 
            // cbPaleta
            // 
            this.cbPaleta.Items.AddRange(new object[] {
            "Ninguno",
            "Bright",
            "GrayScale",
            "Excel",
            "Light",
            "Pastel",
            "EarthTones",
            "SemiTransparent",
            "Berry",
            "Chocolate",
            "Fire",
            "SeaGreen",
            "BrightPastel"});
            this.cbPaleta.Name = "cbPaleta";
            this.cbPaleta.Size = new System.Drawing.Size(121, 23);
            this.cbPaleta.SelectedIndexChanged += new System.EventHandler(this.cbPaleta_SelectedIndexChanged);
            // 
            // Grafica
            // 
            lineAnnotation1.Name = "LineAnnotation1";
            this.Grafica.Annotations.Add(lineAnnotation1);
            this.Grafica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Grafica.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent80;
            this.Grafica.BackSecondaryColor = System.Drawing.Color.White;
            this.Grafica.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent60;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.Grafica.ChartAreas.Add(chartArea1);
            this.Grafica.ContextMenuStrip = this.chGraficar;
            this.Grafica.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Grafica.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.InterlacedRowsColor = System.Drawing.Color.Transparent;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.ShadowColor = System.Drawing.Color.White;
            legend1.TitleForeColor = System.Drawing.Color.White;
            this.Grafica.Legends.Add(legend1);
            this.Grafica.Location = new System.Drawing.Point(0, 0);
            this.Grafica.Name = "Grafica";
            this.Grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Black;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.Label = "#VAL{N}";
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.Name = "Entidad";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt64;
            this.Grafica.Series.Add(series1);
            this.Grafica.Size = new System.Drawing.Size(284, 262);
            this.Grafica.TabIndex = 5;
            this.Grafica.Text = "Grafica";
            title1.BackColor = System.Drawing.SystemColors.Control;
            title1.BackSecondaryColor = System.Drawing.Color.Transparent;
            title1.BorderColor = System.Drawing.Color.Black;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.Transparent;
            title1.Text = "Gráfica de objetos";
            this.Grafica.Titles.Add(title1);
            this.Grafica.Click += new System.EventHandler(this.chart1_Click);
            // 
            // GraficaCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Grafica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraficaCompleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Grafica_Completa_Load);
            this.chGraficar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip chGraficar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem ípoDeGráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbForma;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem paletaDeColoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbPaleta;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
    }
}