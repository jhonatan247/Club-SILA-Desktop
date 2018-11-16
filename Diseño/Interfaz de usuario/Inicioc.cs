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
using System.Diagnostics;
using System.Data.OleDb;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
#endregion

#region Interfaz de usuario
namespace Diseño.Interfaz_de_usuario
{
    #region Program
    public partial class Inicioc : Form
    {
        #region Atributos
        
        Int32 Id = 0;
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath,
        RecycleFlags dwFlags);
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand,
        StringBuilder lpstrReturnString,
        int uReturnLength,
        IntPtr hwndCallback);
        #endregion

        #region Constructor
        public Inicioc()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void Inicio_Load(object sender, EventArgs e)
        {
            label11.Text = Environment.MachineName;
        }
        #endregion

        #region Métodos
        private void GetInstalledPrinters()
        {
            foreach (string printerName in PrinterSettings.InstalledPrinters)
                Impresoras.Items.Add(printerName);
        }
        
        #endregion

        #region Eventos
        private void navegadorWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (CambiarColor.ShowDialog() == DialogResult.OK)
            {
                tabPage2.BackColor = CambiarColor.Color;
                this.BackColor = CambiarColor.Color;
            }

        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            this.BackColor = tabPage1.BackColor;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.BackColor = tabPage2.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CambiarColor.ShowDialog() == DialogResult.OK)
            {
                tabPage1.BackColor = CambiarColor.Color;
                this.BackColor = CambiarColor.Color;
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro(a) de que deseas realizar ésta acción?", "¿Suspender?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("ShutDown", "/l");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro(a) de que deseas realizar ésta acción?", "¿Reiniciar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("ShutDown", "/r");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro(a) de que deseas realizar ésta acción?", "¿Apagar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("ShutDown", "/s");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            RegistryKey user = Registry.CurrentUser;
            RegistryKey change = user.OpenSubKey("Software", true).OpenSubKey("Microsoft", true).OpenSubKey("Internet Explorer", true).OpenSubKey("Main", true);
            change.SetValue("Start Page", textBox2.Text.ToString());


            MessageBox.Show("'" + textBox2.Text + "' Se ha establecido como página de inicio.", "Confirmado");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", textBox1.Text.Trim());
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rasdial", "/disconnect");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"RAM.vbs");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int ret = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            uint result = SHEmptyRecycleBin(IntPtr.Zero, null, 0);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            GetInstalledPrinters();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            trayBar.BalloonTipText = "Abriendo Servico de correo\n\nPor favor espere...\n" +
                "Haz click derecho sobre éste Icono";
            trayBar.BalloonTipTitle = "¡Abriendo!";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
            Process.Start(@"Mail");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Inicio_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Normal == WindowState)
            {
                toolStripMenuItem1.Visible = false;

            }
            else if (FormWindowState.Minimized == WindowState)
            {
                toolStripMenuItem1.Visible = true;

            }
        }
        private void trayBar_DoubleClick(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                this.WindowState = FormWindowState.Normal;
                toolStripMenuItem1.Visible = false;
            }
        }
        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Visible = true;
            this.WindowState = FormWindowState.Minimized;


        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            toolStripMenuItem1.Visible = false;
        }
        private void controlDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Inicio_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                trayBar.Visible = false;
            }
            else if (this.Visible == true)
            {
                trayBar.Visible = true;
            }
        }
        private void crearNuevoUsusarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void controlDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void controlDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private void aprendizajeInteractivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void galeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void b4_Click(object sender, EventArgs e)
        {
            
        }
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trayBar.BalloonTipText = "Abriendo Calculadora\n\nPor favor espere...\n" +
                "Haz click derecho sobre éste Icono";
            trayBar.BalloonTipTitle = "¡Abriendo!";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
            Process.Start(@"CalculadoraSILA");
        }
        private void b3_Click(object sender, EventArgs e)
        {
            
        }
        private void libLink2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void libLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }
        private void b5_Click(object sender, EventArgs e)
        {
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void cerrarCesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void b6_Click(object sender, EventArgs e)
        {
            
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            trayBar.BalloonTipText = "Abriendo Navegador\n\nPor favor espere...\n" +
                "Haz click derecho sobre éste Icono";
            trayBar.BalloonTipTitle = "¡Abriendo!";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
            Process.Start(@"Navegador");
        }
        private void button2_Click1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            

        }
        private void Acercade_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void button16_Click(object sender, EventArgs e)
        {
            trayBar.BalloonTipText = "Abriendo servicio de Notas\n\nPor favor espere...\n" +
                "Haz click derecho sobre éste Icono";
            trayBar.BalloonTipTitle = "¡Abriendo!";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
            Process.Start(@"Notas");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            trayBar.BalloonTipText = "Abriendo Calculadora\n\nPor favor espere...\n" +
                "Haz click derecho sobre éste Icono";
            trayBar.BalloonTipTitle = "¡Abriendo!";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
            Process.Start(@"CalculadoraSILA");
        }
        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            

        }
        private void button13_Click(object sender, EventArgs e)
        {
            trayBar.BalloonTipText = "Abriendo Chat\n\nPor favor espere...\n" +
                "Haz click derecho sobre éste Icono";
            trayBar.BalloonTipTitle = "¡Abriendo!";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
            Process.Start(@"Server");

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            trayBar.BalloonTipText = "Abriendo Reproductor de música\n\nPor favor espere...\n" +
                "Haz click derecho sobre éste Icono";
            trayBar.BalloonTipTitle = "¡Abriendo!";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
            Process.Start(@"Reproductor_SILA");
        }
        private void button17_Click(object sender, EventArgs e)
        {
            
        }
        private void logrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void musicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
        }
        private void FormClosingg(object sender, FormClosingEventArgs e)
        {
            
        }
        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void button15_Click(object sender, EventArgs e)
        {
            
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (Id == 1)
            {
                
            }
            else
            {
                MessageBox.Show("No tiene los permisos suficientes para realizar ésta acción", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button18.PerformClick();
        }
        private void servicioDeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void button33_Click(object sender, EventArgs e)
        {
            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (CambiarColor.ShowDialog() == DialogResult.OK)
            {
                tabPage1.BackColor = CambiarColor.Color;
                this.BackColor = CambiarColor.Color;
            }
        }
    }
    #endregion
}
#endregion
#endregion