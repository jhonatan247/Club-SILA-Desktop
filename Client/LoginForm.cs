using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Client.Properties;

namespace Client
{
    public partial class LoginForm : Form
    {
        Boolean Conectado = false;
        public ClientSettings Client { get; set; }

        public LoginForm()
        {
            Client = new ClientSettings();
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtNickname.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre o apodo para entrar al chat", "Error de validación");
            }
            else
            {
                try
                {
                    Client.Connected += Client_Connected;
                    Client.Connect(txtIP.Text, 2014);
                    Client.Send("Connect|" + txtNickname.Text + "|connected");
                    Settings.Default.User = txtNickname.Text;
                    Settings.Default.Save();
                    
                }
                catch
                {
                    MessageBox.Show("No se ha podido Conectar con el servidor. \n\nAsegurese de que la dirección Ip del servidor es correcta", "No se pudo conectar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Client_Connected(object sender, EventArgs e)
        {
            Conectado = true;
            this.Invoke(Close);
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {

            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.User != "")
            {
                txtNickname.Text = Settings.Default.User;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!Conectado)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}