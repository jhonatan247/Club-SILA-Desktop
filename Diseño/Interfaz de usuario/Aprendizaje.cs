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
using System.Data.OleDb;
#endregion

#region Interfaz de usuario
namespace Diseño.Interfaz_de_usuario
{
    #region Program
    public partial class Aprendizaje : Form
    {
        #region Atributos
        bool salir = true;
        public int ingr = 0;
        public bool ini = false, idep = false, inic = false, hist = false;
        #endregion

        #region Constructor
        public Aprendizaje()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void Aprendizaje_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Métodos
        
        

        #endregion

        #region Eventos
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurarToolStripMenuItem.Visible = false;
        }
        private void Aprendizaje_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                trayBar.Visible = false;
            }
        }
        private void Aprendizaje_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Normal == WindowState)
            {
                restaurarToolStripMenuItem.Visible = false;
            }
            if (FormWindowState.Normal == WindowState)
            {
                restaurarToolStripMenuItem.Visible = false;
            }
            else if (FormWindowState.Minimized == WindowState)
            {
                restaurarToolStripMenuItem.Visible = true;
            }
        }
        private void crearNuevoUsusarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historia.PerformClick();
        }
        private void controlDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coreano.PerformClick();
        }
        private void controlDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodos.PerformClick();
        }
        private void controlDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pomsae.PerformClick();
        }
        private void aprendizajeInteractivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tecnica.PerformClick();
        }
        private void galeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alimentacion.PerformClick();
        }
        private void CombateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combate.PerformClick();
        }
        private void cuerpoHumanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuerpo.PerformClick();
        }
        private void competenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            competencia.PerformClick();
        }
        private void exibicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibicion.PerformClick();
        }
        private void filosofíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filosofia.PerformClick();
        }
        private void juegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            juegos.PerformClick();
        }
        private void trayBar_DoubleClick(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                this.WindowState = FormWindowState.Normal;
                restaurarToolStripMenuItem.Visible = false;
            }
        }
        private void Aprendizaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir == true)
            {
                DialogResult result;

                result = MessageBox.Show("¿Desea salir de la aplicación?", "¿Salir?!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    #endregion
}
#endregion
#endregion
