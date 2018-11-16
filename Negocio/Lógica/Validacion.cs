#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

#region Lógica
namespace Negocio.Lógica
{
    #region Class
    public class Validacion
    {
        #region Validaciones
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
        public static void PreEstablecido(KeyPressEventArgs pE)
        {
            pE.Handled = true;
        }
        public static bool CampoVacio(String pE, Int32 Length)
        {
            if (pE == "" | pE == null | pE.Length < Length)
            {
                return true;
            }
            return false;
        }
        public static bool CampoGrande(String pE, Int32 Length)
        {
            if (pE.Length > Length)
            {
                return true;
            }
            return false;
        }
        public static bool Numero(String pE)
        {
            try
            {
                if ((Convert.ToInt64(pE) >= 100))
                {
                    return false;
                }
                else
                    return false;
            }
            catch
            {
                return true;
            }
        }
        public static bool Correo(String pE)
        {
            try
            {
                MailAddress MS = new MailAddress(pE);
                return false;
            }
            catch
            {
                return true;
            }
        }
        public static bool Fecha(String pE)
        {
            try
            {
                if ((Convert.ToDateTime(pE) >= DateTime.Now))
                {
                    return false;
                }
                else
                    return false;
            }
            catch
            {
                return true;
            }
        }
        public static bool Hora(String pE, String PI)
        {
            try
            {
                TimeSpan Dt = new TimeSpan(Convert.ToInt32(pE), Convert.ToInt32(PI),00);
                    return false;
            }
            catch
            {
                return true;
            }
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
