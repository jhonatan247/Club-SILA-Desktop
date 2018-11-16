#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

#region Lógica
namespace Negocio.Lógica
{
    #region Class
    public class MensajeToolTip
    {
        #region Atributos
        #endregion

        #region Cuadros de mensaje
        public void ValorInvalidado(ToolTip ToolT, Object O)
        {
            ToolT.ToolTipTitle = "Valor inválido";
            ToolT.Show("En el campo " + ((TextBox)O).Tag +"."+
                "\nLo sentimos, el valor que has introducido no es válido. Por favor, revisa y cambia el valor del campo para continuar.",
                ((TextBox)O), 10000);
        }
        public void UsuarioInvalidado(ToolTip ToolT, TextBox Tx)
        {
            ToolT.ToolTipTitle = "Usuario inválido";
            ToolT.Show("Lo sentimos, el usuario que has introducido no se encuentra en el sistema. Por favor, ingresa tu nombre de usuario.",
                Tx, 10000);
        }
        public void SeleccionInvalidada(ToolTip ToolT, TextBox Tx)
        {
            ToolT.ToolTipTitle = "Selección invalida";
            ToolT.Show("Lo sentimos, la selección que hiciste no es correcta.\nPor favor, selecciona una fila o celda para continuar.",
                Tx, 10000);
        }
        public void ContraseñaInvalidada(ToolTip ToolT, TextBox Tx)
        {
            ToolT.ToolTipTitle = "Contraseña inválida";
            ToolT.Show("Lo sentimos, la contraseña que has introducido no es correcta.\nPor favor, ingresa tu contraseña.",
                Tx, 5000);
        }
        public void UsuarioOlvidado(ToolTip ToolT, PictureBox Pb)
        {
            ToolT.ToolTipTitle = "¡Usuario olvidado!";
            ToolT.Show("No se volverán a recordar los datos de usuario al iniciar.",
                Pb, 5000);
        }
        public void ImageFormatoNoSoportado(ToolTip ToolT, PictureBox Pb)
        {
            ToolT.ToolTipTitle = "El formato del archivo no es soportado como imagen";
            ToolT.Show("No se logró cargar el archivo.",
                Pb, 5000);
        }
        public void TextoFormatoNoSoportado(ToolTip ToolT, TextBox Pb)
        {
            ToolT.ToolTipTitle = "El formato del archivo no es soportado como texto";
            ToolT.Show("No se logró cargar el archivo.",
                Pb, 5000);
        }
        public void ContraseñaOlvidada(ToolTip ToolT, PictureBox Pb)
        {
            ToolT.ToolTipTitle = "¡Contraseña olvidada!";
            ToolT.Show("No se volverá a recordar la contraseña al iniciar.",
                Pb, 5000);
        }
        public void Mayusculas(ToolTip ToolT, Button Pb)
        {
            ToolT.ToolTipTitle = "¡Usuario o contraseña incorrectos!";
            ToolT.Show("Lo sentimos, los valores que has introducido para usuario o contraseña no son correctos.\nRecuerda que la introducción incorrecta de carácteres en mayúscula ó minúscula cancela la validación.\nPor favor, revisa e intenta nuevamente.",
                Pb, 10000);
        }
        public void LicenciaFallida(ToolTip ToolT, Button Pb)
        {
            ToolT.ToolTipTitle = "Clave de activación incorrecta";
            ToolT.Show("El código de activación introducido no es válido.\nPor favor revise e intente nuevamente.",
                Pb, 5000);
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
