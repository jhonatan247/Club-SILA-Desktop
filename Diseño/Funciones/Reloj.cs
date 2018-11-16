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
using Negocio.Objetos;
#endregion

#region Funciones
namespace Diseño.Funciones
{
    #region Formulario
    public partial class Reloj : Form
    {
        #region Atributos
        TimmerAction TmAction = new TimmerAction();
        #endregion

        #region Propiedades
        RelojAnalogo Rel { get; set; }
        #endregion

        #region Constructor
        public Reloj()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        void CentrarObjeto(Object Sender, Object Contenedor, Int32 Index)
        {
            switch (Index)
            {
                case 0:
                    ((Label)Sender).Location = new Point(((Form)Contenedor).Width / 2 - ((Label)Sender).Width / 2, ((Label)Sender).Location.Y);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Eventos
        private void timer1_Tick(object sender, EventArgs e)
        {
            TmAction.Reloj(h1, h2, m1, m2, s1, s2, lbFecha);
            Rel.TiempoReloj(pictureBox1, toolTip1);
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Rel = new RelojAnalogo();
            Hide();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
        private void Reloj_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
        private void label1_Resize(object sender, EventArgs e)
        {
            CentrarObjeto(sender, this, 0);
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion