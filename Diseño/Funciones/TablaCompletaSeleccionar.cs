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
    public partial class TablaCompletaSeleccionar : Form
    {
        #region Atributos
        Captura Capt = new Captura();
        Programa Prog = new Programa();
        MensajeBx Mensajebx = new MensajeBx();
        AccionesSistema As = new AccionesSistema();
        #endregion

        #region Propiedades
        public DataTable DataSelet { get; set; }
        DataRow Drow { get; set; }

        VisorImagenes Pantallazo { get; set; }

        SoundPlayer Boton { get; set; }
        SoundPlayer Camara { get; set; }
        SoundPlayer Minimizado { get; set; }

        Int32 I { get; set; }
        String N { get; set; }
        #endregion

        #region Constructor
        public TablaCompletaSeleccionar(Int32 Index, String Name)
        {
            Sonidos();
            I = Index;
            N = Name;
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
        void Excepcion(Exception ex)
        {
            Mensajebx.Excepcion(ex);
        }
        void Selecionar()
        {
            if (TablaBuscar.SelectedRows.Count >= 1)
            {
                try
                {
                    foreach (DataGridViewRow Row in TablaBuscar.SelectedRows)
                    {
                        DataSelet.Rows.Add(TablaBuscar[0, Row.Index].Value);
                        TablaBuscar.Rows.Remove(Row);
                    }
                    TablaSeleccionados.DataSource = DataSelet;
                }
                catch (Exception ex) { Excepcion(ex); return; }

            }
            else if (TablaBuscar.SelectedCells.Count >= 1)
            {
                SelecionCelda(TablaBuscar.SelectedCells[0].RowIndex);
            }
        }
        void SelecionCelda(Int32 Row)
        {
            try
            {
                DataSelet.Rows.Add(TablaBuscar[0, Row].Value);
                TablaBuscar.Rows.Remove(TablaBuscar.Rows[Row]);
                TablaSeleccionados.DataSource = DataSelet;
            }
            catch (Exception ex) { Excepcion(ex); return; }
        }
        void SelecionarTodos()
        {
            try
            {
                foreach (DataGridViewRow Row in TablaBuscar.Rows)
                {
                    DataSelet.Rows.Add(TablaBuscar[0, Row.Index].Value);
                    TablaBuscar.Rows.Remove(Row);
                }
                TablaSeleccionados.DataSource = DataSelet;
            }
            catch (Exception ex) { Excepcion(ex); return; }
        }
        void Deselecionar(String text)
        {
            DataSelet = new DataTable();
            DataSelet.Columns.Add("Código");
            TablaBuscar.DataSource = As.TablaBuscar(I, text);
            TablaSeleccionados.DataSource = DataSelet;
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
            lblEntidad.Text = N;
            Deselecionar("");
        }
        private void bnEditarSeleccion_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Selecionar();
            lblN_Select.Text = "" + TablaSeleccionados.Rows.Count;
        }
        private void bnDeseleccionar_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Deselecionar("");
            lblN_Select.Text = "0";
        }
        private void bnFinalizar_Click(object sender, EventArgs e)
        {
            Boton.Play();
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void bnCancelar_Click(object sender, EventArgs e)
        {
            Boton.Play();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            Pantallazo = new VisorImagenes(Capt.Completa());
            Ptllazo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarTodos();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Deselecionar(textBox1.Text);
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                bnBuscar.PerformClick();
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion