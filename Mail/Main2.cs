using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using System.Net.Mail;
using GmailAPI;
using GvS;
using System.Data.OleDb;

namespace Mail
{
    public partial class Main2 : Form
    {
        bool Otros = false;
        int prueba = 0;
        private bool _browserReady = false;
        string username, password, para;
        string attachfilepatch;
        MailMessage mail = new MailMessage();
        public Main2()
        {
            InitializeComponent();
        }

        private void WaitUntilBrowserReady()
        {
            if (this._browserReady)
            {
                return;
            }
            for (int i = 0; i < 60 && !this._browserReady; i++)
            {
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login2 l = new Login2();
            To T = new To();
            l.ShowDialog();
            T.ShowDialog();
            label1.Text = Properties.Settings.Default.Username2;
            Text += " (" + Properties.Settings.Default.Username2 + ")"; 
            username = Properties.Settings.Default.Username2;
            password = Properties.Settings.Default.PassWord2;
            para = Properties.Settings.Default.Correos;
            Buscar();
        }
        private void Buscar()
        {
            mail = new MailMessage();
            txtTo.Text = "";
            switch (para)
            {
                case "T":
                    try
                    {
                        txtTo.Enabled = false;
                        txtTo.Text = "aplicacionsila@hotmail.com";
                        mail.To.Add(new MailAddress(txtTo.Text));
                        A();
                        C();
                        D();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case "CD":
                    try
                    {
                        txtTo.Enabled = false;
                        txtTo.Text = "aplicacionsila@hotmail.com";
                        mail.To.Add(new MailAddress(txtTo.Text));
                        C();
                        D();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case "CA":
                    try
                    {
                        txtTo.Enabled = false;
                        txtTo.Text = "aplicacionsila@hotmail.com";
                        mail.To.Add(new MailAddress(txtTo.Text));
                        A();
                        C();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case "AD":
                    try
                    {
                        txtTo.Enabled = false;
                        txtTo.Text = "aplicacionsila@hotmail.com";
                        mail.To.Add(new MailAddress(txtTo.Text));
                        A();
                        D();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case "A":
                    try
                    {
                        txtTo.Enabled = false;
                        txtTo.Text = "aplicacionsila@hotmail.com";
                        mail.To.Add(new MailAddress(txtTo.Text));
                        A();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case "D":
                    try
                    {
                        txtTo.Enabled = false;
                        txtTo.Text = "aplicacionsila@hotmail.com";
                        mail.To.Add(new MailAddress(txtTo.Text));
                        D();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case "C":
                    try
                    {
                        txtTo.Enabled = false;
                        txtTo.Text = "aplicacionsila@hotmail.com";
                        mail.To.Add(new MailAddress(txtTo.Text));
                        C();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case "O":
                    txtTo.Enabled = true;
                    Otros = true;
                    break;
                default:
                    txtTo.Enabled = true;
                    Otros = true;
                    break;
            }
        }
        private void A()
        {
            try
            {
                using (OleDbConnection conexion = BDComun.ObtenerConexion())
                {
                    OleDbCommand comando = new OleDbCommand(string.Format(
                        "Select Correo from Admin where Nombre like '%{0}%'", ""), conexion);

                    OleDbDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            prueba = reader.GetInt32(0);
                        }
                        catch (Exception)
                        {
                            mail.To.Add(new MailAddress(reader.GetString(0)));
                            txtTo.Text = txtTo.Text + ", " + reader.GetString(0);
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void C()
        {
            try
            {
                using (OleDbConnection conexion = BDComun.ObtenerConexion())
                {
                    OleDbCommand comando = new OleDbCommand(string.Format(
                        "Select Correo from Acudiente where Genero like '%{0}%'", ""), conexion);

                    OleDbDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        mail.To.Add(new MailAddress(reader.GetString(0)));
                        txtTo.Text = txtTo.Text + ", " + reader.GetString(0);
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void D()
        {
            try
            {
                using (OleDbConnection conexion = BDComun.ObtenerConexion())
                {
                    OleDbCommand comando = new OleDbCommand(string.Format(
                        "Select Correo from gb2 where Cinturon like '%{0}%'", ""), conexion);

                    OleDbDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        mail.To.Add(new MailAddress(reader.GetString(0)));
                        txtTo.Text = txtTo.Text + ", " + reader.GetString(0);
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void lklAttach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attachfilepatch = openFileDialog1.FileName;
                FileInfo file = new FileInfo(attachfilepatch);
                lklAttach.Text = file.Name + " " + (file.Length / 1024).ToString("N0") + " KB";
            }
        }

        private void send()
        {
            try
            {
                if (Otros == true)
                {
                    mail.To.Add(new MailAddress(txtTo.Text));
                }
                Cursor.Current = Cursors.WaitCursor;
                mail.From = new MailAddress(username);
                mail.Subject = txtSubject.Text;
                mail.Body = htmlTextbox1.Text;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                client.EnableSsl = true;
                NetworkCredential MyCredentials = new NetworkCredential(username, password);
                client.Credentials = MyCredentials;
                if (attachfilepatch != null)
                {

                    mail.Attachments.Add(new Attachment(attachfilepatch));
                    client.Send(mail);
                }
                else
                {
                    client.Send(mail);
                }
                MessageBox.Show("Mensaje enviado correctamente",
                    "Mensaje enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscar();


            }
            catch (Exception MyError)
            {
                MessageBox.Show("Ha ocurrido un error: " + MyError.Message);
                Buscar();

            }
        }
        private void btnSendTop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSendButton_Click(object sender, EventArgs e)
        {
            btnSendTop_Click(sender, e);
        }

        private void btnSendButton_Click_1(object sender, EventArgs e)
        {
            send();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GmailAdapter.GMAIL_HOST_URL + "/gmail");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://login.live.com/login.srf?wa=wsignin1.0&ct=1409066173&rver=6.1.6206.0&sa=1&ntprob=-1&wp=MBI_SSL_SHARED&wreply=https:%2F%2Fmail.live.com%2F%3Fowa%3D1%26owasuffix%3Dowa%252f&id=64855&snsc=1&cbcxt=mail");
        }
    }
}
