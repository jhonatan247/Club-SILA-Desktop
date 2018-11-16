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
    public partial class Historia : Form
    {
        #region Atributos
        bool salir = true;
        public int ingrs = 0;
        public bool idep = false, inic = false, mini = false;
        int lol = 0;
        Color l1, l11, l2, l22, l3, l33, l4, l44, l5, l55 = new Color();
        #endregion

        #region Constructor
        public Historia()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void Historia_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
            trayBar.Visible = true;
            l1 = Introduccion.BackColor;
            l11 = Color.Lime;
            l2 = Antigua.BackColor;
            l22 = Color.Orange;
            l3 = Media.BackColor;
            l33 = Color.Red;
            l4 = Moderna.BackColor;
            l44 = Color.Aqua;
            l5 = Actualmente.BackColor;
            l55 = Color.MediumSlateBlue;
            Introduccion.PerformClick();
            panel1.BackColor = rege.BackColor;
            trayBar.BalloonTipText = "Aprende sobre el taekwondo \n\nOpciones\n" +
                "Haz click derecho sobre éste Icono";
            trayBar.BalloonTipTitle = "Historia del taekwondo";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
        }
        #endregion

        #region Métodos
        private void Esspañol()
        {
            titulo.Text = "Historia del taekwondo";
            this.Text = "Historia";
            rege.Text = "Regresar";
            Introduccion.Text = "Introducción";
            Antigua.Text = "Edad Antigua";
            Media.Text = "Edad Media";
            Moderna.Text = "Edad Moderna";
            Actualmente.Text = "Actualmente";


            intro.Text = "Introducción";
            coreano1.Hide();
            ingles1.Hide();
            español1.Show();
            antigu.Text = "Edad Antigua";
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
            medi.Text = "Edad Media";
            coreano7.Hide();
            ingles7.Hide();
            español7.Show();
            modern.Text = "Edad Moderna";
            coreano8.Hide();
            ingles8.Hide();
            español8.Show();
            coreano9.Hide();
            ingles9.Hide();
            español9.Show();
            coreano10.Hide();
            ingles10.Hide();
            español10.Show();
            actual.Text = "Actualmente";
            coreano11.Hide();
            ingles11.Hide();
            español11.Show();
            coreano12.Hide();
            ingles12.Hide();
            español12.Show();
            coreano13.Hide();
            ingles13.Hide();
            español13.Show();

            titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 10);
        }
        private void Coreanno()
        {
            titulo.Text = "태권도의 역사";
            this.Text = "역사";
            rege.Text = "반환";
            Introduccion.Text = "소개";
            Antigua.Text = "노년";
            Media.Text = "중세";
            Moderna.Text = "현대 시대";
            Actualmente.Text = "지금";

            intro.Text = "소개";
            coreano1.Show();
            ingles1.Hide();
            español1.Hide();
            antigu.Text = "노년";
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
            medi.Text = "중세";
            coreano7.Show();
            ingles7.Hide();
            español7.Hide();
            modern.Text = "현대 시대";
            coreano8.Show();
            ingles8.Hide();
            español8.Hide();
            coreano9.Show();
            ingles9.Hide();
            español9.Hide();
            coreano10.Show();
            ingles10.Hide();
            español10.Hide();
            actual.Text = "지금";
            coreano11.Show();
            ingles11.Hide();
            español11.Hide();
            coreano12.Show();
            ingles12.Hide();
            español12.Hide();
            coreano13.Show();
            ingles13.Hide();
            español13.Hide();

            titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 10);
        }
        private void Inggles()
        {
            titulo.Text = "History of Taekwondo";
            this.Text = "History";
            rege.Text = "Back";
            Introduccion.Text = "Introduction";
            Antigua.Text = "Old age";
            Media.Text = "Middle Ages";
            Moderna.Text = "Modern age";
            Actualmente.Text = "Actually";

            intro.Text = "Introduction";
            coreano1.Hide();
            ingles1.Show();
            español1.Hide();
            antigu.Text = "Old Age";
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
            medi.Text = "Middle Ages";
            coreano7.Hide();
            ingles7.Show();
            español7.Hide();
            modern.Text = "Modern Age";
            coreano8.Hide();
            ingles8.Show();
            español8.Hide();
            coreano9.Hide();
            ingles9.Show();
            español9.Hide();
            coreano10.Hide();
            ingles10.Show();
            español10.Hide();
            actual.Text = "Actually";
            coreano11.Hide();
            ingles11.Show();
            español11.Hide();
            coreano12.Hide();
            ingles12.Show();
            español12.Hide();
            coreano13.Hide();
            ingles13.Show();
            español13.Hide();

            titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 10);
        }
        private void Regressar()
        {
            
        }
        #endregion

        #region Eventos
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Regressar();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Regressar();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Regressar();
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
            Coreanno();
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
        private void Historia_FormClosing(object sender, FormClosingEventArgs e)
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
        #endregion
    }
    #endregion
}
#endregion
#endregion
