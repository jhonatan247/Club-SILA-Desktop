using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Notas
{
    public partial class Main : Form
    {
        private string stropen;
        private string strsave;
        public Main()
        {
            InitializeComponent();
        }
        private void exToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Fuente_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            
            }
                
        }
        private void Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.BackColor = colorDialog1.Color;
                //menuStrip1.BackColor = colorDialog1.Color;
                textBox1.ForeColor = colorDialog1.Color;
            }
        }
        private void Carpeta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Clear();
                textBox2.Text = folderBrowserDialog1.SelectedPath;
                string[] lista = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.txt");
                foreach (String l in lista)
                {
                    textBox1.Text += "\n"+ System.IO.File.ReadAllText(l);
                }
            }
        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir archivo";
            openFileDialog1.Filter = "Text file (*.txt)|*.txt|All file(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                stropen = openFileDialog1.FileName;
                textBox1.Text = System.IO.File.ReadAllText(stropen);
                textBox2.Text = stropen;
            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivo de texto (*.txt)|*.txt|Todos los archivos(*.*)|*.*";
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.FileName = textBox2.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strsave = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(strsave, textBox1.Text);
            }
        }
        private void Imprimir_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
        private void Nuevo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nuevo";
            textBox1.Clear();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;

            if (textBox1.Text.Length > 0)
            {
                result = MessageBox.Show("¿Desea guardar los cambios en un archivo de texto?", "¿Guardar?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    saveDialogToolStripMenuItem.PerformClick();
                }
                
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new System.Drawing.Font("Arial", 12);
            String fileToPrint = this.textBox1.Text;
            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            yPos = topMargin + count * printFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(fileToPrint, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            count++;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Linea.Text = "Lineas: " + textBox1.Lines.Length;
            Columna.Text = "Carácteres: " + textBox1.Text.Trim().Length;
        }
        private void mapaDeCaracteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"charmap.exe");
            }
            catch { }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void barraDeEstádoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeEstádoToolStripMenuItem.Checked = !barraDeEstádoToolStripMenuItem.Checked;
            statusStrip1.Visible = !statusStrip1.Visible;
        }

        private void derechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            derechaToolStripMenuItem.Checked = true;
            izquierdaToolStripMenuItem.Checked = false;
            centroToolStripMenuItem.Checked = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }

        private void izquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            derechaToolStripMenuItem.Checked = false;
            izquierdaToolStripMenuItem.Checked = true;
            centroToolStripMenuItem.Checked = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            derechaToolStripMenuItem.Checked = false;
            izquierdaToolStripMenuItem.Checked = false;
            centroToolStripMenuItem.Checked = true;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorToolStripMenuItem.Checked = !editorToolStripMenuItem.Checked;
            textBox1.Visible = !textBox1.Visible;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true); // recupera los datos del archivo que arrastre
                ((TextBox)sender).Text = "";
                foreach (string file in files)
                {
                    ((TextBox)sender).Text += System.IO.File.ReadAllText(file);
                }
            }
            catch{}
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}