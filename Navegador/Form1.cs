using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string url = "";
        List<string> lista = new List<string>();

        public List<string> Urll = new List<string>();

        public List<string> idd = new List<string>();

        public List<string> Historial = new List<string>();
        public List<string> rUrll = new List<string>();

        public List<string> ridd = new List<string>();

        public List<string> rHistorial = new List<string>();
        public string urlk = "https://www.google.com.co/";

        WebBrowser web = new WebBrowser();
        public int i = 0, N, ex, zoom = 100;
        bool cancel = false, agregar = false, pirm = false, seg = false;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (seg == false)
            {
                using (OleDbConnection conexion = BDcomun.ObtenerConexion())
                {
                    OleDbCommand comando = new OleDbCommand(string.Format(
                        "Select Id, hist from nm where Id = {0}", 1), conexion);
                    OleDbDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        N = reader.GetInt32(1);
                    }
                    conexion.Close();
                }
                if (N > 0)
                {
                    int pp = 0;
                    ex = N;
                    if (ex > 500)
                    {
                        pp = ex - 400;
                    }
                    string id;
                    string fe;
                    string ur;
                    string ho;
                    string ti;
                    using (OleDbConnection conexion = BDcomun.ObtenerConexion())
                    {
                        OleDbCommand comando = new OleDbCommand(string.Format(
                            "Select Id, Fecha, Direccion, Hora, Titulo from Historial"), conexion);
                        OleDbDataReader reader = comando.ExecuteReader();
                        while (reader.Read())
                        {
                            id = ex.ToString();
                            fe = reader.GetString(1);
                            ur = reader.GetString(2);
                            ho = reader.GetString(3);
                            ti = reader.GetString(4);
                            idd.Add(id);
                            Urll.Add(ur);
                            Historial.Add("         " + id + ") " + ho + "-" + ti + " (" + ur + ")   " + fe);


                        }
                        conexion.Close();
                    }

                }
            }


            toolStripComboBox1.Size = new Size(this.Width - 490, 23);
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += Web_DocumentComplete;
            web.FileDownload += webBrowser1_FileDownload;
            web.NewWindow += new System.ComponentModel.CancelEventHandler(webBrowser1_NewWindow);
            web.Navigated += web_Navigated;
            tabControl1.TabPages.Add("SILA");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            tabControl1.SelectedTab.Click += tab_click;
            web.Navigate(urlk);
            i += 1;
            web.Focus();



            using (OleDbConnection conexion = BDcomun.ObtenerConexion())
            {
                OleDbCommand comando = new OleDbCommand(string.Format(
                    "Select Id, numero from nm where Id = {0}", 1), conexion);
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    N = reader.GetInt32(1);
                }
                conexion.Close();
            }

            string urll;
            
                using (OleDbConnection conexion = BDcomun.ObtenerConexion())
                {
                    OleDbCommand comando = new OleDbCommand(string.Format(
                        "Select Id, url from favoritos"), conexion);
                    OleDbDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        urll = reader.GetString(1);
                        lista.Add(urll);
                    }
                    conexion.Close();
                }

            toolStripComboBox1.Items.Clear();

            foreach (string pagina in lista)
            {
                toolStripComboBox1.Items.Add(pagina);

            }
            trayBar.BalloonTipText = "Navegador SILA \n\nOpciones\n" +
                "Borre el historial periódicamente para aumentar la velocidad del navegador";
            trayBar.BalloonTipTitle = "Bienvenido(a)";
            trayBar.BalloonTipIcon = ToolTipIcon.Info;
            trayBar.ShowBalloonTip(5000);
        }
        void Web_DocumentComplete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            using (OleDbConnection conexion = BDcomun.ObtenerConexion())
            {
                OleDbCommand comando = new OleDbCommand(string.Format(
                    "Select Id, hist from nm where Id = {0}", 1), conexion);
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    N = reader.GetInt32(1);
                }
                conexion.Close();
            }

            string id;
            string fe;
            string ur;
            string ho;
            string ti;


            using (OleDbConnection conexion = BDcomun.ObtenerConexion())
            {
                OleDbCommand comando = new OleDbCommand(string.Format(
                    "Select Id, Fecha, Direccion, Hora, Titulo from Historial where Id = {0}", N), conexion);
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    id = ex.ToString();
                    fe = reader.GetString(1);
                    ur = reader.GetString(2);
                    ho = reader.GetString(3);
                    ti = reader.GetString(4);
                    ridd.Add(id);
                    rUrll.Add(ur);
                    rHistorial.Add("         " + "(Reciente)" + ho + "-" + ti + " (" + ur + ")   " + fe);


                }
                conexion.Close();
            }







            HtmlElementCollection links = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Document.Links;
            foreach (HtmlElement var in links)
            {
                var.AttachEventHandler("onclick", LinkClicked);
            }

            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
            this.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
            cancel = false;
            toolStripMenuItem3.BackgroundImage = Image.FromFile(@"Icono1.png");
            string h = DateTime.Now.Hour.ToString(), m = DateTime.Now.Minute.ToString();
            if (h.Length < 2)
            {
                h = "0" + h;
            }
            if (m.Length < 2)
            {
                h = "0" + h;
            }


            string Fecha = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year, hora = h + ":" + m;

            using (OleDbConnection conexion = BDcomun.ObtenerConexion())
            {
                OleDbCommand comando = new OleDbCommand(string.Format(
                    "Select Id, hist from nm where Id = {0}", 1), conexion);
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    N = reader.GetInt32(1);
                }
                conexion.Close();
            }
            int retorno = 0;
            using (OleDbConnection conexion = BDcomun.ObtenerConexion())
            {
                OleDbCommand Comando = new OleDbCommand(string.Format("Update nm set hist = '{0}' where Id = {1}",
                    (N + 1), 1), conexion);
                retorno = Comando.ExecuteNonQuery();
                conexion.Close();
            }
            if (retorno >= 1)
            {
                try
                {

                    using (OleDbConnection conn = BDcomun.ObtenerConexion())
                    {
                        OleDbCommand Comando = new OleDbCommand(String.Format("Insert Into Historial (Fecha, Direccion, Hora, Titulo) Values ('{0}', '{1}', '{2}', '{3}')",
                        Fecha, Convert.ToString(((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url), hora, ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Document.Title), conn);
                        Comando.ExecuteNonQuery();
                        Comando.Dispose();
                        conn.Close();
                    }


                }
                catch (Exception)
                {
                    return;
                }
            }




        }

        private void LinkClicked(object sender, EventArgs e)
        {

            HtmlElement link = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Document.ActiveElement;
            url = link.GetAttribute("href");
        }
        void web_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {



            cancel = true;
            toolStripMenuItem3.BackgroundImage = Image.FromFile(@"Icono13.png");

            int ef = 0;
            foreach (string list in lista)
            {
                if (toolStripComboBox1.Text == list)
                {
                    toolStripMenuItem4.BackgroundImage = Image.FromFile(@"Icono9.png");
                    ef = 1;
                }
            }
            if (ef == 0)
            {
                toolStripMenuItem4.BackgroundImage = Image.FromFile(@"Icono8.png");
            }

            if (((WebBrowser)tabControl1.SelectedTab.Controls[0]).CanGoBack == false)
            {

                toolStripMenuItem2.BackgroundImage = Image.FromFile(@"Icono11.png");
            }
            else
            {
                toolStripMenuItem2.BackgroundImage = Image.FromFile(@"Icono2.png");
            }
            if (((WebBrowser)tabControl1.SelectedTab.Controls[0]).CanGoForward == false)
            {
                toolStripMenuItem1.BackgroundImage = Image.FromFile(@"Icono10.png");
            }
            else
            {
                toolStripMenuItem1.BackgroundImage = Image.FromFile(@"Icono3.png");
            }
            toolStripComboBox1.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url.ToString();
        }
        void tab_click(object sender, EventArgs e)
        {

        }

        private void gOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {

                if (toolStripComboBox1.Text == "Historial")
                {
                    toolStripMenuItem3.PerformClick();
                }
                else
                {
                    tabControl1.BringToFront();
                    historial.Controls.Clear();
                    pirm = false;
                    idd.Clear();
                    Urll.Clear();
                    Historial.Clear();
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.Text);
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Focus();
                }
            }

            else if (toolStripComboBox1.Text == "Historial")
            {
                historialToolStripMenuItem1.PerformClick();
            }
            else
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.Text);
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Focus();
        }

        private void adressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Focus();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Focus();
            toolStripComboBox1.Text = "";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;
                idd.Clear();
                Urll.Clear();
                Historial.Clear();
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url);
            }

            else
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (historial.Controls.Count == 0)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                pirm = false;
                historial.Controls.Clear();

                Button btn1 = new Button();
                btn1.Font = button4.Font;
                btn1.Click += button4_Click;
                btn1.FlatStyle = FlatStyle.Popup;
                btn1.Text = "Regresar";
                btn1.Size = new Size(90, 30);
                btn1.MaximumSize = new Size(90, 30);
                btn1.BackColor = Color.Transparent;
                historial.Controls.Add(btn1);
                btn1.Location = new Point(0, 0);
                btn1.Dock = DockStyle.Right;

                Button btn2 = new Button();
                btn2.Font = button3.Font;
                btn2.Click += button3_Click;
                btn2.FlatStyle = FlatStyle.Popup;
                btn2.Text = button3.Text;
                btn2.Size = new Size(140, 30);
                btn2.MaximumSize = new Size(140, 30);
                btn2.BackColor = Color.Transparent;
                historial.Controls.Add(btn2);
                btn2.Location = new Point(0, 0);
                btn2.Dock = DockStyle.Right;
                btn2.BringToFront();

                Button antig = new Button();
                antig.Font = button3.Font;
                antig.Click += atras_Click;
                antig.FlatStyle = FlatStyle.Popup;
                antig.Text = "Más antiguo";
                antig.Size = new Size(120, 30);
                antig.MaximumSize = new Size(120, 30);
                antig.BackColor = Color.Transparent;
                historial.Controls.Add(antig);
                antig.Location = new Point(0, 0);
                antig.Dock = DockStyle.Right;
                antig.BringToFront();

                Label lb = new Label();
                lb.Font = label1.Font;

                lb.Text = label1.Text;
                lb.BackColor = Color.Transparent;
                lb.Size = label1.Size;
                historial.Controls.Add(lb);
                lb.Location = new Point(0, 0);
                lb.Dock = DockStyle.Top;
                lb.BringToFront();

                int fore = ridd.Count - 1;
                if (fore >= 0)
                {
                    foreach (string ii in ridd)
                    {
                        Label lab = new Label();
                        lab.Text = rHistorial[fore];
                        lab.Tag = rUrll[fore];
                        lab.Click += muse_Click;
                        lab.Dock = DockStyle.Top;
                        lab.Font = button3.Font;
                        lab.ForeColor = Color.Green;
                        historial.Controls.Add(lab);
                        lab.Show();
                        lab.BringToFront();
                        fore--;
                        if (fore == 0)
                        {
                            break;
                        }
                    }
                }

                int z = 0;

                if (N > 0)
                {
                    int d = 0;
                    int cont = 0;

                    while (true)
                    {




                        Label lab = new Label();
                        lab.Text = Historial[d];
                        lab.Tag = Urll[d];
                        lab.Click += muse_Click;
                        lab.Dock = DockStyle.Top;
                        lab.Font = button3.Font;
                        if (z == 0)
                        {
                            lab.ForeColor = Color.DodgerBlue;
                            z = 1;
                        }
                        else
                        {
                            lab.ForeColor = Color.Black;
                            z = 0;
                        }
                        historial.Controls.Add(lab);
                        lab.Show();
                        lab.BringToFront();
                        d++;
                        if (d == 400)
                        {
                            break;
                        }
                        if (d == N)
                        {
                            break;
                        }
                        cont++;
                        if (cont == 30)
                        {
                            break;
                        }


                    }
                }
            }
            else
            {

                if (cancel == false)
                {
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Update();
                }
                else
                {
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Stop();
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
                }
            }
        }

        private void adressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://www.google.com.co/");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conexion = BDcomun.ObtenerConexion())
            {
                OleDbCommand comando = new OleDbCommand(string.Format(
                    "Select Id, numero from nm where Id = {0}", 1), conexion);
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    N = reader.GetInt32(1);
                }
                conexion.Close();
            }
            int retorno = 0;
            using (OleDbConnection conexion = BDcomun.ObtenerConexion())
            {
                OleDbCommand Comando = new OleDbCommand(string.Format("Update nm set numero = '{0}' where Id = {1}",
                    (N + 1), 1), conexion);
                retorno = Comando.ExecuteNonQuery();
                conexion.Close();
            }
            if (retorno >= 1)
            {
                try
                {

                    using (OleDbConnection conn = BDcomun.ObtenerConexion())
                    {
                        OleDbCommand Comando = new OleDbCommand(String.Format("Insert Into favoritos (url) Values ('{0}')",
                            Convert.ToString(((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url)), conn);
                        Comando.ExecuteNonQuery();
                        Comando.Dispose();
                        conn.Close();
                    }
                    lista.Add(Convert.ToString(((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url));


                    toolStripComboBox1.Items.Clear();

                    foreach (string pagina in lista)
                    {
                        toolStripComboBox1.Items.Add(pagina);

                    }
                    toolStripMenuItem4.BackgroundImage = Image.FromFile(@"Icono9.png");
                }
                catch (Exception)
                {
                    MessageBox.Show("Éste sitio ya se encuentra en Favoritos", "¡Ya se ha guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void nuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }
            agregar = true;
            toolStripComboBox1.Size = new Size(this.Width - 490, 23);
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += Web_DocumentComplete;
            web.Navigated += web_Navigated;
            tabControl1.TabPages.Add("SILA");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            tabControl1.SelectedTab.Click += tab_click;
            web.Navigate("https://www.google.com.co/");
            i += 1;
            web.Focus();

            toolStripMenuItem2.BackgroundImage = Image.FromFile(@"Icono11.png");
            toolStripMenuItem1.BackgroundImage = Image.FromFile(@"Icono10.png");


        }

        private void cerrarPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }
            if (tabControl1.TabPages.Count - 1 > 0)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://www.google.com.co/");
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
            else
            {
                this.Close();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            toolStripComboBox1.Size = new Size(this.Width - 488, 23);
        }

        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (historial.Controls.Count > 0)
                {

                    if (toolStripComboBox1.Text == "Historial")
                    {
                        toolStripMenuItem3.PerformClick();
                    }
                    else
                    {
                        tabControl1.BringToFront();
                        historial.Controls.Clear();
                        pirm = false;

                        ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.Text);
                        ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Focus();
                    }
                }

                else if (toolStripComboBox1.Text == "Historial")
                {
                    historialToolStripMenuItem1.PerformClick();
                }
                else
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.Text);
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Focus();

            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (historial.Controls.Count > 0)
            {

                if (toolStripComboBox1.Text == "Historial")
                {
                    toolStripMenuItem3.PerformClick();
                }
                else
                {
                    tabControl1.BringToFront();
                    historial.Controls.Clear();
                    pirm = false;

                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.SelectedItem.ToString());
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Focus();
                }
            }

            else if (toolStripComboBox1.Text == "Historial")
            {
                historialToolStripMenuItem1.PerformClick();
            }
            else
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.SelectedItem.ToString());
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Focus();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (agregar == true)
            {
                agregar = false;
            }
            else
            {
                toolStripComboBox1.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url.ToString();
                tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
                this.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;

                int ef = 0;
                foreach (string list in lista)
                {
                    if (toolStripComboBox1.Text == list)
                    {
                        toolStripMenuItem4.BackgroundImage = Image.FromFile(@"Icono9.png");
                        ef = 1;
                    }
                }
                if (ef == 0)
                {
                    toolStripMenuItem4.BackgroundImage = Image.FromFile(@"Icono8.png");
                }

                if (((WebBrowser)tabControl1.SelectedTab.Controls[0]).CanGoBack == false)
                {

                    toolStripMenuItem2.BackgroundImage = Image.FromFile(@"Icono11.png");
                }
                else
                {
                    toolStripMenuItem2.BackgroundImage = Image.FromFile(@"Icono2.png");
                }
                if (((WebBrowser)tabControl1.SelectedTab.Controls[0]).CanGoForward == false)
                {
                    toolStripMenuItem1.BackgroundImage = Image.FromFile(@"Icono10.png");
                }
                else
                {
                    toolStripMenuItem1.BackgroundImage = Image.FromFile(@"Icono3.png");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://www.facebook.com/");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://www.youtube.com/");

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("http://mastkd.com/");

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("http://www.worldtaekwondofederation.net/");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("http://www.ligataekwondobogota.org/");

        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=12&ct=1450309992&rver=6.4.6456.0&wp=MBI_SSL_SHARED&wreply=https:%2F%2Fmail.live.com%2Fdefault.aspx%3Frru%3Dinbox&lc=1033&id=64855&mkt=en-us&cbcxt=mai");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (historial.Controls.Count > 0)
            {
                tabControl1.BringToFront();
                historial.Controls.Clear();
                pirm = false;

            }
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("https://translate.google.com/?hl=es");

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            zoom = zoom + 10;
            toolStripMenuItem9.Text = zoom + "%";
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url.ToString());
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            zoom = zoom - 10;
            toolStripMenuItem9.Text = zoom + "%";
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url.ToString());
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"Navegador");
        }

        private void nuevaPestañaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nuevaPestañaToolStripMenuItem.PerformClick();
        }

        private void historialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "Historial";
            this.Text = "Historial";
            toolStripMenuItem2.BackgroundImage = Image.FromFile(@"Icono2.png");
            toolStripMenuItem1.BackgroundImage = Image.FromFile(@"Icono10.png");
            if (historial.Controls.Count == 0)
            {
                Button btn1 = new Button();
                btn1.Font = button4.Font;
                btn1.Click += button4_Click;
                btn1.FlatStyle = FlatStyle.Popup;
                btn1.Text = "Regresar";
                btn1.Size = new Size(90, 30);
                btn1.MaximumSize = new Size(90, 30);
                btn1.BackColor = Color.Transparent;
                historial.Controls.Add(btn1);
                btn1.Location = new Point(0, 0);
                btn1.Dock = DockStyle.Right;

                Button btn2 = new Button();
                btn2.Font = button3.Font;
                btn2.Click += button3_Click;
                btn2.FlatStyle = FlatStyle.Popup;
                btn2.Text = button3.Text;
                btn2.Size = new Size(140, 30);
                btn2.MaximumSize = new Size(140, 30);
                btn2.BackColor = Color.Transparent;
                historial.Controls.Add(btn2);
                btn2.Location = new Point(0, 0);
                btn2.Dock = DockStyle.Right;
                btn2.BringToFront();

                Button antig = new Button();
                antig.Font = button3.Font;
                antig.Click += atras_Click;
                antig.FlatStyle = FlatStyle.Popup;
                antig.Text = "Más antiguo";
                antig.Size = new Size(120, 30);
                antig.MaximumSize = new Size(120, 30);
                antig.BackColor = Color.Transparent;
                historial.Controls.Add(antig);
                antig.Location = new Point(0, 0);
                antig.Dock = DockStyle.Right;
                antig.BringToFront();

                Label lb = new Label();
                lb.Font = label1.Font;

                lb.Text = label1.Text;
                lb.BackColor = Color.Transparent;
                lb.Size = label1.Size;
                historial.Controls.Add(lb);
                lb.Location = new Point(0, 0);
                lb.Dock = DockStyle.Top;
                lb.BringToFront();

                int fore = ridd.Count - 1;
                if (fore >= 0)
                {
                    foreach (string ii in ridd)
                    {
                        Label lab = new Label();
                        lab.Text = rHistorial[fore];
                        lab.Tag = rUrll[fore];
                        lab.Click += muse_Click;
                        lab.Dock = DockStyle.Top;
                        lab.Font = button3.Font;
                        lab.ForeColor = Color.Green;
                        historial.Controls.Add(lab);
                        lab.Show();
                        lab.BringToFront();
                        fore--;
                        if (fore <= 0)
                        {
                            break;
                        }
                    }
                }

                historial.BringToFront();
                int z = 0;

                if (N > 0)
                {
                    int d = 0;
                    int cont = 0;

                    while (true)
                    {

                        try
                        {
                            Label lab = new Label();
                            lab.Text = Historial[d];
                            lab.Tag = Urll[d];
                            lab.Click += muse_Click;
                            lab.Dock = DockStyle.Top;
                            lab.Font = button3.Font;
                            if (z == 0)
                            {
                                lab.ForeColor = Color.DodgerBlue;
                                z = 1;
                            }
                            else
                            {
                                lab.ForeColor = Color.Black;
                                z = 0;
                            }
                            historial.Controls.Add(lab);
                            lab.Show();
                            lab.BringToFront();
                            d++;
                            if (d == 400)
                            {
                                break;
                            }
                            if (d >= N)
                            {
                                break;
                            }
                            cont++;
                            if (cont == 30)
                            {
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error de historial");
                        }
                    }
                }


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.BringToFront();
            historial.Controls.Clear();
            pirm = false;

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int retorno;
            using (OleDbConnection conexion = BDcomun.ObtenerConexion())
            {
                OleDbCommand Comando = new OleDbCommand(string.Format("Update nm set hist = '{0}' where Id = {1}",
                    0, 1), conexion);
                retorno = Comando.ExecuteNonQuery();
                conexion.Close();
            }
            if (retorno >= 1)
            {
                using (OleDbConnection conexion = BDcomun.ObtenerConexion())
                {
                    OleDbCommand Comando = new OleDbCommand(string.Format("Drop table Historial"), conexion);
                    Comando.ExecuteNonQuery();
                    conexion.Close();
                }
                using (OleDbConnection con = BDcomun.ObtenerConexion())
                {
                    OleDbCommand Coman = new OleDbCommand(string.Format("Create table Historial (Id int identity (1,1) not null, Fecha text, Direccion text, Hora text, Titulo text)"), con);
                    Coman.ExecuteNonQuery();
                    Coman.Dispose();
                    con.Close();
                }
            }
            historial.Controls.Clear();
            Historial.Clear();
            rHistorial.Clear();
            idd.Clear();
            ridd.Clear();
            Urll.Clear();
            rUrll.Clear();
            N = 0;
            pirm = false;

            historialToolStripMenuItem1.PerformClick();
        }
        private void muse_Click(object sender, EventArgs e)
        {
            agregar = true;
            toolStripComboBox1.Size = new Size(this.Width - 490, 23);
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += Web_DocumentComplete;
            web.Navigated += web_Navigated;
            tabControl1.TabPages.Add("SILA");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            tabControl1.SelectedTab.Click += tab_click;

            i += 1;
            web.Focus();

            toolStripMenuItem2.BackgroundImage = Image.FromFile(@"Icono11.png");
            toolStripMenuItem1.BackgroundImage = Image.FromFile(@"Icono10.png");
            tabControl1.BringToFront();
            historial.Controls.Clear();
            pirm = false;

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(((Label)sender).Tag.ToString());
        }
        private void atras_Click(object sender, EventArgs e)
        {

            if (pirm == false)
            {

                ((Button)sender).Text = "Ver Menos";
                pirm = true;
                int z = 0;
                if (N > 30)
                {
                    int d = 30;



                    while (true)
                    {


                        Label lab = new Label();
                        lab.Text = Historial[d];
                        lab.Tag = Urll[d];
                        lab.Click += muse_Click;
                        lab.Dock = DockStyle.Top;
                        lab.Font = button3.Font;
                        if (z == 0)
                        {
                            lab.ForeColor = Color.DodgerBlue;
                            z = 1;
                        }
                        else
                        {
                            lab.ForeColor = Color.Black;
                            z = 0;
                        }
                        historial.Controls.Add(lab);
                        lab.Show();
                        lab.BringToFront();
                        d++;
                        if (d == N)
                        {
                            break;
                        }
                        if (d == 400)
                        {
                            break;
                        }



                    }
                }

            }
            else
            {

                toolStripMenuItem3.PerformClick();
            }



        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {

            e.Cancel = true;
            Form1 f1 = new Form1();

            f1.urlk = url;
            f1.Historial = Historial;
            f1.rHistorial = rHistorial;
            f1.idd = idd;
            f1.ridd = ridd;
            f1.Urll = Urll;
            f1.rUrll = rUrll;
            f1.N = N;
            f1.seg = true;


            f1.Show();


        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {

        }

        private void trayBar_DoubleClick(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                trayBar.Visible = false;
            }
        }

        private void ocultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ocultarToolStripMenuItem.Text == "Ocultar")
            {
                panel3.Hide();
                ocultarToolStripMenuItem.Text = "Mostrar";
            }
            else
            {
                panel3.Show();
                ocultarToolStripMenuItem.Text = "Ocultar";
            }
        }

        private void brrarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int retorno;
            using (OleDbConnection conexion = BDcomun.ObtenerConexion())
            {
                OleDbCommand Comando = new OleDbCommand(string.Format("Update nm set hist = '{0}' where Id = {1}",
                    0, 1), conexion);
                retorno = Comando.ExecuteNonQuery();
                conexion.Close();
            }
            if (retorno >= 1)
            {
                using (OleDbConnection conexion = BDcomun.ObtenerConexion())
                {
                    OleDbCommand Comando = new OleDbCommand(string.Format("Drop table Historial"), conexion);
                    Comando.ExecuteNonQuery();
                    conexion.Close();
                }
                using (OleDbConnection con = BDcomun.ObtenerConexion())
                {
                    OleDbCommand Coman = new OleDbCommand(string.Format("Create table Historial (Id int identity (1,1) not null, Fecha text, Direccion text, Hora text, Titulo text)"), con);
                    Coman.ExecuteNonQuery();
                    Coman.Dispose();
                    con.Close();
                }
            }
            historial.Controls.Clear();
            Historial.Clear();
            rHistorial.Clear();
            idd.Clear();
            ridd.Clear();
            Urll.Clear();
            rUrll.Clear();
            N = 0;
            pirm = false;

            historialToolStripMenuItem1.PerformClick();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade ac = new Acercade();
            ac.ShowDialog();
        }
        private void Reproductor_FormClosing(object sender, FormClosingEventArgs e)
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
}
