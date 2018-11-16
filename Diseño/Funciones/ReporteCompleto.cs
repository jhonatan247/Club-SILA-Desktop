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
    public partial class ReporteCompleto : Form
    {
        #region Atributos
        Captura Capt = new Captura();
        Programa Prog = new Programa();

        VisorImagenes Pantallazo { get; set; }
        #endregion

        #region Constructor
        public ReporteCompleto(Microsoft.Reporting.WinForms.ReportViewer rpt)
        {
            
            Agregar(rpt);
            InitializeComponent();
        }
        #endregion

        #region Métodos
        void Agregar(Microsoft.Reporting.WinForms.ReportViewer rpt)
        {
            Controls.Add(rpt); 
        }
        void Ptllazo()
        {
            Pantallazo.ShowDialog();
        }
        #endregion

        #region Eventos
        private void Grafica_Completa_Load(object sender, EventArgs e)
        {
        }
        private void chart1_Click(object sender, EventArgs e)
        {
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




    
        

