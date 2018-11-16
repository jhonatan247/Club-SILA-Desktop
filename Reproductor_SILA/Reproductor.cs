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
using System.Diagnostics;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Net;
using System.Deployment;
using System.Collections;
using System.CodeDom;
using System.Dynamic;
using System.Xml.XmlConfiguration;
#endregion

#region SILA
namespace Reproductor_SILA
{
    #region Program
    public partial class Reproductor : Form
    {
        #region Atributos
        Acercade acer = new Acercade();
        string Mus = "";
        Random CancionRandom = new Random();
        public bool SILA = false;
        int timerr = 0;
        int totalC = 0, num = 0;
        List<String> nombres = new List<string>();
        bool valor = false, aleatorio = false, repetir = false, pause = true;
        #endregion

        #region Constructor
        public Reproductor()
        {
            InitializeComponent();
        }
        #endregion

        #region LOAD
        private void prueba_Load(object sender, EventArgs e)
        {
            BOO();
            try
            {
                opcionesToolStripMenuItem1.DropDown = contextMenuStrip1;
                ModifyProgressBarColor.SetState(progressBar2, 1);
                ModifyProgressBarColor.SetState(progressBar1, 3);
                dataGridView1.Visible = false;
                tmrFR.Interval = 100;
                trackBar2.Value = 100;
                axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
                label4.Text = "Volumen: " + trackBar2.Value + " %";
                timer1.Interval = 100;
                progressBar1.Value = trackBar2.Value;
            }
            catch (Exception ex)
            {
            }

            if (SILA == true)
            {
                SIL();
            }
            else
            {
                NSIL();
            }


        }
        #endregion load

        #region Métodos

        private void QACanciones()
        {
            int boo = 0;
            using (OleDbConnection conexion = BDComun.ObtenerConexion8())
            {
                try
                {
                    OleDbCommand comando2 = new OleDbCommand(string.Format(
                            "Select bool from Def where Id = {0}", 1), conexion);
                    OleDbDataReader reader = comando2.ExecuteReader();

                    while (reader.Read())
                    {
                        boo = reader.GetInt32(0);
                    }
                    comando2.Dispose();
                }
                catch (Exception ex)
                {

                }
            }
            if (boo == 0)
            {
                int resultado = 0;
                using (OleDbConnection conexion = BDComun.ObtenerConexion8())
                {
                    try
                    {
                        OleDbCommand comando2 = new OleDbCommand(string.Format(
                                "update Def set bool = '{0}' where Id = {1}", 1, 1), conexion);
                        resultado = comando2.ExecuteNonQuery();
                        comando2.Dispose();
                        conexion.Close();

                    }
                    catch (Exception ex)
                    {

                    }
                    if (resultado > 0)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("No se logró acceder a las canciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                int resultado = 0;
                using (OleDbConnection conexion = BDComun.ObtenerConexion8())
                {
                    try
                    {
                        OleDbCommand comando2 = new OleDbCommand(string.Format(
                                "update Def set bool = {0} where Id = {1}", 0, 1), conexion);
                        resultado = comando2.ExecuteNonQuery();
                        comando2.Dispose();
                        conexion.Close();

                    }
                    catch (Exception ex)
                    {

                    }
                    if (resultado > 0)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("No se logró acceder a las canciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void NSIL()
        {
            try
            {
                Int32 id = 0;


                using (OleDbConnection conexion = BDComun.ObtenerConexion8())
                {
                    try
                    {
                        OleDbCommand comando2 = new OleDbCommand(string.Format(
                                "Select N from N where Id = {0}", 1), conexion);
                        OleDbDataReader reader = comando2.ExecuteReader();

                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                        comando2.Dispose();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                if (id > 0)
                {
                    int i = 1;
                    while (true)
                    {
                        try
                        {
                            Musica MS = new Musica();
                            try
                            {
                                MS = MusicaDAL.ObtenerDeportista(i);
                            }
                            catch (Exception)
                            {

                            }


                            if (MS.Url == "" | MS.Url == null | MS.Url == " ")
                            {

                                id++;
                            }
                            else
                            {
                                nombres.Add(MS.Url);
                                dataGridView1.Rows.Add(num, MS.Url);
                                num++;
                                totalC = totalC + 1;
                            }

                            if (i >= id)
                            {
                                break;
                            }
                            i++;
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                    valor = false;
                    //For Each str1 As String In OpenMedia.FileNames
                    //    Play_List.ListBox1.Items.Add(str1)
                    //Next

                    timerr = CancionRandom.Next(0, (totalC - 1));
                    bool timer = false;
                    int contador = 0;
                    if (nombres.Count > 1)
                    {
                        while (true)
                        {
                            try
                            {
                                contador++;
                                if (contador > totalC)
                                {
                                    MessageBox.Show("LOS ARCHIVOS EN LISTA NO EXISTEN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                                }
                                if (System.IO.File.Exists(nombres[timerr]))
                                {
                                    dataGridView1.Rows[timerr].Selected = true;
                                    pause = true;
                                    axWindowsMediaPlayer1.URL = nombres[timerr];
                                    trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                                    progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                                    label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                                    label1.Text = axWindowsMediaPlayer1.URL;
                                    timerr = timerr + 1;
                                    timer2.Enabled = true;

                                    break;
                                }
                                else
                                {
                                    if (timerr <= 0)
                                    {
                                        timer = false;
                                    }
                                    if (timerr >= (totalC - 1))
                                    {
                                        timer = true;
                                    }
                                    if (timer == false)
                                    {
                                        timerr++;
                                    }
                                    if (timer == true)
                                    {
                                        timerr--;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                    else if (nombres.Count == 1)
                    {
                        try
                        {
                            if (System.IO.File.Exists(nombres[0]))
                            {
                                pause = true;
                                axWindowsMediaPlayer1.URL = nombres[0];
                                trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                                progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                                label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                                label1.Text = axWindowsMediaPlayer1.URL;
                                dataGridView1.Rows[0].Selected = true;
                                timer2.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("EL ARCHIVO " + nombres[0] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            timerr = timerr + 1;
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }
        private void SIL()
        {
            try
            {
                using (OleDbConnection conexion = BDComun.ObtenerConexion8())
                {

                    OleDbCommand comando2 = new OleDbCommand(string.Format(
                            "Drop table SILA"), conexion);
                    comando2.ExecuteNonQuery();
                    comando2.Dispose();
                }
                using (OleDbConnection con2 = BDComun.ObtenerConexion8())
                {
                    OleDbCommand Coman = new OleDbCommand(string.Format("Create table SILA (Id int identity (1,1) not null, Url text unique)"), con2);
                    Coman.ExecuteNonQuery();
                    Coman.Dispose();
                    con2.Close();
                }
            }
            catch (Exception)
            {

            }
            Int32 id = 0;
            string[] listaMusica = Directory.GetFiles(@"Rock/", "*.mp3");


            using (OleDbConnection conexion = BDComun.ObtenerConexion8())
            {
                try
                {
                    OleDbCommand comando2 = new OleDbCommand(string.Format(
                            "Select N from N where Id = {0}", 1), conexion);
                    OleDbDataReader reader = comando2.ExecuteReader();

                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                    comando2.Dispose();
                }
                catch (Exception ex)
                {

                }
            }

            if (id > 0)
            {

                int i = 1;
                while (true)
                {

                    Musica MS = new Musica();
                    try
                    {
                        MS = MusicaDAL.ObtenerDeportista(i);
                    }
                    catch (Exception ex)
                    {

                    }


                    if (MS.Url == "" | MS.Url == null | MS.Url == " ")
                    {

                        id++;
                    }
                    else
                    {
                        try
                        {
                            nombres.Add(MS.Url);
                            dataGridView1.Rows.Add(num, MS.Url);
                            num++;
                            totalC = totalC + 1;
                        }
                        catch (Exception ex)
                        {

                        }
                    }

                    if (i >= id)
                    {
                        break;
                    }
                    i++;

                }

            }
            valor = false;
            //For Each str1 As String In OpenMedia.FileNames
            //    Play_List.ListBox1.Items.Add(str1)
            //Next
            foreach (string Str in listaMusica)
            {
                try
                {
                    nombres.Add(Str);
                    dataGridView1.Rows.Add(num, Str);
                    num++;
                    totalC = totalC + 1;

                    using (OleDbConnection conn = BDComun.ObtenerConexion8())
                    {
                        try
                        {
                            OleDbCommand Comando = new OleDbCommand(String.Format("Insert Into SILA (Url) values ('{0}')",
                                Str), conn);

                            Comando.ExecuteNonQuery();
                            Comando.Dispose();
                        }
                        catch (Exception)
                        {

                        }
                    }


                }
                catch (Exception ex)
                {

                }

            }

            timerr = CancionRandom.Next(0, (totalC - 1));
            bool timer = false;
            int contador = 0;
            if (nombres.Count > 1)
            {
                while (true)
                {
                    try
                    {
                        contador++;
                        if (contador > totalC)
                        {
                            MessageBox.Show("LOS ARCHIVOS EN LISTA NO EXISTEN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                        if (System.IO.File.Exists(nombres[timerr]))
                        {
                            pause = true;
                            dataGridView1.Rows[timerr].Selected = true;
                            axWindowsMediaPlayer1.URL = nombres[timerr];
                            trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                            progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                            label1.Text = axWindowsMediaPlayer1.URL;
                            timerr = timerr + 1;
                            timer2.Enabled = true;

                            break;
                        }
                        else
                        {
                            if (timerr <= 0)
                            {
                                timer = false;
                            }
                            if (timerr >= (totalC - 1))
                            {
                                timer = true;
                            }
                            if (timer == false)
                            {
                                timerr++;
                            }
                            if (timer == true)
                            {
                                timerr--;
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            else if (nombres.Count == 1)
            {
                try
                {
                    if (System.IO.File.Exists(nombres[0]))
                    {
                        pause = true;
                        axWindowsMediaPlayer1.URL = nombres[0];
                        trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                        progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                        label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                        label1.Text = axWindowsMediaPlayer1.URL;
                        dataGridView1.Rows[0].Selected = true;
                        timer2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("EL ARCHIVO " + nombres[0] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    timerr = timerr + 1;
                }
                catch (Exception ex)
                {

                }



            }
        }
        private void BOO()
        {
            int boo = 0;
            using (OleDbConnection conexion = BDComun.ObtenerConexion8())
            {
                try
                {
                    OleDbCommand comando2 = new OleDbCommand(string.Format(
                            "Select bool from Def where Id = {0}", 1), conexion);
                    OleDbDataReader reader = comando2.ExecuteReader();

                    while (reader.Read())
                    {
                        boo = reader.GetInt32(0);
                    }
                    comando2.Dispose();
                }
                catch (Exception ex)
                {

                }
            }
            if (boo == 0)
            {
                SILA = true;
            }
            else
            {
                SILA = false;
            }
        }
        private void GetOpenMedia()
        {

            OpenFileDialog OpenMedia = new OpenFileDialog();
            OpenMedia.InitialDirectory = System.Environment.SpecialFolder.CommonMusic.ToString();
            OpenMedia.FileName = "";
            OpenMedia.Multiselect = false;
            OpenMedia.Filter = "Media Files (*.wav;*.snd;*.au;*.aif;*.aifc;*.aiff;*.wma;*.mp2;*.mp3;*.adts;*.adt;*.acc;*.MP4; *.MKV; *.AVI; *.DVD; *.MOV)|*.wav;*.snd;*.au;*.aif;*.aifc;*.aiff;*.wma;*.mp2;*.mp3;*.adts;*.adt;*.acc;*.MP4; *.MKV; *.AVI; *.DVD; *.MOV";
            if (OpenMedia.ShowDialog() == DialogResult.OK)
            {
                int res = MusicaDAL.Reestar();
                if (res > 0)
                {
                    SILA = false;
                    dataGridView1.Rows.Clear();
                    nombres.Clear();
                    totalC = 0;
                    num = 0;
                    axWindowsMediaPlayer1.URL = @"roja.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    label1.Text = "Reproductor SILA";
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timerr = 0;
                    tmrFR.Enabled = false;



                    timerr = 0;
                    num = 0;
                    totalC = 0;
                    tmrFR.Enabled = false;
                    dataGridView1.Rows.Clear();
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    nombres.Clear();
                    tmrFR.Enabled = false;
                    pause = true;



                    try
                    {
                        int agr = 0;
                        Musica Mu = new Musica();
                        Mu.Url = OpenMedia.FileName;
                        agr = MusicaDAL.Agregar(Mu);
                        if (agr > 0)
                        {

                            dataGridView1.Rows.Add(num, OpenMedia.FileName);
                            axWindowsMediaPlayer1.URL = OpenMedia.FileName;
                            trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                            progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                            nombres.Add(axWindowsMediaPlayer1.URL);
                            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                            timer1.Interval = 100;
                            timer2.Enabled = true;
                            label1.Text = axWindowsMediaPlayer1.URL;
                            timerr++;
                            num++;
                            totalC = totalC + 1;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
        private void Anterior()
        {
            if (nombres.Count > 0)
            {
                if (num >= 2)
                {
                    timerr = timerr - 2;
                    if (timerr == -1)
                    {
                        timerr = num - 1;
                    }
                    else if (timerr < -1)
                    {
                        timerr = num - 1;
                    }
                    if (System.IO.File.Exists(nombres[timerr]))
                    {
                        pause = true;
                        dataGridView1.Rows[timerr].Selected = true;
                        axWindowsMediaPlayer1.URL = nombres[timerr];
                        trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                        progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration); ;
                        label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                        label1.Text = axWindowsMediaPlayer1.URL;
                    }
                    else
                    {
                        MessageBox.Show("EL ARCHIVO " + nombres[timerr] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    timerr++;
                }
                else
                {
                    timerr = 0;

                    if (System.IO.File.Exists(nombres[timerr]))
                    {
                        pause = true;
                        dataGridView1.Rows[timerr].Selected = true;
                        axWindowsMediaPlayer1.URL = nombres[timerr];
                        trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                        progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration); ;
                        label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                        label1.Text = axWindowsMediaPlayer1.URL;
                    }
                    else
                    {
                        MessageBox.Show("EL ARCHIVO " + nombres[timerr] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    timerr++;

                }
            }
        }
        private void Reproducir()
        {
            if (System.IO.File.Exists(nombres[Convert.ToInt32(dataGridView1.CurrentRow.Index)]))
            {
                pause = true;
                dataGridView1.Rows[Convert.ToInt32(dataGridView1.CurrentRow.Index)].Selected = true;
                axWindowsMediaPlayer1.URL = nombres[Convert.ToInt32(dataGridView1.CurrentRow.Index)];
                trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration); ;
                label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                label1.Text = axWindowsMediaPlayer1.URL;
            }
            else
            {
                MessageBox.Show("EL ARCHIVO " + nombres[Convert.ToInt32(dataGridView1.CurrentRow.Index)] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            timerr = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + 1;
        }
        private void Siguiente()
        {
            if (nombres.Count > 0)
            {
                if (aleatorio == false && repetir == false)
                {
                    if (timerr >= totalC)
                    {
                        timerr = 0;
                    }

                    if (System.IO.File.Exists(nombres[timerr]))
                    {
                        pause = true;
                        dataGridView1.Rows[timerr].Selected = true;
                        axWindowsMediaPlayer1.URL = nombres[timerr];
                        trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                        progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration); ;
                        label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                        label1.Text = axWindowsMediaPlayer1.URL;
                    }
                    else
                    {
                        MessageBox.Show("EL ARCHIVO " + nombres[timerr] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    timerr = timerr + 1;
                }
                else if (repetir == true)
                {
                    timerr = timerr - 1;
                    if (System.IO.File.Exists(nombres[timerr]))
                    {
                        pause = true;
                        dataGridView1.Rows[timerr].Selected = true;
                        axWindowsMediaPlayer1.URL = nombres[timerr];
                        trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                        progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration); ;
                        label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                        label1.Text = axWindowsMediaPlayer1.URL;
                    }
                    else
                    {
                        MessageBox.Show("EL ARCHIVO " + nombres[timerr] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    timerr = timerr + 1;
                }
                else
                {
                    timerr = CancionRandom.Next(0, totalC - 1);
                    if (System.IO.File.Exists(nombres[timerr]))
                    {
                        pause = true;
                        dataGridView1.Rows[timerr].Selected = true;
                        axWindowsMediaPlayer1.URL = nombres[timerr];
                        trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                        progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration); ;
                        label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                        label1.Text = axWindowsMediaPlayer1.URL;
                    }
                    else
                    {
                        MessageBox.Show("EL ARCHIVO " + nombres[timerr] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    timerr = timerr + 1;
                }
            }
        }
        private void Retroceso()
        {
            if (!(axWindowsMediaPlayer1.Ctlcontrols.currentPosition <= 0))
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition - 1;
                if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition <= 0)
                {
                    tmrFR.Enabled = false;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }
            }
        }
        private void Segundos()
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pause = true;
            }
            else
            {
                pause = false;
            }

            trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
            label3.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            trackBar1.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
            progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
            progressBar2.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);

            if (Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition) + 1 == Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration))
            {
                valor = true;
            }

            if (valor == true)
            {
                valor = false;

                if (timerr >= totalC)
                {
                    timerr = 0;
                }
                else
                {


                    if (aleatorio == false && repetir == false)
                    {
                        if (System.IO.File.Exists(nombres[timerr]))
                        {
                            pause = true;
                            dataGridView1.Rows[timerr].Selected = true;
                            axWindowsMediaPlayer1.URL = nombres[timerr];
                            trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                            progressBar2.Maximum = trackBar1.Maximum;
                            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                            label1.Text = axWindowsMediaPlayer1.URL;
                        }
                        else
                        {
                            MessageBox.Show("EL ARCHIVO " + nombres[timerr] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        timerr = timerr + 1;
                    }
                    else if (repetir == true)
                    {
                        timerr = timerr - 1;
                        if (System.IO.File.Exists(nombres[timerr]))
                        {
                            pause = true;
                            dataGridView1.Rows[timerr].Selected = true;
                            axWindowsMediaPlayer1.URL = nombres[timerr];
                            trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                            progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration); ;
                            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                            label1.Text = axWindowsMediaPlayer1.URL;
                        }
                        else
                        {
                            MessageBox.Show("EL ARCHIVO " + nombres[timerr] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        timerr = timerr + 1;
                    }
                    else
                    {
                        timerr = CancionRandom.Next(0, totalC - 1);
                        if (System.IO.File.Exists(nombres[timerr]))
                        {
                            pause = true;
                            dataGridView1.Rows[timerr].Selected = true;
                            axWindowsMediaPlayer1.URL = nombres[timerr];
                            trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                            progressBar2.Maximum = trackBar1.Maximum;
                            label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                            label1.Text = axWindowsMediaPlayer1.URL;
                        }
                        else
                        {
                            MessageBox.Show("EL ARCHIVO " + nombres[timerr] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        timerr = timerr + 1;
                    }


                }
            }
        }
        private void mute()
        {
            if (axWindowsMediaPlayer1.settings.mute == false)
            {
                button7.BackColor = Color.Red;
                axWindowsMediaPlayer1.settings.mute = true;
                progressBar1.Value = 0;
                progressBar1.Value = 100;
                trackBar2.Value = 0;
                label4.Text = "Volumen: " + trackBar2.Value + " %";

            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                button7.BackColor = SystemColors.Highlight;
                progressBar1.Value = 0;
                trackBar2.Value = 100;
                label4.Text = "Volumen: " + trackBar2.Value + " %";

            }
        }
        private void Añadir()
        {
            tmrFR.Enabled = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            OpenFileDialog OpenMedia = new OpenFileDialog();
            OpenMedia.InitialDirectory = System.Environment.SpecialFolder.CommonMusic.ToString();
            OpenMedia.FileName = "";
            OpenMedia.Title = "Reproductor SILA";
            OpenMedia.Multiselect = true;
            OpenMedia.Filter = "Media Files (*.wav;*.snd;*.au;*.aif;*.aifc;*.aiff;*.wma;*.mp2;*.mp3;*.adts;*.adt;*.acc;*.MP4; *.MKV; *.AVI; *.DVD; *.MOV)|*.wav;*.snd;*.au;*.aif;*.aifc;*.aiff;*.wma;*.mp2;*.mp3;*.adts;*.adt;*.acc;*.MP4; *.MKV; *.AVI; *.DVD; *.MOV";
            if (OpenMedia.ShowDialog() == DialogResult.OK)
            {
                valor = false;
                //For Each str1 As String In OpenMedia.FileNames
                //    Play_List.ListBox1.Items.Add(str1)
                //Next

                foreach (string Str in OpenMedia.FileNames)
                {
                    try
                    {
                        int agr = 0;
                        Musica Mu = new Musica();
                        Mu.Url = Str;
                        agr = MusicaDAL.Agregar(Mu);
                        if (agr > 0)
                        {
                            nombres.Add(Str);
                            dataGridView1.Rows.Add(num, Str);
                            num++;
                            totalC = totalC + 1;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

                pause = true;
                axWindowsMediaPlayer1.URL = nombres[timerr];
                trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                label1.Text = axWindowsMediaPlayer1.URL;

                timerr = timerr + 1;
                timer2.Enabled = true;

            }
        }

        private void Lista()
        {
            if (dataGridView1.Visible == true)
            {
                opcionesToolStripMenuItem1.DropDown = contextMenuStrip1;
                tmrFR.Enabled = false;
                dataGridView2.Visible = false;
                dataGridView1.Visible = false;
                panel2.BringToFront();
                toolStripTextBox1.Text = "";


            }
            else
            {
                toolStripTextBox1.Text = "";
                opcionesToolStripMenuItem1.DropDown = contextMenuStrip1;
                tmrFR.Enabled = false;
                dataGridView1.Visible = true;
                dataGridView1.BringToFront();
            }
        }
        private void Limpiar()
        {
            int res = MusicaDAL.Reestar();
            if (res > 0)
            {
                dataGridView1.Rows.Clear();
                nombres.Clear();
                totalC = 0;
                num = 0;
                axWindowsMediaPlayer1.URL = @"roja.wav";

                axWindowsMediaPlayer1.Ctlcontrols.stop();
                label1.Text = "Reproductor SILA";
                timer1.Enabled = false;
                timer2.Enabled = false;
                timerr = 0;
                tmrFR.Enabled = false;
                SILA = false;
                trackBar1.Value = 0;
                progressBar2.Value = 0;
                progressBar2.Value = 100;
                label2.Text = "00:00";
                label3.Text = "00:00";
                MessageBox.Show("Lista de reproducción limpiada correctamente", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscar()
        {
            dataGridView2.Rows.Clear();
            opcionesToolStripMenuItem1.DropDown = contextMenuStrip2;
            tmrFR.Enabled = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView2.BringToFront();
            int data = 0;
            using (OleDbConnection conexion = BDComun.ObtenerConexion8())
            {
                OleDbCommand comando = new OleDbCommand(string.Format(
                    "Select * from Url where Url like '%{0}%'", toolStripTextBox1.Text), conexion);

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int idd = (reader.GetInt32(0) - 1);
                    dataGridView2.Rows.Add(idd, reader.GetString(1));
                }
                if (SILA == true)
                {
                    OleDbCommand comando2 = new OleDbCommand(string.Format(
                            "Select * from N where Id = {0}", 1), conexion);
                    OleDbDataReader reade2 = comando2.ExecuteReader();

                    while (reade2.Read())
                    {
                        data = reade2.GetInt32(1);
                    }
                    comando2.Dispose();

                    OleDbCommand comando3 = new OleDbCommand(string.Format(
                        "Select * from SILA where Url like '%{0}%'", toolStripTextBox1.Text), conexion);

                    OleDbDataReader reader3 = comando3.ExecuteReader();

                    while (reader3.Read())
                    {
                        int numbb = data + reader3.GetInt32(0);
                        dataGridView2.Rows.Add(numbb - 1, reader3.GetString(1));


                    }
                    conexion.Close();
                }

            }
            pantallaPrincipalToolStripMenuItem.Visible = true;
        }
        #endregion

        #region Eventos
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
        private void quitarAgregarListaDeCancionesPorDefectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QACanciones();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Se limpiará la Lista de reproducción", "¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    GetOpenMedia();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void listaDeReproducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantallaPrincipalToolStripMenuItem.Visible = false;
            dataGridView2.Visible = false;
            Lista();

        }



        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                axWindowsMediaPlayer1.Ctlcontrols.play();
                tmrFR.Enabled = false;
                pause = true;

            }
            catch (Exception ex)
            {
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                pause = false;
                tmrFR.Enabled = false;
                axWindowsMediaPlayer1.Ctlcontrols.pause();

            }
            catch (Exception ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tmrFR.Enabled = false;
                label3.Text = "00:00";
                axWindowsMediaPlayer1.Ctlcontrols.stop();

            }
            catch (Exception ex)
            {
            }
        }

        private void abrirVariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Añadiendo.....";
            try
            {
                Añadir();

            }
            catch (Exception ex)
            {

            }
            this.Text = "Reproductor SILA";
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pause = true;
            }
            else
            {
                pause = false;
            }

            try
            {
                trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                label3.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                trackBar1.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                progressBar2.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
            }
            catch (Exception ex)
            {

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != "")
            {
                try
                {
                    axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar1.Value;
                    progressBar2.Value = trackBar1.Value;

                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                trackBar1.Value = 0;
                progressBar2.Value = trackBar1.Value;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
                label4.Text = "Volumen: " + trackBar2.Value + " %";
                progressBar1.Value = trackBar2.Value;
                if (axWindowsMediaPlayer1.settings.volume == 0)
                {
                    button7.BackColor = Color.Red;
                }
                else
                {
                    button7.BackColor = SystemColors.Highlight;
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                mute();

            }
            catch (Exception ex)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                tmrFR.Enabled = false;
                axWindowsMediaPlayer1.Ctlcontrols.fastForward();


            }
            catch (Exception ex)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tmrFR.Enabled = true;

            }
            catch (Exception ex)
            {
            }
        }

        private void tmrFR_Tick(object sender, EventArgs e)
        {
            try
            {
                Retroceso();


            }
            catch (Exception ex)
            {
            }
        }

        private void abrirUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button8.PerformClick();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Segundos();


        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Reproducir();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una canción (Fila) para reproducir", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Siguiente();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Anterior();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            if (aleatorio == false)
            {
                button10.BackColor = Color.Gold;
                aleatorio = true;
            }
            else
            {
                button10.BackColor = SystemColors.Highlight;
                aleatorio = false;
            }

        }

        private void dataGridView1_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            reproducirToolStripMenuItem.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (repetir == false)
            {
                button11.BackColor = Color.Gold;
                repetir = true;
            }
            else
            {
                button11.BackColor = SystemColors.Highlight;
                repetir = false;
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int remov = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Int32 res = MusicaDAL.Eliminar(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value));
                if (res > 0)
                {
                    dataGridView1.Rows.RemoveAt(remov);
                    nombres.RemoveAt(remov);
                    totalC--;
                    num--;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una canción (Fila) para eliminar", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se limpiará la Lista de reproducción", "¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            reproducirToolStripMenuItem.PerformClick();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Buscar();

        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            opcionesToolStripMenuItem1.DropDown = contextMenuStrip1;
            tmrFR.Enabled = false;
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            panel2.BringToFront();
            pantallaPrincipalToolStripMenuItem.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                if (System.IO.File.Exists(nombres[Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value)]))
                {
                    pause = true;
                    dataGridView2.Rows[dataGridView2.CurrentRow.Index].Selected = true;
                    dataGridView1.Rows[dataGridView2.CurrentRow.Index].Selected = true;
                    axWindowsMediaPlayer1.URL = nombres[Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value)];
                    trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
                    progressBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration); ;
                    label2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                    label1.Text = axWindowsMediaPlayer1.URL;
                }
                else
                {
                    MessageBox.Show("EL ARCHIVO " + nombres[Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value)] + " NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                timerr = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) + 1;



            }
            else
            {
                MessageBox.Show("Debe seleccionar una canción (Fila) para reproducir", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            toolStripMenuItem2.PerformClick();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                toolStripMenuItem1.PerformClick();
            }
        }

        private void Reproductor_SizeChanged(object sender, EventArgs e)
        {
            toolStripTextBox1.Size = new Size(this.Width - (listaDeReproducciónToolStripMenuItem.Width + abrirToolStripMenuItem.Width + 270), 23);
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (acer.Visible == false)
            {
                acer.ShowDialog();
            }
        }

        private void Reproductor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                try
                {
                    if (pause == false)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        tmrFR.Enabled = false;
                        pause = true;
                    }
                    else if (pause == true)
                    {
                        pause = false;
                        tmrFR.Enabled = false;
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                    }

                }
                catch (Exception ex)
                {
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
        }
        private void button10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                try
                {
                    if (pause == false)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        tmrFR.Enabled = false;
                        pause = true;
                    }
                    else if (pause == true)
                    {
                        pause = false;
                        tmrFR.Enabled = false;
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                    }

                }
                catch (Exception ex)
                {
                }
            }
        }
        private void axWindowsMediaPlayer1_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            if (e.nButton == 1)
            {
                try
                {
                    if (pause == false)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        tmrFR.Enabled = false;
                        pause = true;
                    }
                    else if (pause == true)
                    {
                        pause = false;
                        tmrFR.Enabled = false;
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        #endregion 
    }
    #endregion
}
#endregion
#endregion