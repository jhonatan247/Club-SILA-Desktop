using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mail
{
    public partial class To : Form
    {
        String TOO { get; set; }
        public To()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Correos = "T";
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Correos = "CD";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Correos = "CA";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Correos = "AD";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Correos = "A";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Correos = "D";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Correos = "C";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Correos = "O";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    TOO = "T";
                    break;
                case 1:
                    TOO = "APED";
                    break;
                case 2:
                    TOO = "APEA";
                    break;
                case 3:
                    TOO = "APDA";
                    break;
                case 4:
                    TOO = "AEDA";
                    break;
                case 5:
                    TOO = "PEDA";
                    break;
                case 6:
                    TOO = "APE";
                    break;
                case 7:
                    TOO = "APD";
                    break;
                case 8:
                    TOO = "APA";
                    break;
                case 9:
                    TOO = "AED";
                    break;
                case 10:
                    TOO = "AEA";
                    break;
                case 11:
                    TOO = "ADA";
                    break;
                case 12:
                    TOO = "PED";
                    break;
                case 13:
                    TOO = "PEA";
                    break;
                case 14:
                    TOO = "PDA";
                    break;
                case 15:
                    TOO = "EDA";
                    break;
                case 16:
                    TOO = "AP";
                    break;
                case 17:
                    TOO = "AE";
                    break;
                case 18:
                    TOO = "AD";
                    break;
                case 19:
                    TOO = "AA";
                    break;
                case 20:
                    TOO = "PE";
                    break;
                case 21:
                    TOO = "PD";
                    break;
                case 22:
                    TOO = "PA";
                    break;
                case 23:
                    TOO = "ED";
                    break;
                case 24:
                    TOO = "EA";
                    break;
                case 25:
                    TOO = "DA";
                    break;
                case 26:
                    TOO = "A";
                    break;
                case 27:
                    TOO = "P";
                    break;
                case 28:
                    TOO = "E";
                    break;
                case 29:
                    TOO = "D";
                    break;
                case 30:
                    TOO = "A";
                    break;
                case 31:
                    TOO = "AS";
                    break;
                case 32:
                    TOO = "PS";
                    break;
                case 33:
                    TOO = "ES";
                    break;
                case 34:
                    TOO = "DS";
                    break;
                case 35:
                    TOO = "AS";
                    break;
                case 36:
                    TOO = "O";
                    break;
                default:
                    break;
            }
            Properties.Settings.Default.Correos = TOO;
            Properties.Settings.Default.Save();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
