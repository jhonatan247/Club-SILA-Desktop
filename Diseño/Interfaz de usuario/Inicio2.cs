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

#region Interfaz de usuaro
namespace Diseño.Interfaz_de_usuario
{
    #region Formulario
    public partial class Inicio2 : Form
    {
        #region Atributos
        RelojAnalogo Rej = new RelojAnalogo();
        Color Blue = Color.FromArgb(3, 169, 244);
        Color Gray = Color.FromArgb(68, 68, 68);
        Reloj Rel = new Reloj();
        CRUD_Objeto CEntidad = new CRUD_Objeto();
        MensajeBx Mensajebx = new MensajeBx();
        GestionarEntidades GestEnt = new GestionarEntidades(1);
        MensajeToolTip MensajeTool = new MensajeToolTip();
        AccionesSistema As = new AccionesSistema();
        MensajeTrayBar MensajeTray = new MensajeTrayBar();
        TimmerAction Gif = new TimmerAction();
        Captura Capt = new Captura();
        AcercaDe Aceraca = new AcercaDe();
        Programa Prog = new Programa();
        Byte[] DatosImg = new Byte[0];

        Boolean Cancelar = false, Inicial = false;
        Int32 FMR = 0;
        String FMR_NAME = "OBJETOS";
        #endregion

        #region Propiedades
        List<SoundPlayer> Lst { get; set; }
        List<Image> Img { get; set; }
        List<String> Txt { get; set; }
        MemoryStream MemS { get; set; }
        Color Fuente { get; set; }
        Color Fondo { get; set; }
        Int64 ID { get; set; }
        Int64 Valor { get; set; }
        Int32 xx { get; set; }
        Int32 FF { get; set; }
        E_Objeto Entidad { get; set; }
        E_Programa Eprog { get; set; }
        DataRow Drow { get; set; }
        DataTable DataSelet { get; set; }
        DataTable DataSource { get; set; }
        Icono FondoPantalla { get; set; }

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
        public Inicio2()
        {
            InitializeComponent();
            Lst = As.Sonidos();
            Img = As.Imagenes();
            Txt = As.Textos();
            Sonidos();
            TitulosGrafica();
            Diseñar();
            pbxFoto2.AllowDrop =
                pbFoto.AllowDrop = true;
        }
        #endregion

        #region Métodos
        //Formulario
        void TitulosGrafica()
        {
        }
        //Diseño
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
        void Div(bool Check, Panel sender)
        {
            if (Check)
            {
                foreach (Panel pnl in sender.Controls.OfType<Panel>())
                {
                    pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }
            else
            {
                foreach (Panel pnl in sender.Controls.OfType<Panel>())
                {
                    pnl.BorderStyle = System.Windows.Forms.BorderStyle.None;
                }
            }
        }
        void CambiarDivisionesMenu(bool Check)
        {
            if (Check)
            {
                foreach (Panel P in pnlMenuBarra.Controls.OfType<Panel>())
                {
                    if (P.Tag.ToString() != "space")
                        P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    foreach (Panel PP in P.Controls.OfType<Panel>())
                    {
                        if (PP.Tag.ToString() != "space")
                            PP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        foreach (Panel PPP in PP.Controls.OfType<Panel>())
                        {
                            if (PPP.Tag.ToString() != "space")
                                PPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            foreach (Panel PPPP in PPP.Controls.OfType<Panel>())
                            {
                                if (PPPP.Tag.ToString() != "space")
                                    PPPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                foreach (Panel PPPPP in PPPP.Controls.OfType<Panel>())
                                {
                                    if (PPPPP.Tag.ToString() != "space")
                                        PPPPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                }
                            }
                        }
                    }
                }
                pnlMenuBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                foreach (Panel P in pnlMenuBarra.Controls.OfType<Panel>())
                {
                    if (P.Tag.ToString() != "space")
                        P.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    foreach (Panel PP in P.Controls.OfType<Panel>())
                    {
                        if (PP.Tag.ToString() != "space")
                            PP.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        foreach (Panel PPP in PP.Controls.OfType<Panel>())
                        {
                            if (PPP.Tag.ToString() != "space")
                                PPP.BorderStyle = System.Windows.Forms.BorderStyle.None;
                            foreach (Panel PPPP in PPP.Controls.OfType<Panel>())
                            {
                                if (PPPP.Tag.ToString() != "space")
                                    PPPP.BorderStyle = System.Windows.Forms.BorderStyle.None;
                                foreach (Panel PPPPP in PPPP.Controls.OfType<Panel>())
                                {
                                    if (PPPPP.Tag.ToString() != "space")
                                        PPPPP.BorderStyle = System.Windows.Forms.BorderStyle.None;
                                }
                            }
                        }
                    }
                }
                pnlMenuBarra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
        private void GuardarImagen(Image IMG, string Nombre)
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
        void Deseleccionar(bool Check)
        {
            foreach (CheckBox CH in pnlMenuBarra.Controls.OfType<CheckBox>())
            {
                CH.Checked = Check;
            }
            foreach (Panel P in pnlMenuBarra.Controls.OfType<Panel>())
            {
                foreach (CheckBox CH in P.Controls.OfType<CheckBox>())
                {
                    CH.Checked = Check;
                }
                foreach (Panel PP in P.Controls.OfType<Panel>())
                {
                    foreach (CheckBox CH in PP.Controls.OfType<CheckBox>())
                    {
                        CH.Checked = Check;
                    }
                    foreach (Panel PPP in PP.Controls.OfType<Panel>())
                    {
                        foreach (CheckBox CH in PPP.Controls.OfType<CheckBox>())
                        {
                            CH.Checked = Check;
                        }
                        foreach (Panel PPPP in PPP.Controls.OfType<Panel>())
                        {
                            foreach (CheckBox CH in PPPP.Controls.OfType<CheckBox>())
                            {
                                CH.Checked = Check;
                            }
                            foreach (Panel PPPPP in PPPP.Controls.OfType<Panel>())
                            {
                                foreach (CheckBox CH in PPPPP.Controls.OfType<CheckBox>())
                                {
                                    CH.Checked = Check;
                                }
                            }
                        }
                    }
                }
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
        void VisibleCheck(bool Check, int Index)
        {
            if (Check)
            {
                switch (Index)
                {
                    case 0:
                        foreach (ToolStripMenuItem Tool in páginasToolStripMenuItem.DropDown.Items)
                        {
                            Tool.Visible = true;
                            Settings.Default.VerPaginas = true;
                            Settings.Default.Save();
                        }
                        break;
                    case 1:
                        TabControl.Controls.Add(pgInicio);
                        break;
                    case 2:
                        TabControl.Controls.Add(pgNoticias);
                        break;
                    case 3:
                        TabControl.Controls.Add(pgEventos);
                        break;
                    case 4:
                        TabControl.Controls.Add(pgAsistencias);
                        break;
                    case 5:
                        TabControl.Controls.Add(pgCompras);
                        break;
                    case 6:
                        TabControl.Controls.Add(pgCumpleaños);
                        break;
                    case 7:
                        TabControl.Controls.Add(pgDenuncias);
                        break;
                    case 8:
                        TabControl.Controls.Add(pgCuenta);
                        break;
                    case 9:
                        panelInferior.Show();
                        panelMen.Height -= 45;
                        Settings.Default.VerPanelInferior = true;
                        Settings.Default.Save();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (Index)
                {
                    case 0:
                        Todaspag(false);
                        Settings.Default.VerPaginas = false;
                        Settings.Default.Save();
                        break;
                    case 1:
                        TabControl.Controls.Remove(pgInicio);
                        break;
                    case 2:
                        TabControl.Controls.Remove(pgNoticias);
                        break;
                    case 3:
                        TabControl.Controls.Remove(pgEventos);
                        break;
                    case 4:
                        TabControl.Controls.Remove(pgAsistencias);
                        break;
                    case 5:
                        TabControl.Controls.Remove(pgCompras);
                        break;
                    case 6:
                        TabControl.Controls.Remove(pgCumpleaños);
                        break;
                    case 7:
                        TabControl.Controls.Remove(pgDenuncias);
                        break;
                    case 8:
                        TabControl.Controls.Remove(pgCuenta);
                        break;
                    case 9:
                        panelInferior.Hide();
                        panelMen.Height += 45;
                        Settings.Default.VerPanelInferior = false;
                        Settings.Default.Save();
                        break;
                    default:
                        break;
                }
            }
            Boton.Play();
        }
        void Todaspag(bool value)
        {
            foreach (ToolStripMenuItem Tool in páginasToolStripMenuItem.DropDown.Items)
            {
                Tool.Checked = value;
                Tool.Visible = value;
            }
            páginasToolStripMenuItem.Checked = value;
            verTodasToolStripMenuItem.Checked = false;
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
            FF = As.CondicionalesDobles(0, Fuente, Fondo);
            if (FF != 100)
            {
                cbPrediseño.SelectedIndex = FF;
            }
            ColorDiseño(0, Fondo);
            ColorDiseño(1, Fuente);
        }
        void CicloBoton(Color Tinte, bool Back)
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
                        foreach (Panel Pnll in Pnl.Controls.OfType<Panel>())
                        {
                            foreach (Button Bn in Pnll.Controls.OfType<Button>())
                            {
                                Bn.ForeColor = Tinte;
                            }
                            foreach (Panel Pnlll in Pnll.Controls.OfType<Panel>())
                            {
                                foreach (Button Bn in Pnlll.Controls.OfType<Button>())
                                {
                                    Bn.ForeColor = Tinte;
                                }
                            }
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
                            foreach (Panel Pnlll in Pnll.Controls.OfType<Panel>())
                            {
                                foreach (Button Bn in Pnlll.Controls.OfType<Button>())
                                {
                                    try
                                    {
                                        Bn.ForeColor = Tinte;
                                    }
                                    catch { }
                                }
                                foreach (Panel Pnllll in Pnlll.Controls.OfType<Panel>())
                                {
                                    foreach (Button Bn in Pnllll.Controls.OfType<Button>())
                                    {
                                        try
                                        {
                                            Bn.ForeColor = Tinte;
                                        }
                                        catch { }
                                    }
                                    foreach (Panel Pnlllll in Pnllll.Controls.OfType<Panel>())
                                    {
                                        foreach (Button Bn in Pnlllll.Controls.OfType<Button>())
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
                        foreach (Panel Pnll in Pnl.Controls.OfType<Panel>())
                        {
                            foreach (Button Bn in Pnll.Controls.OfType<Button>())
                            {
                                Bn.BackColor = Tinte;
                            }
                            foreach (Panel Pnlll in Pnll.Controls.OfType<Panel>())
                            {
                                foreach (Button Bn in Pnlll.Controls.OfType<Button>())
                                {
                                    Bn.BackColor = Tinte;
                                }
                            }
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
                            foreach (Panel Pnlll in Pnll.Controls.OfType<Panel>())
                            {
                                foreach (Button Bn in Pnlll.Controls.OfType<Button>())
                                {
                                    try
                                    {
                                        Bn.BackColor = Tinte;
                                    }
                                    catch { }
                                }
                                foreach (Panel Pnllll in Pnlll.Controls.OfType<Panel>())
                                {
                                    foreach (Button Bn in Pnllll.Controls.OfType<Button>())
                                    {
                                        try
                                        {
                                            Bn.BackColor = Tinte;
                                        }
                                        catch { }
                                    }
                                    foreach (Panel Pnlllll in Pnllll.Controls.OfType<Panel>())
                                    {
                                        foreach (Button Bn in Pnlllll.Controls.OfType<Button>())
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
        void CicloColor(Color Tinte)
        {
            foreach (Label Sender in Controls.OfType<Label>())
            {
                Sender.ForeColor = Tinte;
            }
            foreach (CheckBox Sender in Controls.OfType<CheckBox>())
            {
                Sender.ForeColor = Tinte;
            }
            foreach (Panel Sender in Controls.OfType<Panel>())
            {
                foreach (Label lbl in Sender.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Tinte;
                }
                foreach (CheckBox chk in Sender.Controls.OfType<CheckBox>())
                {
                    chk.ForeColor = Tinte;
                }
                foreach (Panel pnl in Sender.Controls.OfType<Panel>())
                {
                    foreach (Label lbl in pnl.Controls.OfType<Label>())
                    {
                        lbl.ForeColor = Tinte;
                    }
                    foreach (CheckBox chk in pnl.Controls.OfType<CheckBox>())
                    {
                        chk.ForeColor = Tinte;
                    }
                    foreach (Panel pnll in pnl.Controls.OfType<Panel>())
                    {
                        foreach (Label lbl in pnll.Controls.OfType<Label>())
                        {
                            lbl.ForeColor = Tinte;
                        }
                        foreach (CheckBox chk in pnll.Controls.OfType<CheckBox>())
                        {
                            chk.ForeColor = Tinte;
                        }
                        foreach (Panel pnlll in pnll.Controls.OfType<Panel>())
                        {
                            foreach (Label lbl in pnlll.Controls.OfType<Label>())
                            {
                                lbl.ForeColor = Tinte;
                            }
                            foreach (CheckBox chk in pnlll.Controls.OfType<CheckBox>())
                            {
                                chk.ForeColor = Tinte;
                            }
                        }
                    }
                }
            }
            foreach (TabPage Sender in TabControl.Controls.OfType<TabPage>())
            {
                foreach (Label lbl in Sender.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Tinte;
                }
                foreach (CheckBox chk in Sender.Controls.OfType<CheckBox>())
                {
                    chk.ForeColor = Tinte;
                }
                foreach (Panel pnl in Sender.Controls.OfType<Panel>())
                {
                    foreach (Label lbl in pnl.Controls.OfType<Label>())
                    {
                        lbl.ForeColor = Tinte;
                    }
                    foreach (CheckBox chk in pnl.Controls.OfType<CheckBox>())
                    {
                        chk.ForeColor = Tinte;
                    }
                    foreach (Panel pnll in pnl.Controls.OfType<Panel>())
                    {
                        foreach (Label lbl in pnll.Controls.OfType<Label>())
                        {
                            lbl.ForeColor = Tinte;
                        }
                        foreach (CheckBox chk in pnll.Controls.OfType<CheckBox>())
                        {
                            chk.ForeColor = Tinte;
                        }
                        foreach (Panel pnlll in pnll.Controls.OfType<Panel>())
                        {
                            foreach (Label lbl in pnlll.Controls.OfType<Label>())
                            {
                                lbl.ForeColor = Tinte;
                            }
                            foreach (CheckBox chk in pnlll.Controls.OfType<CheckBox>())
                            {
                                chk.ForeColor = Tinte;
                            }
                            foreach (Panel pnllll in pnlll.Controls.OfType<Panel>())
                            {
                                foreach (Label lbl in pnllll.Controls.OfType<Label>())
                                {
                                    lbl.ForeColor = Tinte;
                                }
                                foreach (CheckBox chk in pnllll.Controls.OfType<CheckBox>())
                                {
                                    chk.ForeColor = Tinte;
                                }
                                foreach (Panel pnlllll in pnllll.Controls.OfType<Panel>())
                                {
                                    foreach (Label lbl in pnlllll.Controls.OfType<Label>())
                                    {
                                        lbl.ForeColor = Tinte;
                                    }
                                    foreach (CheckBox chk in pnlllll.Controls.OfType<CheckBox>())
                                    {
                                        chk.ForeColor = Tinte;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        void ColorDiseño(int Index, Color Tinte)
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
                    foreach (object Sender in MenuSup.Items)
                    {
                        try
                        {
                            ((ToolStripMenuItem)Sender).ForeColor = Tinte;
                        }
                        catch { }
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
        void CicloTabla(Color Tinte, bool Back)
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
        void EnviarDiseño(int R, int G, int B, int R1, int G1, int B1)
        {
            FF = As.CondicionalesDobles(0, Fuente, Fondo);
            if (FF < 100 && cbPrediseño.SelectedIndex != FF)
            {
                cbPrediseño.SelectedIndex = FF; return;
            }
            Eprog = new E_Programa(R, G, B, R1, G1, B1);
            Prog.UPDATE3(Eprog);
        }
        void Switch(int Index)
        {
            switch(Index)
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
        //Imagen
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
            pbxFoto2.Image = pbFoto.Image = Img;

            Eprog = new E_Programa(pbxFoto2.Image);
            Prog.UPDATE7(Eprog);
            Mensajebx.FotoPerfil();
        }
        void pbxLlenar(Image IM, String Source)
        {

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
        void Cerrasesión()
        {
            Cancelar = true;
            Boton.Play(); Cancelar = As.CerrarSesion();
        }
        void GraficaComp(DataTable Source)
        {

        }
        void GraficarTodos()
        {
            GraficaComp(CEntidad.TSELECT());
        }
        void GraficarTodosReciclaje()
        {
            GraficaComp(CEntidad.TRSELECT());
        }
        void ComboBx()
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    registrarToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgInicio;
                    break;
                case 1:
                    actualizarToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgNoticias;
                    break;
                case 2:
                    reciclajeToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgEventos;
                    break;
                case 3:
                    buscarToolStripMenuItem1.Checked = true;
                    TabControl.SelectedTab = pgAsistencias;
                    break;
                case 4:
                    graficarToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgCompras;
                    break;
                case 5:
                    reportarToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgCumpleaños;
                    break;
                case 6:
                    avanzadosToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgDenuncias;
                    break;
                case 7:
                    reciclajeToolStripMenuItem.Checked = true;
                    TabControl.SelectedTab = pgCuenta;
                    break;
                default:
                    break;
            }
        }
        void SelectItm(int index)
        {
            toolStripComboBox1.SelectedIndex = toolStripComboBox2.SelectedIndex = toolStripComboBox3.SelectedIndex =
            toolStripComboBox4.SelectedIndex = toolStripComboBox5.SelectedIndex = toolStripComboBox6.SelectedIndex =
            toolStripComboBox7.SelectedIndex = toolStripComboBox8.SelectedIndex = toolStripComboBox9.SelectedIndex =
            toolStripComboBox10.SelectedIndex = toolStripComboBox13.SelectedIndex = index;
        }
        //Mensajes
        void TxCampoVacio(object O)
        {
            MensajeTool.ValorInvalidado(toolTip2, O);
        }
        void ErrorMensaje(Int16 Numero)
        {
            Mensajebx.ErrorMensaje(Numero);
        }
        void TrayMensaje(int Numero)
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

        //Busqueda
        void Buscar(DataGridView DGV, string Texto, ComboBox CB, DateTimePicker DTP)
        {
            switch (CB.SelectedIndex)
            {
                case 0:
                    try {  }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 1:
                    try {  }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 2:
                    try {  }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 3:
                    try { }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 4:
                    try {  }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                case 5:
                    try {  }
                    catch (Exception ex) { Excepcion(ex); return; }
                    break;
                default:
                    break;
            }
        }
        void BuscarReciclaje()
        {

        }
        void Listar(Int16 busc)
        {

        }
        void VerTodos(DataGridView Dt)
        {
            Dt.DataSource = CEntidad.TSELECT();
        }

        bool GuardarCambios()
        {
            if (Mensajebx.Guardar() == DialogResult.No)
            {
                ConfirmarContraseña ConfContrr = new ConfirmarContraseña();
                if (ConfContrr.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
            }
                return true;
        }
        void EditarSelecion()
        {


        }
        void EditarSelecionCelda(Int32 Row)
        {


        }
        void VerSelec()
        {

        }
        void VerSelecCelda(Int32 Row)
        {

        }
        void ReportarSelec()
        {

        }
        void ReportarSelecCelda(Int32 Row)
        {

        }

        void ReciclarSelecion()
        {

        }
        void ReciclarSelecionCelda(Int32 Row)
        {

        }
        void ReciclarSeleccionados()
        {

        }
        void ReciclarTodos()
        {

        }

        void RestaurarSelecion()
        {

        }
        void RestaurarSelecionCelda(Int32 Row)
        {

        }
        void RestaurarSeleccionados()
        {

        }
        void RestaurarTodos()
        {

        }

        void EliminarSelecion()
        {

        }
        void EliminarSelecionCelda(Int32 Row)
        {

        }
        void EliminarSeleccionados()
        {

        }
        void EliminarTodos()
        {

        }

        void GraficarSeleccionados(Int32 Index)
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

        void Graficar()
        {
        }
        void EntidadCompleta()
        {

        }
        void ReporteCompleto()
        {

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

        void Check(Int32 Index, Boolean Check)
        {
            switch (Index)
            {
                case 0:
                    panel27.Visible =
                    pnlUsuDeportista.Visible =
                    pnlUsuAcudiente.Visible =
                    pnlUsuEntrenador.Visible =
                    pnlUsuAdministrador.Visible =
                    pnlUsuProgramador.Visible = Check;
                    break;
                case 1: lbGCDeportista.Visible = Check;
                    break;
                case 2: lbGCAcudiente.Visible = Check;
                    break;
                case 3: lbGCEntrenador.Visible = Check;
                    break;
                case 4: lbGCAdministrador.Visible = Check;
                    break;
                case 5: lbGCProgramador.Visible = Check;
                    break;
                case 6: pnlMiembros.Visible = Check;
                    break;
                case 7:
                    panel35.Visible =
                        panel33.Visible =
                        panel31.Visible =
                        panel29.Visible =
                    panel1.Visible =
                    panel3.Visible =
                    panel6.Visible =
                    panel9.Visible = Check;
                    break;
                case 8:
                    button1.Visible = Check;
                    break;
                case 9:
                    button6.Visible = Check;
                    break;
                case 10:
                    button10.Visible = Check;
                    break;
                case 11:
                    button11.Visible = Check;
                    break;
                case 12:
                    panel17.Visible = Check;
                    break;
                case 13:
                    button12.Visible = Check;
                    break;
                case 14:
                    panel19.Visible = Check;
                    break;
                case 15:
                    button13.Visible = Check;
                    break;
                case 16:
                    label8.Visible = Check;
                    break;
                case 17:
                    label12.Visible = Check;
                    break;
                case 18:
                    label11.Visible = Check;
                    break;
                case 19:
                    label10.Visible = Check;
                    break;
                case 20:
                    label9.Visible = Check;
                    break;
                case 21:
                    panel25.Visible = Check;
                    break;
                case 22:
                    label7.Visible = Check;
                    break;
                case 23:
                    panel5.Visible =
                        panel21.Visible =
                        panel23.Visible = Check;
                    break;
                case 24:
                    label1.Visible = Check;
                    break;
                case 25:
                    label3.Visible = Check;
                    break;
                case 26:
                    label6.Visible = Check;
                    break;
                default:
                    break;
            }
        }
        void Rellenar()
        {
            try
            {
                Drow = Prog.TSELECT().Rows[0];
                lblDato1.Text = Drow[21].ToString();//usuario
                lbUsuario.Text += txUsuario.Text = lblDato1.Text;
                lblDato2.Text = Drow[24].ToString();//correo
                lbCorreo.Text += txCorreo.Text = lblDato2.Text;
                lblDato3.Text = lbNombre.Text = Drow[2].ToString();//nombre
                Text = trayBar.Text = "Club Sila - Inicio (Programador: " + Drow[2].ToString() + ")";
                lblDato4.Text = Drow[23].ToString();//estado
                lbEstado.Text += txEstado.Text = lblDato4.Text;
                CentrarObjeto(0);
            }
            catch { }
            try
            {
                if (Drow[31] != null)
                {
                    DatosImg = (Byte[])Drow[31];//foto
                    MemS = new MemoryStream(DatosImg);
                    pbxFoto2.Image = pbFoto.Image = Bitmap.FromStream(MemS);

                }
            }
            catch { }
            if (Drow[7].ToString() == "HOMBRE")//genero
            {
                pbxFoto1.Image = Img[6];
            }
            else if (Drow[7].ToString() == "MUJER")
            {
                pbxFoto1.Image = Img[7];
            }
            else
            {
                pbxFoto1.Image = Img[8];
            }
            lbGenero.Text += txGenero.Text = Drow[7].ToString();
            lbDocumento.Text += txDocumento.Text = Drow[9].ToString();
            DateTime nacimiento = Convert.ToDateTime(Drow[10]);
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            lbEdad.Text += txEdad.Text = edad + " años";
        }
        void ImportarValores()
        {
            cbForma.SelectedIndex = Settings.Default.Forma;
            cbPaleta.SelectedIndex = Settings.Default.Paleta;
            cbEstiloFRM.SelectedIndex = Settings.Default.Borde;
            DivisionesToolStripMenuItem.Checked = Settings.Default.DivMP;
            páginasToolStripMenuItem.Checked = Settings.Default.VerPaginas;
            panelInferiorToolStripMenuItem.Checked = Settings.Default.VerPanelInferior;
            divisionesToolStripMenuItem1.Checked = Settings.Default.DivIn;
            divisionesToolStripMenuItem2.Checked = Settings.Default.DivOp;
            divisionesToolStripMenuItem3.Checked = Settings.Default.DivDP;
            txtEstadoUsu.Text = Settings.Default.Estado;
        }
        #endregion

        #region Eventos
        private void FormLoad(object sender, EventArgs e)
        {
            Rellenar();
            ImportarValores();
            tTiempo.Start();
            SelectItm(0);
            Inicio.Play();
            Focus();
            Deseleccionar(false);
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
            ReciclarSelecion();
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
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = pgEventos;
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
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
        private void FRM_OBJETO_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Minimizado.Play();
                trayBar.Visible = true;
                MensajeTray.TrayCRUD(trayBar);
                Hide();
            }
            else if (WindowState == FormWindowState.Maximized | WindowState == FormWindowState.Normal)
            {
                trayBar.Visible = false;
            }
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
            Rej.Tiempo(pbReloj, toolTip1, Fuente, Fondo);
            pnlLin1.BackColor =
            pnlLin2.BackColor =
            pnlLin3.BackColor =
            pnlLin4.BackColor = Fuente;
        }
        private void maximizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GraficaComp(CEntidad.TSELECT_GRAFICAR());
        }
        private void toolStripComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Inicial)
            {
                Boton.Play();
            }
            Settings.Default.Forma = cbForma.SelectedIndex;
            Settings.Default.Save();
        }
        private void cbPaleta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Inicial)
            {
                Boton.Play();
            }
            Settings.Default.Paleta = cbPaleta.SelectedIndex;
            Settings.Default.Save();
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
            TablaC = new TablaCompletaSeleccionar(FMR, FMR_NAME);
            if (TablaC.ShowDialog() == DialogResult.OK)
            {
                if (TablaC.DataSelet.Rows.Count >= 1)
                {
                    DataSelet = TablaC.DataSelet;
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

        }
        private void pbxImagenReg_Click(object sender, EventArgs e)
        {
            Boton.Play();
            if (!panelMen.Visible)
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
            if (!panelMen.Visible)
            {
                panelMen.Show();
                panelMen.BringToFront();
                MenuSup.Enabled =
                TabControl.Enabled = false;
            }
            else
            {
                panelMen.Hide();
                TabControl.Enabled =
                MenuSup.Enabled = true;
            }
        }
        private void FRM_OBJETO_Click(object sender, EventArgs e)
        {
            if (panelMen.Visible)
            {
                panelMen.Hide();
                TabControl.Enabled =
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
        }
        private void pgReportes_Enter(object sender, EventArgs e)
        {
            Listar(3);
            SelectItm(5);
        }
        private void bnInicio_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            if (GestEnt.ShowDialog() != DialogResult.OK)
            {
                Cancelar = false;
            }
        }
        private void pb_Click(object sender, EventArgs e)
        {
            Hide();
            Rel.ShowDialog();
            Show();
            Focus();
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
        private void cbCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.PreEstablecido(e);
        }
        private void bnGraficarTodosAvan_Click(object sender, EventArgs e)
        {
            GraficarTodos();
        }
        private void bnSeleccionarPap_Click(object sender, EventArgs e)
        {
            TablaC = new TablaCompletaSeleccionar(FMR + 1, FMR_NAME);
            if (TablaC.ShowDialog() == DialogResult.OK)
            {
                if (TablaC.DataSelet.Rows.Count >= 1)
                {
                    DataSelet = TablaC.DataSelet;
                }
            }
        }
        private void TablaSelectPapelera_DoubleClick(object sender, EventArgs e)
        {

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
        private void pgReciclaje_Enter(object sender, EventArgs e)
        {
            BuscarReciclaje();
            SelectItm(7);
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
        private void opcionesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            pnlOpciones.Visible =
            chTituloOpciones.Checked = opcionesToolStripMenuItem.Checked;
        }
        private void menúPrincipalToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            pnlMenuPrincipal.Visible =
                chTituloMenu.Checked = menúPrincipalToolStripMenuItem.Checked;
        }
        private void datosDeUsuarioToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            pnlDatosUsuario.Visible =
                chTituloDatosUsuario.Checked = datosDeUsuarioToolStripMenuItem.Checked;
        }
        private void CheckEvent(object sender, EventArgs e)
        {
            Check(Convert.ToInt32(((CheckBox)sender).Tag), ((CheckBox)sender).Checked);
        }
        #endregion

        private void tGif_Tick(object sender, EventArgs e)
        {
            xx = Gif.PictureSILA(tGif, pbGif, xx);
        }
        private void pgInicio_Leave(object sender, EventArgs e)
        {
        }
        private void pgInicio_Validating(object sender, CancelEventArgs e)
        {
        }
        private void bnGCDeportista_SizeChanged(object sender, EventArgs e)
        {

        }
        private void Pags_CheckedChanged(object sender, EventArgs e)
        {
            VisibleCheck(((ToolStripMenuItem)sender).Checked, Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
        }
        private void páginasToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            Todaspag(true);
        }
        private void DragEnter_Event(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void pbx_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true); // recupera los datos del archivo que arrastre
                
                if (((PictureBox)sender).Tag.ToString() == "Foto")
                {
                    ActualizarFoto(Image.FromFile(files[0])); return;
                }
                ((PictureBox)sender).Image = Image.FromFile(files[0]);
            }
            catch
            {
                MensajeTool.ImageFormatoNoSoportado(toolTip2, ((PictureBox)sender));
            }
        }
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void pnlOpcionesBtn_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cbPrediseño_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstiloPrediseñado();
        }
        private void DivisionesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.DivMP = DivisionesToolStripMenuItem.Checked;
            Settings.Default.Save();
            CambiarDivisionesMenu(((ToolStripMenuItem)sender).Checked);
        }
        private void chTituloMenu_CheckedChanged(object sender, EventArgs e)
        {
            Deseleccionar(chTituloMenu.Checked);
        }
        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelMen.Visible | TabControl.SelectedTab == pgInicio)
            {
                GuardarImagen(pbxFoto2.Image, "Foto de " + lblDato3.Text);
            }
            else
            {

            }
        }
        private void chTituloOpciones_CheckedChanged(object sender, EventArgs e)
        {
            pnlOpcionesBtn.Visible = chTituloOpciones.Checked;
        }

        private void lbGCDeportista_MouseMove(object sender, MouseEventArgs e)
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

        private void lbGCDeportista_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Fuente;
            ((Label)sender).BackColor = Color.Transparent;
        }

        private void lbGCDeportista_Resize(object sender, EventArgs e)
        {
            int zz = ((Label)sender).MaximumSize.Width;
            try
            {
                if (((Label)sender).Width >= zz - 34)
                {
                    ((Label)sender).Height = 30;
                    ((Label)sender).Image = Img[Convert.ToInt32(((Label)sender).Tag)];
                }
                else if (((Label)sender).Width >= zz - 56)
                {
                    ((Label)sender).Height = 30;
                    ((Label)sender).Image = Img[11];
                }
                else if (((Label)sender).Width < 90)
                {
                    ((Label)sender).Height = 43;
                    ((Label)sender).Image = Img[11];
                }
                else
                {
                    ((Label)sender).Height = 43;
                    ((Label)sender).Image = Img[Convert.ToInt32(((Label)sender).Tag)];
                }
            }
            catch { }
        }

        private void pbGif_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pbGif_MouseLeave(object sender, EventArgs e)
        {

        }

        private void chTituloMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (Estilo(1))
            {
                ((CheckBox)sender).ForeColor = Color.White;
                ((CheckBox)sender).BackColor = Blue;
            }
            else
            {
                ((CheckBox)sender).ForeColor = Fondo;
                ((CheckBox)sender).BackColor = Fuente;
            }
        }

        private void chTituloMenu_MouseLeave(object sender, EventArgs e)
        {
            ((CheckBox)sender).ForeColor = Fuente;
            ((CheckBox)sender).BackColor = Color.Transparent;
        }

        private void chTituloDatosUsuario_CheckedChanged(object sender, EventArgs e)
        {
            pbFoto.Visible =
            pnlLabelDatosUsuario.Visible = chTituloDatosUsuario.Checked;
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (Estilo(1))
            {
                lbTitulo.ForeColor =
                    lbTituloInicioPr.ForeColor =
                    lbNombre.ForeColor = Color.White;
                pnlTitulo.BackColor = Blue;
            }
            else
            {
                lbTitulo.ForeColor =
                    lbTituloInicioPr.ForeColor =
                    lbNombre.ForeColor = Fondo;
                pnlTitulo.BackColor = Fuente;
            }
            tGif.Start();
        }

        private void pnlTitulo_MouseLeave(object sender, EventArgs e)
        {
            lbTitulo.ForeColor =
                    lbTituloInicioPr.ForeColor =
                    lbNombre.ForeColor = Fuente;
            pnlTitulo.BackColor = Color.Transparent;
            tGif.Stop();
        }
        private void divisionesToolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked)
            {
                foreach (Panel pnl in pgInicio.Controls.OfType<Panel>())
                {
                    pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }
            else
            {
                foreach (Panel pnl in pgInicio.Controls.OfType<Panel>())
                {
                    pnl.BorderStyle = System.Windows.Forms.BorderStyle.None;
                }
            }
            Settings.Default.DivIn = ((ToolStripMenuItem)sender).Checked;
            Settings.Default.Save();
        }

        private void divisionesToolStripMenuItem3_CheckedChanged(object sender, EventArgs e)
        {
            Div(divisionesToolStripMenuItem3.Checked, pnlDatosUsuario);
            Settings.Default.DivDP = ((ToolStripMenuItem)sender).Checked;
            Settings.Default.Save();
        }

        private void divisionesToolStripMenuItem2_CheckedChanged(object sender, EventArgs e)
        {
            Div(divisionesToolStripMenuItem2.Checked, pnlOpciones);
            Settings.Default.DivOp = ((ToolStripMenuItem)sender).Checked;
            Settings.Default.Save();
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

        private void button14_Click(object sender, EventArgs e)
        {
            if (bnActivarEdicion.Text != "Terminado")
            {
                foreach (TextBox tx in pnlLabelDatosUsuario.Controls.OfType<TextBox>())
                {
                    tx.Show();
                }
                bnActivarEdicion.Text = "Terminado";
            }
            else
            {
                if (GuardarCambios())
                {
                    foreach (TextBox tx in pnlLabelDatosUsuario.Controls.OfType<TextBox>())
                    {
                        tx.Hide();
                    }
                    bnActivarEdicion.Text = "Activar edición";
                }
            }
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
        private void txtEstadoUsu_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Estado = txtEstadoUsu.Text;
            Settings.Default.Save();
        }
    }
    #endregion
}
#endregion
#endregion