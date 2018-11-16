#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
#endregion

#region Lógica
namespace Negocio.Lógica
{
    #region Class
    public class TimmerAction
    {
        #region Atributos
        MensajeBx Mensaje = new MensajeBx();
        AccionesSistema As = new AccionesSistema();
        #endregion

        #region Propiedades
        List<Image> Img { get; set; }
        int Hour { get; set; }
        int Minute { get; set; }
        int Segundo { get; set; }
        #endregion

        #region Constructor
        public TimmerAction()
        {
        }
        #endregion

        #region Métodos
        public int PictureSILA(object Timer, PictureBox PBx, int xx)
        {if (xx == 373)
            {
                xx = 0;
            }
            else if (xx < 25)
            {
                ((Timer)Timer).Interval = 200;
            }
            else if (xx == 25 | xx == 39 | xx == 116 | xx == 125 | xx == 174 | xx == 321 | xx == 334 | xx == 346)
            {
                ((Timer)Timer).Interval = 50;
            }
            else if (xx == 32 | xx == 59 | xx == 122 | xx == 134 | xx == 183 | xx == 310 | xx == 328 | xx == 343 | xx == 353)
            {
                ((Timer)Timer).Interval = 200;
            }
            else if (xx == 305)
            {
                ((Timer)Timer).Interval = 400;
            }
            try
            {
                PBx.Image = As.Spro(xx);
                xx++;
            }
            catch
            {
                ((Timer)Timer).Enabled = false;
                Mensaje.ErrorMensaje(8);
            }
            return xx;
        }
        public int PicturePresentacion(object Timer, PictureBox PBx, int xx, object Frm, int Interrupcion, bool Cerrar)
        {
            if (xx == Interrupcion)
            {
                if (Cerrar)
                {
                    ((Timer)Timer).Enabled = false;
                    ((Form)Frm).Close();
                }
                return 0;
            }
            try
            {
                PBx.Image = As.Anima(xx);
                xx ++;
            }
            catch
            {
                ((Timer)Timer).Enabled = false;
                ((Form)Frm).Close();
                Mensaje.ErrorMensaje(8);
            }
            return xx;
        }
        public void Reloj(PictureBox h1, PictureBox h2, PictureBox m1, PictureBox m2, PictureBox s1, PictureBox s2, Label lbFecha)
        {
            Img = As.ImagenesReloj();
            try
            {
                Random random = new Random();
                Hour = DateTime.Now.TimeOfDay.Hours;
                int hora1 = 0, hora2 = 0, minuto1 = 0, minuto2 = 0, segundo1 = 0, segundo2 = 0;

                DateTime Fecha;
                string Dia, Mes = "", Año;
                Fecha = DateTime.Now.Date;
                Dia = Fecha.Day.ToString();
                Año = Fecha.Year.ToString();
                switch (Fecha.Month.ToString())
                {
                    case "1":
                        Mes = " de enero del ";
                        break;
                    case "2":
                        Mes = " de febrero del ";
                        break;
                    case "3":
                        Mes = " de marzo del ";
                        break;
                    case "4":
                        Mes = " de abril del ";
                        break;
                    case "5":
                        Mes = " de mayo del ";
                        break;
                    case "6":
                        Mes = " de junio del ";
                        break;
                    case "7":
                        Mes = " de julio del ";
                        break;
                    case "8":
                        Mes = " de agosto del ";
                        break;
                    case "9":
                        Mes = " de septiembre del ";
                        break;
                    case "10":
                        Mes = " de octubre del ";
                        break;
                    case "11":
                        Mes = " de noviembre del ";
                        break;
                    case "12":
                        Mes = " de diciembe del ";
                        break;
                }
                lbFecha.Text = Dia + Mes + Año;
                lbFecha.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                switch (Hour)
                {
                    case 0:
                        hora1 = 0;
                        hora2 = 0;
                        break;
                    case 1:
                        hora1 = 0;
                        hora2 = 1;
                        break;
                    case 2:
                        hora1 = 0;
                        hora2 = 2;
                        break;
                    case 3:
                        hora1 = 0;
                        hora2 = 3;
                        break;
                    case 4:
                        hora1 = 0;
                        hora2 = 4;
                        break;
                    case 5:
                        hora1 = 0;
                        hora2 = 5;
                        break;
                    case 6:
                        hora1 = 0;
                        hora2 = 6;
                        break;
                    case 7:
                        hora1 = 0;
                        hora2 = 7;
                        break;
                    case 8:
                        hora1 = 0;
                        hora2 = 8;
                        break;
                    case 9:
                        hora1 = 0;
                        hora2 = 9;
                        break;
                    case 10:
                        hora1 = 1;
                        hora2 = 0;
                        break;
                    case 11:
                        hora1 = 1;
                        hora2 = 1;
                        break;
                    case 12:
                        hora1 = 1;
                        hora2 = 2;
                        break;
                    case 13:
                        hora1 = 1;
                        hora2 = 3;
                        break;
                    case 14:
                        hora1 = 1;
                        hora2 = 4;
                        break;
                    case 15:
                        hora1 = 1;
                        hora2 = 5;
                        break;
                    case 16:
                        hora1 = 1;
                        hora2 = 6;
                        break;
                    case 17:
                        hora1 = 1;
                        hora2 = 7;
                        break;
                    case 18:
                        hora1 = 1;
                        hora2 = 8;
                        break;
                    case 19:
                        hora1 = 1;
                        hora2 = 9;
                        break;
                    case 20:
                        hora1 = 2;
                        hora2 = 0;
                        break;
                    case 21:
                        hora1 = 2;
                        hora2 = 1;
                        break;
                    case 22:
                        hora1 = 2;
                        hora2 = 2;
                        break;
                    case 23:
                        hora1 = 2;
                        hora2 = 3;
                        break;

                }
                Minute = DateTime.Now.TimeOfDay.Minutes;
                switch (Minute)
                {
                    case 0:
                        minuto1 = 0;
                        minuto2 = 0;
                        break;
                    case 1:
                        minuto1 = 0;
                        minuto2 = 1;
                        break;
                    case 2:
                        minuto1 = 0;
                        minuto2 = 2;
                        break;
                    case 3:
                        minuto1 = 0;
                        minuto2 = 3;
                        break;
                    case 4:
                        minuto1 = 0;
                        minuto2 = 4;
                        break;
                    case 5:
                        minuto1 = 0;
                        minuto2 = 5;
                        break;
                    case 6:
                        minuto1 = 0;
                        minuto2 = 6;
                        break;
                    case 7:
                        minuto1 = 0;
                        minuto2 = 7;
                        break;
                    case 8:
                        minuto1 = 0;
                        minuto2 = 8;
                        break;
                    case 9:
                        minuto1 = 0;
                        minuto2 = 9;
                        break;
                    case 10:
                        minuto1 = 1;
                        minuto2 = 0;
                        break;
                    case 11:
                        minuto1 = 1;
                        minuto2 = 1;
                        break;
                    case 12:
                        minuto1 = 1;
                        minuto2 = 2;
                        break;
                    case 13:
                        minuto1 = 1;
                        minuto2 = 3;
                        break;
                    case 14:
                        minuto1 = 1;
                        minuto2 = 4;
                        break;
                    case 15:
                        minuto1 = 1;
                        minuto2 = 5;
                        break;
                    case 16:
                        minuto1 = 1;
                        minuto2 = 6;
                        break;
                    case 17:
                        minuto1 = 1;
                        minuto2 = 7;
                        break;
                    case 18:
                        minuto1 = 1;
                        minuto2 = 8;
                        break;
                    case 19:
                        minuto1 = 1;
                        minuto2 = 9;
                        break;
                    case 20:
                        minuto1 = 2;
                        minuto2 = 0;
                        break;
                    case 21:
                        minuto1 = 2;
                        minuto2 = 1;
                        break;
                    case 22:
                        minuto1 = 2;
                        minuto2 = 2;
                        break;
                    case 23:
                        minuto1 = 2;
                        minuto2 = 3;
                        break;
                    case 24:
                        minuto1 = 2;
                        minuto2 = 4;
                        break;
                    case 25:
                        minuto1 = 2;
                        minuto2 = 5;
                        break;
                    case 26:
                        minuto1 = 2;
                        minuto2 = 6;
                        break;
                    case 27:
                        minuto1 = 2;
                        minuto2 = 7;
                        break;
                    case 28:
                        minuto1 = 2;
                        minuto2 = 8;
                        break;
                    case 29:
                        minuto1 = 2;
                        minuto2 = 9;
                        break;
                    case 30:
                        minuto1 = 3;
                        minuto2 = 0;
                        break;
                    case 31:
                        minuto1 = 3;
                        minuto2 = 1;
                        break;
                    case 32:
                        minuto1 = 3;
                        minuto2 = 2;
                        break;
                    case 33:
                        minuto1 = 3;
                        minuto2 = 3;
                        break;
                    case 34:
                        minuto1 = 3;
                        minuto2 = 4;
                        break;
                    case 35:
                        minuto1 = 3;
                        minuto2 = 5;
                        break;
                    case 36:
                        minuto1 = 3;
                        minuto2 = 6;
                        break;
                    case 37:
                        minuto1 = 3;
                        minuto2 = 7;
                        break;
                    case 38:
                        minuto1 = 3;
                        minuto2 = 8;
                        break;
                    case 39:
                        minuto1 = 3;
                        minuto2 = 9;
                        break;
                    case 40:
                        minuto1 = 4;
                        minuto2 = 0;
                        break;
                    case 41:
                        minuto1 = 4;
                        minuto2 = 1;
                        break;
                    case 42:
                        minuto1 = 4;
                        minuto2 = 2;
                        break;
                    case 43:
                        minuto1 = 4;
                        minuto2 = 3;
                        break;
                    case 44:
                        minuto1 = 4;
                        minuto2 = 4;
                        break;
                    case 45:
                        minuto1 = 4;
                        minuto2 = 5;
                        break;
                    case 46:
                        minuto1 = 4;
                        minuto2 = 6;
                        break;
                    case 47:
                        minuto1 = 4;
                        minuto2 = 7;
                        break;
                    case 48:
                        minuto1 = 4;
                        minuto2 = 8;
                        break;
                    case 49:
                        minuto1 = 4;
                        minuto2 = 9;
                        break;
                    case 50:
                        minuto1 = 5;
                        minuto2 = 0;
                        break;
                    case 51:
                        minuto1 = 5;
                        minuto2 = 1;
                        break;
                    case 52:
                        minuto1 = 5;
                        minuto2 = 2;
                        break;
                    case 53:
                        minuto1 = 5;
                        minuto2 = 3;
                        break;
                    case 54:
                        minuto1 = 5;
                        minuto2 = 4;
                        break;
                    case 55:
                        minuto1 = 5;
                        minuto2 = 5;
                        break;
                    case 56:
                        minuto1 = 5;
                        minuto2 = 6;
                        break;
                    case 57:
                        minuto1 = 5;
                        minuto2 = 7;
                        break;
                    case 58:
                        minuto1 = 5;
                        minuto2 = 8;
                        break;
                    case 59:
                        minuto1 = 5;
                        minuto2 = 9;
                        break;
                }
                Segundo = DateTime.Now.TimeOfDay.Seconds;
                switch (Segundo)
                {
                    case 0:
                        segundo1 = 0;
                        segundo2 = 0;
                        break;
                    case 1:
                        segundo1 = 0;
                        segundo2 = 1;
                        break;
                    case 2:
                        segundo1 = 0;
                        segundo2 = 2;
                        break;
                    case 3:
                        segundo1 = 0;
                        segundo2 = 3;
                        break;
                    case 4:
                        segundo1 = 0;
                        segundo2 = 4;
                        break;
                    case 5:
                        segundo1 = 0;
                        segundo2 = 5;
                        break;
                    case 6:
                        segundo1 = 0;
                        segundo2 = 6;
                        break;
                    case 7:
                        segundo1 = 0;
                        segundo2 = 7;
                        break;
                    case 8:
                        segundo1 = 0;
                        segundo2 = 8;
                        break;
                    case 9:
                        segundo1 = 0;
                        segundo2 = 9;
                        break;
                    case 10:
                        segundo1 = 1;
                        segundo2 = 0;
                        break;
                    case 11:
                        segundo1 = 1;
                        segundo2 = 1;
                        break;
                    case 12:
                        segundo1 = 1;
                        segundo2 = 2;
                        break;
                    case 13:
                        segundo1 = 1;
                        segundo2 = 3;
                        break;
                    case 14:
                        segundo1 = 1;
                        segundo2 = 4;
                        break;
                    case 15:
                        segundo1 = 1;
                        segundo2 = 5;
                        break;
                    case 16:
                        segundo1 = 1;
                        segundo2 = 6;
                        break;
                    case 17:
                        segundo1 = 1;
                        segundo2 = 7;
                        break;
                    case 18:
                        segundo1 = 1;
                        segundo2 = 8;
                        break;
                    case 19:
                        segundo1 = 1;
                        segundo2 = 9;
                        break;
                    case 20:
                        segundo1 = 2;
                        segundo2 = 0;
                        break;
                    case 21:
                        segundo1 = 2;
                        segundo2 = 1;
                        break;
                    case 22:
                        segundo1 = 2;
                        segundo2 = 2;
                        break;
                    case 23:
                        segundo1 = 2;
                        segundo2 = 3;
                        break;
                    case 24:
                        segundo1 = 2;
                        segundo2 = 4;
                        break;
                    case 25:
                        segundo1 = 2;
                        segundo2 = 5;
                        break;
                    case 26:
                        segundo1 = 2;
                        segundo2 = 6;
                        break;
                    case 27:
                        segundo1 = 2;
                        segundo2 = 7;
                        break;
                    case 28:
                        segundo1 = 2;
                        segundo2 = 8;
                        break;
                    case 29:
                        segundo1 = 2;
                        segundo2 = 9;
                        break;
                    case 30:
                        segundo1 = 3;
                        segundo2 = 0;
                        break;
                    case 31:
                        segundo1 = 3;
                        segundo2 = 1;
                        break;
                    case 32:
                        segundo1 = 3;
                        segundo2 = 2;
                        break;
                    case 33:
                        segundo1 = 3;
                        segundo2 = 3;
                        break;
                    case 34:
                        segundo1 = 3;
                        segundo2 = 4;
                        break;
                    case 35:
                        segundo1 = 3;
                        segundo2 = 5;
                        break;
                    case 36:
                        segundo1 = 3;
                        segundo2 = 6;
                        break;
                    case 37:
                        segundo1 = 3;
                        segundo2 = 7;
                        break;
                    case 38:
                        segundo1 = 3;
                        segundo2 = 8;
                        break;
                    case 39:
                        segundo1 = 3;
                        segundo2 = 9;
                        break;
                    case 40:
                        segundo1 = 4;
                        segundo2 = 0;
                        break;
                    case 41:
                        segundo1 = 4;
                        segundo2 = 1;
                        break;
                    case 42:
                        segundo1 = 4;
                        segundo2 = 2;
                        break;
                    case 43:
                        segundo1 = 4;
                        segundo2 = 3;
                        break;
                    case 44:
                        segundo1 = 4;
                        segundo2 = 4;
                        break;
                    case 45:
                        segundo1 = 4;
                        segundo2 = 5;
                        break;
                    case 46:
                        segundo1 = 4;
                        segundo2 = 6;
                        break;
                    case 47:
                        segundo1 = 4;
                        segundo2 = 7;
                        break;
                    case 48:
                        segundo1 = 4;
                        segundo2 = 8;
                        break;
                    case 49:
                        segundo1 = 4;
                        segundo2 = 9;
                        break;
                    case 50:
                        segundo1 = 5;
                        segundo2 = 0;
                        break;
                    case 51:
                        segundo1 = 5;
                        segundo2 = 1;
                        break;
                    case 52:
                        segundo1 = 5;
                        segundo2 = 2;
                        break;
                    case 53:
                        segundo1 = 5;
                        segundo2 = 3;
                        break;
                    case 54:
                        segundo1 = 5;
                        segundo2 = 4;
                        break;
                    case 55:
                        segundo1 = 5;
                        segundo2 = 5;
                        break;
                    case 56:
                        segundo1 = 5;
                        segundo2 = 6;
                        break;
                    case 57:
                        segundo1 = 5;
                        segundo2 = 7;
                        break;
                    case 58:
                        segundo1 = 5;
                        segundo2 = 8;
                        break;
                    case 59:
                        segundo1 = 5;
                        segundo2 = 9;
                        break;
                }
                h1.Image = Img[hora1];
                h2.Image = Img[hora2];
                m1.Image = Img[minuto1];
                m2.Image = Img[minuto2];
                s1.Image = Img[segundo1];
                s2.Image = Img[segundo2];
            }
            catch { }
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
