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
#endregion

#region Interfaz de usuario
namespace Diseño.Interfaz_de_usuario
{
    #region Formulario
    public partial class Inicio1 : Form
    {
        #region Atributos
        Reloj Rel = new Reloj();
        CRUD_Objeto CEntidad = new CRUD_Objeto();
        MensajeBx Mensajebx = new MensajeBx();
        MensajeToolTip MensajeTool = new MensajeToolTip();
        AccionesSistema As = new AccionesSistema();
        MensajeTrayBar MensajeTray = new MensajeTrayBar();
        Captura Capt = new Captura();
        AcercaDe Aceraca = new AcercaDe();
        Programa Prog = new Programa();
        Byte[] DatosImg = new Byte[0];

        Boolean Cancelar = false, Inicial = false;

        GestionarEntidades GestEnt = new GestionarEntidades(1);
        Int32 FMR = 0;
        String FMR_NAME = "OBJETOS";

        List<SoundPlayer> Lst { get; set; }
        List<Image> Img { get; set; }
        List<String> Txt { get; set; }
        MemoryStream MemS { get; set; }
        Color Fuente { get; set; }
        Color Fondo { get; set; }
        Int64 ID { get; set; }
        Int64 Valor { get; set; }
        E_Objeto Entidad { get; set; }
        E_Programa Eprog { get; set; }
        DataRow Drow { get; set; }
        DataTable DataSelet { get; set; }
        DataTable DataSource { get; set; }

        ReporteCompleto RPT { get; set; }
        VisorImagenes Pantallazo { get; set; }
        GraficaCompleta GrafiC { get; set; }
        EntidadCompleta EntiC { get; set; }
        TablaCompletaSeleccionar TablaC { get; set; }
        ConfirmarContraseña ConfContr { get; set; }
        OpenFileDialog OpenMedia { get; set; }

        SoundPlayer Boton { get; set; }
        SoundPlayer Camara { get; set; }
        SoundPlayer Inicio { get; set; }
        SoundPlayer Minimizado { get; set; }
        SoundPlayer Datos { get; set; }
        #endregion

        #region Constructor
        public Inicio1()
        {
            InitializeComponent();
            Lst = As.Sonidos();
            Img = As.Imagenes();
            Txt = As.Textos();
            Sonidos();
            TitulosGrafica();
        }
        #endregion

        #region Métodos
        void VolverAntForm()
        {
            Cancelar = true;
            Boton.Play(); 
            As.RegresarFormAnt();
        }
        void TitulosGrafica()
        {
            
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
            ColorDiseño(0, Fondo);
            Fuente = Clr[1];
            ColorDiseño(1, Fuente);
        }
        void CicloBoton(Color Tinte, Boolean Back)
        {
            if (!Back)
            {
                foreach (Button Sender in Controls.OfType<Button>())
                {
                    try
                    {
                        Sender.ForeColor = Tinte;
                    }
                    catch { }
                }
                foreach (Panel Sender in Controls.OfType<Panel>())
                {
                    foreach (Button Bn in Sender.Controls.OfType<Button>())
                    {
                        try
                        {
                            Bn.ForeColor = Tinte;
                        }
                        catch { }
                    }
                    foreach (Panel Pnl in Sender.Controls.OfType<Panel>())
                    {
                        foreach (Button Bn in Pnl.Controls.OfType<Button>())
                        {
                            try
                            {
                                Bn.ForeColor = Tinte;
                            }
                            catch { }
                        }
                    }
                }
                foreach (TabPage Sender in TabControl.Controls.OfType<TabPage>())
                {
                    foreach (Button Bn in Sender.Controls.OfType<Button>())
                    {
                        try
                        {
                            Bn.BackColor = Tinte;
                        }
                        catch { }
                    }
                    foreach (Panel pnl in Sender.Controls.OfType<Panel>())
                    {
                        foreach (Button Bn in pnl.Controls.OfType<Button>())
                        {
                            try
                            {
                                Bn.ForeColor = Tinte;
                            }
                            catch { }
                        }
                        foreach (Panel Pnll in pnl.Controls.OfType<Panel>())
                        {
                            foreach (Button Bn in Pnll.Controls.OfType<Button>())
                            {
                                try
                                {
                                    Bn.ForeColor = Tinte;
                                }
                                catch { }
                            }

                        }
                    }
                }
            }

            else
            {
                foreach (Button Sender in Controls.OfType<Button>())
                {
                    try
                    {
                        Sender.BackColor = Tinte;
                    }
                    catch { }
                }
                foreach (Panel Sender in Controls.OfType<Panel>())
                {
                    foreach (Button Bn in Sender.Controls.OfType<Button>())
                    {
                        try
                        {
                            Bn.BackColor = Tinte;
                        }
                        catch { }
                    }
                    foreach (Panel Pnl in Sender.Controls.OfType<Panel>())
                    {
                        foreach (Button Bn in Pnl.Controls.OfType<Button>())
                        {
                            try
                            {
                                Bn.BackColor = Tinte;
                            }
                            catch { }
                        }
                    }
                }
                foreach (TabPage Sender in TabControl.Controls.OfType<TabPage>())
                {
                    foreach (Button Bn in Sender.Controls.OfType<Button>())
                    {
                        try
                        {
                            Bn.BackColor = Tinte;
                        }
                        catch { }
                    }
                    foreach (Panel pnl in Sender.Controls.OfType<Panel>())
                    {
                        foreach (Button Bn in pnl.Controls.OfType<Button>())
                        {
                            try
                            {
                                Bn.BackColor = Tinte;
                            }
                            catch { }
                        }
                        foreach (Panel Pnll in pnl.Controls.OfType<Panel>())
                        {
                            foreach (Button Bn in Pnll.Controls.OfType<Button>())
                            {
                                try
                                {
                                    Bn.BackColor = Tinte;
                                }
                                catch { }
                            }
                        }
                    }
                }
            }
        }
        void Botones()
        {
            if (!As.Condicionales(1, Fondo) && !As.Condicionales(0, Fuente))
            {
                CicloBoton(bnInicio.BackColor, true);

                CicloBoton(Color.White, false);
            }
            else
            {
                CicloBoton(Color.White, true);

                CicloBoton(Color.Black, false);
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
                    pbxFoto2.Image = Image.FromFile(OpenMedia.FileName);
                    Eprog = new E_Programa(pbxFoto2.Image);
                    Prog.UPDATE7(Eprog);
                    Mensajebx.FotoPerfil();
                }
            }
            catch (Exception ex) { Excepcion(ex); }
        }
        void ColorDiseño(Int16 Index, Color Tinte)
        {
            switch (Index)
            {
                case 0:
                    this.BackColor = Tinte;
                    
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
                    
                    if (As.Condicionales(0, Tinte))
                    {
                        panelInferior1.BackColor = Tinte;
                        
                    }
                    else
                    {
                        panelInferior1.BackColor = Color.White;
                        
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
                        catch{}
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
            
        }
        void Listar(Int16 busc)
        {
            Boton.Play();
            switch (busc)
            {
                case 0:
                    TablaActualizar.Show();
                    TablaActualizar.BringToFront();
                    break;
                case 1:
                    break;
                case 2:
                    bnVerSeleccion.Show();
                    bnCapturar.Hide();
                    bnPCompletaEntidad.Hide();
                    TablaBuscar.Show();
                    TablaBuscar.BringToFront();
                    break;
                case 3:
                    
                    break;
                default:
                    break;
            }
        }
        void Cerrasesión()
        {
            Cancelar = true;
            Boton.Play(); Cancelar = As.CerrarSesion();
        }
        void GraficaComp(DataTable Source)
        {
            
            GrafiC.ShowDialog();
            cbForma.SelectedIndex = Settings.Default.Forma;
            cbPaleta.SelectedIndex = Settings.Default.Paleta;
        }
        void ComboBx()
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    TabControl.SelectedTab = pgInicio;
                    break;
                case 1:
                    TabControl.SelectedTab = pgNoticias;
                    break;
                case 2:
                    TabControl.SelectedTab = pgEventos;
                    break;
                case 3:
                    TabControl.SelectedTab = pgAsistencias;
                    break;
                case 4:
                    TabControl.SelectedTab = pgCumpleaños;
                    break;
                case 5:
                    TabControl.SelectedTab = pgCompras;
                    break;
                case 6:
                    TabControl.SelectedTab = pgCuenta;
                    break;
                default:
                    break;
            }
        }
        void SelectItm(Int32 index)
        {
            toolStripComboBox1.SelectedIndex = index;
            toolStripComboBox2.SelectedIndex = index;
            toolStripComboBox3.SelectedIndex = index;
            toolStripComboBox4.SelectedIndex = index;
            toolStripComboBox5.SelectedIndex = index;
            toolStripComboBox6.SelectedIndex = index;
            toolStripComboBox7.SelectedIndex = index;
            toolStripComboBox8.SelectedIndex = index;
            toolStripComboBox9.SelectedIndex = index;
        }
        void VerTodos(DataGridView Dt)
        {
            Dt.DataSource = CEntidad.TSELECT();
        }
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
        void Insertar()
        {
            
        }
        void Buscar(DataGridView DGV, String Texto)
        {
            try { DGV.DataSource = CEntidad.LIKETT(Texto); }
            catch (Exception ex) { Excepcion(ex); return; }
        }
        void pbxLlenar(Image IM, String Source)
        {
            
        }
        void EditarSelecion()
        {
            

        }
        
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
                
        }
        void VerSelecCelda(Int32 Row)
        {
            try
            {
                bnVerSeleccion.Hide();
                bnCapturar.Show();
                bnPCompletaEntidad.Show();
                TablaBuscar.Hide();
                
                DatosImg = (Byte[])TablaBuscar[5, Row].Value;
                MemS = new MemoryStream(DatosImg);
                pbxLlenar(Bitmap.FromStream(MemS), "Entidad");
            }
            catch (Exception ex) { Excepcion(ex); }
        }
        void ReportarSelec()
        {
            
        }
        void EliminarSelecion()
        {
            
        }
        void GraficarSeleccionados()
        {
            
        }
        void EliminarSeleccionados()
        {
            
        }
        void EliminarTodos()
        {
            
        }
        void ActualizarTodos()
        {
            
        }
        void ActualizarSeleccionados()
        {
            
        }
        void Actualizar()
        {
            
        }
        void CapturaTabl()
        {
            
        }
        void EnviarDiseño(Int32 R, Int32 G, Int32 B, Int32 R1, Int32 G1, Int32 B1)
        {
            Eprog = new E_Programa(R, G, B, R1, G1, B1);
            Prog.UPDATE3(Eprog);
        }
        void Graficar()
        {
            TitulosGrafica();
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
        void EntidadCompleta()
        {
            
            List<PictureBox> lstpbx = new List<PictureBox>();
            
            EntiC.ShowDialog();
        }
        void ReporteCompleto()
        {
            Microsoft.Reporting.WinForms.ReportViewer rpt = new Microsoft.Reporting.WinForms.ReportViewer();
            rpt = ing_programador;
            RPT = new ReporteCompleto(rpt);
            RPT.ShowDialog();
            pgCompras.Controls.Add(ing_programador);
            ing_programador.BringToFront();
        }
        void BorderStyle()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                switch (cbEstiloFRM.SelectedIndex)
                {
                    case 0:
                        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        break;
                    case 1: FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        break;
                    case 2: FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                        break;
                    case 3: FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        break;
                    case 4: FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                        break;
                    case 5: FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                        break;
                    case 6: FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                        break;
                    default:
                        break;
                }
                WindowState = FormWindowState.Maximized;
                Settings.Default.Borde = cbEstiloFRM.SelectedIndex;
                Settings.Default.Save();
                return;
            }
            switch (cbEstiloFRM.SelectedIndex)
            {
                case 0:
                    FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    break;
                case 1: FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    break;
                case 2: FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                    break;
                case 3: FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                    break;
                case 4: FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    break;
                case 5: FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                    break;
                case 6: FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                    break;
                default:
                    break;
            }
            Settings.Default.Borde = cbEstiloFRM.SelectedIndex;
            Settings.Default.Save();
        }
        void Ptllazo()
        {
            Pantallazo.ShowDialog();
            Sonidos();
            cbEstiloFRM.SelectedIndex = Settings.Default.Borde;
        }
        void CampoAvanzados()
        {
            
        }
        void CentrarObjeto(Object Sender, Object Contenedor, Int32 Index)
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
        #endregion

        #region Eventos
        private void FormLoad(object sender, EventArgs e)
        {
            this.ing_programador.LocalReport.EnableHyperlinks = true;
            this.pROGSELECT_R_PROGRAMADORTableAdapter.Fill(this.dTS_PROGRAMADOR.PROGSELECT_R_PROGRAMADOR);
            ing_programador.RefreshReport();
            try
            {
                Drow = Prog.TSELECT6().Rows[0];
                lblDato1.Text = Drow[0].ToString();
                lblDato2.Text = Drow[1].ToString();
                lblDato3.Text = Drow[2].ToString();
                lblDato4.Text = Drow[3].ToString();
                CentrarObjeto(lblDato4, panelMenuSup, 0);
                CentrarObjeto(lblDato3, panelMenuSup, 0);
            }
            catch { }
            try
            {
                if (Drow[16] != null)
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
            Tiempo.Enabled = true;
            SelectItm(0);
            Diseñar();
            cbForma.SelectedIndex = Settings.Default.Forma;
            cbPaleta.SelectedIndex = Settings.Default.Paleta;
            cbEstiloFRM.SelectedIndex = Settings.Default.Borde;
            Inicio.Play();
        }
        private void Letras(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }
        private void Numeros(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }
        private void bnInsertar_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Insertar();
        }
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
        private void bnBuscarAct_Click(object sender, EventArgs e)
        {
            Listar(0);
        }
        private void bnEditarSelecion_Click(object sender, EventArgs e)
        {
            Boton.Play();
            TabControl.SelectedTab = pgNoticias;
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
            EliminarSelecion();
        }
        private void bnBuscar_Click(object sender, EventArgs e)
        {
            Listar(2);
        }
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            Listar(0);
            SelectItm(1);
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
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItm(toolStripComboBox1.SelectedIndex);
            ComboBx();
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
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectItm(((ToolStripComboBox)sender).SelectedIndex);
        }
        private void VerSeleccion_Click(object sender, EventArgs e)
        {
            Boton.Play();
            VerSelec();
        }
        private void objetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            TablaActualizar.Show();
            TabControl.SelectedTab = pgNoticias;
            TablaActualizar.BringToFront();
            VerTodos(TablaActualizar);
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = pgEventos;
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            panelInferior3.Show();
            TablaBuscar.Show();
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
        private void txBuscarAct_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void txBuscarElim_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        private void txBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void TablaEliminar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void TablaBuscar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bnVerSeleccion.PerformClick();
        }
        private void TablaActualizar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            
        }
        private void tabPage5_Enter(object sender, EventArgs e)
        {
            Boton.Play();
            Graficar();
            SelectItm(4);
        }
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            CapturarFecha();
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
            
        }
        private void maximizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GraficaComp(CEntidad.TSELECT_GRAFICAR());
        }
        private void toolStripComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cbPaleta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void pantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntidadCompleta();
        }
        private void toolStripComboBox9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Inicial)
            {
                Boton.Play();
            }
            BorderStyle();
        }
        private void tabPage6_Enter(object sender, EventArgs e)
        {
            Boton.Play();
            SelectItm(6);
        }
        private void bnSeleccionarAvan1_Click(object sender, EventArgs e)
        {
            
        }
        private void bnGraficarSelecAvan_Click(object sender, EventArgs e)
        {
            GraficarSeleccionados();
        }
        private void bnEliminarSelecAvan_Click(object sender, EventArgs e)
        {
            EliminarSeleccionados();
        }
        private void bnEliminarTodosAvan_Click(object sender, EventArgs e)
        {
            EliminarTodos();
        }
        private void bnEditarSelecAvan_Click(object sender, EventArgs e)
        {
            ActualizarSeleccionados();
        }
        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CampoAvanzados();
        }
        private void txValorCampo2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void bnEditarTodosAvan_Click(object sender, EventArgs e)
        {
            ActualizarTodos();
        }
        private void TablaAvanz_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void pbxImagenReg_Click(object sender, EventArgs e)
        {
            Boton.Play();
            AñadirImg();
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
        private void FRM_OBJETO_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible)
            {
                panelMenu.Hide();
                TabControl.Enabled = true;
                MenuSup.Enabled = true;
            }
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
            
        }
        private void pgReportes_Enter(object sender, EventArgs e)
        {
            Listar(3);
            SelectItm(5);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Minimizado.Play();
            ReporteCompleto();
            Minimizado.Play();
        }
        private void pbxImagenBuscar_Resize(object sender, EventArgs e)
        {
            ((PictureBox)sender).Height = ((PictureBox)sender).Width;
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
            cbEstiloFRM.SelectedIndex = 4;
            cbForma.SelectedIndex = 10;
            cbPaleta.SelectedIndex = 2;
        }
        #endregion

        private void bnGestionarEntidades_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            if (GestEnt.ShowDialog() != DialogResult.OK)
            {
                Cancelar = false;
            }
        }

        private void bnRefrescar_Click(object sender, EventArgs e)
        {
            Boton.Play();
            this.pROGSELECT_R_PROGRAMADORTableAdapter.Fill(this.dTS_PROGRAMADOR.PROGSELECT_R_PROGRAMADOR);
            ing_programador.RefreshReport();
        }
    }
    #endregion
}
#endregion
#endregion