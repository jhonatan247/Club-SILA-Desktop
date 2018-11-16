﻿#region Código hecho por Jhonatan Torres
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
using Negocio.Lógica;
using Negocio.Manejo_de_datos;
using System.Media;
using System.Windows.Forms.DataVisualization.Charting;
using Diseño.Properties;
#endregion

#region Funciones
namespace Diseño.Funciones
{
    #region Formulario
    public partial class ConfirmarContraseña : Form
    {
        #region Atributos
        Captura Capt = new Captura();
        Programa Prog = new Programa();
        MensajeBx Mensajebx = new MensajeBx();
        MensajeToolTip MensajeTool = new MensajeToolTip();
        AccionesSistema As = new AccionesSistema();
        Color Blue = Color.FromArgb(3, 169, 244);
        #endregion

        #region Propiedades
        DataRow Drow { get; set; }

        VisorImagenes Pantallazo { get; set; }

        SoundPlayer Boton { get; set; }
        SoundPlayer Camara { get; set; }
        SoundPlayer Minimizado { get; set; }

        string Contraseña { get; set; }
        #endregion

        #region Constructor
        public ConfirmarContraseña()
        {
                Sonidos();
                InitializeComponent();
        }
        #endregion

        #region Métodos
        void Ptllazo()
        {
            Pantallazo.ShowDialog();
            Sonidos();
        }
        void Sonidos()
        {
            List<SoundPlayer> Lst = As.Sonidos();
            Drow = Prog.TSELECT4().Rows[0];
            if (Drow[0].ToString() == "A")
            {
                Boton = Lst[0];
                Camara = Lst[1];
                Minimizado = Lst[3];
                Minimizado.Play();
            }
            else
            {
                Boton = Lst[5];
                Camara = Lst[5]; 
                Minimizado = Lst[5];
            }
        }
        void Excepcion(Exception ex)
        {
            Mensajebx.Excepcion(ex);
        }
        #endregion

        #region Eventos
        private void Grafica_Completa_Load(object sender, EventArgs e)
        {
            Drow = Prog.TSELECT2().Rows[0];
            Contraseña = Drow[1].ToString();
            DialogResult = DialogResult.Cancel;
        }

        private void bnFinalizar_Click(object sender, EventArgs e)
        {
            Boton.Play();
            if (txContraseña.Text == Contraseña)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MensajeTool.ContraseñaInvalidada(toolTip2, txContraseña);
            }
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            Boton.Play();
            Close();
        }
        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            Pantallazo = new VisorImagenes(Capt.Formulario(this));
            Ptllazo();
        }

        private void chVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chVerContraseña.Checked == true)
            {
                txContraseña.PasswordChar = textBox1.PasswordChar;
            }
            else
            {
                txContraseña.PasswordChar = '•';
            }
        }

        private void txContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bnFinalizar.PerformClick();
            }
        }
        #endregion

        private void bnFinalizar_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Blue;
        }

        private void bnFinalizar_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Blue;
        }

        private void lbSalir_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        private void lbSalir_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Gray;
        }
        private void contrat_Click(object sender, EventArgs e)
        {
            lbContrat.Hide();
            txContraseña.Focus();
        }

        private void txContraseña_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                lbContrat.Show();
            }
            else
            {
                lbContrat.Hide();
            }
        }

        private void chVerContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            ((CheckBox)sender).Checked = true;
        }

        private void chVerContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            ((CheckBox)sender).Checked = false;
        }

        private void ConfirmarContraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("");
        }
    }
    #endregion
}
#endregion
#endregion