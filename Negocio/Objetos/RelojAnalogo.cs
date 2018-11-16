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
#endregion

#region Lógica
namespace Negocio.Objetos
{
    #region Class
    public class RelojAnalogo
    {
        #region Atributos
        Color Gray = Color.FromArgb(68, 68, 68);
        Color Blue = Color.FromArgb(3, 169, 244);
        List<Color> Coloress = new List<Color>();
        List<Brush> Brush = new List<Brush>();
        Bitmap bmp;
        Graphics g;

        const int WIDTH = 300, HEIGHT = 300, secHAND = 140, minHAND = 110, hrHAND = 80;
        int cx, cy;
        #endregion
        #region Constructor
        public RelojAnalogo()
        {
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            cx = WIDTH / 2;
            cy = HEIGHT / 2;
            Coloress.Add(Blue);
            Brush.Add(Brushes.DeepSkyBlue);
            Coloress.Add(Color.Green);
            Brush.Add(Brushes.Green);
            Coloress.Add(Color.Red);
            Brush.Add(Brushes.Red);
            Coloress.Add(Color.Purple);
            Brush.Add(Brushes.Purple);
            Coloress.Add(Color.DarkOrange);
            Brush.Add(Brushes.DarkOrange);
            Coloress.Add(Color.Teal);
            Brush.Add(Brushes.Teal);
            Coloress.Add(Color.Tomato);
            Brush.Add(Brushes.Tomato);
            Coloress.Add(Color.Gold);
            Brush.Add(Brushes.Gold);
            Coloress.Add(Color.Turquoise);
            Brush.Add(Brushes.Turquoise);
        }
        public RelojAnalogo(Color C1, Color C2, Color C3, Color C4, Brush F12, Brush F3, Brush F6, Brush F9)
        {
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            cx = WIDTH / 2;
            cy = HEIGHT / 2;
            Coloress.Add(C1);
            Brush.Add(F12);
            Coloress.Add(C2);
            Brush.Add(F3);
            Coloress.Add(C3);
            Brush.Add(F6);
            Coloress.Add(C4);
            Brush.Add(F9);
        }
        public RelojAnalogo(Color C1, Color C2, Color C3, Color C4)
        {
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            cx = WIDTH / 2;
            cy = HEIGHT / 2;
            Coloress.Add(C1);
            Coloress.Add(C2);
            Coloress.Add(C3);
            Coloress.Add(C4);
        }
        #endregion

        #region Métodos
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
        #endregion

        #region Eventos
        public void RelojIngreso(Color BackColor, int value, PictureBox pictureBox1, ToolTip toolTip1)
        {
            g = Graphics.FromImage(bmp);

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            String AA = DateTime.Now.Year.ToString();
            String MM = DateTime.Now.Month.ToString();
            if (MM.Length < 2) { MM = "0" + MM; }
            String DD = DateTime.Now.Day.ToString();
            if (DD.Length < 2) { DD = "0" + DD; }
            String SS = DateTime.Now.Second.ToString();
            if (SS.Length < 2) { SS = "0" + SS; }
            String Mm = DateTime.Now.Minute.ToString();
            if (Mm.Length < 2) { Mm = "0" + Mm; }
            String HH = DateTime.Now.Hour.ToString();
            if (HH.Length < 2) { HH = "0" + HH; }


            int[] handCoord = new int[2];

            g.Clear(BackColor);

            //g.DrawEllipse(new Pen(Coloress[cbEstilo.SelectedIndex], 7f), 0, 0, WIDTH, HEIGHT);

            g.DrawString("|", new Font("Arial", 40), Brush[value], new PointF(135, -3));//12
            g.DrawString("__", new Font("Arial", 40), Brush[value], new PointF(240, 95));//3
            g.DrawString("|", new Font("Arial", 40), Brush[value], new PointF(135, 240));//6
            g.DrawString("__", new Font("Arial", 40), Brush[value], new PointF(0, 95));//9

            handCoord = msCoord(ss, secHAND);
            g.DrawLine(new Pen(Coloress[value], 7f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            handCoord = msCoord(mm, minHAND);
            g.DrawLine(new Pen(Coloress[value], 8f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            handCoord = hrCoord(hh % 12, mm, hrHAND);
            g.DrawLine(new Pen(Coloress[value], 10f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            pictureBox1.Image = bmp;

            g.Dispose();
            toolTip1.SetToolTip(pictureBox1, "Hora actual: " + HH + ":" + Mm + ":" + SS + ".\n Fecha: " + DD + "/" + MM + "/" + AA + ".");
        }
        public void TiempoReloj(PictureBox pictureBox1, ToolTip toolTip1)
        {
            g = Graphics.FromImage(bmp);

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            String AA = DateTime.Now.Year.ToString();
            String MM = DateTime.Now.Month.ToString();
            if (MM.Length < 2) { MM = "0" + MM; }
            String DD = DateTime.Now.Day.ToString();
            if (DD.Length < 2) { DD = "0" + DD; }
            String SS = DateTime.Now.Second.ToString();
            if (SS.Length < 2) { SS = "0" + SS; }
            String Mm = DateTime.Now.Minute.ToString();
            if (Mm.Length < 2) { Mm = "0" + Mm; }
            String HH = DateTime.Now.Hour.ToString();
            if (HH.Length < 2) { HH = "0" + HH; }


            int[] handCoord = new int[2];

            g.Clear(SystemColors.Control);

            g.DrawEllipse(new Pen(Blue, 7f), 0, 0, WIDTH, HEIGHT);

            g.DrawString("|", new Font("Arial", 40), Brushes.LightBlue, new PointF(135, -3));//12
            g.DrawString("__", new Font("Arial", 40), Brushes.LightBlue, new PointF(240, 95));//3
            g.DrawString("|", new Font("Arial", 40), Brushes.LightBlue, new PointF(135, 240));//6
            g.DrawString("__", new Font("Arial", 40), Brushes.LightBlue, new PointF(0, 95));//9

            handCoord = msCoord(ss, secHAND);
            g.DrawLine(new Pen(Blue, 7f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            handCoord = msCoord(mm, minHAND);
            g.DrawLine(new Pen(Blue, 8f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            handCoord = hrCoord(hh % 12, mm, hrHAND);
            g.DrawLine(new Pen(Blue, 10f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            pictureBox1.Image = bmp;

            g.Dispose();
            toolTip1.SetToolTip(pictureBox1, "Hora actual: " + HH + ":" + Mm + ":" + SS + ".\n Fecha: " + DD + "/" + MM + "/" + AA + ".");
        }
        public void Tiempo(PictureBox pictureBox1, ToolTip toolTip1, Color Fuente, Color Fondo)
        {
            g = Graphics.FromImage(bmp);

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            String AA = DateTime.Now.Year.ToString();
            String MM = DateTime.Now.Month.ToString();
            if (MM.Length < 2) { MM = "0" + MM; }
            String DD = DateTime.Now.Day.ToString();
            if (DD.Length < 2) { DD = "0" + DD; }
            String SS = DateTime.Now.Second.ToString();
            if (SS.Length < 2) { SS = "0" + SS; }
            String Mm = DateTime.Now.Minute.ToString();
            if (Mm.Length < 2) { Mm = "0" + Mm; }
            String HH = DateTime.Now.Hour.ToString();
            if (HH.Length < 2) { HH = "0" + HH; }


            int[] handCoord = new int[2];

            g.Clear(Fondo);


            //g.DrawString("|", new Font("Arial", 20f, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))), Brush[0], new PointF(135, -3));//12
            //g.DrawString("__", new Font("Arial", 40), Brush[1], new PointF(240, 95));//3
            //g.DrawString("|", new Font("Arial", 40), Brush[2], new PointF(135, 240));//6
            //g.DrawString("__", new Font("Arial", 40), Brush[3], new PointF(0, 95));//9

            handCoord = hrCoord(hh % 12, mm, hrHAND);
            g.DrawLine(new Pen(Fuente, 15f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            handCoord = msCoord(mm, minHAND);
            g.DrawLine(new Pen(Fuente, 13f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            handCoord = msCoord(ss, secHAND);
            g.DrawLine(new Pen(Fuente, 10f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            pictureBox1.Image = bmp;

            g.Dispose();
            toolTip1.SetToolTip(pictureBox1, "Hora actual: " + HH + ":" + Mm + ":" + SS + ".\n Fecha: " + DD + "/" + MM + "/" + AA + ".");
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
