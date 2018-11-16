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
#endregion

#region Funciones
namespace Diseño.Funciones
{
    #region Formulario
    public partial class PantallaCompleta : Form
    {
        #region Atributos
        Int32 N = 0, totalI = 0, timer = 0;
        List<Image> Imagenes;
        List<String> Ubicacion;
        #endregion

        #region Constructor
        public PantallaCompleta(List<Image> IMG, List<String> UBC, Int32 Index)
        {
            InitializeComponent();
            Ubicacion = UBC;
            Imagenes = IMG;
            N = Index;
            totalI = Imagenes.Count - 1;
        }
        #endregion

        #region Métodos
        private void RegresarImg()
        {
            if (totalI > 0)
            {
                if (pbImagen.Image == Imagenes[0])
                {
                    N = totalI;
                    pbImagen.Image = Imagenes[N];
                    lblNombre.Text = Ubicacion[N];
                }
                else
                {
                    N--;
                    pbImagen.Image = Imagenes[N];
                    lblNombre.Text = Ubicacion[N];
                }
                pbImagen.Size = Imagenes[N].Size;
                Posicion();
            }
        }
        private void AvanzarImg()
        {
            if (totalI > 0)
            {
                if (pbImagen.Image == Imagenes[totalI])
                {
                    N = 0;
                    pbImagen.Image = Imagenes[N];
                    lblNombre.Text = Ubicacion[N];
                }
                else
                {
                    N++;
                    pbImagen.Image = Imagenes[N];
                    lblNombre.Text = Ubicacion[N];
                }
                pbImagen.Size = Imagenes[N].Size;
                Posicion();
            }
        }
        void Posicion()
        {
            if (pbImagen.Width < this.Width && pbImagen.Height < this.Height)
            {
                pbImagen.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - pbImagen.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - pbImagen.Height / 2);
            }
            else
            {
                this.VerticalScroll.Value = 0;
                this.HorizontalScroll.Value = 0;
                pbImagen.Location = new Point(0, 0);
            }
        }
        #endregion

        #region Eventos
        private void pantalla_Completa_Load(object sender, EventArgs e)
        {
            pbImagen.Image = Imagenes[N];
            pbImagen.Size = Imagenes[N].Size;
            lblNombre.Text = Ubicacion[N];
            Posicion();
            if(Imagenes.Count>1)
            {
                timer1.Enabled = true;
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if ((timer % 10) == 0)
            {
                AvanzarImg();
            }
        }

        private void imagenSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvanzarImg();
        }

        private void imagenAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegresarImg();
        }

        private void pantalla_Completa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left:
                    AvanzarImg();
                    break;
                case Keys.Right:
                    RegresarImg();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
        private void pantalla_Completa_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            timer = 0;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion