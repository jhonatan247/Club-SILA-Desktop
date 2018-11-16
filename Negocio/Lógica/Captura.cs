#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;
#endregion

#region Lógica
namespace Negocio.Lógica
{
    #region Class
    public class Captura
    {
        #region Atributos
        Bitmap Pantalla { get; set; }
        Graphics Imagen { get; set; }
        Int32 InicialX { get; set; }
        Int32 InicialY { get; set; }

        #endregion

        #region Capturas
        void Condicional(Form Formulario)
        {
            if (Formulario.Width >= Screen.PrimaryScreen.Bounds.Width)
            {
                InicialX = -45;
            }
            else if (Formulario.Width >= Screen.PrimaryScreen.Bounds.Width - 10)
            {
                InicialX = -40;
            }
            else if (Formulario.Width >= Screen.PrimaryScreen.Bounds.Width - 20)
            {
                InicialX = -30;
            }
            else if (Formulario.Width >= Screen.PrimaryScreen.Bounds.Width - 30)
            {
                InicialX = -20;
            }
            else if (Formulario.Width >= Screen.PrimaryScreen.Bounds.Width - 40)
            {
                InicialX = -10;
            }
            else if (Formulario.Width >= Screen.PrimaryScreen.Bounds.Width - 60)
            {
                InicialX = 0;
            }
            else
            {
                InicialX = (Formulario.Location.X + 10);
            }
        }
        public Bitmap Completa()
        {
            Pantalla = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Imagen = Graphics.FromImage(Pantalla);
            Imagen.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            return Pantalla;
            
        }
        public Bitmap Formulario(Form Formulario)
        {
            Pantalla = new Bitmap(Formulario.Width, Formulario.Height);
            Imagen = Graphics.FromImage(Pantalla);
            Imagen.CopyFromScreen(Formulario.Location.X, Formulario.Location.Y, 0, 0, Formulario.Size);
            return Pantalla;
        }
        public Bitmap Tabla(Form Formulario, DataGridView Dt, Int32 Index)
        {
            Pantalla = new Bitmap(Dt.Width, Dt.Height);
            Imagen = Graphics.FromImage(Pantalla);
            switch (Index)
            {
                case 0:
                    Condicional(Formulario);
                    InicialY = (Formulario.Location.Y + 100);
                    break;
                case 1 | 3 | 4:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 130);
                    break;
                case 2:
                    InicialX = (Formulario.Location.X + 17);
                    InicialY = (Formulario.Location.Y + 130);
                    break;
                case 5:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 126);
                    break;
                case 6:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 126);
                    break;

                default:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 130);
                    break;
            }
            Imagen.CopyFromScreen(InicialX, InicialY, 0, 0, Dt.Size);
            return Pantalla;
        }
        public Bitmap Tabla2(Form Formulario, DataGridView Dt, Int32 Index)
        {
            Pantalla = new Bitmap(Dt.Width, Dt.Height);
            Imagen = Graphics.FromImage(Pantalla);
            switch (Index)
            {
                case 0:
                    Condicional(Formulario);
                    InicialY = (Formulario.Location.Y + 65);
                    break;
                case 1 | 3 | 4:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 85);
                    break;
                case 2:
                    InicialX = (Formulario.Location.X + 17);
                    InicialY = (Formulario.Location.Y + 85);
                    break;
                case 5:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 81);
                    break;
                case 6:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 81);
                    break;

                default:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 85);
                    break;
            }
            Imagen.CopyFromScreen(InicialX, InicialY, 0, 0, Dt.Size);
            return Pantalla;
        }
        public Bitmap Registro(Form Formulario, Panel P, Int32 Index)
        {
            Pantalla = new Bitmap(P.Width, P.Height);
            Imagen = Graphics.FromImage(Pantalla);
            switch (Index)
            {
                case 0:
                    Condicional(Formulario);
                    InicialY = (Formulario.Location.Y + 100);
                    break;
                case 1 | 3 | 4:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 130);
                    break;
                case 2:
                    InicialX = (Formulario.Location.X + 17);
                    InicialY = (Formulario.Location.Y + 130);
                    break;
                case 5:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 126);
                    break;
                case 6:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 126);
                    break;

                default:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 130);
                    break;
            }
            Imagen.CopyFromScreen(InicialX, InicialY, 0, 0, P.Size);
            return Pantalla;
        }
        public Bitmap Grafica(Form Formulario, Chart C, Int32 Index) 
        {
            Pantalla = new Bitmap(C.Width, C.Height);
            Imagen = Graphics.FromImage(Pantalla);
            switch (Index)
            {
                case 0:
                    InicialX = (Formulario.Location.X + 10);
                    InicialY = (Formulario.Location.Y + 52);
                    break;
                case 1 | 3 | 4:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 82);
                    break;
                case 2:
                    InicialX = (Formulario.Location.X + 17);
                    InicialY = (Formulario.Location.Y + 82);
                    break;
                case 5:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 78);
                    break;
                case 6:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 78);
                    break;

                default:
                    InicialX = (Formulario.Location.X + 15);
                    InicialY = (Formulario.Location.Y + 82);
                    break;
            }
            Imagen.CopyFromScreen(InicialX, InicialY, 0, 0, C.Size);
            return Pantalla;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
