#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

#region Navegador
namespace Navegador
{
    #region Program
    public partial class Acercade : Form
    {
        #region Atributos
        int timer = 0, timer2 = 1;
        #endregion

        #region Constructor
        public Acercade()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void Acercade_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        #endregion

        #region Métodos
        private void Colores1()
        {
            timer++;
            if (timer == 1)
            {
                label6.ForeColor = Color.Crimson;
                label3.ForeColor = Color.White;
            }
            else if (timer == 2)
            {
                label6.ForeColor = Color.DeepPink;
                label3.ForeColor = Color.Tomato;
            }
            else if (timer == 3)
            {
                label6.ForeColor = Color.Violet;
                label3.ForeColor = Color.Orange;
            }
            else if (timer == 4)
            {
                label6.ForeColor = Color.MediumPurple;
                label3.ForeColor = Color.GreenYellow;
            }
            else if (timer == 5)
            {
                label6.ForeColor = Color.DodgerBlue;
                label3.ForeColor = Color.Turquoise;
            }
            else if (timer == 6)
            {
                label6.ForeColor = Color.Turquoise;
                label3.ForeColor = Color.DodgerBlue;
            }
            else if (timer == 7)
            {
                label6.ForeColor = Color.GreenYellow;
                label3.ForeColor = Color.MediumPurple;
            }
            else if (timer == 8)
            {
                label6.ForeColor = Color.Orange;
                label3.ForeColor = Color.Violet;
            }
            else if (timer == 9)
            {
                label6.ForeColor = Color.Tomato;
                label3.ForeColor = Color.DeepPink;
            }
            else if (timer == 10)
            {
                label6.ForeColor = Color.White;
                label3.ForeColor = Color.Crimson;
                timer = 0;
            }
        }
        private void Colores2()
        {
            if (timer2 == 0)
            {
                label4.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                Timer2.Enabled = false;
            }

            else if (timer2 == 1)
            {
                label4.ForeColor = Color.Yellow;
                label7.ForeColor = Color.Yellow;
            }
            else if (timer2 == 2)
            {
                label4.ForeColor = Color.Yellow;
                label7.ForeColor = Color.Yellow;
            }
            else if (timer2 == 3)
            {
                label4.ForeColor = Color.Yellow;
                label7.ForeColor = Color.Yellow;
            }
            else if (timer2 == 4)
            {
                label4.ForeColor = Color.Yellow;
                label7.ForeColor = Color.Yellow;
            }
            else if (timer2 == 5)
            {
                label4.ForeColor = Color.Yellow;
                label7.ForeColor = Color.Yellow;
            }
            else if (timer2 == 6)
            {
                label4.ForeColor = Color.Yellow;
                label7.ForeColor = Color.Yellow;
            }
            else if (timer2 == 7)
            {
                label4.ForeColor = Color.Blue;
                label7.ForeColor = Color.Blue;
            }
            else if (timer2 == 8)
            {
                label4.ForeColor = Color.Blue;
                label7.ForeColor = Color.Blue;
            }
            else if (timer2 == 9)
            {
                label4.ForeColor = Color.Blue;
                label7.ForeColor = Color.Blue;
            }
            else if (timer2 == 10)
            {
                label4.ForeColor = Color.Red;
                label7.ForeColor = Color.Red;
            }
            else if (timer2 == 11)
            {
                label4.ForeColor = Color.Red;
                label7.ForeColor = Color.Red;
            }
            else if (timer2 == 12)
            {
                label4.ForeColor = Color.Red;
                label7.ForeColor = Color.Red;
                timer2 = 1;
            }
            timer2++;
        }
        #endregion

        #region Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            timer2 = 1;
            button3.Show();
            Timer2.Enabled = true;
            button1.ForeColor = Color.Red;
        }
        private void Acercade_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Hide();
            timer2 = 0;

            button1.ForeColor = Color.Aqua;
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            timer2 = 1;
            Timer2.Enabled = true;

            button1.ForeColor = Color.Red;
            button3.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Colores1();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Colores2();
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion