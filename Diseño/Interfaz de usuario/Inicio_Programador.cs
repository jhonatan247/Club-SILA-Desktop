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
using System.Runtime.InteropServices;
using System.Drawing.Printing;
#endregion

#region Interfaz de usuario
namespace Diseño.Interfaz_de_usuario
{
    #region Formulario
    public partial class Inicio_Programador : Form
    {
        #region Atributos
        //
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, String pszRootPath,
        RecycleFlags dwFlags);

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern Int32 mciSendString(String lpstrCommand,
        StringBuilder lpstrReturnString,
        Int32 uReturnLength,
        IntPtr hwndCallback);
        //
        GestionarEntidades GestEnt = new GestionarEntidades(1);
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
        Int32 FMR = 0;
        String FMR_NAME = "OBJETOS";

        List<SoundPlayer> Lst { get; set; }
        List<Image> Img { get; set; }
        List<String> Txt  { get; set; }
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
        public Inicio_Programador()
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
            
            if (Cancelar == true)
                Application.ExitThread();
        }
        void TitulosGrafica()
        {
            
        }
        private void GetInstalledPrinters()
        {
            foreach (string printerName in PrinterSettings.InstalledPrinters)
                lstImpresoras.Items.Add(printerName);
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
        void Botones()
        {
            if (!As.Condicionales(1, Fondo) && !As.Condicionales(0, Fuente))
            {
                bnBuscar.BackColor = bnApagar.BackColor;
                bnCapturar.BackColor = bnApagar.BackColor;
                bnFinalizar.BackColor = bnApagar.BackColor;
                bnInsertar.BackColor = bnApagar.BackColor;
                bnPCompletaEntidad.BackColor = bnApagar.BackColor;
                bnSonido.BackColor = bnApagar.BackColor;
                bnVerSeleccion.BackColor = bnApagar.BackColor;

                bnBuscar.ForeColor = Color.White;
                bnCapturar.ForeColor = Color.White;
                bnFinalizar.ForeColor = Color.White;
                bnInsertar.ForeColor = Color.White;
                bnPCompletaEntidad.ForeColor = Color.White;
                bnSonido.ForeColor = Color.White;
                bnVerSeleccion.ForeColor = Color.White;
            }
            else
            {
                bnBuscar.BackColor = Color.White;
                bnCapturar.BackColor = Color.White;
                bnFinalizar.BackColor = Color.White;
                bnInsertar.BackColor = Color.White;
                bnPCompletaEntidad.BackColor = Color.White;
                bnSonido.BackColor = Color.White;
                bnVerSeleccion.BackColor = Color.White;

                bnBuscar.ForeColor = Color.Black;
                bnCapturar.ForeColor = Color.Black;
                bnFinalizar.ForeColor = Color.Black;
                bnInsertar.ForeColor = Color.Black;
                bnPCompletaEntidad.ForeColor = Color.Black;
                bnSonido.ForeColor = Color.Black;
                bnVerSeleccion.ForeColor = Color.Black;
            }
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
                OpenMedia.Filter = "Archivo de Imágen (*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG;)|*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG";
                if (OpenMedia.ShowDialog() == DialogResult.OK)
                {
                    pbxFoto1.Image = Image.FromFile(OpenMedia.FileName);
                    pbxFoto2.Image = Image.FromFile(OpenMedia.FileName);
                    Eprog = new E_Programa(pbxFoto1.Image);
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
                    TablaBuscar.BackgroundColor = Tinte;
                    tabPage1.BackColor = Tinte;
                    Botones();
                    break;
                case 1:
                    toolStripMenuItem1.ForeColor = Tinte;
                    diseñoToolStripMenuItem.ForeColor = Tinte;
                    ayudaToolStripMenuItem.ForeColor = Tinte;
                    if (As.Condicionales(0, Tinte))
                    {
                        panelInferior1.BackColor = Tinte;
                        panelInferior3.BackColor = Tinte;
                    }
                    else
                    {
                        panelInferior1.BackColor = Color.White;
                        panelInferior3.BackColor = Color.White;
                    }
                    if (As.Condicionales(1, Tinte))
                    {
                        TablaBuscar.DefaultCellStyle.ForeColor = Tinte;
                        TablaBuscar.AlternatingRowsDefaultCellStyle.ForeColor = Tinte;
                    }
                    else
                    {
                        TablaBuscar.DefaultCellStyle.ForeColor = Color.Black;
                        TablaBuscar.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                    }
                    CicloColor(Tinte);
                    Botones();
                    break;
                default:
                    break;
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
        void Listar(Int16 busc)
        {
            Boton.Play();
            switch (busc)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    bnVerSeleccion.Show();
                    bnCapturar.Hide();
                    bnPCompletaEntidad.Hide();
                    TablaBuscar.Show();
                    panelBuscar.Hide();
                    TablaBuscar.BringToFront();
                    Buscar(TablaBuscar, txBuscar.Text);
                    break;
                default:
                    break;
            }
        }
        void Cerrasesión()
        {
            
            if (Cancelar == true)
                Application.ExitThread();
        }
        void ComboBx()
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    TabControl.SelectedTab = tabPage1;
                    break;
                case 1:
                    TabControl.SelectedTab = tabPage2;
                    break;
                default:
                    break;
            }
        }
        void SelectItm(Int32 index)
        {
            toolStripComboBox1.SelectedIndex = index;
            toolStripComboBox4.SelectedIndex = index;
            toolStripComboBox6.SelectedIndex = index;
            toolStripComboBox7.SelectedIndex = index;
            txBuscar.Clear();
        }
        void VerTodos(DataGridView Dt)
        {
            Dt.DataSource = CEntidad.TSELECT();
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
                    DatosImg = (Byte[])TablaBuscar.CurrentRow.Cells[4].Value;
                    MemS = new MemoryStream(DatosImg);
                    pbxImagenBuscar.Image = Bitmap.FromStream(MemS);
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
                DatosImg = (Byte[])TablaBuscar[4, Row].Value;
                MemS = new MemoryStream(DatosImg);
                pbxImagenBuscar.Image = Bitmap.FromStream(MemS);
            }
            catch (Exception ex) { Excepcion(ex); }
        }
        void CapturaTabl()
        {
            if (this.Visible == true)
            {
                
                if (TabControl.SelectedTab == tabPage2 && TablaBuscar.Visible == true)
                {
                    Camara.Play();
                    
                }
                else
                    ErrorMensaje(2);
            }
            else
                TrayMensaje(0);
        }
        void EnviarDiseño(Int32 R, Int32 G, Int32 B, Int32 R1, Int32 G1, Int32 B1)
        {
            Eprog = new E_Programa(R, G, B, R1, G1, B1);
            Prog.UPDATE3(Eprog);
        }
        void Graficar()
        {
            
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
            foreach (Label Sender in panelInferior.Controls.OfType<Label>())
            {
                try
                {
                    Sender.ForeColor = Tinte;
                }
                catch { }
            }
            foreach (Label Sender in tabPage1.Controls.OfType<Label>())
            {
                try
                {
                    Sender.ForeColor = Tinte;
                }
                catch { }
            }
            foreach (Label Sender in panelBuscar.Controls.OfType<Label>())
            {
                try
                {
                    Sender.ForeColor = Tinte;
                }
                catch { }
            }
            foreach (Label Sender in panelSuperior3.Controls.OfType<Label>())
            {
                try
                {
                    Sender.ForeColor = Tinte;
                }
                catch { }
            }
        }
        void EntidadCompleta()
        {
            List<Label> lst = new List<Label>();
            foreach (Label Sender in panelBuscar.Controls.OfType<Label>())
            {
                try
                {
                    String tx = @Sender.Text;
                    Label lb = new Label();
                    lb.Text = tx;
                    lb.Anchor = Sender.Anchor;
                    lb.Font = Sender.Font;
                    if (Sender == label18)
                    {
                        lb.Location = new Point(439 / 2 - Sender.Width, Sender.Location.Y);
                    }
                    else
                    {
                        lb.Location = Sender.Location;
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
                    PictureBox lb = new PictureBox();
                    lb.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left))); ;
                    lb.Image = Sender.Image;
                    lb.SizeMode = PictureBoxSizeMode.AutoSize;
                    lb.Location = Sender.Location;
                    lstpbx.Add(lb);
                }
                catch { }
            }
            EntiC = new EntidadCompleta(lst, lstpbx);
            EntiC.ShowDialog();
        }
        void BorderStyle()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                switch (toolStripComboBox9.SelectedIndex)
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
                Settings.Default.Borde = toolStripComboBox9.SelectedIndex;
                Settings.Default.Save();
                return;
            }
            switch (toolStripComboBox9.SelectedIndex)
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
            Settings.Default.Borde = toolStripComboBox9.SelectedIndex;
            Settings.Default.Save();
        }
        void Ptllazo()
        {
            Pantallazo.ShowDialog();
            Sonidos();
            toolStripComboBox9.SelectedIndex = Settings.Default.Borde;
        }
        #endregion

        #region Eventos
        private void FormLoad(object sender, EventArgs e)
        {
            try
            {
                Drow = Prog.TSELECT6().Rows[0];
                lblDato1.Text = Drow[0].ToString();
                lblDato2.Text = Drow[1].ToString();
                lblDato3.Text = Drow[2].ToString();
                lblDato4.Text = Drow[3].ToString();
            }
            catch { }
            try
            {
                if (Drow[4] != null)
                {
                    DatosImg = (Byte[])Drow[4];
                    MemS = new MemoryStream(DatosImg);
                    pbxFoto1.Image = Bitmap.FromStream(MemS);
                    pbxFoto2.Image = Bitmap.FromStream(MemS);
                }
            }
            catch { }
            lbNombrePC.Text = Environment.MachineName;
            Tiempo.Enabled = true;
            SelectItm(0);
            Diseñar();
            toolStripComboBox9.SelectedIndex = Settings.Default.Borde;
            Inicio.Play();
        }
        private void Letras(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
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
            if (this.Visible)
            {
                if (TabControl.SelectedTab == tabPage2 && bnCapturar.Visible)
                {
                    
                }
                else
                    ErrorMensaje(3);
            }
            else
                TrayMensaje(0);
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
        private void txBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                bnBuscar.PerformClick();
        }
        private void TablaBuscar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bnVerSeleccion.PerformClick();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Aceraca.ShowDialog();
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
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            CapturarFecha();
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
        #endregion

        private void bnApagar_Click(object sender, EventArgs e)
        {
            if (Mensajebx.Apagar(0) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("ShutDown", "/s");
            }
        }

        private void bnSuspender_Click(object sender, EventArgs e)
        {
            if (Mensajebx.Apagar(1) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("ShutDown", "/l");
            }
        }

        private void bnReiniciar_Click(object sender, EventArgs e)
        {
            if (Mensajebx.Apagar(2) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("ShutDown", "/r");
            }
        }

        private void bnPaginaInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void bnBuscarInternet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(textBox1.Text.Trim());
        }

        private void bnRepararInternet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rasdial", "/disconnect");
        }

        private void bnLiberarMemoria_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Externos/RAM.vbs");
        }

        private void bnAbrirCD_Click(object sender, EventArgs e)
        {
            mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
            bnAbrirCD.Enabled = false;
            bnCerrarCD.Enabled = true;
        }

        private void bnCerrarCD_Click(object sender, EventArgs e)
        {
            int ret = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
            bnAbrirCD.Enabled = true;
            bnCerrarCD.Enabled = false;
        }

        private void bnVaciarPapelera_Click(object sender, EventArgs e)
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, 0);
        }

        private void bnListarImpresoras_Click(object sender, EventArgs e)
        {
            GetInstalledPrinters();
        }

        private void bnGestionarEntidades_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            if (GestEnt.ShowDialog() != DialogResult.OK)
            {
                Cancelar = false;
            }
        }
    }
    #endregion
}
#endregion
#endregion