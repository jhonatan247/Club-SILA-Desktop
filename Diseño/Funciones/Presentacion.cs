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
using Diseño.Interfaz_de_usuario;
#endregion

#region Funciones
namespace Diseño.Funciones
{
    #region Formulario
    public partial class Presentacion : Form
    {
        #region Atributos
        TimmerAction TmAction = new TimmerAction();
        Color Blue = SystemColors.Highlight;
        Int32 Xx { get; set; }
        #endregion

        #region Constructor
        public Presentacion()
        {
            InitializeComponent();
            tImagenes.Enabled = true;
            Xx = 0;
        }
        #endregion

        #region Métodos
        void Colores(Color Tinte)
        {
            BackColor = Tinte;
        }
        #endregion

        #region Eventos
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            switch (Settings.Default.DiseñoIngreso)
            {
                case 0:
                    Colores(Blue);
                    break;
                case 1:
                    Colores(Color.Green);
                    break;
                case 2:
                    Colores(Color.Red);
                    break;
                case 3:
                    Colores(Color.Purple);
                    break;
                case 4:
                    Colores(Color.DarkOrange);
                    break;
                case 5:
                    Colores(Color.Teal);
                    break;
                case 6:
                    Colores(Color.Tomato);
                    break;
                case 7:
                    Colores(Color.Gold);
                    break;
                case 8:
                    Colores(Color.Turquoise);
                    break;
                default:
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Xx = TmAction.PicturePresentacion(sender, pbImagen, Xx, this, 60, true);
        }
        private void pbImagen_Click(object sender, EventArgs e)
        {
            Xx = 59;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion