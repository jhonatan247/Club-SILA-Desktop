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
using System.Windows.Forms.DataVisualization.Charting;
using Diseño.Properties;
#endregion

#region Funciones
namespace Diseño.Funciones
{
    #region Formulario
    public partial class GraficaCompleta : Form
    {
        #region Atributos
        Captura Capt = new Captura();
        Programa Prog = new Programa();
        AccionesSistema As = new AccionesSistema();

        Color Fuente { get; set; }
        Color Fondo { get; set; }
        String NombreEntidad { get; set; }
        String Title { get; set; }
        String XValueMember { get; set; }
        String YValueMember { get; set; }
        DataTable DataSource { get; set; }

        VisorImagenes Pantallazo { get; set; }
        DataRow Drow { get; set; }

        SoundPlayer Boton { get; set; }
        SoundPlayer Camara { get; set; }
        SoundPlayer Minimizado { get; set; }
        #endregion

        #region Constructor
        public GraficaCompleta(String pNombreEntidad, String pTitle, String pXValueMember, String pYValueMember, DataTable pDataSource)
        {
            Sonidos();
            this.NombreEntidad = pNombreEntidad;
            this.Title = pTitle;
            this.XValueMember = pXValueMember;
            this.YValueMember = pYValueMember;
            this.DataSource = pDataSource;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        void Sonidos()
        {
            List<SoundPlayer> Lst = As.Sonidos();
            Drow = Prog.TSELECT4().Rows[0];
            if (Drow[0].ToString() == "A")
            {
                Boton = Lst[0];
                Camara = Lst[1];
                Minimizado = Lst[3];
                Minimizado.Play();
            }
            else
            {
                Boton = Lst[5];
                Camara = Lst[5]; 
                Minimizado = Lst[5];
            }
        }
        void Diseñar()
        {
            List<Color> Clr = As.Diseño();
            Fondo = Clr[0];
            ColorDiseño(0, Fondo);
            Fuente = Clr[1];
            ColorDiseño(1, Fuente);
        }
        void ColorDiseño(Int16 Index, Color Tinte)
        {
            switch (Index)
            {
                case 0:
                    this.BackColor = Tinte;
                    Grafica.BackColor = Tinte;
                    Grafica.Titles[0].BackColor = Tinte;
                    Grafica.Legends[0].BackColor = Tinte;
                    break;
                case 1:
                    Grafica.Series[0].Color = Tinte;
                    Grafica.Titles[0].ForeColor = Tinte;
                    Grafica.Titles[0].BorderColor = Tinte;
                    Grafica.Legends[0].BorderColor = Tinte;
                    Grafica.Legends[0].ForeColor = Tinte;
                    Grafica.Annotations[0].LineColor = Tinte;
                    Grafica.ChartAreas[0].BackColor = Tinte;
                    break;
                default:
                    break;
            }
        }
        void Ptllazo()
        {
            Pantallazo.ShowDialog();
            Sonidos();
        }
        #endregion

        #region Eventos
        private void Grafica_Completa_Load(object sender, EventArgs e)
        {
            Grafica.Series[0].Name = NombreEntidad;
            Grafica.Series[0].XValueMember = XValueMember;
            Grafica.Series[0].YValueMembers = YValueMember;
            Grafica.Titles[0].Text = Title;
            Grafica.DataSource = DataSource;
            Diseñar();
            cbForma.SelectedIndex = Settings.Default.Forma;
            cbPaleta.SelectedIndex = Settings.Default.Paleta;
        }
        private void chart1_Click(object sender, EventArgs e)
        {
            Minimizado.Play();
            this.Close();
        }
        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            Pantallazo = new VisorImagenes(Capt.Completa());
            Ptllazo();
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boton.Play();
            Settings.Default.Forma = cbForma.SelectedIndex;
            Settings.Default.Save();
            As.TipoSerie(Grafica, cbForma.SelectedIndex);
        }
        private void cbPaleta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boton.Play();
            As.PaletaSerie(Grafica, cbPaleta.SelectedIndex);
            Settings.Default.Paleta = cbPaleta.SelectedIndex;
            Settings.Default.Save();
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion




    
        

