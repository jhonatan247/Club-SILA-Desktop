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
using System.Data.OleDb;
using Negocio.Lógica;
using Diseño.Properties;
using System.Media;
using Negocio.Manejo_de_datos;
using System.Diagnostics;
using Diseño.Interfaz_de_usuario;
using Negocio.Entidades;
#endregion

#region Función
namespace Diseño.Funciones
{
    #region Formulario
    public partial class VisorImagenes : Form
    {
        #region Atributos
        Int32 zoomm = 100, N = 0, totalI =0;

        List<Image> Imagenes = new List<Image>();
        List<String> Ubicacion = new List<String>();
        MensajeBx Mensajebx = new MensajeBx();
        AccionesSistema As = new AccionesSistema();
        Programa Prog = new Programa();
        AcercaDe Aceraca = new AcercaDe();
        #endregion

        #region Propiedades
        SoundPlayer Boton { get; set; }
        SoundPlayer Camara { get; set; }
        SoundPlayer Inicio { get; set; }
        SoundPlayer Minimizado { get; set; }
        SoundPlayer Datos { get; set; }

        DataRow Drow { get; set; }

        E_Programa Eprog { get; set; }
        #endregion

        #region Constructor
        public VisorImagenes(Image Imagen)
        {
            InitializeComponent();
            Imagenes.Add(Imagen);
            Ubicacion.Add("Pantallazo");
            Sonidos();
        }
        #endregion

        #region Métodos
        void Excepcion(Exception ex)
        {
            Mensajebx.Excepcion(ex);
        }
        void Sonidos()
        {
            List<SoundPlayer> Lst = As.Sonidos();
            List<Image> Img = As.Imagenes();
            List<String> Txt = As.Textos();
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
                Minimizado.Play();
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
        void Aumentar()
        {
            if (pbImagen.Width < 25000 && pbImagen.Height < 25000)
            {
                zoomm = zoomm + 10;
                ZoomM(10);
                label1.Text = "Zoom: " + zoomm + "%";
                Posicion();
            }
        }
        void Disminuir()
        {
            if (pbImagen.Width > 30 && pbImagen.Height > 30)
            {
                zoomm = zoomm - 10;
                ZoomQ(10);
                label1.Text = "Zoom: " + zoomm + "%";
                Posicion();
            }
        }
        void Posicion()
        {
            if (pbImagen.Width < this.Width && pbImagen.Height < this.Height)
            {
                pbImagen.Location = new Point(panel2.Width / 2 - pbImagen.Width / 2, panel2.Height / 2 - pbImagen.Height / 2);
            }
            else
            {
                panel2.VerticalScroll.Value = 0;
                panel2.HorizontalScroll.Value = 0;
                pbImagen.Location = new Point(0, 0);
            }
            
        }
        private void Guardarr()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            saveFileDialog1.Title = "Guardar como.. ";
            saveFileDialog1.FileName = lblNombre.Text = Ubicacion[N];
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.Imagenes[N].Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.Imagenes[N].Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        this.Imagenes[N].Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        this.Imagenes[N].Save(fs,
                           System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }
        void RoarDerecha()
        {
            Image img = pbImagen.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbImagen.Image = img;
            Tamaño();
            Posicion();
        }
        void RoarIzquierda()
        {
            Image img = pbImagen.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbImagen.Image = img;
            Tamaño();
            Posicion();
        }
        private void RegresarImg()
        {
            if (totalI > 0)
            {
                if (pbImagen.Image == Imagenes[0])
                {
                    N = totalI;
                    pbImagen.Image = Imagenes[N];
                    lblNombre.Text = Ubicacion[N];
                }
                else
                {
                    N--;
                    pbImagen.Image = Imagenes[N];
                    lblNombre.Text = Ubicacion[N];
                }
                pbImagen.Size = Imagenes[N].Size;
                Posicion();
            }
        }
        private void AvanzarImg()
        {
            if (totalI > 0)
            {
                if (pbImagen.Image == Imagenes[totalI])
                {
                    N = 0;
                    pbImagen.Image = Imagenes[N];
                    lblNombre.Text = Ubicacion[N];
                }
                else
                {
                    N++;
                    pbImagen.Image = Imagenes[N];
                    lblNombre.Text = Ubicacion[N];
                }
                pbImagen.Size = Imagenes[N].Size;
                Posicion();
            }
        }
        void Tamaño()
        {
            try
            {
                Bitmap bmp1 = new Bitmap(pbImagen.Image);
                pbImagen.Height = bmp1.Height;
                pbImagen.Width = bmp1.Width;
            }
            catch { }
        }
        private void ZoomM(Double zoo)
        {
            Double zoomRatio = zoo + (1);
            Double widthZoom = pbImagen.Width * zoomRatio / 100;
            Double heightZoom = pbImagen.Height * zoomRatio / 100;
            pbImagen.Width += Convert.ToInt32(Math.Round(widthZoom));
            pbImagen.Height += Convert.ToInt32(Math.Round(heightZoom));
        }
        private void ZoomQ(Double zoo)
        {
            Double zoomRatio = zoo;
            Double widthZoom = pbImagen.Width * zoomRatio / 100;
            Double heightZoom = pbImagen.Height * zoomRatio / 100;
            pbImagen.Width -= Convert.ToInt32(Math.Round(widthZoom));
            pbImagen.Height -= Convert.ToInt32(Math.Round(heightZoom));
        }
        private void AñadirImg()
        {
            try
            {
                OpenFileDialog OpenMedia = new OpenFileDialog();
                OpenMedia.InitialDirectory = System.Environment.SpecialFolder.CommonMusic.ToString();
                OpenMedia.FileName = "";
                OpenMedia.Title = "Elegir imágen..";
                OpenMedia.Multiselect = true;
                OpenMedia.Filter = "Archivo de Imágen (*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG;)|*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG";
                if (OpenMedia.ShowDialog() == DialogResult.OK)
                {
                    foreach (string Str in OpenMedia.FileNames)
                    {
                            Imagenes.Add(Image.FromFile(Str));
                            Ubicacion.Add(Str);
                            totalI = Imagenes.Count - 1;
                    }
                    zoomm = 100;
                    label1.Text = "Zoom: " + zoomm + "%";
                    pbImagen.Image = Imagenes[totalI];
                    lblNombre.Text = Ubicacion[totalI];
                    Tamaño();
                    Posicion();
                    N = totalI;
                    Mensajebx.ImagenesAñadidas();
                }
            }
            catch (Exception ex) { Excepcion(ex); }
        }
        private void PantallaC()
        {
            PantallaCompleta PC = new PantallaCompleta(Imagenes,Ubicacion, N);
            PC.ShowDialog();
        }
        #endregion

        #region Eventos
        private void Foto_Load(object sender, EventArgs e)
        {
            try
            {
                lblNombre.Text = Ubicacion[N];
                pbImagen.Image = Imagenes[N];
                Tamaño();
                Posicion();
                cbEstiloFRM.SelectedIndex = Settings.Default.Borde;
                Camara.Play();
            }
            catch (Exception ex) { Excepcion(ex); }
        }
        private void Foto_FormClosing(object sender, FormClosingEventArgs e)
        {
            N = 0;
            totalI = 0;
            Imagenes.Clear();
            Ubicacion.Clear();
            Minimizado.Play();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Boton.Play();
            RoarDerecha();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Boton.Play();
            AvanzarImg();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Boton.Play();
            RegresarImg();
        }
        private void Foto_SizeChanged(object sender, EventArgs e)
        {
            Tamaño();
            Posicion();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Boton.Play();
            RoarIzquierda();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Aumentar();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Boton.Play();
            Disminuir();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            AñadirImg();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Guardarr();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image IMAGE = Imagenes[N];
            e.Graphics.DrawImage(IMAGE, 10, 20, 900, 920);
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            PrintDialog pr = new PrintDialog();
            if (pr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    printDocument1.PrinterSettings = pr.PrinterSettings;
                    printDocument1.Print();
                }
                catch (Exception ex) { Excepcion(ex); }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Boton.Play();
            PantallaC();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturaPantallazo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left:
                    AvanzarImg();
                    break;
                case Keys.Right:
                    RegresarImg();
                    break;
                case Keys.Up:
                    Aumentar();
                    break;
                case Keys.Down:
                    Disminuir();
                    break;
                default:
                    break;
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
        private void toolStripComboBox9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Boton.Play();
            BorderStyle();
        }
        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            try { Process.Start(Settings.Default.InstruccionesVisorImg); }
            catch (Exception ex) { Excepcion(ex); }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boton.Play();
            this.Close();
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
        #endregion

    }
    #endregion
}
#endregion
#endregion