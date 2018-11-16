using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Main : Form
    {
        bool Escribiendo1 = true;
        bool Operando = false;
        bool Escribiendo2 = false;
        List<Int32> Operaciones = new List<int>();
        List<float> Valores1 = new List<float>();
        List<float> Valores2 = new List<float>();
        Int32 Operacion { get; set; }
        float Valor1 { get; set; }
        float Valor2 { get; set; }
        public Main()
        {
            Valor1 = 0;
            InitializeComponent();
        }
        void Mems()
        {
            Memoria.BringToFront();
            if (ssEstado.Visible)
            {
                Memoria.Height = 125;
            }
            else
            {
                Memoria.Height = 150;
            }
        }
        void Controltx()
        {
            if (Width == 216 && txPrincipal.Text.Length <= 14)
            {
                this.txPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else if (Width == 216 && txPrincipal.Text.Length > 14 && txPrincipal.Text.Length <= 18)
            {
                this.txPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else if (Width == 216 && txPrincipal.Text.Length > 18 && txPrincipal.Text.Length <= 20)
            {
                this.txPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else if (Width == 216 && txPrincipal.Text.Length > 20 && txPrincipal.Text.Length <= 26)
            {
                this.txPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else if (Width == 216 && txPrincipal.Text.Length > 26)
            {
                this.txPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '0':
                    bn0.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case '1':
                    bn1.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case '2':
                    bn2.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case '3':
                    bn3.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case '4':
                    bn4.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case '5':
                    bn5.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case '6':
                    bn6.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case '7':
                    bn7.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case '8':
                    bn8.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case '9':
                    bn9.Focus();
                    Operando = Calculadora.Numero(e.KeyChar, txPrincipal);
                    break;
                case ',':
                    bnComa.Focus();
                    Operando = Calculadora.Coma(txPrincipal);
                    break;
                case '.':
                    bnComa.Focus();
                    Operando = Calculadora.Coma(txPrincipal);
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyValue)
            {
                case (char)Keys.Enter:
                    bnIgual.Focus();
                    bnIgual.PerformClick();
                    break;
                case (char)Keys.Back:
                    bnDel.Focus();
                    bnDel.PerformClick();
                    break;
                case (char)Keys.Delete:
                    bnCE.Focus();
                    bnCE.PerformClick();
                    break;
                case (char)Keys.Space:
                    bnIgual.Focus();
                    bnIgual.PerformClick();
                    break;
                case (char)Keys.Escape:
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void txPrincipal_TextChanged(object sender, EventArgs e)
        {
            if(txPrincipal.Text == "")
            {
                txPrincipal.Text = "0";
            }
            if (txPrincipal.Text.Length > 32)
            {
                txPrincipal.Text = txPrincipal.Text.Substring(0, txPrincipal.Text.Length - 1);
            }
            Controltx();
        }

        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estandarToolStripMenuItem.Checked = true;
            cientificaToolStripMenuItem.Checked = false;
            pnlCientifica.Hide();
            pnlTipo.Hide();
            this.Width = 216;
            Controltx();
            CenterToScreen();
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estandarToolStripMenuItem.Checked = false;
            cientificaToolStripMenuItem.Checked = true;
            pnlCientifica.Show();
            pnlTipo.Show();
            this.Width = 475;
            this.txPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CenterToScreen();
        }

        private void barraDeEstádoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeEstádoToolStripMenuItem.Checked = !barraDeEstádoToolStripMenuItem.Checked;
            ssEstado.Visible = !ssEstado.Visible;
            Mems();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Numero_Click(object sender, EventArgs e)
        {
            Operando = Calculadora.Numero(Convert.ToChar(((Button)sender).Text), txPrincipal);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            estandarToolStripMenuItem.PerformClick();
            CenterToScreen();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Operando = Calculadora.Borrar(txPrincipal);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Operando = Calculadora.Coma(txPrincipal);
        }

        private void bnSigno_Click(object sender, EventArgs e)
        {
            Operando = Calculadora.Signo(txPrincipal);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txPrincipal.Clear();
        }

        private void memoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            memoriaToolStripMenuItem.Checked = !memoriaToolStripMenuItem.Checked;
            if(memoriaToolStripMenuItem.Checked)
            {
                Memoria.Show();
                Height = 475;
            }
            else
            {
                Memoria.Hide();
                Height = 350;
            }
            Mems();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Escribiendo1 | Operando)
            {
                Escribiendo1 = false;
                Operando = true;
                Escribiendo2 = true;
                Valor1 = float.Parse(txPrincipal.Text);
                Operacion = Convert.ToInt32(((Button)sender).Tag);
                txOperacion.Text = Calculadora.Operacion(Operacion, txPrincipal.Text);
                txPrincipal.Clear();
            }
        }

        private void bnIgual_Click(object sender, EventArgs e)
        {
            if(Escribiendo2)
            {
                Valor2 = float.Parse(txPrincipal.Text);
                txOperacion.Text += txPrincipal.Text;
                txPrincipal.Text = Calculadora.Operar(Valor1, Operacion, Valor2).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Valor1 = 1;
            Operacion = 4;
            txOperacion.Text = Calculadora.Operacion(Operacion, "1");
            Valor2 = float.Parse(txPrincipal.Text);
            txOperacion.Text += txPrincipal.Text;
            txPrincipal.Text = Calculadora.Operar(Valor1, Operacion, Valor2).ToString();
        }
    }
}
