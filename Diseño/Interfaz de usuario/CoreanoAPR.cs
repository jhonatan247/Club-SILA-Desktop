#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

#region Interfaz de usuario
namespace Diseño.Interfaz_de_usuario
{
    #region Program
    public partial class CoreanoAPR : Form
    {
        #region Atributos
        bool salir = true;
        public int ingrs = 0;
        public bool idep = false, inic = false, mini = false;
        int lol = 0;
        Color l1, l11, l2, l22, l3, l33, l4, l44, l5, l55 = new Color();
        #endregion

        #region Constructor
        public CoreanoAPR()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void Historia_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        #endregion

        #region Métodos
        private void Inicializar()
        {
            axWindowsMediaPlayer1.URL = @"Aprendizaje\Pronun.mp4";
            axWindowsMediaPlayer2.URL = @"Aprendizaje\Voc1.mp4";
            axWindowsMediaPlayer3.URL = @"Aprendizaje\Voc2.mp4";
            axWindowsMediaPlayer4.URL = @"Aprendizaje\Voc3.mp4";
            axWindowsMediaPlayer5.URL = @"Aprendizaje\Voc4.mp4";
            button1.PerformClick();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            axWindowsMediaPlayer3.Ctlcontrols.stop();
            axWindowsMediaPlayer4.Ctlcontrols.stop();
            axWindowsMediaPlayer5.Ctlcontrols.stop();
            trayBar.Visible = true;
            l1 = Introduccion.BackColor;
            l11 = Color.Teal;
            l2 = Antigua.BackColor;
            l22 = Color.OrangeRed;
            l3 = Media.BackColor;
            l33 = Color.DarkGoldenrod;
            l4 = Moderna.BackColor;
            l44 = Color.Orange;
            l5 = Actualmente.BackColor;
            l55 = Color.Silver;
            Moderna.PerformClick();
            panel1.BackColor = rege.BackColor;
            trayBar.BalloonTipText = "Aprende sobre el taekwondo \n\nOpciones\n" +
                "Haz click derecho sobre éste Icono";
            trayBar.BalloonTipTitle = "Coreano";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
        }
        private void Regresar()
        {
            
        }
        private void Esspañol()
        {
            titulo.Text = "Coreano";
            this.Text = "Coreano";
            rege.Text = "Regresar";
            Introduccion.Text = "Números y numeráles";
            Antigua.Text = "Alfabeto";
            Media.Text = "Lectura y escritura";
            Moderna.Text = "Pronunciación";
            Actualmente.Text = "Vocabulario";


            intro.Text = "Números y numerales";
            coreano1.Hide();
            ingles1.Hide();
            español1.Show();
            coreano14.Hide();
            ingles14.Hide();
            español14.Show();
            antigu.Text = "Alfabeto";
            coreano2.Hide();
            ingles2.Hide();
            español2.Show();
            coreano3.Hide();
            ingles3.Hide();
            español3.Show();
            coreano4.Hide();
            ingles4.Hide();
            español4.Show();
            coreano5.Hide();
            ingles5.Hide();
            español5.Show();
            coreano6.Hide();
            ingles6.Hide();
            español6.Show();
            medi.Text = "Lectura y escritura";
            coreano7.Hide();
            ingles7.Hide();
            español7.Show();
            coreano15.Hide();
            ingles15.Hide();
            español15.Show();
            coreano16.Hide();
            ingles16.Hide();
            español16.Show();
            coreano17.Hide();
            ingles17.Hide();
            español17.Show();
            modern.Text = "Pronunciación";
            coreano8.Hide();
            ingles8.Hide();
            español8.Show();
            coreano9.Hide();
            ingles9.Hide();
            español9.Show();
            coreano10.Hide();
            ingles10.Hide();
            español10.Show();
            actual.Text = "Vocabulario";
            coreano11.Hide();
            ingles11.Hide();
            español11.Show();
            coreano12.Hide();
            ingles12.Hide();
            español12.Show();
            coreano13.Hide();
            ingles13.Hide();
            español13.Show();
            coreano18.Hide();
            ingles18.Hide();
            español18.Show();
            coreano19.Hide();
            ingles19.Hide();
            español19.Show();
            coreano20.Hide();
            ingles20.Hide();
            español20.Show();
            coreano21.Hide();
            ingles21.Hide();
            español21.Show();
            coreano22.Hide();
            ingles22.Hide();
            español22.Show();
            coreano23.Hide();
            ingles23.Hide();
            español23.Show();
            coreano24.Hide();
            ingles24.Hide();
            español24.Show();
            coreano25.Hide();
            ingles25.Hide();
            español25.Show();
            coreano26.Hide();
            ingles26.Hide();
            español26.Show();
            coreano27.Hide();
            ingles27.Hide();
            español27.Show();
            coreano28.Hide();
            ingles28.Hide();
            español28.Show();
            coreano29.Hide();
            ingles29.Hide();
            español29.Show();
            coreano30.Hide();
            ingles30.Hide();
            español30.Show();

            titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 10);
        }
        private void Correano()
        {
            titulo.Text = "한국의";
            this.Text = "한국의";
            rege.Text = "반환";
            Introduccion.Text = "숫자와 부호";
            Antigua.Text = "알파벳";
            Media.Text = "읽기와 쓰기";
            Moderna.Text = "발음";
            Actualmente.Text = "어휘";

            intro.Text = "숫자와 부호";
            coreano1.Show();
            ingles1.Hide();
            español1.Hide();
            coreano14.Show();
            ingles14.Hide();
            español14.Hide();
            antigu.Text = "알파벳";
            coreano2.Show();
            ingles2.Hide();
            español2.Hide();
            coreano3.Show();
            ingles3.Hide();
            español3.Hide();
            coreano4.Show();
            ingles4.Hide();
            español4.Hide();
            coreano5.Show();
            ingles5.Hide();
            español5.Hide();
            coreano6.Show();
            ingles6.Hide();
            español6.Hide();
            medi.Text = "읽기와 쓰기";
            coreano7.Show();
            ingles7.Hide();
            español7.Hide();
            coreano15.Show();
            ingles15.Hide();
            español15.Hide();
            coreano16.Show();
            ingles16.Hide();
            español16.Hide();
            coreano17.Show();
            ingles17.Hide();
            español17.Hide();
            modern.Text = "발음";
            coreano8.Show();
            ingles8.Hide();
            español8.Hide();
            coreano9.Show();
            ingles9.Hide();
            español9.Hide();
            coreano10.Show();
            ingles10.Hide();
            español10.Hide();
            actual.Text = "어휘";
            coreano11.Show();
            ingles11.Hide();
            español11.Hide();
            coreano12.Show();
            ingles12.Hide();
            español12.Hide();
            coreano13.Show();
            ingles13.Hide();
            español13.Hide();

            coreano18.Show();
            ingles18.Hide();
            español18.Hide();
            coreano19.Show();
            ingles19.Hide();
            español19.Hide();
            coreano20.Show();
            ingles20.Hide();
            español20.Hide();
            coreano21.Show();
            ingles21.Hide();
            español21.Hide();
            coreano22.Show();
            ingles22.Hide();
            español22.Hide();
            coreano23.Show();
            ingles23.Hide();
            español23.Hide();
            coreano24.Show();
            ingles24.Hide();
            español24.Hide();
            coreano25.Show();
            ingles25.Hide();
            español25.Hide();
            coreano26.Show();
            ingles26.Hide();
            español26.Hide();
            coreano27.Show();
            ingles27.Hide();
            español27.Hide();
            coreano28.Show();
            ingles28.Hide();
            español28.Hide();
            coreano29.Show();
            ingles29.Hide();
            español29.Hide();
            coreano30.Show();
            ingles30.Hide();
            español30.Hide();
            titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 10);
        }
        private void Inggles()
        {
            titulo.Text = "Korean";
            this.Text = "Korean";
            rege.Text = "Back";
            Introduccion.Text = "Numbers and numerals";
            Antigua.Text = "Alphabet";
            Media.Text = "Reading and writing";
            Moderna.Text = "Pronunciation";
            Actualmente.Text = "Vocabulary";

            intro.Text = "Numbers and numerals";
            coreano1.Hide();
            ingles1.Show();
            español1.Hide();
            coreano14.Hide();
            ingles14.Show();
            español14.Hide();
            antigu.Text = "Alphabet";
            coreano2.Hide();
            ingles2.Show();
            español2.Hide();
            coreano3.Hide();
            ingles3.Show();
            español3.Hide();
            coreano4.Hide();
            ingles4.Show();
            español4.Hide();
            coreano5.Hide();
            ingles5.Show();
            español5.Hide();
            coreano6.Hide();
            ingles6.Show();
            español6.Hide();
            medi.Text = "Reading and writing";
            coreano7.Hide();
            ingles7.Show();
            español7.Hide();
            coreano15.Hide();
            ingles15.Show();
            español15.Hide();
            coreano16.Hide();
            ingles16.Show();
            español16.Hide();
            coreano17.Hide();
            ingles17.Show();
            español17.Hide();
            modern.Text = "Pronunciation";
            coreano8.Hide();
            ingles8.Show();
            español8.Hide();
            coreano9.Hide();
            ingles9.Show();
            español9.Hide();
            coreano10.Hide();
            ingles10.Show();
            español10.Hide();
            actual.Text = "Vocabulary";
            coreano11.Hide();
            ingles11.Show();
            español11.Hide();
            coreano12.Hide();
            ingles12.Show();
            español12.Hide();
            coreano13.Hide();
            ingles13.Show();
            español13.Hide();

            coreano18.Hide();
            ingles18.Show();
            español18.Hide();
            coreano19.Hide();
            ingles19.Show();
            español19.Hide();
            coreano20.Hide();
            ingles20.Show();
            español20.Hide();
            coreano21.Hide();
            ingles21.Show();
            español21.Hide();
            coreano22.Hide();
            ingles22.Show();
            español22.Hide();
            coreano23.Hide();
            ingles23.Show();
            español23.Hide();
            coreano24.Hide();
            ingles24.Show();
            español24.Hide();
            coreano25.Hide();
            ingles25.Show();
            español25.Hide();
            coreano26.Hide();
            ingles26.Show();
            español26.Hide();
            coreano27.Hide();
            ingles27.Show();
            español27.Hide();
            coreano28.Hide();
            ingles28.Show();
            español28.Hide();
            coreano29.Hide();
            ingles29.Show();
            español29.Hide();
            coreano30.Hide();
            ingles30.Show();
            español30.Hide();
            titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 10);
        }
        #endregion

        #region Eventos
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Regresar();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restaurarToolStripMenuItem.Visible = false;
        }

        private void Historia_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                trayBar.Visible = false;
            }
        }
        private void Historia_Resize(object sender, EventArgs e)
        {

            if (FormWindowState.Minimized == WindowState)
            {
                restaurarToolStripMenuItem.Visible = true;
                if (lol == 1)
                {
                    mini = true;
                }
            }
            else if (FormWindowState.Maximized == WindowState)
            {
                restaurarToolStripMenuItem.Visible = false;
                lol = 1;
                if (mini == false)
                {
                    titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 10);
                    panel1.Location = new Point(this.Width / 2 - panel1.Width / 2, 100);
                    panel1.Width = (730);
                    panel1.Height = (this.Height - 137);
                }
                else
                {
                    mini = false;
                }
            }
            else if (FormWindowState.Normal == WindowState)
            {
                lol = 0;
                restaurarToolStripMenuItem.Visible = false;
                titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 10);
                panel1.Location = new Point(270, 100);
                panel1.Width = (this.Width - 286);
                panel1.Height = (this.Height - 137);
            }
        }
        private void crearNuevoUsusarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historia.PerformClick();
        }
        private void controlDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Introduccion.PerformClick();
            if (FormWindowState.Minimized == WindowState)
            {
                WindowState = FormWindowState.Maximized;

            }
        }
        private void controlDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Antigua.PerformClick();
            if (FormWindowState.Minimized == WindowState)
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        private void controlDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media.PerformClick();
            if (FormWindowState.Minimized == WindowState)
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        private void aprendizajeInteractivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Moderna.PerformClick();
            if (FormWindowState.Minimized == WindowState)
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        private void galeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualmente.PerformClick();
            if (FormWindowState.Minimized == WindowState)
            {
                WindowState = FormWindowState.Maximized;

            }
        }
        private void Español_Click(object sender, EventArgs e)
        {
            Esspañol();
        }

        private void Coreano_Click(object sender, EventArgs e)
        {
            Correano();
        }

        private void Inglés_Click(object sender, EventArgs e)
        {
            Inggles();
        }

        private void Introduccion_Click(object sender, EventArgs e)
        {
            Introduccion.ForeColor = Color.White;
            Antigua.ForeColor = Color.Black;
            Media.ForeColor = Color.Black;
            Moderna.ForeColor = Color.Black;
            Actualmente.ForeColor = Color.Black;
            Introduccion.BackColor = l11;
            Antigua.BackColor = l2;
            Media.BackColor = l3;
            Moderna.BackColor = l4;
            Actualmente.BackColor = l5;
            panel1.BackColor = rege.BackColor;
            intro.Show();
            antigu.Hide();
            medi.Hide();
            modern.Hide();
            actual.Hide();
        }

        private void Antigua_Click(object sender, EventArgs e)
        {
            Introduccion.ForeColor = Color.Black;
            Antigua.ForeColor = Color.White;
            Media.ForeColor = Color.Black;
            Moderna.ForeColor = Color.Black;
            Actualmente.ForeColor = Color.Black;
            Introduccion.BackColor = l1;
            Antigua.BackColor = l22;
            Media.BackColor = l3;
            Moderna.BackColor = l4;
            Actualmente.BackColor = l5;
            panel1.BackColor = antigu.BackColor;
            antigu.Show();
            intro.Hide();
            medi.Hide();
            modern.Hide();
            actual.Hide();
        }
        private void Media_Click(object sender, EventArgs e)
        {
            Introduccion.ForeColor = Color.Black;
            Antigua.ForeColor = Color.Black;
            Media.ForeColor = Color.White;
            Moderna.ForeColor = Color.Black;
            Actualmente.ForeColor = Color.Black;
            Introduccion.BackColor = l1;
            Antigua.BackColor = l2;
            Media.BackColor = l33;
            Moderna.BackColor = l4;
            Actualmente.BackColor = l5;
            panel1.BackColor = medi.BackColor;
            medi.Show();
            antigu.Hide();
            intro.Hide();
            modern.Hide();
            actual.Hide();
        }
        private void Moderna_Click(object sender, EventArgs e)
        {
            Introduccion.ForeColor = Color.Black;
            Antigua.ForeColor = Color.Black;
            Media.ForeColor = Color.Black;
            Moderna.ForeColor = Color.White;
            Actualmente.ForeColor = Color.Black;
            Introduccion.BackColor = l1;
            Antigua.BackColor = l2;
            Media.BackColor = l3;
            Moderna.BackColor = l44;
            Actualmente.BackColor = l5;
            panel1.BackColor = modern.BackColor;
            medi.Hide();
            antigu.Hide();
            intro.Hide();
            modern.Show();
            actual.Hide();
        }
        private void Actualmente_Click(object sender, EventArgs e)
        {
            Introduccion.ForeColor = Color.Black;
            Antigua.ForeColor = Color.Black;
            Media.ForeColor = Color.Black;
            Moderna.ForeColor = Color.Black;
            Actualmente.ForeColor = Color.White;
            Introduccion.BackColor = l1;
            Antigua.BackColor = l2;
            Media.BackColor = l3;
            Moderna.BackColor = l4;
            Actualmente.BackColor = l55;
            panel1.BackColor = actual.BackColor;
            medi.Hide();
            antigu.Hide();
            intro.Hide();
            modern.Hide();
            actual.Show();
        }
        private void trayBar_DoubleClick(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                this.WindowState = FormWindowState.Maximized;
                restaurarToolStripMenuItem.Visible = false;
            }
        }
        private void eapañolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        private void coreanoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }
        private void CoreanoAPR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir == true)
            {
                DialogResult result;

                result = MessageBox.Show("¿Desea salir de la aplicación?", "¿Salir?!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button4.Show();
        }
        private void Galeria_MouseMove(object sender, MouseEventArgs e)
        {
            button4.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion