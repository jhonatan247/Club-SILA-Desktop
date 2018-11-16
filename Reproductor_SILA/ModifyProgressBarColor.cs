#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
#endregion

#region SILA
namespace Reproductor_SILA
{
    #region Class
    public static class ModifyProgressBarColor
    {
        #region Atributos
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        #endregion

        #region Métodos
        public static void SetState(this  ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion