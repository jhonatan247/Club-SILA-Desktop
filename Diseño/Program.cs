#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diseño.Interfaz_de_usuario;
using Diseño;
using Negocio.Lógica;
using Negocio.Manejo_de_datos;
using Negocio.Entidades;
using Diseño.Funciones;
using Diseño.Gestión_de_datos;
using System.Diagnostics;

#endregion

#region Diseño
namespace Diseño
{
    #region Class
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        #region Atributos
        [STAThread]
        #endregion

        #region Constructor
        static void Main()
        {
            #region Obtener
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Programa Prm = new Programa();
            DataRow Dr = Prm.TSELECT1().Rows[0];
            #endregion

            #region Inicio
            if (IsExecutingApplication() | Convert.ToInt64(Dr[0]) != 0)
            {
                switch (Convert.ToInt64(Dr[0]))
                {
                    case 0:
                        Application.Run(new Inicio2());
                        break;
                    case 1:
                        if (Zero() == 1)
                            Application.Run(new Inicio2());
                        break;
                    case 2:
                        if (Zero() == 1)
                            Application.Run(new FRM_OBJETO());
                        break;
                    default:
                        if (Zero() == 1)
                            Application.Run(new Ingreso());
                        break;
                }
            }
            else
            {
                MensajeBx Mx = new MensajeBx();
                Mx.DobleInicio();
                Application.Run(new Licencia(1));
            }
            #endregion
        }
        #endregion

        #region Métodos
        static Int64 Zero()
        {
            E_Programa Entidad = new E_Programa(0);
            Programa Prm = new Programa();
            return Prm.UPDATE1(Entidad);
        }
        private static bool IsExecutingApplication()
        {
            // Proceso actual
            Process currentProcess = Process.GetCurrentProcess();

            // Matriz de procesos
            Process[] processes = Process.GetProcesses();

            // Recorremos los procesos en ejecución
            foreach (Process p in processes)
            {
                if (p.Id != currentProcess.Id && p.ProcessName == currentProcess.ProcessName)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

    }
    #endregion
}
#endregion
#endregion