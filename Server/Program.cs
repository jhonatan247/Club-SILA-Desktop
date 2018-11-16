using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Server
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (IsExecutingApplication())
            {
                Application.Run(new Main());
            }
            else
            {
                MessageBox.Show("Ya se encuentra conectado como administrador", "No se logró completar la acción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        /// <summary>
        /// Invokes an action on the UI thread
        /// </summary>
        public static void Invoke(this Control control, Action action)
        {
            control.Invoke(action);
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
    }
}