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
    public partial class EntidadCompleta : Form
    {
        #region Atributos
        Captura Capt = new Captura();
        Programa Prog = new Programa();
        AccionesSistema As = new AccionesSistema();

        Color Fuente { get; set; }
        Color Fondo { get; set; }

        VisorImagenes Pantallazo { get; set; }
        DataRow Drow { get; set; }

        SoundPlayer Boton { get; set; }
        SoundPlayer Camara { get; set; }
        SoundPlayer Minimizado { get; set; }
        #endregion

        #region Constructor
        public EntidadCompleta(List<Label> lst, List<PictureBox> lstpbx)
        {
            Sonidos();
            Agregar(lst, lstpbx);
            InitializeComponent();
        }
        #endregion

        #region Métodos
        void Agregar(List<Label> lst, List<PictureBox> lstpbx)
        {
            foreach (Label lb in lst)
            {
                lb.Click += this.chart1_Click;
                Controls.Add(lb);
            }
            foreach (PictureBox pb in lstpbx)
            {
                pb.Click += this.chart1_Click;
                Controls.Add(pb);
            }
        }
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
                    break;
                case 1:
                    CicloColor(Tinte);
                    break;
                default:
                    break;
            }
        }
        void CicloColor(Color Tinte)
        {
            foreach (Label Sender in Controls.OfType<Label>())
            {
                try
                {
                    Sender.ForeColor = Tinte;
                }
                catch { }
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
            Diseñar();
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
        #endregion
    }
    #endregion
}
#endregion
#endregion




    
        

