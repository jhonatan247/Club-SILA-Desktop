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
using System.Media;
using Negocio.Manejo_de_datos;
using Negocio.Lógica;
using System.Diagnostics;
#endregion

#region Interfaz de usuario
namespace Diseño.Interfaz_de_usuario
{
    #region Formulario
    public partial class Licencia : Form
    {
        #region Atributos
        SoundPlayer Minimizado { get; set; }
        List<Image> Img { get; set; }
        List<String> Txt { get; set; }
        Int32 Xx { get; set; }

        DataRow Drow { get; set; }

        Programa Prog = new Programa();
        AccionesSistema As = new AccionesSistema();
        TimmerAction TmAction = new TimmerAction();
        MensajeToolTip MensajeTool = new MensajeToolTip();
        Int32 I { get; set; }
        bool Cerrar = false;
        #endregion

        #region Constructor
        public Licencia(Int32 Index)
        {
            I = Index;
            InitializeComponent();
            Img = As.Imagenes();
            Txt = As.Textos();
            try
            {
                Drow = Prog.TSELECT4().Rows[0];
                if (Drow[0].ToString() == "A")
                {
                    Minimizado = As.Sonidos()[3];
                }
                else
                {
                    Minimizado = As.Sonidos()[5];
                }
            }
            catch { }
            Xx = 0;
        }
        #endregion

        #region Metodos
        #endregion

        #region Eventos
        private void Licencia_Load(object sender, EventArgs e)
        {
            tTransparencia.Enabled = true;
            lstProductos.SelectedIndex = 1;
        }
        private void Licencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Cerrar)
            {
                Minimizado.Play();
            }
            else { e.Cancel = true; bnAceptar.PerformClick(); }
        }
        private void tTransparencia_Tick(object sender, EventArgs e)
        {
            Opacity += 0.02;
            if (Opacity >= 1)
            {
                tTransparencia.Enabled = false;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstProductos.SelectedIndex)
            {

                case 0:
                    lblDescripcion.Text = Txt[5];
                    pbIcono.Image = Img[9];
                    break;
                case 1:
                    lblDescripcion.Text = Txt[6];
                    pbIcono.Image = Img[10];
                    break;
                case 2:
                    lblDescripcion.Text = Txt[7];
                    pbIcono.Image = Img[3];
                    break;
                default:
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cerrar = true;
            if (I == 1)
            {
                Process currentProcess = Process.GetCurrentProcess();
                currentProcess.Kill();
                Application.Exit();
            }
            else
                this.Close();
        }
        private void bnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(@"Club Sila
Versión 1.4.5 REL

Microsoft .NET Framework
Versión 4.6.00081

Licencia instalada: "+Txt[6]+@"
    
Microsoft SQL Server 2012");
        }
        #endregion

        private void l1_TextChanged(object sender, EventArgs e)
        {
            if(l1.Text.Trim().Length>3)
            {
                l2.Text = l1.Text.Substring(3, l1.Text.Length - 3) + l2.Text;
                l1.Text = l1.Text.Substring(0, 3);
            }
        }

        private void l2_TextChanged(object sender, EventArgs e)
        {
            if (l2.Text.Trim().Length > 3)
            {
                l3.Text = l2.Text.Substring(3, l2.Text.Length - 3) + l3.Text;
                l2.Text = l2.Text.Substring(0, 3);
            }

        }

        private void l3_TextChanged(object sender, EventArgs e)
        {
            if (l3.Text.Trim().Length > 3)
            {
                l4.Text = l3.Text.Substring(3, l3.Text.Length - 3) + l4.Text;
                l3.Text = l3.Text.Substring(0, 3);
            }
        }

        private void l4_TextChanged(object sender, EventArgs e)
        {
            if (l4.Text.Trim().Length > 3)
            {
                l5.Text = l4.Text.Substring(3, l4.Text.Length - 3) + l5.Text;
                l4.Text = l4.Text.Substring(0, 3);
            }
        }

        private void l5_TextChanged(object sender, EventArgs e)
        {
            if (l5.Text.Trim().Length > 3)
            {
                l6.Text = l5.Text.Substring(3, l5.Text.Length - 3) + l6.Text;
                l5.Text = l5.Text.Substring(0, 3);
            }
        }

        private void l6_TextChanged(object sender, EventArgs e)
        {
            if (l6.Text.Trim().Length > 3)
            {
                l7.Text = l6.Text.Substring(3, l6.Text.Length - 3) + l7.Text;
                l6.Text = l6.Text.Substring(0, 3);
            }
        }

        private void l7_TextChanged(object sender, EventArgs e)
        {
            if (l7.Text.Trim().Length > 3)
            {
                l8.Text = l7.Text.Substring(3, l7.Text.Length - 3) + l8.Text;
                l7.Text = l7.Text.Substring(0, 3);
            }
        }

        private void l8_TextChanged(object sender, EventArgs e)
        {
            if (l8.Text.Trim().Length > 3)
            {
                l8.Text = l8.Text.Substring(0, 3);
            }
        }

        private void bnActivar_Click(object sender, EventArgs e)
        {
            MensajeTool.LicenciaFallida(toolTip1, bnActivar);
        }

        private void l1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((MaskedTextBox)sender).Text += e.KeyChar;
            e.Handled = true;
        }
    }
    #endregion
}
#endregion
#endregion
