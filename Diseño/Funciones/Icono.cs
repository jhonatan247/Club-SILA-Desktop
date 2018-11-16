#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Lógica;
using Negocio.Manejo_de_datos;
using System.Media;
using Diseño.Properties;
#endregion

#region Funciones
namespace Diseño.Funciones
{
    #region Formulario
    public partial class Icono : Form
    {
        #region Atributos
        Boolean top = true;
        Boolean left = true;
        Int32 Speed = 25;
        AccionesSistema As = new AccionesSistema();
        #endregion

        #region Propiedades
        List<Image> Img { get; set; }
        #endregion

        #region Constructor
        public Icono()
        {
            InitializeComponent();
            Img = As.Imagenes();
        }
        #endregion

        #region Métodos
        #endregion

        #region Eventos
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (top == true) Icono.ActiveForm.Top += Speed; else Icono.ActiveForm.Top -= Speed;
                if (left == true) Icono.ActiveForm.Left += Speed; else Icono.ActiveForm.Left -= Speed;

                if (Icono.ActiveForm.Top >= Screen.PrimaryScreen.Bounds.Height - pictureBox1.Height)
                {
                    top = false;
                    pictureBox1.Image = Img[3];
                }
                else if (Icono.ActiveForm.Left >= Screen.PrimaryScreen.Bounds.Width - pictureBox1.Width)
                {
                    left = false;
                    pictureBox1.Image = Img[5];
                }
                else if (Icono.ActiveForm.Top < -5)
                {
                    top = true;
                    pictureBox1.Image = Img[5];
                }
                else if (Icono.ActiveForm.Left < -5)
                {
                    left = true;
                    pictureBox1.Image = Img[3];
                }
            }
            catch
            {

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Focus();
            Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Hide();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
        private void Icono_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void Icono_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        
    }
    #endregion
}
#endregion
#endregion