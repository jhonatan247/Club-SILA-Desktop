using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mail
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.txtUserName.Text = Properties.Settings.Default.Username;
            this.txtPassWord.Text = Properties.Settings.Default.PassWord;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = this.txtUserName.Text;
            Properties.Settings.Default.PassWord = this.txtPassWord.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }
    }
}
