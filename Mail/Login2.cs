using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Mail
{
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
            this.txtUserName.Text = Properties.Settings.Default.Username2;
            this.txtPassWord.Text = Properties.Settings.Default.PassWord2;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lbEstado.Text = "Autentificando...";
            try
            {
                MailAddress mail = new MailAddress(txtUserName.Text);
                Properties.Settings.Default.Username2 = this.txtUserName.Text;
                Properties.Settings.Default.PassWord2 = this.txtPassWord.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch
            {
                MessageBox.Show("El correo ingresado no es válido.");
            }
            lbEstado.Text = "Esperando...";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }
    }
}
