#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using Diseño.Properties;
using Negocio.Lógica;
using Negocio.Entidades;
using Negocio.Manejo_de_datos;
using Diseño.Funciones;
using Negocio.Objetos;
#endregion

#region SILA
namespace Diseño.Interfaz_de_usuario
{
    #region Program
    public partial class Ingreso : Form
    {
        #region Atributos
        Captura Capt = new Captura();
        AcercaDe Aceraca = new AcercaDe();
        Programa Prog = new Programa();
        Presentacion Present = new Presentacion();
        MensajeBx Mensajebx = new MensajeBx();
        MensajeToolTip MensajeTool = new MensajeToolTip();
        AccionesSistema As = new AccionesSistema();
        MensajeTrayBar MensajeTray = new MensajeTrayBar();
        TimmerAction TmAction = new TimmerAction();

        bool Cancelar = false;
        Color Blue = Color.FromArgb(3,169,244);
        Color Gray = Color.FromArgb(68,68,68);

        bool Inicial = false;
        #endregion

        #region Propiedades
        RelojAnalogo Rel { get; set; }
        E_Programa Eprog { get; set; }
        Icono Fondo { get; set; }
        DataRow Drow { get; set; }
        DataTable DataSource { get; set; }

        VisorImagenes Pantallazo { get; set; }
        EnviarCodigo ReContra { get; set; }

        List<SoundPlayer> Lst { get; set; }
        List<Image> Img { get; set; }
        List<String> Txt { get; set; }
        SoundPlayer Boton { get; set; }
        SoundPlayer Camara { get; set; }
        SoundPlayer Inicio { get; set; }
        SoundPlayer Minimizado { get; set; }
        SoundPlayer Datos { get; set; }

        Int32 Limer { get; set; }
        Int32 Xx { get; set; }
        String Contaseña { get; set; }
        String NUsuario { get; set; }
        String NUsuario_Alern { get; set; }
        String Correo { get; set; }
        #endregion

        #region Constructor
        public Ingreso()
        {
            InitializeComponent();
            Lst = As.Sonidos();
            Img = As.Imagenes();
            Txt = As.Textos();
            Sonidos();
        }
        #endregion

        #region Métodos
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
                activarDesactivarSonidosToolStripMenuItem.Image = Img[1];
                activarDesactivarSonidosToolStripMenuItem.Text = Txt[1];
            }
        }
        void TxCampoVacio(Object O)
        {
            MensajeTool.ValorInvalidado(toolTip2, O);
        }
        private void Autentificar()
        {
            Limer = 0;
            if (Validacion.CampoVacio(txUsuario.Text.Trim(), 3))
            {
                Datos.Play();
                TxCampoVacio(txUsuario);
                return;
            }
            else if (Validacion.CampoVacio(txContraseña.Text.Trim(), 3))
            {
                Datos.Play();
                TxCampoVacio(txContraseña);
                return;
            }
            DataSource = Prog.AUTENTIFICAR(txUsuario.Text.Trim(), txContraseña.Text.Trim());
            if (DataSource.Rows.Count == 1)
            {
                Drow = Prog.AUTENTIFICAR_MAYUS(Convert.ToInt64(DataSource.Rows[0][0])).Rows[0];
                Contaseña = Drow[0].ToString();
                NUsuario = Drow[1].ToString();
                NUsuario_Alern = Drow[2].ToString();
                Correo = Drow[3].ToString();
                if ((Contaseña == txContraseña.Text.Trim() && NUsuario == txUsuario.Text.Trim())
                    | (Contaseña == txContraseña.Text.Trim() && NUsuario_Alern == txUsuario.Text.Trim())
                    | (Contaseña == txContraseña.Text.Trim() && Correo == txUsuario.Text.Trim().ToUpper()))
                {
                    if (chRecordarme.Checked)
                    {
                        Settings.Default.Usuario = txUsuario.Text.Trim();
                        Settings.Default.Contraseña = txContraseña.Text.Trim();
                        Settings.Default.Save();
                    }
                    Prog.OBTENER_DATOS(Convert.ToInt64(DataSource.Rows[0][0]));
                    Cancelar = true;
                    Application.Restart();
                }
                else
                {
                    MensajeTool.Mayusculas(toolTip2, bnIngresar);
                }
            }
            else
            {
                Mensajebx.DatosIncorrectos(txUsuario.Text);
            }
        }
        void Ptllazo()
        {
            Pantallazo.ShowDialog();
            Sonidos();
        }
        void TrayMensaje(Int32 Numero)
        {
            MensajeTray.TrayMensaje(Numero, trayBar);
        }
        void Excepcion(Exception ex)
        {
            Mensajebx.Excepcion(ex);
        }
        void Colores(Color Tinte)
        {
            toolAcciones.ForeColor =
            toolAyuda.ForeColor =
            toolDiseño.ForeColor = 
            lbTitulo.ForeColor = 
            lbSubTitulo.ForeColor = 
            lbContrat.ForeColor = 
            lbUsut.ForeColor = 
            txUsuario.ForeColor = 
            txContraseña.ForeColor = 
            bnIngresar.BackColor = 
            chRecordarme.ForeColor =
            lOlvid.ForeColor = 
            pBarra.BackColor = Tinte;
            foreach (ToolStripMenuItem Item in toolAcciones.DropDownItems.OfType<ToolStripMenuItem>())
            {
                Item.ForeColor = Tinte;
                foreach (ToolStripMenuItem Item2 in Item.DropDownItems.OfType<ToolStripMenuItem>())
                {
                    Item2.ForeColor = Tinte;
                }
            }
            foreach (ToolStripMenuItem Item in toolAyuda.DropDownItems.OfType<ToolStripMenuItem>())
            {
                Item.ForeColor = Tinte;
                foreach (ToolStripMenuItem Item2 in Item.DropDownItems.OfType<ToolStripMenuItem>())
                {
                    Item2.ForeColor = Tinte;
                }
            }
            foreach (ToolStripMenuItem Item in toolDiseño.DropDownItems.OfType<ToolStripMenuItem>())
            {
                Item.ForeColor = Tinte;
                foreach (ToolStripMenuItem Item2 in Item.DropDownItems.OfType<ToolStripMenuItem>())
                {
                    Item2.ForeColor = Tinte;
                }
            }
        }
        #endregion

        #region Eventos
        private void Ingreso_Load(object sender, EventArgs e)
        {
            Rel = new RelojAnalogo();
            cbEstilo.SelectedIndex = Settings.Default.DiseñoIngreso;

            Present.ShowDialog();
            tTransparencia.Enabled = true;
            txUsuario.Text = Settings.Default.Usuario;
            txContraseña.Text = Settings.Default.Contraseña;
            pbOlvidarUsuario.Enabled = true;
            pbOlvidarContraseña.Enabled = true;
            Inicio.Play();
            Inicial = false;
            tReloj.Start();
            Focus();
        }
        
        private void completaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallazo = new VisorImagenes(Capt.Completa());
            Ptllazo();
        }
        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Visible)
            {
                Pantallazo = new VisorImagenes(Capt.Formulario(this));
                Ptllazo();
            }
            else
                TrayMensaje(0);
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Limer = 0;
            tTransparencia.Enabled = false;
            Hide();
            Aceraca.ShowDialog();
            Show();
            tTransparencia.Enabled = true;
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Application.Exit();
        }
        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            try { Process.Start(Settings.Default.InstruccionesIngreso); }
            catch (Exception ex) { Excepcion(ex); }
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
        private void button2_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Cancelar = false;
            Process.Start(@"Actualizar_Datos");
            Application.Exit();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Opacity += 0.02;
            Limer++;
            if (Limer >= 600)
            {
                Limer = 0;
                Hide();
                Fondo = new Icono();
                tTransparencia.Enabled = false;
                Fondo.ShowDialog();
                Show();
                Focus();
                Limer = 0;
                tTransparencia.Enabled = true;
            }
        }
        private void usu_Click(object sender, EventArgs e)
        {
            lbUsut.Hide();
            txUsuario.Focus();
        }
        private void contrat_Click(object sender, EventArgs e)
        {
            lbContrat.Hide();
            txContraseña.Focus();
        }
        private void usu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                bnIngresar.PerformClick();
            }
        }
        private void btning_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Autentificar();
        }
        private void FormClosingg(object sender, FormClosingEventArgs e)
        {
            if (!Cancelar)
            {
                if (Mensajebx.Salir() != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
                Cancelar = true;
                Process currentProcess = Process.GetCurrentProcess();
                currentProcess.Kill();
                Application.Exit();
                trayBar.Visible = false;
            }
        }
        private void Ingreso_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Limer = 0;
                tTransparencia.Enabled = false;
                Minimizado.Play();
                trayBar.Visible = true;
                MensajeTray.TrayIngrseo(trayBar);
                Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized | this.WindowState == FormWindowState.Normal)
            {
                tTransparencia.Enabled = true;
                trayBar.Visible = false;
            }
        }
        private void trayBar_DoubleClick(object sender, EventArgs e)
        {
            Boton.Play();
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void pbOlvidar_Click(object sender, EventArgs e)
        {
            Settings.Default.Usuario = "";
            Settings.Default.Contraseña = "";
            Settings.Default.Save();
            MensajeTool.UsuarioOlvidado(toolTip2, pbOlvidarUsuario);
            pbOlvidarUsuario.Enabled = false;
            pbOlvidarContraseña.Enabled = false;
        }
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Size = new Size(MinimumSize.Width +100, MinimumSize.Height + 100);
            CenterToScreen();
        }
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Size = MinimumSize;
            CenterToScreen();
        }
        private void tsmiMinimizado_Click(object sender, EventArgs e)
        {
            Limer = 0;
            Boton.Play();
            WindowState = FormWindowState.Minimized;
        }
        private void cbEstilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEstilo.SelectedIndex)
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
            Settings.Default.DiseñoIngreso = cbEstilo.SelectedIndex;
            Settings.Default.Save();
        }
        private void Ingreso_LocationChanged(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        #endregion

        private void txUsuario_TextChanged(object sender, EventArgs e)
        {
            Limer = 0;
            if (((TextBox)sender).Text == "")
            {
                lbUsut.Show();
            }
            else
            {
                lbUsut.Hide();
            }
        }

        private void txContraseña_TextChanged(object sender, EventArgs e)
        {
            Limer = 0;
            if (((TextBox)sender).Text == "")
            {
                lbContrat.Show();
            }
            else
            {
                lbContrat.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Settings.Default.Contraseña = "";
            Settings.Default.Save();
            MensajeTool.UsuarioOlvidado(toolTip2, pbOlvidarUsuario);
            pbOlvidarContraseña.Enabled = false;
        }

        private void abrirProtectorDePantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limer = 700;
        }

        private void tReloj_Tick(object sender, EventArgs e)
        {
            Rel.RelojIngreso(BackColor, cbEstilo.SelectedIndex, pictureBox1, toolTip1);
        }
        private void bn_MouseMove(object sender, MouseEventArgs e)
        {
            if(txContraseña.Text.Trim().Length < 3 && txUsuario.Text.Trim().Length < 3)
            {
                ((Button)sender).BackColor = Gray;
                ((Button)sender).ForeColor = Color.White;
            }
            else
            {
                ((Button)sender).BackColor = Color.White;
                ((Button)sender).ForeColor = Blue;
            }
        }

        private void bn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Blue;
        }

        private void lOlvid_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Limer = 0;
            ReContra = new EnviarCodigo();
            Hide();
            ReContra.ShowDialog();
            Show();
        }

        private void lOlvid_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).ForeColor = Gray;
        }

        private void lOlvid_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Blue;
        }

        private void txUsuario_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Trim() == "")
            {
                lbUsut.Show();
            }
        }

        private void txContraseña_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Trim() == "")
            {
                lbContrat.Show();
            }
        }
    }
    #endregion
}
#endregion
#endregion