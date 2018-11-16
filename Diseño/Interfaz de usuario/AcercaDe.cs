#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using Negocio.Manejo_de_datos;
using Negocio.Lógica;
using Diseño.Properties;
#endregion

#region Interfaz de usuario
namespace Diseño.Interfaz_de_usuario
{
    #region Formulario
    public partial class AcercaDe : Form
    {
        #region Atributos
        Color Blue = SystemColors.Highlight;
        Programa Prog = new Programa();
        AccionesSistema As = new AccionesSistema();
        TimmerAction TmAction = new TimmerAction();
        #endregion

        #region Propiedades
        SoundPlayer Aplauso { get; set; }
        List<Image> Img { get; set; }
        List<string> Txt { get; set; }
        int Xx { get; set; }
        Licencia Lic { get; set; }

        DataRow Drow { get; set; }
        #endregion

        #region Constructor
        public AcercaDe()
        {
            InitializeComponent();
            Img = As.Imagenes();
            Txt = As.Textos();
            try
            {
                Drow = Prog.TSELECT4().Rows[0];
                if (Drow[0].ToString() == "A")
                {
                    Aplauso = As.Sonidos()[6];
                }
                else
                {
                    Aplauso = As.Sonidos()[5];
                }
            }
            catch{ }
            Xx = 0;
        }
        #endregion

        #region Metodos
        void Colores(Color Tinte)
        {
            pbLogo.BackColor = Tinte;
        }
        #endregion

        #region Eventos
        private void AcercaDe_Load(object sender, EventArgs e)
        {
            tTransparencia.Enabled = true;
            lstProductos.SelectedIndex = 1;
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
        private void AcercaDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplauso.Play();
        }
        private void tTransparencia_Tick(object sender, EventArgs e)
        {
            Opacity += 0.02;
            if (Opacity >= 1)
            {
                tImagenes.Enabled = true;
                tTransparencia.Enabled = false;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstProductos.SelectedIndex)
            {
                    
                case 0:
                    lblDescripcion.Text = Txt[2];
                    pbIcono.Image = Img[2];
                    break;
                case 1:
                    lblDescripcion.Text = Txt[3];
                    pbIcono.Image = Img[3];
                    break;
                case 2:
                    lblDescripcion.Text = Txt[4];
                    pbIcono.Image = Img[4];
                    break;
                default:
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(@"Club Sila
Versión 1.4.5 REL

Microsoft .NET Framework
Versión 4.6.00081

Versión instalada: Ultimate
    
Microsoft SQL Server 2012");
        }
        private void tImagenes_Tick(object sender, EventArgs e)
        {
            Xx = TmAction.PicturePresentacion(sender, pbLogo, Xx, this, 72, false);
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lic = new Licencia(0);
            Hide();
            Lic.ShowDialog();
            Show();
        }
    }
    #endregion
}
#endregion
#endregion
