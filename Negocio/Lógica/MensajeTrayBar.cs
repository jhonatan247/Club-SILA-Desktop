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
    public class MensajeTrayBar
    {
        #region Atributos
        #endregion

        #region Cuadros de mensaje
        public void Ingreso(NotifyIcon trayBar)
        {
            trayBar.BalloonTipText = "Bienvenido(a)\n\n" +
                    "Ingresa a tu cuenta\n";
            trayBar.BalloonTipTitle = "Club SILA V: 10.0.0";
            trayBar.BalloonTipIcon = ToolTipIcon.None;
            trayBar.ShowBalloonTip(5000);
            
        }
        public void TrayCRUD(NotifyIcon trayBar)
        {
            trayBar.BalloonTipText = "Acciones:\n  -Click derecho sobre éste icono para ver opciones.\n -Doble click para abrir el formulario.";
            trayBar.BalloonTipTitle = "Gestionar entidad.";
            trayBar.BalloonTipIcon = ToolTipIcon.None;
            trayBar.ShowBalloonTip(5000);
        }
        public void TrayIngrseo(NotifyIcon trayBar)
        {
            trayBar.BalloonTipText = "Acciones:\n  -Click derecho sobre éste icono para ver opciones.\n -Doble click para ver el formulario.";
            trayBar.BalloonTipTitle = "Club Sila v: 1.4.5";
            trayBar.BalloonTipIcon = ToolTipIcon.None;
            trayBar.ShowBalloonTip(5000);
        }

        private void ErrorPersonalizado(NotifyIcon trayBar, String Texto)
        {
            trayBar.BalloonTipText = Texto;
            trayBar.BalloonTipTitle = "Error";
            trayBar.BalloonTipIcon = ToolTipIcon.Error;
            trayBar.ShowBalloonTip(5000);
        }
        public void TrayMensaje(Int32 Numero, NotifyIcon trayBar)
        {
            switch (Numero)
            {
                case 0:
                    ErrorPersonalizado(trayBar,
                        "El formulario no es visible.");
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
