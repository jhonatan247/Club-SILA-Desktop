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
using Negocio.Entidades;
using Negocio.Manejo_de_datos;
using Diseño.Properties;
using System.Diagnostics;
using Diseño.Funciones;
using Diseño.Interfaz_de_usuario;
using System.Media;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using Negocio.Objetos;
#endregion

#region Gestión de datos
namespace Diseño.Gestión_de_datos
{
    #region Formulario
    public partial class FRM_OBJETO : Form
    {
        #region Atributos
        //Relojes
        RelojAnalogo Rej = new RelojAnalogo();
        Reloj Rel = new Reloj();
        //Colores
        Color Blue = Color.FromArgb(3, 169, 244);
        Color Gray = Color.FromArgb(68, 68, 68);
        //Mensajes
        MensajeBx Mensajebx = new MensajeBx();
        MensajeToolTip MensajeTool = new MensajeToolTip();
        AccionesSistema As = new AccionesSistema();
        MensajeTrayBar MensajeTray = new MensajeTrayBar();
        //Clases
        Captura Capt = new Captura();
        Programa Prog = new Programa();
        //Diálogos
        AcercaDe Aceraca = new AcercaDe();
        //Bytes
        Byte[] DatosImg = new Byte[0];
        //Booleanos
        Boolean Cancelar = false, Inicial = false;
        //Formulario
        Int32 FMR = 0;
        String FMR_NAME = "OBJETOS";
        #endregion

        #region Propiedades
        //Entidades
        CRUD_Objeto CEntidad { get; set; }
        //Listas
        List<SoundPlayer> Lst { get; set; }
        List<Image> Img { get; set; }
        List<String> Txt { get; set; }
        //Imagen
        MemoryStream MemS { get; set; }
        //Colores
        Color Fuente { get; set; }
        Color Fondo { get; set; }
        //Numeros
        Int64 ID { get; set; }
        Int64 Valor { get; set; }
        //Datos
        E_Programa Eprog { get; set; }
        DataRow Drow { get; set; }
        DataTable DataSelet { get; set; }
        DataTable DataSource { get; set; }
        //Formularios
        Icono FondoPantalla { get; set; }
        ReporteCompleto RPT { get; set; }
        VisorImagenes Pantallazo { get; set; }
        GraficaCompleta GrafiC { get; set; }
        EntidadCompleta EntiC { get; set; }
        TablaCompletaSeleccionar TablaC { get; set; }
        ConfirmarContraseña ConfContr { get; set; }
        OpenFileDialog OpenMedia { get; set; }
        //Sonidos
        SoundPlayer Boton { get; set; }
        SoundPlayer Camara { get; set; }
        SoundPlayer Inicio { get; set; }
        SoundPlayer Minimizado { get; set; }
        SoundPlayer Datos { get; set; }
        #endregion

        #region Constructor
        public FRM_OBJETO()
        {
            //Iniciar formulario
            InitializeComponent();
            //Coordinar busqueda
            CbBusqueda1.SelectedIndex = CbBusqueda2.SelectedIndex = CbBusqueda3.SelectedIndex =
                CbBusqueda4.SelectedIndex = CbBusqueda5.SelectedIndex = 1;
            //Generar sonidos
            Lst = As.Sonidos();
            //Generar Imagenes
            Img = As.Imagenes();
            //Generar Textos
            Txt = As.Textos();
            //Añadir sonidos
            Sonidos();
            //Nombrar
            TitulosGrafica();
            //Diseñar formulario
            Diseñar();
        }
        #endregion

        #region Métodos
        //Programa
        bool Estilo(int Index)
        {
            switch (Index)
            {
                case 0:
                    if (!As.Condicionales(1, Fondo))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 1:
                    if (!As.Condicionales(1, Fondo) && !As.Condicionales(0, Fuente))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }
        void Cerrasesión()
        {
            Cancelar = true;
            Boton.Play(); Cancelar = As.CerrarSesion();
        }
        void ComboBx()
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    registrarToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgRegistrar;
                    break;
                case 1:
                    actualizarToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgActualizar;
                    break;
                case 2:
                    reciclajeToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgReciclar;
                    break;
                case 3:
                    buscarToolStripMenuItem1.Checked = true;
                    TabControl.SelectedTab = pgBuscar;
                    break;
                case 4:
                    graficarToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgGraficar;
                    break;
                case 5:
                    reportarToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgReportar;
                    break;
                case 6:
                    avanzadosToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgAvanzados;
                    break;
                case 7:
                    reciclajeToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgReciclaje;
                    break;
                default:
                    break;
            }
            páginasToolStripMenuItem.Checked = true;
        }
        void SelectItm(Int32 index)
        {
            toolStripComboBox1.SelectedIndex = toolStripComboBox2.SelectedIndex = toolStripComboBox3.SelectedIndex =
            toolStripComboBox4.SelectedIndex = toolStripComboBox5.SelectedIndex = toolStripComboBox6.SelectedIndex =
            toolStripComboBox7.SelectedIndex = toolStripComboBox8.SelectedIndex = toolStripComboBox9.SelectedIndex =
            toolStripComboBox10.SelectedIndex = toolStripComboBox13.SelectedIndex = index;
            txBuscar.Clear();
            txBuscarAct.Clear();
            txBuscarRec.Clear();
            txBuscarRep.Clear();
        }
        void CampoAvanzados()
        {
            foreach (TextBox sender in gbActAv.Controls.OfType<TextBox>())
            {
                sender.Hide();
            }
            foreach (ComboBox sender in gbActAv.Controls.OfType<ComboBox>())
            {
                sender.Hide();
            }
            foreach (PictureBox sender in gbActAv.Controls.OfType<PictureBox>())
            {
                sender.Hide();
            }
            foreach (MaskedTextBox sender in gbActAv.Controls.OfType<MaskedTextBox>())
            {
                sender.Hide();
            }
            foreach (DateTimePicker sender in gbActAv.Controls.OfType<DateTimePicker>())
            {
                sender.Hide();
            }
            cbCampo.Show();
            switch (cbCampo.SelectedIndex)
            {
                case 0:
                    txValorCampo1.Show();
                    break;
                case 1:
                    txValorCampo2.Show();
                    break;
                case 2:
                    pbxImagenAvan.Show();
                    txImagen.Show();
                    break;
                default:
                    break;
            }
        }
        void Rellenar()
        {
            try
            {
                Drow = Prog.TSELECT6().Rows[0];
                lblDato1.Text = Drow[0].ToString();
                lblDato2.Text = Drow[1].ToString();
                lblDato3.Text = Drow[2].ToString();
                lblDato4.Text = Drow[3].ToString();
                CentrarObjeto(0);
            }
            catch { }
            try
            {
                if (Drow[4] != null)
                {
                    DatosImg = (Byte[])Drow[4];
                    MemS = new MemoryStream(DatosImg);
                    pbxFoto2.Image = Bitmap.FromStream(MemS);
                }
            }
            catch { }
            if (Drow[5].ToString() == "HOMBRE")
            {
                pbxFoto1.Image = Img[6];
            }
            else if (Drow[5].ToString() == "MUJER")
            {
                pbxFoto1.Image = Img[7];
            }
            else
            {
                pbxFoto1.Image = Img[8];
            }
        }
        void VolverAntForm()
        {
            Cancelar = true;
            Boton.Play();
            As.RegresarFormAnt();
        }
        //Diseño
        private void GuardarImagen(Image IMG, String Nombre)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            saveFileDialog1.Title = "Guardar como.. ";
            saveFileDialog1.FileName = Nombre;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        IMG.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        IMG.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        IMG.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        IMG.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }
        void EstiloPrediseñado()
        {
            switch (cbPrediseño.SelectedIndex)
            {
                case 0:
                    Fuente = Color.Black;
                    Fondo = Color.White;
                    break;
                case 1:
                    Fuente = Blue;
                    Fondo = Color.White;
                    break;
                case 2:
                    Fuente = Color.White;
                    Fondo = Color.Black;
                    break;
                case 3:
                    Fuente = Color.White;
                    Fondo = Color.Tomato;
                    break;
                case 4:
                    Fuente = Color.White;
                    Fondo = Color.Green;
                    break;
                case 5:
                    Fuente = Color.White;
                    Fondo = Blue;
                    break;
                case 6:
                    Fuente = SystemColors.Control;
                    Fondo = Color.DimGray;
                    break;
                case 7:
                    Fuente = Color.DimGray;
                    Fondo = SystemColors.Control;
                    break;
                case 8:
                    Fuente = Color.Red;
                    Fondo = Color.White;
                    break;
                case 9:
                    Fuente = Color.Purple;
                    Fondo = Color.White;
                    break;
                case 10:
                    Fuente = Color.DarkOrange;
                    Fondo = Color.White;
                    break;
                case 11:
                    Fuente = Color.Teal;
                    Fondo = Color.White;
                    break;
                case 12:
                    Fuente = Color.Gold;
                    Fondo = Color.White;
                    break;
                case 13:
                    Fuente = Color.Turquoise;
                    Fondo = Color.White;
                    break;
                case 14:
                    Fuente = Color.White;
                    Fondo = Color.Red;
                    break;
                case 15:
                    Fuente = Color.White;
                    Fondo = Color.Purple;
                    break;
                case 16:
                    Fuente = Color.White;
                    Fondo = Color.DarkOrange;
                    break;
                case 17:
                    Fuente = Color.White;
                    Fondo = Color.Teal;
                    break;
                case 18:
                    Fuente = Color.Black;
                    Fondo = Color.Gold;
                    break;
                case 19:
                    Fuente = Color.White;
                    Fondo = Color.Turquoise;
                    break;
                default:
                    break;
            }
            ColorDiseño(0, Fondo);
            ColorDiseño(1, Fuente);
            EnviarDiseño(Fuente.R, Fuente.G, Fuente.B, Fondo.R, Fondo.G, Fondo.B);
        }
        void VisibleCheck(ToolStripMenuItem sender)
        {
            if (sender.Checked)
            {
                switch (Convert.ToInt32(sender.Tag))
                {
                    case 0:
                        foreach (ToolStripMenuItem Tool in páginasToolStripMenuItem.DropDown.Items)
                        {
                            Tool.Visible = true;
                        }
                        break;
                    case 1:
                        TabControl.Controls.Add(pgRegistrar);
                        break;
                    case 2:
                        TabControl.Controls.Add(pgActualizar);
                        break;
                    case 3:
                        TabControl.Controls.Add(pgReciclar);
                        break;
                    case 4:
                        TabControl.Controls.Add(pgBuscar);
                        break;
                    case 5:
                        TabControl.Controls.Add(pgGraficar);
                        break;
                    case 6:
                        TabControl.Controls.Add(pgReportar);
                        break;
                    case 7:
                        TabControl.Controls.Add(pgAvanzados);
                        break;
                    case 8:
                        TabControl.Controls.Add(pgReciclaje);
                        break;
                    case 9:
                        panelInferior.Show();
                        panelMenu.Height -= 45;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (Convert.ToInt32(sender.Tag))
                {
                    case 0:
                        Todaspag(false);
                        break;
                    case 1:
                        TabControl.Controls.Remove(pgRegistrar);
                        break;
                    case 2:
                        TabControl.Controls.Remove(pgActualizar);
                        break;
                    case 3:
                        TabControl.Controls.Remove(pgReciclar);
                        break;
                    case 4:
                        TabControl.Controls.Remove(pgBuscar);
                        break;
                    case 5:
                        TabControl.Controls.Remove(pgGraficar);
                        break;
                    case 6:
                        TabControl.Controls.Remove(pgReportar);
                        break;
                    case 7:
                        TabControl.Controls.Remove(pgAvanzados);
                        break;
                    case 8:
                        TabControl.Controls.Remove(pgReciclaje);
                        break;
                    case 9:
                        panelInferior.Hide();
                        panelMenu.Height += 45;
                        break;
                    default:
                        break;
                }
            }
            Boton.Play();
        }
        void Todaspag(Boolean value)
        {
            foreach (ToolStripMenuItem Tool in páginasToolStripMenuItem.DropDown.Items)
            {
                Tool.Checked = value;
                Tool.Visible = value;
            }
            páginasToolStripMenuItem.Checked = value;
            verTodasToolStripMenuItem.Checked = false;
        }
        void TitulosGrafica()
        {
            Grafica.Series[0].Name = "Objeto\nvs\nprecio";
            Grafica.Series[0].XValueMember = "Objeto";
            Grafica.Series[0].YValueMembers = "Precio_estimado";
            Grafica.Titles[0].Text = "Gráfica de objetos";
        }
        void Sonidos()
        {
            Drow = Prog.TSELECT4().Rows[0];
            if (Drow[0].ToString() == "A")
            {
                Boton = Lst[0];
                Camara = Lst[1];
                Inicio = Lst[2];
                Minimizado = Lst[3];
                Datos = Lst[4];
                bnSonido.Image = Img[0];
                activarDesactivarSonidosToolStripMenuItem.Image = Img[0];
                activarDesactivarSonidosToolStripMenuItem.Text = Txt[0];
                if (Inicial)
                {
                    Minimizado.Play();
                }
            }
            else
            {
                Boton = Lst[5];
                Camara = Lst[5]; ;
                Inicio = Lst[5]; ;
                Minimizado = Lst[5];
                Datos = Lst[5];
                bnSonido.Image = Img[1];
                activarDesactivarSonidosToolStripMenuItem.Image = Img[1];
                activarDesactivarSonidosToolStripMenuItem.Text = Txt[1];
            }
        }
        void Diseñar()
        {
            List<Color> Clr = As.Diseño();
            Fondo = Clr[0];
            Fuente = Clr[1];
            Int32 FF = As.CondicionalesDobles(0, Fuente, Fondo);
            if (FF != 100)
            {
                cbPrediseño.SelectedIndex = FF;
            }
            ColorDiseño(0, Fondo);
            ColorDiseño(1, Fuente);
        }
        void CicloBoton(Color Tinte, Boolean Back)
        {
            if (!Back)
            {
                foreach (Button Sender in Controls.OfType<Button>())
                {
                        Sender.ForeColor = Tinte;
                }
                foreach (Panel Sender in Controls.OfType<Panel>())
                {
                    foreach (Button Bn in Sender.Controls.OfType<Button>())
                    {
                            Bn.ForeColor = Tinte;
                    }
                    foreach (Panel Pnl in Sender.Controls.OfType<Panel>())
                    {
                        foreach (Button Bn in Pnl.Controls.OfType<Button>())
                        {
                                Bn.ForeColor = Tinte;
                        }
                    }
                }
                foreach (TabPage Sender in TabControl.Controls.OfType<TabPage>())
                {
                    foreach (Button Bn in Sender.Controls.OfType<Button>())
                    {
                            Bn.BackColor = Tinte;
                    }
                    foreach (Panel pnl in Sender.Controls.OfType<Panel>())
                    {
                        foreach (Button Bn in pnl.Controls.OfType<Button>())
                        {
                                Bn.ForeColor = Tinte;
                        }
                        foreach (Panel Pnll in pnl.Controls.OfType<Panel>())
                        {
                            foreach (Button Bn in Pnll.Controls.OfType<Button>())
                            {
                                    Bn.ForeColor = Tinte;
                            }

                        }
                    }
                    foreach (GroupBox gb in Sender.Controls.OfType<GroupBox>())
                    {
                        foreach (Button Bn in gb.Controls.OfType<Button>())
                        {
                            Bn.ForeColor = Tinte;
                        }
                        foreach (GroupBox gbb in gb.Controls.OfType<GroupBox>())
                        {
                            foreach (Button Bn in gbb.Controls.OfType<Button>())
                            {
                                Bn.ForeColor = Tinte;
                            }

                        }
                    }
                }
            }

            else
            {
                foreach (Button Sender in Controls.OfType<Button>())
                {
                        Sender.BackColor = Tinte;
                }
                foreach (Panel Sender in Controls.OfType<Panel>())
                {
                    foreach (Button Bn in Sender.Controls.OfType<Button>())
                    {
                            Bn.BackColor = Tinte;
                    }
                    foreach (Panel Pnl in Sender.Controls.OfType<Panel>())
                    {
                        foreach (Button Bn in Pnl.Controls.OfType<Button>())
                        {
                                Bn.BackColor = Tinte;
                        }
                    }
                }
                foreach (TabPage Sender in TabControl.Controls.OfType<TabPage>())
                {
                    foreach (Button Bn in Sender.Controls.OfType<Button>())
                    {
                            Bn.BackColor = Tinte;
                    }
                    foreach (Panel pnl in Sender.Controls.OfType<Panel>())
                    {
                        foreach (Button Bn in pnl.Controls.OfType<Button>())
                        {
                                Bn.BackColor = Tinte;
                        }
                        foreach (Panel Pnll in pnl.Controls.OfType<Panel>())
                        {
                            foreach (Button Bn in Pnll.Controls.OfType<Button>())
                            {
                                    Bn.BackColor = Tinte;
                            }
                        }
                    }
                    foreach (GroupBox gb in Sender.Controls.OfType<GroupBox>())
                    {
                        foreach (Button Bn in gb.Controls.OfType<Button>())
                        {
                            Bn.BackColor = Tinte;
                        }
                        foreach (GroupBox gbb in gb.Controls.OfType<GroupBox>())
                        {
                            foreach (Button Bn in gbb.Controls.OfType<Button>())
                            {
                                Bn.BackColor = Tinte;
                            }

                        }
                    }
                }
            }
        }
        void Botones()
        {
            if (Estilo(1))
            {
                CicloBoton(Blue, true);

                CicloBoton(Color.White, false);
            }
            else
            {
                CicloBoton(Color.White, true);

                CicloBoton(Color.Black, false);
            }
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
                    CicloTabla(Tinte, true);
                    foreach (TabPage Sender in TabControl.Controls.OfType<TabPage>())
                    {
                        Sender.BackColor = Tinte;
                    }
                    Botones();
                    break;
                case 1:
                    ForeColor = Tinte;
                    foreach (Object Sender in MenuSup.Items)
                    {
                        try
                        {
                            ((ToolStripMenuItem)Sender).ForeColor = Tinte;
                        }
                        catch { }
                    }
                    Grafica.Series[0].Color = Tinte;
                    Grafica.Titles[0].ForeColor = Tinte;
                    Grafica.Titles[0].BorderColor = Tinte;
                    Grafica.Legends[0].BorderColor = Tinte;
                    Grafica.Legends[0].ForeColor = Tinte;
                    Grafica.Annotations[0].LineColor = Tinte;
                    Grafica.ChartAreas[0].BackColor = Tinte;
                    if (As.Condicionales(0, Tinte))
                    {
                        panelInferior1.BackColor = Tinte;
                        panelInferior2.BackColor = Tinte;
                        panelInferior3.BackColor = Tinte;
                        panelInferior4.BackColor = Tinte;
                    }
                    else
                    {
                        panelInferior1.BackColor = Color.White;
                        panelInferior2.BackColor = Color.White;
                        panelInferior3.BackColor = Color.White;
                        panelInferior4.BackColor = Color.White;
                    }
                    if (As.Condicionales(1, Tinte))
                    {
                        CicloTabla(Tinte, false);
                    }
                    else
                    {
                        CicloTabla(Color.Black, false);
                    }
                    CicloColor(Tinte);
                    Botones();
                    break;
                default:
                    break;
            }
            if (Estilo(0))
            {
                lbEstadoUsu.ForeColor = Color.DarkGray;
            }
            else
            {
                lbEstadoUsu.ForeColor = ForeColor;
            }
        }
        void CicloTabla(Color Tinte, Boolean Back)
        {
            if (!Back)
            {
                foreach (TabPage Sender in TabControl.Controls.OfType<TabPage>())
                {
                    foreach (DataGridView dtgv in Sender.Controls.OfType<DataGridView>())
                    {
                        try
                        {
                            dtgv.DefaultCellStyle.ForeColor = Tinte;
                            dtgv.AlternatingRowsDefaultCellStyle.ForeColor = Tinte;
                        }
                        catch { }
                    }
                }
            }
            else
            {
                foreach (TabPage Sender in TabControl.Controls.OfType<TabPage>())
                {
                    foreach (DataGridView dtgv in Sender.Controls.OfType<DataGridView>())
                    {
                        try
                        {
                            dtgv.BackgroundColor = Tinte;
                        }
                        catch { }
                    }
                }
            }
        }
        void pbxLlenar(Image IM, String Source)
        {
            pbxImagenAct.Image = 
            pbxImagenAvan.Image = 
            pbxImagenReg.Image = 
            pbxImagenBuscar.Image = IM;
            txImagen.Text = Source;
        }
        void EnviarDiseño(Int32 R, Int32 G, Int32 B, Int32 R1, Int32 G1, Int32 B1)
        {
            Int32 FF = As.CondicionalesDobles(0, Fuente, Fondo);
            if (FF < 100 && cbPrediseño.SelectedIndex != FF)
            {
                cbPrediseño.SelectedIndex = FF; return;
            }
            Eprog = new E_Programa(R, G, B, R1, G1, B1);
            Prog.UPDATE3(Eprog);

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
            foreach (Panel Sender in Controls.OfType<Panel>())
            {
                foreach (Label lbl in Sender.Controls.OfType<Label>())
                {
                    try
                    {
                        lbl.ForeColor = Tinte;
                    }
                    catch { }
                }
                foreach (Panel pnl in Sender.Controls.OfType<Panel>())
                {
                    foreach (Label lbl in pnl.Controls.OfType<Label>())
                    {
                        try
                        {
                            lbl.ForeColor = Tinte;
                        }
                        catch { }
                    }
                }
            }
            foreach (TabPage Sender in TabControl.Controls.OfType<TabPage>())
            {
                foreach (Label lbl in Sender.Controls.OfType<Label>())
                {
                    try
                    {
                        lbl.ForeColor = Tinte;
                    }
                    catch { }
                }
                foreach (Panel pnl in Sender.Controls.OfType<Panel>())
                {
                    foreach (Label lbl in pnl.Controls.OfType<Label>())
                    {
                        try
                        {
                            lbl.ForeColor = Tinte;
                        }
                        catch { }
                    }
                    foreach (Panel pnll in pnl.Controls.OfType<Panel>())
                    {
                        foreach (Label lbl in pnll.Controls.OfType<Label>())
                        {
                            try
                            {
                                lbl.ForeColor = Tinte;
                            }
                            catch { }
                        }
                    }
                }
            }
        }
        void Switch(int Index)
        {
            switch (Index)
            {
                case 0:
                    switch (cbEstiloFRM.SelectedIndex)
                    {
                        case 0:
                            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                            break;
                        case 1:
                            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                            break;
                        case 2:
                            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                            break;
                        case 3:
                            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                            break;
                        case 4:
                            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                            break;
                        case 5:
                            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                            break;
                        case 6:
                            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        void BorderStyle()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Switch(0);
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                Switch(0);
            }
            ShowIcon = true;
            Settings.Default.Borde = cbEstiloFRM.SelectedIndex;
            Settings.Default.Save();
        }
        void CentrarObjet(Object Sender, Object Contenedor, Int32 Index)
        {
            switch (Index)
            {
                case 0:
                    ((Label)Sender).Location = new Point(((Panel)Contenedor).Width / 2 - ((Label)Sender).Width / 2, ((Label)Sender).Location.Y);
                    break;
                default:
                    break;
            }
        }
        void CentrarObjeto(int Index)
        {
            switch (Index)
            {
                case 0:
                    foreach (Label sender in panelMenuSup.Controls.OfType<Label>())
                    {
                        sender.Location = new Point(panelMenuSup.Width / 2 - sender.Width / 2, sender.Location.Y);
                    }
                    break;
                default:
                    break;
            }
        }
        private void AñadirImg()
        {
            try
            {
                OpenMedia = new OpenFileDialog();
                OpenMedia.InitialDirectory = System.Environment.SpecialFolder.CommonMusic.ToString();
                OpenMedia.FileName = "";
                OpenMedia.Title = "Elegir imagen..";
                OpenMedia.Multiselect = false;
                OpenMedia.Filter = "Archivo de Imagen (*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG;)|*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG";
                if (OpenMedia.ShowDialog() == DialogResult.OK)
                {
                    pbxLlenar(Image.FromFile(OpenMedia.FileName), OpenMedia.FileName);
                }
            }
            catch (Exception ex) { Excepcion(ex); }
        }
        private void CambiarFotoPerfil()
        {
            try
            {
                OpenMedia = new OpenFileDialog();
                OpenMedia.InitialDirectory = System.Environment.SpecialFolder.CommonMusic.ToString();
                OpenMedia.FileName = "";
                OpenMedia.Title = "Elegir nueva foto de perfil..";
                OpenMedia.Multiselect = false;
                OpenMedia.Filter = "Archivo de Imagen (*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG;)|*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG";
                if (OpenMedia.ShowDialog() == DialogResult.OK)
                {
                    ActualizarFoto(Image.FromFile(OpenMedia.FileName));
                }
            }
            catch (Exception ex) { Excepcion(ex); }
        }
        void ActualizarFoto(Image Img)
        {
            pbxFoto2.Image = Img;
            Eprog = new E_Programa(pbxFoto2.Image);
            Prog.UPDATE7(Eprog);
            Mensajebx.FotoPerfil();
        }
        private void CapturarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            if (Convert.ToInt16(DateTime.Now.Second) < 10)
            {
                lblHora.Text = DateTime.Now.ToShortTimeString() + ":0" + DateTime.Now.Second.ToString();
                return;
            }
            lblHora.Text = DateTime.Now.ToShortTimeString() + ":" + DateTime.Now.Second.ToString();
        }
        void Limpiar()
        {
            txNombre.Clear();
            txValor.Clear();
            txDescripcion.Clear();
        }
        //Busqueda
        void Buscar(DataGridView DGV, String Texto, ComboBox CB, DateTimePicker DTP)
        {
            CEntidad = new CRUD_Objeto();
            switch (CB.SelectedIndex)
            {
                case 0:
                    try { DGV.DataSource = CEntidad.LIKE_OBJETOT(Texto, DTP.Value); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 1:
                    try { DGV.DataSource = CEntidad.LIKETT(Texto); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 2:
                    try { DGV.DataSource = CEntidad.LIKE1(Texto); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 3:
                    try { DGV.DataSource = CEntidad.LIKE2(Texto); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 4:
                    try { DGV.DataSource = CEntidad.LIKE3(Texto); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 5:
                    try { DGV.DataSource = CEntidad.LIKE4(DTP.Value); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                default:
                    break;
            }
        }
        void BuscarReciclaje()
        {
            switch (CbBusqueda5.SelectedIndex)
            {
                case 0:
                    try { TablaPapelera.DataSource = CEntidad.RLIKET(txBuscarPap.Text, dtpBuscPap.Value); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 1:
                    try { TablaPapelera.DataSource = CEntidad.RLIKETT(txBuscarPap.Text); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 2:
                    try { TablaPapelera.DataSource = CEntidad.RLIKE1(txBuscarPap.Text); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 3:
                    try { TablaPapelera.DataSource = CEntidad.RLIKE2(txBuscarPap.Text); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 4:
                    try { TablaPapelera.DataSource = CEntidad.RLIKE3(txBuscarPap.Text); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 5:
                    try { TablaPapelera.DataSource = CEntidad.RLIKE4(dtpBuscPap.Value); }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                default:
                    break;
            }
        }
        void Listar(Int16 busc)
        {
            Boton.Play();
            switch (busc)
            {
                case 0:
                    panelActualizar.Hide();
                    TablaActualizar.Show();
                    TablaActualizar.BringToFront();
                    Buscar(TablaActualizar, txBuscarAct.Text, CbBusqueda1, dtpBuscAct);
                    break;
                case 1:
                    Buscar(TablaReciclar, txBuscarRec.Text, CbBusqueda2, dtpBuscRec);
                    break;
                case 2:
                    bnVerSeleccion.Show();
                    bnCapturar.Hide();
                    bnPCompletaEntidad.Hide();
                    TablaBuscar.Show();
                    panelBuscar.Hide();
                    TablaBuscar.BringToFront();
                    Buscar(TablaBuscar, txBuscar.Text, CbBusqueda3, dtpBusc);
                    break;
                case 3:
                    TablaReportes.Show();
                    rptEntidad.Hide();
                    bnPCompletaReporte.Hide();
                    bnReportarSeleccion.Show();
                    TablaReportes.BringToFront();
                    Buscar(TablaReportes, txBuscarRep.Text, CbBusqueda4, dtpBuscRep);
                    break;
                default:
                    break;
            }
        }
        void VerTodos(DataGridView Dt)
        {
            Dt.DataSource = CEntidad.TSELECT();
        }
        //Mensajes
        void TxCampoVacio(Object O)
        {
            MensajeTool.ValorInvalidado(toolTip2, O);
        }
        void ErrorMensaje(Int16 Numero)
        {
            Mensajebx.ErrorMensaje(Numero);
        }
        void TrayMensaje(Int32 Numero)
        {
            MensajeTray.TrayMensaje(Numero, trayBar);
        }
        void Excepcion(Exception ex)
        {
            Mensajebx.Excepcion(ex);
        }
        void SeleccionIncorrecta(TextBox Tx)
        {
            MensajeTool.SeleccionInvalidada(toolTip2, Tx);
        }
        //Insertar
        void Insertar()
        {
            if (Validacion.CampoVacio(txNombre.Text.Trim(), 3))
            {
                Datos.Play();
                TxCampoVacio(txNombre);
                return;
            }
            else if (Validacion.CampoVacio(txValor.Text.Trim(), 3) | Validacion.CampoGrande(txValor.Text.Trim(), 15) | Validacion.Numero(txValor.Text.Trim()))
            {
                Datos.Play();
                TxCampoVacio(txValor);
                return;
            }
            else if (Validacion.CampoVacio(txDescripcion.Text.Trim(), 10))
            {
                Datos.Play();
                TxCampoVacio(txDescripcion);
                return;
            }
            try
            {
                CEntidad = new CRUD_Objeto(0, txNombre.Text.Trim(), txDescripcion.Text.Trim(), Convert.ToInt64(txValor.Text.Trim()), pbxImagenReg.Image);
                Valor = CEntidad.INSERT();
                if (Valor != 1) { ErrorMensaje(0); return; }
            }
            catch (Exception ex) { Excepcion(ex); return; }

            Mensajebx.Insertado();
            Limpiar();
        }
        //Mostrar
        void VerSelec()
        {
            if (TablaBuscar.SelectedRows.Count == 1)
            {
                try
                {
                    bnVerSeleccion.Hide();
                    TablaBuscar.Hide();
                    bnCapturar.Show();
                    bnPCompletaEntidad.Show();
                    panelBuscar.Show();
                    panelBuscar.BringToFront();

                    lblCodigo.Text = TablaBuscar.CurrentRow.Cells[0].Value.ToString();
                    lblNombre.Text = TablaBuscar.CurrentRow.Cells[1].Value.ToString();
                    lblDescripcion.Text = TablaBuscar.CurrentRow.Cells[2].Value.ToString();
                    lblValor.Text = "$" + TablaBuscar.CurrentRow.Cells[3].Value.ToString();

                    DatosImg = (Byte[])TablaBuscar.CurrentRow.Cells[5].Value;
                    MemS = new MemoryStream(DatosImg);
                    pbxLlenar(Bitmap.FromStream(MemS), "Entidad");
                }
                catch (Exception ex) { Excepcion(ex); }
            }
            else if (TablaBuscar.SelectedCells.Count >= 1)
            {
                VerSelecCelda(TablaBuscar.SelectedCells[0].RowIndex);
            }
            else
                SeleccionIncorrecta(txBuscar);
        }
        void VerSelecCelda(Int32 Row)
        {
            try
            {
                bnVerSeleccion.Hide();
                bnCapturar.Show();
                bnPCompletaEntidad.Show();
                TablaBuscar.Hide();
                panelBuscar.Show();
                panelBuscar.BringToFront();

                lblCodigo.Text = TablaBuscar[0, Row].Value.ToString();
                lblNombre.Text = TablaBuscar[1, Row].Value.ToString();
                lblDescripcion.Text = TablaBuscar[2, Row].Value.ToString();
                lblValor.Text = "$" + TablaBuscar[3, Row].Value.ToString();
                DatosImg = (Byte[])TablaBuscar[5, Row].Value;
                MemS = new MemoryStream(DatosImg);
                pbxLlenar(Bitmap.FromStream(MemS), "Entidad");
            }
            catch (Exception ex) { Excepcion(ex); }
        }
        //Reportar
        void ReportarSelec()
        {
            if (TablaReportes.SelectedRows.Count == 1)
            {
                try
                {
                    TablaReportes.Hide();
                    rptEntidad.Show();
                    bnPCompletaReporte.Show();
                    bnReportarSeleccion.Hide();
                    rptEntidad.BringToFront();

                    sELECT_OBJETOTableAdapter.Fill(this.dTS_RPT_OBJETO.SELECT_OBJETO, Convert.ToInt64(TablaReportes.CurrentRow.Cells[0].Value));
                    rptEntidad.RefreshReport();

                    DatosImg = (Byte[])TablaReportes.CurrentRow.Cells[5].Value;
                    MemS = new MemoryStream(DatosImg);
                    pbxLlenar(Bitmap.FromStream(MemS), "Entidad");
                }
                catch (Exception ex) { Excepcion(ex); }
            }
            else if (TablaReportes.SelectedCells.Count >= 1)
            {
                ReportarSelecCelda(TablaReportes.SelectedCells[0].RowIndex);
            }
            else
                SeleccionIncorrecta(txBuscarRep);
        }
        void ReportarSelecCelda(Int32 Row)
        {
            try
            {
                TablaReportes.Hide();
                rptEntidad.Show();
                rptEntidad.BringToFront();
                bnPCompletaReporte.Show();
                bnReportarSeleccion.Hide();

                sELECT_OBJETOTableAdapter.Fill(this.dTS_RPT_OBJETO.SELECT_OBJETO, Convert.ToInt64(TablaReportes[0, Row].Value));
                rptEntidad.RefreshReport();

                DatosImg = (Byte[])TablaReportes[5, Row].Value;
                MemS = new MemoryStream(DatosImg);
                pbxImagenBuscar.Image = Bitmap.FromStream(MemS);
            }
            catch (Exception ex) { Excepcion(ex); }
        }
        //Reciclar
        void ReciclarSelecion()
        {
            if (TablaReciclar.SelectedRows.Count == 1)
            {
                if (Mensajebx.Reciclar() == DialogResult.Yes)
                {
                    try
                    {
                        ID = Convert.ToInt64(TablaReciclar.CurrentRow.Cells[0].Value);
                        Valor = CEntidad.RECICLAR(ID);
                        if (Valor != 1) { ErrorMensaje(1); return; }
                    }
                    catch (Exception ex) { Excepcion(ex); return; }

                    Mensajebx.Reciclado();
                    Listar(1);
                }
            }
            else if (TablaReciclar.SelectedCells.Count >= 1)
            {
                ReciclarSelecionCelda(TablaReciclar.SelectedCells[0].RowIndex);
            }
            else
            {
                SeleccionIncorrecta(txBuscarRec);
            }
        }
        void ReciclarSelecionCelda(Int32 Row)
        {
            if (Mensajebx.Reciclar() == DialogResult.Yes)
            {
                try
                {
                    ID = Convert.ToInt64(TablaReciclar[0, Row].Value);

                    Valor = CEntidad.RECICLAR(ID);
                    if (Valor != 1) { ErrorMensaje(1); return; }
                }
                catch (Exception ex) { Excepcion(ex); return; }

                Mensajebx.Reciclado();
                Listar(1);
            }
        }
        void ReciclarSeleccionados()
        {
            if (TablaAvanz.Rows.Count >= 1)
            {
                if (Mensajebx.ReciclarSelec() == DialogResult.Yes)
                {
                    Valor = 0;
                    foreach (DataGridViewRow Row in TablaAvanz.Rows)
                    {
                        try
                        {
                            ID = Convert.ToInt64(TablaAvanz[0, Row.Index].Value);

                            Valor = CEntidad.RECICLAR(ID);
                            if (Valor != 1) { ErrorMensaje(5); return; }
                        }
                        catch (Exception ex) { Excepcion(ex); return; }
                    }
                    TablaAvanz.DataSource = new DataTable();
                    Mensajebx.Reciclados();
                }
            }
            else
            {
                ErrorMensaje(11);
            }
        }
        void ReciclarTodos()
        {
            if (Mensajebx.ReciclarTodos() == DialogResult.Yes)
            {
                try
                {
                    Valor = CEntidad.TRECICLAR();
                    if (Valor < 1) { ErrorMensaje(13); return; }
                }
                catch (Exception ex) { Excepcion(ex); return; }
                TablaAvanz.DataSource = new DataTable();
                Mensajebx.Reciclados();

            }
        }
        //Reestaurar
        void RestaurarSelecion()
        {
            if (TablaPapelera.SelectedRows.Count == 1)
            {
                if (Mensajebx.Restaurar() == DialogResult.Yes)
                {
                    try
                    {
                        ID = Convert.ToInt64(TablaPapelera.CurrentRow.Cells[0].Value);

                        Valor = CEntidad.RECUPERAR(ID);
                        if (Valor != 1) { ErrorMensaje(1); return; }
                    }
                    catch (Exception ex) { Excepcion(ex); return; }

                    Mensajebx.Reestaurado();
                    TablaSelectPapelera.DataSource = new DataTable();
                    BuscarReciclaje();
                }
            }
            else if (TablaPapelera.SelectedCells.Count >= 1)
            {
                RestaurarSelecionCelda(TablaPapelera.SelectedCells[0].RowIndex);
            }
            else
            {
                SeleccionIncorrecta(txBuscarPap);
            }
        }
        void RestaurarSelecionCelda(Int32 Row)
        {
            if (Mensajebx.Restaurar() == DialogResult.Yes)
            {
                try
                {
                    ID = Convert.ToInt64(TablaPapelera[0, Row].Value);

                    Valor = CEntidad.RECUPERAR(ID);
                    if (Valor != 1) { ErrorMensaje(1); return; }
                }
                catch (Exception ex) { Excepcion(ex); return; }

                Mensajebx.Reestaurado();
                TablaSelectPapelera.DataSource = new DataTable();
                BuscarReciclaje();
            }
        }
        void RestaurarSeleccionados()
        {
            if (TablaSelectPapelera.Rows.Count >= 1)
            {
                if (Mensajebx.RestaurarSelec() == DialogResult.Yes)
                {
                    Valor = 0;
                    foreach (DataGridViewRow Row in TablaSelectPapelera.Rows)
                    {
                        try
                        {
                            ID = Convert.ToInt64(TablaSelectPapelera[0, Row.Index].Value);

                            Valor = CEntidad.RECUPERAR(ID);
                            if (Valor != 1) { ErrorMensaje(5); return; }
                        }
                        catch (Exception ex) { Excepcion(ex); return; }
                    }
                    TablaSelectPapelera.DataSource = new DataTable();
                    Mensajebx.Reestaurados();
                    BuscarReciclaje();
                }
            }
            else
            {
                ErrorMensaje(11);
            }
        }
        void RestaurarTodos()
        {
            if (Mensajebx.RestaurarTodos() == DialogResult.Yes)
            {
                try
                {
                    Valor = CEntidad.TRECUPERAR();
                    if (Valor < 1) { ErrorMensaje(13); return; }
                }
                catch (Exception ex) { Excepcion(ex); return; }

                TablaSelectPapelera.DataSource = new DataTable();
                Mensajebx.Reestaurados();
                BuscarReciclaje();

            }
        }
        //Eliminar
        void EliminarSelecion()
        {
            if (TablaPapelera.SelectedRows.Count == 1)
            {
                if (Mensajebx.Eliminar() == DialogResult.Yes)
                {
                    ConfContr = new ConfirmarContraseña();
                    if (ConfContr.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            ID = Convert.ToInt64(TablaPapelera.CurrentRow.Cells[0].Value);

                            Valor = CEntidad.DELETE(ID);
                            if (Valor != 1) { ErrorMensaje(1); return; }
                        }
                        catch (Exception ex) { Excepcion(ex); return; }

                        Mensajebx.Eliminado();
                        TablaSelectPapelera.DataSource = new DataTable();
                        BuscarReciclaje();
                    }
                }
            }
            else if (TablaPapelera.SelectedCells.Count >= 1)
            {
                EliminarSelecionCelda(TablaPapelera.SelectedCells[0].RowIndex);
            }
            else
            {
                SeleccionIncorrecta(txBuscarPap);
            }
        }
        void EliminarSelecionCelda(Int32 Row)
        {
            if (Mensajebx.Eliminar() == DialogResult.Yes)
            {
                ConfContr = new ConfirmarContraseña();
                if (ConfContr.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ID = Convert.ToInt64(TablaPapelera[0, Row].Value);

                        Valor = CEntidad.DELETE(ID);
                        if (Valor != 1) { ErrorMensaje(1); return; }
                    }
                    catch (Exception ex) { Excepcion(ex); return; }

                    Mensajebx.Eliminado();
                    TablaSelectPapelera.DataSource = new DataTable();
                    BuscarReciclaje();
                }
            }
        }
        void EliminarSeleccionados()
        {
            if (TablaSelectPapelera.Rows.Count >= 1)
            {
                if (Mensajebx.EliminarSelec() == DialogResult.Yes)
                {
                    ConfContr = new ConfirmarContraseña();
                    if (ConfContr.ShowDialog() == DialogResult.OK)
                    {
                        Valor = 0;
                        foreach (DataGridViewRow Row in TablaSelectPapelera.Rows)
                        {
                            try
                            {
                                ID = Convert.ToInt64(TablaSelectPapelera[0, Row.Index].Value);

                                Valor = CEntidad.DELETE(ID);
                                if (Valor != 1) { ErrorMensaje(5); return; }
                            }
                            catch (Exception ex) { Excepcion(ex); return; }
                        }
                        TablaSelectPapelera.DataSource = new DataTable();
                        Mensajebx.Eliminados();
                        BuscarReciclaje();
                    }
                }
            }
            else
            {
                ErrorMensaje(11);
            }
        }
        void EliminarTodos()
        {
            if (Mensajebx.EliminarTodos() == DialogResult.Yes)
            {
                ConfContr = new ConfirmarContraseña();
                if (ConfContr.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Valor = CEntidad.TDELETE();
                        if (Valor < 1) { ErrorMensaje(13); return; }
                    }
                    catch (Exception ex) { Excepcion(ex); return; }
                    TablaSelectPapelera.DataSource = new DataTable();
                    Mensajebx.Eliminados();
                    BuscarReciclaje();
                }
            }
        }
        //Actualizar
        void ActualizarTodos()
        {
            if (Mensajebx.ActualizarTodos() == DialogResult.Yes)
            {
                ConfContr = new ConfirmarContraseña();
                if (ConfContr.ShowDialog() == DialogResult.OK)
                {
                    switch (cbCampo.SelectedIndex)
                    {
                        case 0:
                            if (Validacion.CampoVacio(txValorCampo1.Text.Trim(), 10))
                            {
                                Datos.Play();
                                TxCampoVacio(txValorCampo1);
                                return;
                            }
                            else
                            {
                                foreach (DataGridViewRow Row in TablaAvanz.Rows)
                                {
                                    try
                                    {
                                        CEntidad = new CRUD_Objeto(txValorCampo1.Text.Trim());
                                        Valor = CEntidad.UPDATE_1();
                                        if (Valor < 1) { ErrorMensaje(12); return; }
                                        Mensajebx.Actualizado();
                                    }
                                    catch (Exception ex) { Excepcion(ex); return; }
                                }
                            }
                            break;
                        case 1:
                            if (Validacion.CampoVacio(txValorCampo2.Text.Trim(), 3) | Validacion.CampoGrande(txValorCampo2.Text.Trim(), 15) | Validacion.Numero(txValorCampo2.Text.Trim()))
                            {
                                Datos.Play();
                                TxCampoVacio(txValorCampo2);
                                return;
                            }
                            else
                            {
                                try
                                {
                                    CEntidad = new CRUD_Objeto(Convert.ToInt64(txValorCampo2.Text.Trim()));

                                    Valor = CEntidad.UPDATE_2();
                                    if (Valor < 1) { ErrorMensaje(12); return; }
                                    Mensajebx.Actualizado();
                                }
                                catch (Exception ex) { Excepcion(ex); return; }
                            }
                            break;
                        case 2:
                            try
                            {
                                CEntidad = new CRUD_Objeto(pbxImagenAvan.Image);

                                Valor = CEntidad.UPDATE_2();
                                if (Valor < 1) { ErrorMensaje(12); return; }
                                Mensajebx.Actualizado();
                            }
                            catch (Exception ex) { Excepcion(ex); return; }

                            break;
                        default:
                            Valor = 0;
                            ErrorMensaje(10);
                            break;
                    }
                }
            }
        }
        void ActualizarSeleccionados()
        {
            if (TablaAvanz.Rows.Count >= 1)
            {
                if (Mensajebx.ActualizarSelec() == DialogResult.Yes)
                {
                    Valor = 0;
                    switch (cbCampo.SelectedIndex)
                    {
                        case 0:
                            if (Validacion.CampoVacio(txValorCampo1.Text.Trim(), 10))
                            {
                                Datos.Play();
                                TxCampoVacio(txValorCampo1);
                                return;
                            }
                            else
                            {
                                foreach (DataGridViewRow Row in TablaAvanz.Rows)
                                {
                                    try
                                    {
                                        CEntidad = new CRUD_Objeto(txValorCampo1.Text.Trim(), Convert.ToInt64(Row.Cells[0].Value));

                                        Valor = CEntidad.UPDATE_4();
                                        if (Valor != 1) { ErrorMensaje(12); return; }
                                    }
                                    catch (Exception ex) { Excepcion(ex); return; }
                                }
                                Mensajebx.Actualizado();
                            }
                            break;
                        case 1:
                            if (Validacion.CampoVacio(txValorCampo2.Text.Trim(), 3) | Validacion.CampoGrande(txValorCampo2.Text.Trim(), 15) | Validacion.Numero(txValorCampo2.Text.Trim()))
                            {
                                Datos.Play();
                                TxCampoVacio(txValorCampo2);
                                return;
                            }
                            else
                            {
                                foreach (DataGridViewRow Row in TablaAvanz.Rows)
                                {
                                    try
                                    {
                                        CEntidad = new CRUD_Objeto(Convert.ToInt64(txValorCampo2.Text.Trim()), Convert.ToInt64(Row.Cells[0].Value));

                                        Valor = CEntidad.UPDATE_5();
                                        if (Valor != 1) { ErrorMensaje(12); return; }
                                    }
                                    catch (Exception ex) { Excepcion(ex); return; }
                                }
                                Mensajebx.Actualizado();
                            }
                            break;
                        case 2:
                            foreach (DataGridViewRow Row in TablaAvanz.Rows)
                            {
                                try
                                {
                                    CEntidad = new CRUD_Objeto(pbxImagenAvan.Image, Convert.ToInt64(Row.Cells[0].Value));

                                    Valor = CEntidad.UPDATE_6();
                                    if (Valor != 1) { ErrorMensaje(12); return; }
                                }
                                catch (Exception ex) { Excepcion(ex); return; }
                            }
                            Mensajebx.Actualizado();
                            break;
                        default:
                            Valor = 0;
                            ErrorMensaje(10);
                            break;
                    }
                }
            }
            else
            {
                ErrorMensaje(11);
            }
        }
        void Actualizar()
        {
            if (Validacion.CampoVacio(txNombreAct.Text.Trim(), 3))
            {
                Datos.Play();
                TxCampoVacio(txNombreAct);
                return;
            }
            else if (Validacion.CampoVacio(txValorAct.Text.Trim(), 3) | Validacion.CampoGrande(txValorAct.Text.Trim(), 15) | Validacion.Numero(txValorAct.Text.Trim()))
            {
                Datos.Play();
                TxCampoVacio(txValorAct);
                return;
            }
            else if (Validacion.CampoVacio(txDescripcionAct.Text.Trim(), 5))
            {
                Datos.Play();
                TxCampoVacio(txDescripcionAct);
                return;
            }
            try
            {
                CEntidad = new CRUD_Objeto(ID, txNombreAct.Text.Trim(), txDescripcionAct.Text.Trim(), Convert.ToInt64(txValorAct.Text.Trim()), pbxImagenAct.Image);
                Valor = CEntidad.UPDATE();
                if (Valor != 1) { ErrorMensaje(4); return; }
            }
            catch (Exception ex) { Excepcion(ex); return; }

            Mensajebx.Actualizado();
            Listar(0);
        }
        void EditarSelecion()
        {
            if (TablaActualizar.SelectedRows.Count == 1)
            {
                try
                {
                    panelActualizar.Show();
                    TablaActualizar.Hide();
                    ID = Convert.ToInt64(TablaActualizar.CurrentRow.Cells[0].Value);
                    txNombreAct.Text = TablaActualizar.CurrentRow.Cells[1].Value.ToString();
                    txDescripcionAct.Text = TablaActualizar.CurrentRow.Cells[2].Value.ToString();
                    txValorAct.Text = "" + Convert.ToInt64(TablaActualizar.CurrentRow.Cells[3].Value);
                    DatosImg = (Byte[])TablaActualizar.CurrentRow.Cells[5].Value;
                    MemS = new MemoryStream(DatosImg);
                    pbxLlenar(Bitmap.FromStream(MemS), "Entidad");
                    panelActualizar.BringToFront();
                }
                catch (Exception ex) { Excepcion(ex); }
            }
            else if (TablaActualizar.SelectedCells.Count >= 1)
            {
                EditarSelecionCelda(TablaActualizar.SelectedCells[0].RowIndex);
            }
            else
            {
                SeleccionIncorrecta(txBuscarAct);
            }

        }
        void EditarSelecionCelda(Int32 Row)
        {
            try
            {
                panelActualizar.Show();
                TablaActualizar.Hide();
                ID = Convert.ToInt64(TablaActualizar[0, Row].Value);
                txNombreAct.Text = TablaActualizar[1, Row].Value.ToString();
                txDescripcionAct.Text = TablaActualizar[2, Row].Value.ToString();
                txValorAct.Text = "" + Convert.ToInt64(TablaActualizar[3, Row].Value);
                DatosImg = (Byte[])TablaActualizar[5, Row].Value;
                MemS = new MemoryStream(DatosImg);
                pbxLlenar(Bitmap.FromStream(MemS), "Entidad");
                panelActualizar.BringToFront();
            }
            catch (Exception ex) { Excepcion(ex); }

        }
        //Captura
        void CapturaTabl()
        {
            if (this.Visible == true)
            {
                if (TabControl.SelectedTab == pgActualizar && TablaActualizar.Visible == true)
                {
                    Camara.Play();
                    Pantallazo = new VisorImagenes(Capt.Tabla(this, TablaActualizar, cbEstiloFRM.SelectedIndex));
                    Ptllazo();
                }
                else if (TabControl.SelectedTab == pgReciclar)
                {
                    Camara.Play();
                    Pantallazo = new VisorImagenes(Capt.Tabla(this, TablaReciclar, cbEstiloFRM.SelectedIndex));
                    Ptllazo();
                }
                else if (TabControl.SelectedTab == pgBuscar && TablaBuscar.Visible == true)
                {
                    Camara.Play();
                    Pantallazo = new VisorImagenes(Capt.Tabla(this, TablaBuscar, cbEstiloFRM.SelectedIndex));
                    Ptllazo();
                }
                else if (TabControl.SelectedTab == pgAvanzados)
                {
                    Camara.Play();
                    Pantallazo = new VisorImagenes(Capt.Tabla2(this, TablaAvanz, cbEstiloFRM.SelectedIndex));
                    Ptllazo();
                }
                else if (TabControl.SelectedTab == pgReportar)
                {
                    Camara.Play();
                    Pantallazo = new VisorImagenes(Capt.Tabla(this, TablaReportes, cbEstiloFRM.SelectedIndex));
                    Ptllazo();
                }
                else if (TabControl.SelectedTab == pgReciclaje)
                {
                    Camara.Play();
                    Pantallazo = new VisorImagenes(Capt.Tabla2(this, TablaSelectPapelera, cbEstiloFRM.SelectedIndex));
                    Ptllazo();
                }
                else
                    ErrorMensaje(2);
            }
            else
                TrayMensaje(0);
        }
        void Ptllazo()
        {
            Pantallazo.ShowDialog();
            Sonidos();
            cbEstiloFRM.SelectedIndex = Settings.Default.Borde;
        }
        //Graficar
        void Graficar()
        {
            TitulosGrafica();
            Grafica.DataSource = CEntidad.TSELECT_GRAFICAR();
        }
        void GraficarSeleccionados(Int32 Index)
        {
            switch (Index)
            {
                case 1:
                    if (TablaAvanz.Rows.Count >= 1)
                    {
                        DataSource = new DataTable();
                        DataSource.Columns.Add(Grafica.Series[0].XValueMember);
                        DataSource.Columns.Add(Grafica.Series[0].YValueMembers);
                        foreach (DataGridViewRow Row in TablaAvanz.Rows)
                        {
                            Drow = As.TablaSeleccionar(FMR, Convert.ToInt32(TablaAvanz[0, Row.Index].Value));
                            DataSource.Rows.Add(Drow[1].ToString(), Convert.ToInt64(Drow[3]));
                        }
                        GraficaComp(DataSource);
                    }
                    else
                    {
                        ErrorMensaje(11);
                    }
                    break;
                case 2:
                    if (TablaSelectPapelera.Rows.Count >= 1)
                    {
                        DataSource = new DataTable();
                        DataSource.Columns.Add(Grafica.Series[0].XValueMember);
                        DataSource.Columns.Add(Grafica.Series[0].YValueMembers);
                        foreach (DataGridViewRow Row in TablaSelectPapelera.Rows)
                        {
                            Drow = As.TablaSeleccionar(FMR, Convert.ToInt32(TablaSelectPapelera[0, Row.Index].Value));
                            DataSource.Rows.Add(Drow[1].ToString(), Convert.ToInt64(Drow[3]));
                        }
                        GraficaComp(DataSource);
                    }
                    else
                    {
                        ErrorMensaje(11);
                    }
                    break;
                default:
                    break;
            }
        }
        void GraficaComp(DataTable Source)
        {
            GrafiC = new GraficaCompleta(Grafica.Series[0].Name, Grafica.Titles[0].Text.ToString(), Grafica.Series[0].XValueMember.ToString(), Grafica.Series[0].YValueMembers.ToString(), Source);
            GrafiC.ShowDialog();
            cbForma.SelectedIndex = Settings.Default.Forma;
            cbPaleta.SelectedIndex = Settings.Default.Paleta;
        }
        void GraficarTodos()
        {
            GraficaComp(CEntidad.TSELECT());
        }
        void GraficarTodosReciclaje()
        {
            GraficaComp(CEntidad.TRSELECT());
        }
        //Ver completo
        void EntidadCompleta()
        {
            Int32 Y = 0, Alto = 0;
            List<Label> lst = new List<Label>();
            panelBuscar.VerticalScroll.Value = 0;
            panelBuscar.HorizontalScroll.Value = 0;
            foreach (Label Sender in panelBuscar.Controls.OfType<Label>())
            {
                try
                {
                    String tx = @Sender.Text;
                    Label lb = new Label();
                    lb.Font = Sender.Font;
                    lb.Text = tx;
                    lb.MaximumSize = new Size(1000, 9999);
                    lb.AutoSize = true;
                    lb.Size = lb.PreferredSize;
                    lb.Anchor = Sender.Anchor;
                    if (Sender == lblTituloEntidadBuscar)
                    {
                        lb.Location = new Point(439 / 2 - Sender.Width, Sender.Location.Y);
                    }
                    else
                    {
                        lb.Location = Sender.Location;
                    }

                    if (lb.Location.Y >= Y)
                    {
                        if (lb.Location.Y > Y)
                        {
                            Y = lb.Location.Y;
                            Alto = lb.Height;
                        }
                        else if (lb.Location.Y == Y && lb.Height > Alto)
                        {
                            Alto = lb.Height;
                        }
                    }
                    lst.Add(lb);

                }
                catch { }
            }
            List<PictureBox> lstpbx = new List<PictureBox>();
            foreach (PictureBox Sender in panelBuscar.Controls.OfType<PictureBox>())
            {
                try
                {
                    PictureBox pb = new PictureBox();
                    pb.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left))); ;
                    pb.Image = Sender.Image;

                    pb.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb.Location = new Point(10, (Y + Alto + 20));
                    lstpbx.Add(pb);
                }
                catch { }
            }
            EntiC = new EntidadCompleta(lst, lstpbx);
            EntiC.ShowDialog();
        }
        void ReporteCompleto()
        {
            Microsoft.Reporting.WinForms.ReportViewer rpt = new Microsoft.Reporting.WinForms.ReportViewer();
            rpt = rptEntidad;
            RPT = new ReporteCompleto(rpt);
            RPT.ShowDialog();
            pgReportar.Controls.Add(rptEntidad);
            rptEntidad.BringToFront();
        }
        #endregion

        #region Eventos
        //Load
        private void FormLoad(object sender, EventArgs e)
        {
            pbxFoto2.AllowDrop =
            pbxImagenAct.AllowDrop =
            pbxImagenReg.AllowDrop =
            pbxImagenAvan.AllowDrop =
            rptEntidad.LocalReport.EnableHyperlinks = true;
            Rellenar();
            tTiempo.Start();
            SelectItm(0);
            cbForma.SelectedIndex = Settings.Default.Forma;
            cbPaleta.SelectedIndex = Settings.Default.Paleta;
            cbEstiloFRM.SelectedIndex = Settings.Default.Borde;
            Inicio.Play();
            Focus();
        }
        //Validaciones
        private void Letras(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }
        private void Numeros(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }
        //Formulario
        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Cancelar)
            {
                if (Mensajebx.Salir() != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
            trayBar.Visible = false;
        }
        private void FRM_OBJETO_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Minimizado.Play();
                trayBar.Visible = true;
                MensajeTray.TrayCRUD(trayBar);
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized | this.WindowState == FormWindowState.Normal)
            {
                trayBar.Visible = false;
            }
        }
        private void FRM_OBJETO_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible)
            {
                panelMenu.Hide();
                TabControl.Enabled = true;
                MenuSup.Enabled = true;
            }
        }
        //Botones
        private void bnInsertar_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Insertar();
        }
        private void bnBuscarAct_Click(object sender, EventArgs e)
        {
            Listar(0);
        }
        private void bnEditarSelecion_Click(object sender, EventArgs e)
        {
            Boton.Play();
            TabControl.SelectedTab = pgActualizar;
            EditarSelecion();
        }
        private void bnActualizar_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Actualizar();
        }
        private void bnBuscarElim_Click(object sender, EventArgs e)
        {
            Listar(1);
        }
        private void bnEliminarSeleccion_Click(object sender, EventArgs e)
        {
            Boton.Play();
            ReciclarSelecion();
        }
        private void bnBuscar_Click(object sender, EventArgs e)
        {
            Listar(2);
        }
        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            try { Process.Start(Settings.Default.InstruccionesCRUD); }
            catch (Exception ex) { Excepcion(ex); }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Application.Exit();
        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cerrasesión();
        }
        private void regresarAlMenúAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VolverAntForm();
        }
        private void completaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallazo = new VisorImagenes(Capt.Completa());
            Ptllazo();
        }
        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Pantallazo = new VisorImagenes(Capt.Formulario(this));
                Ptllazo();
            }
            else
                TrayMensaje(0);
        }
        private void tablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapturaTabl();
        }
        private void VerSeleccion_Click(object sender, EventArgs e)
        {
            Boton.Play();
            VerSelec();
        }
        private void objetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (TabControl.SelectedTab == pgBuscar && bnCapturar.Visible)
                {
                    Pantallazo = new VisorImagenes(Capt.Registro(this, panelBuscar, cbEstiloFRM.SelectedIndex));
                    Ptllazo();
                }
                else
                    ErrorMensaje(3);
            }
            else
                TrayMensaje(0);
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            panelActualizar.Hide();
            TablaActualizar.Show();
            TabControl.SelectedTab = pgActualizar;
            TablaActualizar.BringToFront();
            VerTodos(TablaActualizar);
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = pgReciclar;
            VerTodos(TablaReciclar);
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            panelInferior3.Show();
            TablaBuscar.Show();
            panelBuscar.Hide();
            TablaBuscar.BringToFront();
            VerTodos(TablaBuscar);
        }
        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            cdElegirColor.Color = Fuente;
            if (cdElegirColor.ShowDialog() == DialogResult.OK)
            {
                if (As.Condicionales(2, cdElegirColor.Color))
                {
                    Fuente = cdElegirColor.Color;
                    ColorDiseño(1, cdElegirColor.Color);
                    EnviarDiseño(cdElegirColor.Color.R, cdElegirColor.Color.G, cdElegirColor.Color.B, Fondo.R, Fondo.G, Fondo.B);
                }
                else { ErrorMensaje(9); colorDeFuenteToolStripMenuItem.PerformClick(); return; }
            }
        }
        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            WindowState = FormWindowState.Minimized;
        }
        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            this.Show();
            WindowState = FormWindowState.Maximized;
        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Show();
            WindowState = FormWindowState.Normal;
            Focus();
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            cdElegirColor.Color = Fondo;
            if (cdElegirColor.ShowDialog() == DialogResult.OK)
                if (As.Condicionales(3, cdElegirColor.Color))
                {
                    Fondo = cdElegirColor.Color;
                    ColorDiseño(0, Fondo);
                    EnviarDiseño(Fuente.R, Fuente.G, Fuente.B, Fondo.R, Fondo.G, Fondo.B);
                }
                else { ErrorMensaje(9); colorToolStripMenuItem.PerformClick(); }
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Boton.Play();
            Aceraca.ShowDialog();
            Show();
        }
        private void activarDesactivarSonidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drow = Prog.TSELECT4().Rows[0];
            if (Drow[0].ToString() == "A")
            {
                Eprog = new E_Programa("D");
                Prog.UPDATE4(Eprog);
            }
            else
            {
                Eprog = new E_Programa("A");
                Prog.UPDATE4(Eprog);
            }
            Sonidos();
        }
        private void bnGraficarSeleccion_Click(object sender, EventArgs e)
        {
            Graficar();
        }
        private void GraficatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (TabControl.SelectedTab == pgGraficar)
                {
                    Pantallazo = new VisorImagenes(Capt.Grafica(this, Grafica, cbEstiloFRM.SelectedIndex));
                    Ptllazo();
                }
                else
                    ErrorMensaje(7);
            }
            else
                TrayMensaje(0);
        }
        private void bnSeleccionarAvan1_Click(object sender, EventArgs e)
        {
            TablaC = new TablaCompletaSeleccionar(FMR, FMR_NAME);
            if (TablaC.ShowDialog() == DialogResult.OK)
            {
                if (TablaC.DataSelet.Rows.Count >= 1)
                {
                    DataSelet = TablaC.DataSelet;
                    TablaAvanz.DataSource = DataSelet;
                }
            }
        }
        private void bnGraficarSelecAvan_Click(object sender, EventArgs e)
        {
            GraficarSeleccionados(1);
        }
        private void bnEliminarSelecAvan_Click(object sender, EventArgs e)
        {
            ReciclarSeleccionados();
        }
        private void bnEliminarTodosAvan_Click(object sender, EventArgs e)
        {
            ReciclarTodos();
        }
        private void bnEditarSelecAvan_Click(object sender, EventArgs e)
        {
            ActualizarSeleccionados();
        }
        private void bnEditarTodosAvan_Click(object sender, EventArgs e)
        {
            ActualizarTodos();
        }
        private void TablaAvanz_DoubleClick(object sender, EventArgs e)
        {
            if (TablaAvanz.SelectedRows.Count == 1)
            {
                TablaAvanz.Rows.Remove(TablaAvanz.CurrentRow);
            }
            else if (TablaAvanz.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow DR in TablaAvanz.SelectedRows)
                {
                    TablaAvanz.Rows.Remove(TablaAvanz.Rows[DR.Index]);
                }
            }
            else if (TablaAvanz.SelectedCells.Count >= 1)
            {
                TablaAvanz.Rows.Remove(TablaAvanz.Rows[TablaAvanz.SelectedCells[0].RowIndex]);
            }
        }
        private void pbxImagenReg_Click(object sender, EventArgs e)
        {
            Boton.Play();
            if (!panelMenu.Visible)
            {
                AñadirImg();
            }
            else
            {
                CambiarFotoPerfil();
            }
        }
        private void pbxFoto_Click(object sender, EventArgs e)
        {
            Boton.Play();
            CambiarFotoPerfil();
        }
        private void pbxFoto1_Click(object sender, EventArgs e)
        {
            Boton.Play();
            if (!panelMenu.Visible)
            {
                panelMenu.Show();
                panelMenu.BringToFront();
                MenuSup.Enabled = false;
                TabControl.Enabled = false;
            }
            else
            {
                panelMenu.Hide();
                TabControl.Enabled = true;
                MenuSup.Enabled = true;
            }
        }
        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {
            CapturaTabl();
        }
        private void bnEliminarSelleccionadosRec_Click(object sender, EventArgs e)
        {
            EliminarSeleccionados();
        }
        private void bnRecuperarSeleccionados_Click(object sender, EventArgs e)
        {
            RestaurarSeleccionados();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GraficarSeleccionados(2);
        }
        private void bnEliminarSeleccionRec_Click(object sender, EventArgs e)
        {
            EliminarSelecion();
        }
        private void bnRecuperarSeleccionRec_Click(object sender, EventArgs e)
        {
            RestaurarSelecion();
        }
        private void bnElinimarTodosRec_Click(object sender, EventArgs e)
        {
            EliminarTodos();
        }
        private void bnRecuperarTodosRec_Click(object sender, EventArgs e)
        {
            RestaurarTodos();
        }
        private void bnGraficarTodosRec_Click(object sender, EventArgs e)
        {
            GraficarTodosReciclaje();
        }
        private void fondoDePantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FondoPantalla = new Icono();
            FondoPantalla.ShowDialog();
            Show();
            Focus();
        }
        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"Programas\Servidor.exe");
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"Programas\Usuario cliente.exe");
        }
        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"Programas\Editor de texto.exe");
        }
        private void maximizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GraficaComp(CEntidad.TSELECT_GRAFICAR());
        }
        private void pantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntidadCompleta();
        }
        private void bnBuscarRep_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Listar(3);
        }
        private void bnReportarSeleccion_Click(object sender, EventArgs e)
        {
            Boton.Play();
            ReportarSelec();
        }
        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            Boton.Play();
            TablaBuscar.Show();
            bnPCompletaReporte.Hide();
            bnReportarSeleccion.Show();
            rptEntidad.Hide();
            TablaReportes.BringToFront();
            VerTodos(TablaReportes);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Minimizado.Play();
            ReporteCompleto();
            Minimizado.Play();
        }
        private void bnInicio_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            As.VolverInicio();
        }
        private void pb_Click(object sender, EventArgs e)
        {
            Hide();
            Rel.ShowDialog();
            Focus();
            Show();
        }
        private void reestablecerConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            Settings.Default.Save();
            Fuente = Color.FromArgb(255, 0, 0, 0);
            Fondo = Color.FromArgb(255, 255, 255, 255);
            ColorDiseño(0, Fondo);
            ColorDiseño(1, Fuente);
            EnviarDiseño(Fuente.R, Fuente.G, Fuente.B, Fondo.R, Fondo.G, Fondo.B);
            Eprog = new E_Programa("A");
            Prog.UPDATE4(Eprog);
            cbEstiloFRM.SelectedIndex = 4;
            cbForma.SelectedIndex = 10;
            cbPaleta.SelectedIndex = 2;
        }
        private void bnGraficarTodosAvan_Click(object sender, EventArgs e)
        {
            GraficarTodos();
        }
        private void bnBuscarPap_Click(object sender, EventArgs e)
        {
            BuscarReciclaje();
        }
        private void bnSeleccionarPap_Click(object sender, EventArgs e)
        {
            TablaC = new TablaCompletaSeleccionar(FMR + 1, FMR_NAME);
            if (TablaC.ShowDialog() == DialogResult.OK)
            {
                if (TablaC.DataSelet.Rows.Count >= 1)
                {
                    DataSelet = TablaC.DataSelet;
                    TablaSelectPapelera.DataSource = DataSelet;
                }
            }
        }
        private void TablaSelectPapelera_DoubleClick(object sender, EventArgs e)
        {
            if (TablaSelectPapelera.SelectedRows.Count == 1)
            {
                TablaSelectPapelera.Rows.Remove(TablaSelectPapelera.CurrentRow);
            }
            else if (TablaSelectPapelera.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow DR in TablaSelectPapelera.SelectedRows)
                {
                    TablaSelectPapelera.Rows.Remove(TablaSelectPapelera.Rows[DR.Index]);
                }
            }
            else if (TablaSelectPapelera.SelectedCells.Count >= 1)
            {
                TablaSelectPapelera.Rows.Remove(TablaSelectPapelera.Rows[TablaSelectPapelera.SelectedCells[0].RowIndex]);
            }
        }
        private void páginasToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            Todaspag(true);
        }
        //Paginas
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            Listar(0);
            SelectItm(1);
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (Inicial == false)
            {
                Inicial = true;
                return;
            }
            SelectItm(0);
            Boton.Play();
        }
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            Listar(1);
            SelectItm(2);
        }
        private void tabPage4_Enter(object sender, EventArgs e)
        {
            if (!bnCapturar.Visible) { Listar(2); }
            SelectItm(3);
        }
        private void tabPage5_Enter(object sender, EventArgs e)
        {
            Boton.Play();
            Graficar();
            SelectItm(4);
        }
        private void tabPage6_Enter(object sender, EventArgs e)
        {
            Boton.Play();
            SelectItm(6);
        }
        private void pgReciclaje_Enter(object sender, EventArgs e)
        {
            Boton.Play();
            BuscarReciclaje();
            SelectItm(7);
        }
        private void pgReportes_Enter(object sender, EventArgs e)
        {
            Listar(3);
            SelectItm(5);
        }
        //ComboBox
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItm(toolStripComboBox1.SelectedIndex);
            ComboBx();
        }
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItm(((ToolStripComboBox)sender).SelectedIndex);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbBusqueda1.SelectedIndex == 0)
            {
                txBuscarAct.Show();
                dtpBuscAct.Show();
                txBuscarAct.Location = new Point(txBuscarAct.Location.X, 0);
                dtpBuscAct.Location = new Point(dtpBuscAct.Location.X, txBuscarAct.Height);
            }
            else if (CbBusqueda1.SelectedIndex <= 4)
            {
                txBuscarAct.Show();
                dtpBuscAct.Hide();
                txBuscarAct.Location = new Point(txBuscarAct.Location.X, (panelSuperior1.Height / 2) - (txBuscarAct.Height / 2));
            }
            else
            {
                dtpBuscAct.Show();
                txBuscarAct.Hide();
                dtpBuscAct.Location = new Point(dtpBuscAct.Location.X, (panelSuperior1.Height / 2) - (dtpBuscAct.Height / 2));
            }
            bnBuscarAct.PerformClick();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbBusqueda2.SelectedIndex == 0)
            {
                txBuscarRec.Show();
                dtpBuscRec.Show();
                txBuscarRec.Location = new Point(txBuscarRec.Location.X, 0);
                dtpBuscRec.Location = new Point(dtpBuscRec.Location.X, txBuscarRec.Height);
            }
            else if (CbBusqueda2.SelectedIndex <= 4)
            {
                txBuscarRec.Show();
                dtpBuscRec.Hide();
                txBuscarRec.Location = new Point(txBuscarRec.Location.X, (panelSuperior2.Height / 2) - (txBuscarRec.Height / 2));
            }
            else
            {
                dtpBuscRec.Show();
                txBuscarRec.Hide();
                dtpBuscRec.Location = new Point(dtpBuscRec.Location.X, (panelSuperior2.Height / 2) - (dtpBuscRec.Height / 2));
            }
            bnBuscarRec.PerformClick();
        }
        private void CbBusqueda3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbBusqueda3.SelectedIndex == 0)
            {
                txBuscar.Show();
                dtpBusc.Show();
                txBuscar.Location = new Point(txBuscar.Location.X, 0);
                dtpBusc.Location = new Point(dtpBusc.Location.X, txBuscar.Height);
            }
            else if (CbBusqueda3.SelectedIndex <= 4)
            {
                txBuscar.Show();
                dtpBusc.Hide();
                txBuscar.Location = new Point(txBuscar.Location.X, (panelSuperior3.Height / 2) - (txBuscar.Height / 2));
            }
            else
            {
                dtpBusc.Show();
                txBuscar.Hide();
                dtpBusc.Location = new Point(dtpBusc.Location.X, (panelSuperior3.Height / 2) - (dtpBusc.Height / 2));
            }
            bnBuscar.PerformClick();
        }
        private void CbBusqueda4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbBusqueda4.SelectedIndex == 0)
            {
                txBuscarRep.Show();
                dtpBuscRep.Show();
                txBuscarRep.Location = new Point(txBuscarRep.Location.X, 0);
                dtpBuscRep.Location = new Point(dtpBuscRep.Location.X, txBuscarRep.Height);
            }
            else if (CbBusqueda4.SelectedIndex <= 4)
            {
                txBuscarRep.Show();
                dtpBuscRep.Hide();
                txBuscarRep.Location = new Point(txBuscarRep.Location.X, (panelSuperior4.Height / 2) - (txBuscarRep.Height / 2));
            }
            else
            {
                dtpBuscRep.Show();
                txBuscarRep.Hide();
                dtpBuscRep.Location = new Point(dtpBuscRep.Location.X, (panelSuperior4.Height / 2) - (dtpBuscRep.Height / 2));
            }
            bnBuscarRep.PerformClick();
        }
        private void cbBusqueda5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbBusqueda5.SelectedIndex == 0)
            {
                txBuscarPap.Show();
                dtpBuscPap.Show();
                txBuscarPap.Location = new Point(txBuscarPap.Location.X, 0);
                dtpBuscPap.Location = new Point(dtpBuscPap.Location.X, txBuscarPap.Height);
            }
            else if (CbBusqueda5.SelectedIndex <= 4)
            {
                txBuscarPap.Show();
                dtpBuscPap.Hide();
                txBuscarPap.Location = new Point(txBuscarPap.Location.X, (panelSuperior5.Height / 2) - (txBuscarPap.Height / 2));
            }
            else
            {
                dtpBuscPap.Show();
                txBuscarPap.Hide();
                dtpBuscPap.Location = new Point(dtpBuscPap.Location.X, (panelSuperior5.Height / 2) - (dtpBuscPap.Height / 2));
            }
            bnBuscarPap.PerformClick();
        }
        private void toolStripComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Inicial)
            {
                Boton.Play();
            }
            Settings.Default.Forma = cbForma.SelectedIndex;
            Settings.Default.Save();
            As.TipoSerie(Grafica, cbForma.SelectedIndex);
        }
        private void cbPaleta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Inicial)
            {
                Boton.Play();
            }
            Settings.Default.Paleta = cbPaleta.SelectedIndex;
            Settings.Default.Save();
            As.PaletaSerie(Grafica, cbPaleta.SelectedIndex);
        }
        private void toolStripComboBox9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Inicial)
            {
                Boton.Play();
            }
            BorderStyle();
        }
        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CampoAvanzados();
        }
        private void cbCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.PreEstablecido(e);
        }
        //TextBox
        private void Text_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true); // recupera los datos del archivo que arrastre
                StreamReader reader = new StreamReader(files[0], System.Text.Encoding.Default);// creo un reader del contenido del archivo
                ((TextBox)sender).Text = reader.ReadToEnd(); // escribo el contenido
                reader.Close();
            }
            catch
            {
                MensajeTool.TextoFormatoNoSoportado(toolTip2, ((TextBox)sender));
            }
        }
        private void txBuscarAct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                bnBuscarAct.PerformClick();
        }
        private void txBuscarElim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                bnBuscarRec.PerformClick();
        }
        private void txBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                bnBuscar.PerformClick();
        }
        private void txNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bnInsertar.PerformClick();
            }
        }
        private void txNombreAct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bnActualizar.PerformClick();
            }
        }
        private void txBuscarRep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                bnBuscarRep.PerformClick();
        }
        private void txBuscarPap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                bnBuscarPap.PerformClick();
        }
        private void txValorCampo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bnEditarSelecAvan.PerformClick();
            }
        }
        //DataGridView
        private void TablaEliminar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bnReciclarSeleccion.PerformClick();
        }
        private void TablaBuscar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bnVerSeleccion.PerformClick();
        }
        private void TablaActualizar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bnEditarSeleccion.PerformClick();
        }
        //Timer
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            CapturarFecha();
            Rej.Tiempo(pbReloj, toolTip1, Fuente, Fondo);
            pnlLin1.BackColor = Fuente;
            pnlLin2.BackColor = Fuente;
            pnlLin3.BackColor = Fuente;
            pnlLin4.BackColor = Fuente;
        }
        //PictureBox
        private void pbxImagenReg_Resize(object sender, EventArgs e)
        {
            ((PictureBox)sender).Width = ((PictureBox)sender).Height;
            txImagen.Width = (txValorCampo2.Width - (pbxImagenAvan.Width + 6));
            txImagen.Location = new Point(pbxImagenAvan.Width + 13, txImagen.Location.Y);
        }
        private void pbxImagenBuscar_Resize(object sender, EventArgs e)
        {
            ((PictureBox)sender).Height = ((PictureBox)sender).Width;
        }
        private void pbxFoto2_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true); // recupera los datos del archivo que arrastre

                if (((PictureBox)sender).Tag.ToString() == "Foto")
                {
                    ActualizarFoto(Image.FromFile(files[0])); return;
                }
                pbxLlenar(Image.FromFile(files[0]), files[0]);
            }
            catch
            {
                MensajeTool.ImageFormatoNoSoportado(toolTip2, ((PictureBox)sender));
            }
        }
        private void pbxFoto2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        //CheckBox
        private void registrarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            VisibleCheck(((ToolStripMenuItem)sender));
        }
        #endregion

        private void cbPrediseño_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstiloPrediseñado();
        }

        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible)
            {
                GuardarImagen(pbxFoto2.Image, "Foto de " + lblDato3.Text);
            }
            else
            {
                GuardarImagen(pbxImagenReg.Image, "Imagen " + FMR_NAME);
            }
        }
        private void txtEstadoUsu_MouseMove(object sender, MouseEventArgs e)
        {
            txtEstadoUsu.Enabled = true;
            txtEstadoUsu.Focus();
            lbEstadoUsu.Hide();
        }

        private void txtEstadoUsu_MouseLeave(object sender, EventArgs e)
        {
            txtEstadoUsu.Enabled = false;
            lbEstadoUsu.Show();
        }

        private void txtEstadoUsu_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Estado = txtEstadoUsu.Text;
            Settings.Default.Save();
        }
        private void lbColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (Estilo(1))
            {
                ((Label)sender).ForeColor = Color.White;
                ((Label)sender).BackColor = Blue;
            }
            else
            {
                ((Label)sender).ForeColor = Fondo;
                ((Label)sender).BackColor = Fuente;
            }
        }

        private void lbColo_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Fuente;
            ((Label)sender).BackColor = Color.Transparent;
        }
        private void bn_MouseMove(object sender, MouseEventArgs e)
        {
            if (Estilo(1))
            {
                ((Button)sender).BackColor = Color.White;
                ((Button)sender).ForeColor = Blue;
            }
            else
            {
                ((Button)sender).BackColor = Gray;
                ((Button)sender).ForeColor = Color.White;
            }

        }

        private void bn_MouseLeave(object sender, EventArgs e)
        {
            if (Estilo(1))
            {
                ((Button)sender).ForeColor = Color.White;
                ((Button)sender).BackColor = Blue;
            }
            else
            {
                ((Button)sender).BackColor = Color.White;
                ((Button)sender).ForeColor = Color.Black;
            }
        }
    }
    #endregion
}
#endregion
#endregion