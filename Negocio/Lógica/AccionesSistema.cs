#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Lógica;
using Negocio.Entidades;
using Negocio.Manejo_de_datos;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Media;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using Negocio.Properties;
#endregion

#region Lógica
namespace Negocio.Lógica
{
    #region Class
    public class AccionesSistema
    {
        #region Atributos
        MensajeBx MensajeBx = new MensajeBx();
        Programa Prog = new Programa();
        Color Blue = Color.FromArgb(3, 169, 244);
        private String Fichero = "Conexion.txt";
        #endregion

        #region Propiedades
        CRUD_Objeto CEntidad { get; set; }
        Color Fuente { get; set; }
        Color Fondo { get; set; }
        List<SoundPlayer> Snd { get; set; }
        List<Image> Img { get; set; }
        List<String> Txt { get; set; }
        E_Programa Entidad { get; set; }
        SoundPlayer Sonido { get; set; }
        Boolean Retorno { get; set; }
        Color Tinte { get; set; }
        DataRow Drow { get; set; }
        DataTable Tabla { get; set; }
        #endregion

        #region Acciones
        public Boolean CerrarSesion()
        {
                if (MensajeBx.CerrarSesion() == DialogResult.Yes)
                {
                    Entidad = new E_Programa(99999);
                    if (Prog.UPDATE1(Entidad) == 1)
                    {
                        Application.Restart(); return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
        }
        public void CambiarFormulario(uint FormularioSig, uint FormularioAnt)
        {
            Entidad = new E_Programa(FormularioSig, FormularioAnt);
                if (Prog.UPDATE8(Entidad) == 1)
                    Application.Restart();
        }
        public void RegresarFormAnt()
        {
            Drow = Prog.TSELECT1().Rows[0];
            if (Convert.ToInt64(Drow[1]) <= 5 && Convert.ToInt64(Drow[1]) > 0)
            {
                Entidad = new E_Programa(Convert.ToInt64(Drow[1]));
                if (Prog.UPDATE1(Entidad) == 1)
                    Application.Restart();
            }
            else if (Convert.ToInt64(Drow[1]) > 5)
            {
                Entidad = new E_Programa(Convert.ToInt64(Drow[1]), 0);
                if (Prog.UPDATE8(Entidad) == 1)
                    Application.Restart();
            }
            else
            {
                VolverInicio();
            }
        }
        public void VolverInicio()
        {
            Drow = Prog.TSELECT1().Rows[0];
            Entidad = new E_Programa(Convert.ToInt64(Drow[2]));
            if (Prog.UPDATE1(Entidad) == 1)
                Application.Restart();
        }
        public void TipoSerie(Chart Grafica, Int32 Index)
        {
            switch (Index)
            {
                case 0:
                    Grafica.Series[0].ChartType = SeriesChartType.Point;
                    break;
                case 1:
                    Grafica.Series[0].ChartType = SeriesChartType.FastPoint;
                    break;
                case 2:
                    Grafica.Series[0].ChartType = SeriesChartType.Bubble;
                    break;
                case 3:
                    Grafica.Series[0].ChartType = SeriesChartType.Line;
                    break;
                case 4:
                    Grafica.Series[0].ChartType = SeriesChartType.Spline;
                    break;
                case 5:
                    Grafica.Series[0].ChartType = SeriesChartType.StepLine;
                    break;
                case 6:
                    Grafica.Series[0].ChartType = SeriesChartType.FastLine;
                    break;
                case 7:
                    Grafica.Series[0].ChartType = SeriesChartType.Bar;
                    break;
                case 8:
                    Grafica.Series[0].ChartType = SeriesChartType.StackedBar;
                    break;
                case 9:
                    Grafica.Series[0].ChartType = SeriesChartType.StackedBar100;
                    break;
                case 10:
                    Grafica.Series[0].ChartType = SeriesChartType.Column;
                    break;
                case 11:
                    Grafica.Series[0].ChartType = SeriesChartType.StackedColumn;
                    break;
                case 12:
                    Grafica.Series[0].ChartType = SeriesChartType.StackedColumn100;
                    break;
                case 13:
                    Grafica.Series[0].ChartType = SeriesChartType.Area;
                    break;
                case 14:
                    Grafica.Series[0].ChartType = SeriesChartType.SplineArea;
                    break;
                case 15:
                    Grafica.Series[0].ChartType = SeriesChartType.StackedArea;
                    break;
                case 16:
                    Grafica.Series[0].ChartType = SeriesChartType.StackedArea100;
                    break;
                case 17:
                    Grafica.Series[0].ChartType = SeriesChartType.Pie;
                    break;
                case 18:
                    Grafica.Series[0].ChartType = SeriesChartType.Doughnut;
                    break;
                case 19:
                    Grafica.Series[0].ChartType = SeriesChartType.Stock;
                    break;
                case 20:
                    Grafica.Series[0].ChartType = SeriesChartType.Candlestick;
                    break;
                case 21:
                    Grafica.Series[0].ChartType = SeriesChartType.Range;
                    break;
                case 22:
                    Grafica.Series[0].ChartType = SeriesChartType.SplineRange;
                    break;
                case 23:
                    Grafica.Series[0].ChartType = SeriesChartType.RangeBar;
                    break;
                case 24:
                    Grafica.Series[0].ChartType = SeriesChartType.RangeColumn;
                    break;
                case 25:
                    Grafica.Series[0].ChartType = SeriesChartType.Radar;
                    break;
                case 26:
                    Grafica.Series[0].ChartType = SeriesChartType.Polar;
                    break;
                case 27:
                    Grafica.Series[0].ChartType = SeriesChartType.ErrorBar;
                    break;
                case 28:
                    Grafica.Series[0].ChartType = SeriesChartType.BoxPlot;
                    break;
                case 29:
                    Grafica.Series[0].ChartType = SeriesChartType.Renko;
                    break;
                case 30:
                    Grafica.Series[0].ChartType = SeriesChartType.ThreeLineBreak;
                    break;
                case 31:
                    Grafica.Series[0].ChartType = SeriesChartType.Kagi;
                    break;
                case 32:
                    Grafica.Series[0].ChartType = SeriesChartType.PointAndFigure;
                    break;
                case 33:
                    Grafica.Series[0].ChartType = SeriesChartType.Funnel;
                    break;
                case 34:
                    Grafica.Series[0].ChartType = SeriesChartType.Pyramid;
                    break;
                default:
                    break;
            }
        }
        public void PaletaSerie(Chart Grafica, Int32 Index)
        {
            switch (Index)
            {
                case 0:
                    Grafica.Series[0].Palette = ChartColorPalette.None;
                    Grafica.Palette = ChartColorPalette.None;
                    break;
                case 1:
                    Grafica.Series[0].Palette = ChartColorPalette.Bright;
                    Grafica.Palette = ChartColorPalette.Bright;
                    break;
                case 2:
                    Grafica.Series[0].Palette = ChartColorPalette.Grayscale;
                    Grafica.Palette = ChartColorPalette.Grayscale;
                    break;
                case 3:
                    Grafica.Series[0].Palette = ChartColorPalette.Excel;
                    Grafica.Palette = ChartColorPalette.Excel;
                    break;
                case 4:
                    Grafica.Series[0].Palette = ChartColorPalette.Light;
                    Grafica.Palette = ChartColorPalette.Light;
                    break;
                case 5:
                    Grafica.Series[0].Palette = ChartColorPalette.Pastel;
                    Grafica.Palette = ChartColorPalette.Pastel;
                    break;
                case 6:
                    Grafica.Series[0].Palette = ChartColorPalette.EarthTones;
                    Grafica.Palette = ChartColorPalette.EarthTones;
                    break;
                case 7:
                    Grafica.Series[0].Palette = ChartColorPalette.SemiTransparent;
                    Grafica.Palette = ChartColorPalette.SemiTransparent;
                    break;
                case 8:
                    Grafica.Series[0].Palette = ChartColorPalette.Berry;
                    Grafica.Palette = ChartColorPalette.Berry;
                    break;
                case 9:
                    Grafica.Series[0].Palette = ChartColorPalette.Chocolate;
                    Grafica.Palette = ChartColorPalette.Chocolate;
                    break;
                case 10:
                    Grafica.Series[0].Palette = ChartColorPalette.Fire;
                    Grafica.Palette = ChartColorPalette.Fire;
                    break;
                case 11:
                    Grafica.Series[0].Palette = ChartColorPalette.SeaGreen;
                    Grafica.Palette = ChartColorPalette.SeaGreen;
                    break;
                case 12:
                    Grafica.Series[0].Palette = ChartColorPalette.BrightPastel;
                    Grafica.Palette = ChartColorPalette.BrightPastel;
                    break;
                default:
                    break;
            }
        }
        public List<SoundPlayer> Sonidos()
        {
            Snd = new List<SoundPlayer>();
            Snd.Add(new SoundPlayer(Resources.Boton)); //0
            Snd.Add(new SoundPlayer(Resources.Camara)); //1
            Snd.Add(new SoundPlayer(Resources.Inicio)); //2
            Snd.Add(new SoundPlayer(Resources.Minimizado)); //3
            Snd.Add(new SoundPlayer(Resources.Datos)); //4
            Snd.Add(new SoundPlayer(Resources.Silencio)); //5
            Snd.Add(new SoundPlayer(Resources.Aplauso)); //6
            return Snd;
        }
        public List<Image> Imagenes()
        {
            Img = new List<Image>();
            Img.Add(Resources.SonidoA); //0
            Img.Add(Resources.SonidoD); //1
            Img.Add(Resources.sql); //2
            Img.Add(Resources.logot); //3
            Img.Add(Resources.framework); //4
            Img.Add(Resources.logo2); //5
            Img.Add(Resources.Hombre); //6
            Img.Add(Resources.Mujer); //7
            Img.Add(Resources.Maleta); //8
            Img.Add(Resources.Free); //9
            Img.Add(Resources.Share); //10
            Img.Add(Resources.x000); //11
            Img.Add(Resources.GUsuarios); //12
            Img.Add(Resources.Gasistencia); //13
            Img.Add(Resources.GDocumentos); //14
            Img.Add(Resources.GLogros); //15
            Img.Add(Resources.GAhorro); //16
            Img.Add(Resources.GLecciones); //17
            Img.Add(Resources._134); //18
            return Img;
        }
        public Image Anima(int xx)
        {
            Image Imagg = Resources._000;
            switch(xx)
            {
                case 0:
                    Imagg = Resources._000;
                    break;
                case 1:
                    Imagg = Resources._001;
                    break;
                case 2:
                    Imagg = Resources._002;
                    break;
                case 3:
                    Imagg = Resources._003;
                    break;
                case 4:
                    Imagg = Resources._004;
                    break;
                case 5:
                    Imagg = Resources._005;
                    break;
                case 6:
                    Imagg = Resources._006;
                    break;
                case 7:
                    Imagg = Resources._007;
                    break;
                case 8:
                    Imagg = Resources._008;
                    break;
                case 9:
                    Imagg = Resources._009;
                    break;
                case 10:
                    Imagg = Resources._010;
                    break;
                case 11:
                    Imagg = Resources._011;
                    break;
                case 12:
                    Imagg = Resources._012;
                    break;
                case 13:
                    Imagg = Resources._013;
                    break;
                case 14:
                    Imagg = Resources._014;
                    break;
                case 15:
                    Imagg = Resources._015;
                    break;
                case 16:
                    Imagg = Resources._016;
                    break;
                case 17:
                    Imagg = Resources._017;
                    break;
                case 18:
                    Imagg = Resources._018;
                    break;
                case 19:
                    Imagg = Resources._019;
                    break;
                case 20:
                    Imagg = Resources._020;
                    break;
                case 21:
                    Imagg = Resources._021;
                    break;
                case 22:
                    Imagg = Resources._022;
                    break;
                case 23:
                    Imagg = Resources._023;
                    break;
                case 24:
                    Imagg = Resources._024;
                    break;
                case 25:
                    Imagg = Resources._025;
                    break;
                case 26:
                    Imagg = Resources._026;
                    break;
                case 27:
                    Imagg = Resources._027;
                    break;
                case 28:
                    Imagg = Resources._028;
                    break;
                case 29:
                    Imagg = Resources._029;
                    break;
                case 30:
                    Imagg = Resources._030;
                    break;
                case 31:
                    Imagg = Resources._031;
                    break;
                case 32:
                    Imagg = Resources._032;
                    break;
                case 33:
                    Imagg = Resources._033;
                    break;
                case 34:
                    Imagg = Resources._034;
                    break;
                case 35:
                    Imagg = Resources._035;
                    break;
                case 36:
                    Imagg = Resources._036;
                    break;
                case 37:
                    Imagg = Resources._037;
                    break;
                case 38:
                    Imagg = Resources._038;
                    break;
                case 39:
                    Imagg = Resources._039;
                    break;
                case 40:
                    Imagg = Resources._040;
                    break;
                case 41:
                    Imagg = Resources._041;
                    break;
                case 42:
                    Imagg = Resources._042;
                    break;
                case 43:
                    Imagg = Resources._043;
                    break;
                case 44:
                    Imagg = Resources._044;
                    break;
                case 45:
                    Imagg = Resources._045;
                    break;
                case 46:
                    Imagg = Resources._046;
                    break;
                case 47:
                    Imagg = Resources._047;
                    break;
                case 48:
                    Imagg = Resources._048;
                    break;
                case 49:
                    Imagg = Resources._049;
                    break;
                case 50:
                    Imagg = Resources._050;
                    break;
                case 51:
                    Imagg = Resources._051;
                    break;
                case 52:
                    Imagg = Resources._052;
                    break;
                case 53:
                    Imagg = Resources._053;
                    break;
                case 54:
                    Imagg = Resources._054;
                    break;
                case 55:
                    Imagg = Resources._055;
                    break;
                case 56:
                    Imagg = Resources._056;
                    break;
                case 57:
                    Imagg = Resources._057;
                    break;
                case 58:
                    Imagg = Resources._058;
                    break;
                case 59:
                    Imagg = Resources._059;
                    break;
                case 60:
                    Imagg = Resources._060;
                    break;
                case 61:
                    Imagg = Resources._061;
                    break;
                case 62:
                    Imagg = Resources._062;
                    break;
                case 63:
                    Imagg = Resources._063;
                    break;
                case 64:
                    Imagg = Resources._064;
                    break;
                case 65:
                    Imagg = Resources._065;
                    break;
                case 66:
                    Imagg = Resources._066;
                    break;
                case 67:
                    Imagg = Resources._067;
                    break;
                case 68:
                    Imagg = Resources._068;
                    break;
                case 69:
                    Imagg = Resources._069;
                    break;
                case 70:
                    Imagg = Resources._070;
                    break;
                case 71:
                    Imagg = Resources._071;
                    break;
                default:
                    Imagg = Resources._000;
                    break;
            }
            return Imagg;
        }
        public Image Spro(int xx)
        {
            Image Imagg = Resources.Spro000;
            switch(xx)
            {
                case 0:
                    Imagg = Resources.Spro000;
                    break;
                case 1:
                    Imagg = Resources.Spro001;
                    break;
                case 2:
                    Imagg = Resources.Spro002;
                    break;
                case 3:
                    Imagg = Resources.Spro003;
                    break;
                case 4:
                    Imagg = Resources.Spro004;
                    break;
                case 5:
                    Imagg = Resources.Spro005;
                    break;
                case 6:
                    Imagg = Resources.Spro006;
                    break;
                case 7:
                    Imagg = Resources.Spro007;
                    break;
                case 8:
                    Imagg = Resources.Spro008;
                    break;
                case 9:
                    Imagg = Resources.Spro009;
                    break;
                case 10:
                    Imagg = Resources.Spro000;
                    break;
                case 11:
                    Imagg = Resources.Spro011;
                    break;
                case 12:
                    Imagg = Resources.Spro012;
                    break;
                case 13:
                    Imagg = Resources.Spro013;
                    break;
                case 14:
                    Imagg = Resources.Spro014;
                    break;
                case 15:
                    Imagg = Resources.Spro015;
                    break;
                case 16:
                    Imagg = Resources.Spro016;
                    break;
                case 17:
                    Imagg = Resources.Spro017;
                    break;
                case 18:
                    Imagg = Resources.Spro018;
                    break;
                case 19:
                    Imagg = Resources.Spro019;
                    break;
                case 20:
                    Imagg = Resources.Spro020;
                    break;
                case 21:
                    Imagg = Resources.Spro021;
                    break;
                case 22:
                    Imagg = Resources.Spro022;
                    break;
                case 23:
                    Imagg = Resources.Spro023;
                    break;
                case 24:
                    Imagg = Resources.Spro024;
                    break;
                case 25:
                    Imagg = Resources.Spro025;
                    break;
                case 26:
                    Imagg = Resources.Spro026;
                    break;
                case 27:
                    Imagg = Resources.Spro027;
                    break;
                case 28:
                    Imagg = Resources.Spro028;
                    break;
                case 29:
                    Imagg = Resources.Spro029;
                    break;
                case 30:
                    Imagg = Resources.Spro030;
                    break;
                case 31:
                    Imagg = Resources.Spro031;
                    break;
                case 32:
                    Imagg = Resources.Spro032;
                    break;
                case 33:
                    Imagg = Resources.Spro033;
                    break;
                case 34:
                    Imagg = Resources.Spro034;
                    break;
                case 35:
                    Imagg = Resources.Spro035;
                    break;
                case 36:
                    Imagg = Resources.Spro036;
                    break;
                case 37:
                    Imagg = Resources.Spro037;
                    break;
                case 38:
                    Imagg = Resources.Spro038;
                    break;
                case 39:
                    Imagg = Resources.Spro039;
                    break;
                case 40:
                    Imagg = Resources.Spro040;
                    break;
                case 41:
                    Imagg = Resources.Spro041;
                    break;
                case 42:
                    Imagg = Resources.Spro042;
                    break;
                case 43:
                    Imagg = Resources.Spro043;
                    break;
                case 44:
                    Imagg = Resources.Spro044;
                    break;
                case 45:
                    Imagg = Resources.Spro045;
                    break;
                case 46:
                    Imagg = Resources.Spro046;
                    break;
                case 47:
                    Imagg = Resources.Spro047;
                    break;
                case 48:
                    Imagg = Resources.Spro048;
                    break;
                case 49:
                    Imagg = Resources.Spro049;
                    break;
                case 50:
                    Imagg = Resources.Spro050;
                    break;
                case 51:
                    Imagg = Resources.Spro051;
                    break;
                case 52:
                    Imagg = Resources.Spro052;
                    break;
                case 53:
                    Imagg = Resources.Spro053;
                    break;
                case 54:
                    Imagg = Resources.Spro054;
                    break;
                case 55:
                    Imagg = Resources.Spro055;
                    break;
                case 56:
                    Imagg = Resources.Spro056;
                    break;
                case 57:
                    Imagg = Resources.Spro057;
                    break;
                case 58:
                    Imagg = Resources.Spro058;
                    break;
                case 59:
                    Imagg = Resources.Spro059;
                    break;
                case 60:
                    Imagg = Resources.Spro060;
                    break;
                case 61:
                    Imagg = Resources.Spro061;
                    break;
                case 62:
                    Imagg = Resources.Spro062;
                    break;
                case 63:
                    Imagg = Resources.Spro063;
                    break;
                case 64:
                    Imagg = Resources.Spro064;
                    break;
                case 65:
                    Imagg = Resources.Spro065;
                    break;
                case 66:
                    Imagg = Resources.Spro066;
                    break;
                case 67:
                    Imagg = Resources.Spro067;
                    break;
                case 68:
                    Imagg = Resources.Spro068;
                    break;
                case 69:
                    Imagg = Resources.Spro069;
                    break;
                case 70:
                    Imagg = Resources.Spro070;
                    break;
                case 71:
                    Imagg = Resources.Spro071;
                    break;
                case 72:
                    Imagg = Resources.Spro072;
                    break;
                case 73:
                    Imagg = Resources.Spro073;
                    break;
                case 74:
                    Imagg = Resources.Spro074;
                    break;
                case 75:
                    Imagg = Resources.Spro075;
                    break;
                case 76:
                    Imagg = Resources.Spro076;
                    break;
                case 77:
                    Imagg = Resources.Spro077;
                    break;
                case 78:
                    Imagg = Resources.Spro078;
                    break;
                case 79:
                    Imagg = Resources.Spro079;
                    break;
                case 80:
                    Imagg = Resources.Spro080;
                    break;
                case 81:
                    Imagg = Resources.Spro081;
                    break;
                case 82:
                    Imagg = Resources.Spro082;
                    break;
                case 83:
                    Imagg = Resources.Spro083;
                    break;
                case 84:
                    Imagg = Resources.Spro084;
                    break;
                case 85:
                    Imagg = Resources.Spro085;
                    break;
                case 86:
                    Imagg = Resources.Spro086;
                    break;
                case 87:
                    Imagg = Resources.Spro087;
                    break;
                case 88:
                    Imagg = Resources.Spro088;
                    break;
                case 89:
                    Imagg = Resources.Spro089;
                    break;
                case 90:
                    Imagg = Resources.Spro090;
                    break;
                case 91:
                    Imagg = Resources.Spro091;
                    break;
                case 92:
                    Imagg = Resources.Spro092;
                    break;
                case 93:
                    Imagg = Resources.Spro093;
                    break;
                case 94:
                    Imagg = Resources.Spro094;
                    break;
                case 95:
                    Imagg = Resources.Spro095;
                    break;
                case 96:
                    Imagg = Resources.Spro096;
                    break;
                case 97:
                    Imagg = Resources.Spro097;
                    break;
                case 98:
                    Imagg = Resources.Spro098;
                    break;
                case 99:
                    Imagg = Resources.Spro099;
                    break;
                case 100:
                    Imagg = Resources.Spro100;
                    break;
                case 101:
                    Imagg = Resources.Spro101;
                    break;
                case 102:
                    Imagg = Resources.Spro102;
                    break;
                case 103:
                    Imagg = Resources.Spro103;
                    break;
                case 104:
                    Imagg = Resources.Spro104;
                    break;
                case 105:
                    Imagg = Resources.Spro105;
                    break;
                case 106:
                    Imagg = Resources.Spro106;
                    break;
                case 107:
                    Imagg = Resources.Spro107;
                    break;
                case 108:
                    Imagg = Resources.Spro108;
                    break;
                case 109:
                    Imagg = Resources.Spro109;
                    break;
                case 110:
                    Imagg = Resources.Spro100;
                    break;
                case 111:
                    Imagg = Resources.Spro111;
                    break;
                case 112:
                    Imagg = Resources.Spro112;
                    break;
                case 113:
                    Imagg = Resources.Spro113;
                    break;
                case 114:
                    Imagg = Resources.Spro114;
                    break;
                case 115:
                    Imagg = Resources.Spro115;
                    break;
                case 116:
                    Imagg = Resources.Spro116;
                    break;
                case 117:
                    Imagg = Resources.Spro117;
                    break;
                case 118:
                    Imagg = Resources.Spro118;
                    break;
                case 119:
                    Imagg = Resources.Spro119;
                    break;
                case 120:
                    Imagg = Resources.Spro120;
                    break;
                case 121:
                    Imagg = Resources.Spro121;
                    break;
                case 122:
                    Imagg = Resources.Spro122;
                    break;
                case 123:
                    Imagg = Resources.Spro123;
                    break;
                case 124:
                    Imagg = Resources.Spro124;
                    break;
                case 125:
                    Imagg = Resources.Spro125;
                    break;
                case 126:
                    Imagg = Resources.Spro126;
                    break;
                case 127:
                    Imagg = Resources.Spro127;
                    break;
                case 128:
                    Imagg = Resources.Spro128;
                    break;
                case 129:
                    Imagg = Resources.Spro129;
                    break;
                case 130:
                    Imagg = Resources.Spro130;
                    break;
                case 131:
                    Imagg = Resources.Spro131;
                    break;
                case 132:
                    Imagg = Resources.Spro132;
                    break;
                case 133:
                    Imagg = Resources.Spro133;
                    break;
                case 134:
                    Imagg = Resources.Spro134;
                    break;
                case 135:
                    Imagg = Resources.Spro135;
                    break;
                case 136:
                    Imagg = Resources.Spro136;
                    break;
                case 137:
                    Imagg = Resources.Spro137;
                    break;
                case 138:
                    Imagg = Resources.Spro138;
                    break;
                case 139:
                    Imagg = Resources.Spro139;
                    break;
                case 140:
                    Imagg = Resources.Spro140;
                    break;
                case 141:
                    Imagg = Resources.Spro141;
                    break;
                case 142:
                    Imagg = Resources.Spro142;
                    break;
                case 143:
                    Imagg = Resources.Spro143;
                    break;
                case 144:
                    Imagg = Resources.Spro144;
                    break;
                case 145:
                    Imagg = Resources.Spro145;
                    break;
                case 146:
                    Imagg = Resources.Spro146;
                    break;
                case 147:
                    Imagg = Resources.Spro147;
                    break;
                case 148:
                    Imagg = Resources.Spro148;
                    break;
                case 149:
                    Imagg = Resources.Spro149;
                    break;
                case 150:
                    Imagg = Resources.Spro150;
                    break;
                case 151:
                    Imagg = Resources.Spro151;
                    break;
                case 152:
                    Imagg = Resources.Spro152;
                    break;
                case 153:
                    Imagg = Resources.Spro153;
                    break;
                case 154:
                    Imagg = Resources.Spro154;
                    break;
                case 155:
                    Imagg = Resources.Spro155;
                    break;
                case 156:
                    Imagg = Resources.Spro156;
                    break;
                case 157:
                    Imagg = Resources.Spro157;
                    break;
                case 158:
                    Imagg = Resources.Spro158;
                    break;
                case 159:
                    Imagg = Resources.Spro159;
                    break;
                case 160:
                    Imagg = Resources.Spro160;
                    break;
                case 161:
                    Imagg = Resources.Spro161;
                    break;
                case 162:
                    Imagg = Resources.Spro162;
                    break;
                case 163:
                    Imagg = Resources.Spro163;
                    break;
                case 164:
                    Imagg = Resources.Spro164;
                    break;
                case 165:
                    Imagg = Resources.Spro165;
                    break;
                case 166:
                    Imagg = Resources.Spro166;
                    break;
                case 167:
                    Imagg = Resources.Spro167;
                    break;
                case 168:
                    Imagg = Resources.Spro168;
                    break;
                case 169:
                    Imagg = Resources.Spro169;
                    break;
                case 170:
                    Imagg = Resources.Spro170;
                    break;
                case 171:
                    Imagg = Resources.Spro171;
                    break;
                case 172:
                    Imagg = Resources.Spro172;
                    break;
                case 173:
                    Imagg = Resources.Spro173;
                    break;
                case 174:
                    Imagg = Resources.Spro174;
                    break;
                case 175:
                    Imagg = Resources.Spro175;
                    break;
                case 176:
                    Imagg = Resources.Spro176;
                    break;
                case 177:
                    Imagg = Resources.Spro177;
                    break;
                case 178:
                    Imagg = Resources.Spro178;
                    break;
                case 179:
                    Imagg = Resources.Spro179;
                    break;
                case 180:
                    Imagg = Resources.Spro180;
                    break;
                case 181:
                    Imagg = Resources.Spro181;
                    break;
                case 182:
                    Imagg = Resources.Spro182;
                    break;
                case 183:
                    Imagg = Resources.Spro183;
                    break;
                case 184:
                    Imagg = Resources.Spro184;
                    break;
                case 185:
                    Imagg = Resources.Spro185;
                    break;
                case 186:
                    Imagg = Resources.Spro186;
                    break;
                case 187:
                    Imagg = Resources.Spro187;
                    break;
                case 188:
                    Imagg = Resources.Spro188;
                    break;
                case 189:
                    Imagg = Resources.Spro189;
                    break;
                case 190:
                    Imagg = Resources.Spro190;
                    break;
                case 191:
                    Imagg = Resources.Spro191;
                    break;
                case 192:
                    Imagg = Resources.Spro192;
                    break;
                case 193:
                    Imagg = Resources.Spro193;
                    break;
                case 194:
                    Imagg = Resources.Spro194;
                    break;
                case 195:
                    Imagg = Resources.Spro195;
                    break;
                case 196:
                    Imagg = Resources.Spro196;
                    break;
                case 197:
                    Imagg = Resources.Spro197;
                    break;
                case 198:
                    Imagg = Resources.Spro198;
                    break;
                case 199:
                    Imagg = Resources.Spro199;
                    break;
                case 200:
                    Imagg = Resources.Spro200;
                    break;
                case 201:
                    Imagg = Resources.Spro201;
                    break;
                case 202:
                    Imagg = Resources.Spro202;
                    break;
                case 203:
                    Imagg = Resources.Spro203;
                    break;
                case 204:
                    Imagg = Resources.Spro204;
                    break;
                case 205:
                    Imagg = Resources.Spro205;
                    break;
                case 206:
                    Imagg = Resources.Spro206;
                    break;
                case 207:
                    Imagg = Resources.Spro207;
                    break;
                case 208:
                    Imagg = Resources.Spro208;
                    break;
                case 209:
                    Imagg = Resources.Spro209;
                    break;
                case 210:
                    Imagg = Resources.Spro200;
                    break;
                case 211:
                    Imagg = Resources.Spro211;
                    break;
                case 212:
                    Imagg = Resources.Spro212;
                    break;
                case 213:
                    Imagg = Resources.Spro213;
                    break;
                case 214:
                    Imagg = Resources.Spro214;
                    break;
                case 215:
                    Imagg = Resources.Spro215;
                    break;
                case 216:
                    Imagg = Resources.Spro216;
                    break;
                case 217:
                    Imagg = Resources.Spro217;
                    break;
                case 218:
                    Imagg = Resources.Spro218;
                    break;
                case 219:
                    Imagg = Resources.Spro219;
                    break;
                case 220:
                    Imagg = Resources.Spro220;
                    break;
                case 221:
                    Imagg = Resources.Spro221;
                    break;
                case 222:
                    Imagg = Resources.Spro222;
                    break;
                case 223:
                    Imagg = Resources.Spro223;
                    break;
                case 224:
                    Imagg = Resources.Spro224;
                    break;
                case 225:
                    Imagg = Resources.Spro225;
                    break;
                case 226:
                    Imagg = Resources.Spro226;
                    break;
                case 227:
                    Imagg = Resources.Spro227;
                    break;
                case 228:
                    Imagg = Resources.Spro228;
                    break;
                case 229:
                    Imagg = Resources.Spro229;
                    break;
                case 230:
                    Imagg = Resources.Spro230;
                    break;
                case 231:
                    Imagg = Resources.Spro231;
                    break;
                case 232:
                    Imagg = Resources.Spro232;
                    break;
                case 233:
                    Imagg = Resources.Spro233;
                    break;
                case 234:
                    Imagg = Resources.Spro234;
                    break;
                case 235:
                    Imagg = Resources.Spro235;
                    break;
                case 236:
                    Imagg = Resources.Spro236;
                    break;
                case 237:
                    Imagg = Resources.Spro237;
                    break;
                case 238:
                    Imagg = Resources.Spro238;
                    break;
                case 239:
                    Imagg = Resources.Spro239;
                    break;
                case 240:
                    Imagg = Resources.Spro240;
                    break;
                case 241:
                    Imagg = Resources.Spro241;
                    break;
                case 242:
                    Imagg = Resources.Spro242;
                    break;
                case 243:
                    Imagg = Resources.Spro243;
                    break;
                case 244:
                    Imagg = Resources.Spro244;
                    break;
                case 245:
                    Imagg = Resources.Spro245;
                    break;
                case 246:
                    Imagg = Resources.Spro246;
                    break;
                case 247:
                    Imagg = Resources.Spro247;
                    break;
                case 248:
                    Imagg = Resources.Spro248;
                    break;
                case 249:
                    Imagg = Resources.Spro249;
                    break;
                case 250:
                    Imagg = Resources.Spro250;
                    break;
                case 251:
                    Imagg = Resources.Spro251;
                    break;
                case 252:
                    Imagg = Resources.Spro252;
                    break;
                case 253:
                    Imagg = Resources.Spro253;
                    break;
                case 254:
                    Imagg = Resources.Spro254;
                    break;
                case 255:
                    Imagg = Resources.Spro255;
                    break;
                case 256:
                    Imagg = Resources.Spro256;
                    break;
                case 257:
                    Imagg = Resources.Spro257;
                    break;
                case 258:
                    Imagg = Resources.Spro258;
                    break;
                case 259:
                    Imagg = Resources.Spro259;
                    break;
                case 260:
                    Imagg = Resources.Spro260;
                    break;
                case 261:
                    Imagg = Resources.Spro261;
                    break;
                case 262:
                    Imagg = Resources.Spro262;
                    break;
                case 263:
                    Imagg = Resources.Spro263;
                    break;
                case 264:
                    Imagg = Resources.Spro264;
                    break;
                case 265:
                    Imagg = Resources.Spro265;
                    break;
                case 266:
                    Imagg = Resources.Spro266;
                    break;
                case 267:
                    Imagg = Resources.Spro267;
                    break;
                case 268:
                    Imagg = Resources.Spro268;
                    break;
                case 269:
                    Imagg = Resources.Spro269;
                    break;
                case 270:
                    Imagg = Resources.Spro270;
                    break;
                case 271:
                    Imagg = Resources.Spro271;
                    break;
                case 272:
                    Imagg = Resources.Spro272;
                    break;
                case 273:
                    Imagg = Resources.Spro273;
                    break;
                case 274:
                    Imagg = Resources.Spro274;
                    break;
                case 275:
                    Imagg = Resources.Spro275;
                    break;
                case 276:
                    Imagg = Resources.Spro276;
                    break;
                case 377:
                    Imagg = Resources.Spro277;
                    break;
                case 278:
                    Imagg = Resources.Spro278;
                    break;
                case 279:
                    Imagg = Resources.Spro279;
                    break;
                case 280:
                    Imagg = Resources.Spro280;
                    break;
                case 281:
                    Imagg = Resources.Spro281;
                    break;
                case 282:
                    Imagg = Resources.Spro282;
                    break;
                case 283:
                    Imagg = Resources.Spro283;
                    break;
                case 284:
                    Imagg = Resources.Spro284;
                    break;
                case 285:
                    Imagg = Resources.Spro285;
                    break;
                case 286:
                    Imagg = Resources.Spro286;
                    break;
                case 287:
                    Imagg = Resources.Spro287;
                    break;
                case 288:
                    Imagg = Resources.Spro288;
                    break;
                case 289:
                    Imagg = Resources.Spro289;
                    break;
                case 290:
                    Imagg = Resources.Spro290;
                    break;
                case 291:
                    Imagg = Resources.Spro291;
                    break;
                case 292:
                    Imagg = Resources.Spro292;
                    break;
                case 293:
                    Imagg = Resources.Spro293;
                    break;
                case 294:
                    Imagg = Resources.Spro294;
                    break;
                case 295:
                    Imagg = Resources.Spro295;
                    break;
                case 296:
                    Imagg = Resources.Spro296;
                    break;
                case 297:
                    Imagg = Resources.Spro297;
                    break;
                case 298:
                    Imagg = Resources.Spro298;
                    break;
                case 299:
                    Imagg = Resources.Spro299;
                    break;
                case 300:
                    Imagg = Resources.Spro300;
                    break;
                case 301:
                    Imagg = Resources.Spro301;
                    break;
                case 302:
                    Imagg = Resources.Spro302;
                    break;
                case 303:
                    Imagg = Resources.Spro303;
                    break;
                case 304:
                    Imagg = Resources.Spro304;
                    break;
                case 305:
                    Imagg = Resources.Spro305;
                    break;
                case 306:
                    Imagg = Resources.Spro306;
                    break;
                case 307:
                    Imagg = Resources.Spro307;
                    break;
                case 308:
                    Imagg = Resources.Spro308;
                    break;
                case 309:
                    Imagg = Resources.Spro309;
                    break;
                case 310:
                    Imagg = Resources.Spro300;
                    break;
                case 311:
                    Imagg = Resources.Spro311;
                    break;
                case 312:
                    Imagg = Resources.Spro312;
                    break;
                case 313:
                    Imagg = Resources.Spro313;
                    break;
                case 314:
                    Imagg = Resources.Spro314;
                    break;
                case 315:
                    Imagg = Resources.Spro315;
                    break;
                case 316:
                    Imagg = Resources.Spro316;
                    break;
                case 317:
                    Imagg = Resources.Spro317;
                    break;
                case 318:
                    Imagg = Resources.Spro318;
                    break;
                case 319:
                    Imagg = Resources.Spro319;
                    break;
                case 320:
                    Imagg = Resources.Spro320;
                    break;
                case 321:
                    Imagg = Resources.Spro321;
                    break;
                case 322:
                    Imagg = Resources.Spro322;
                    break;
                case 323:
                    Imagg = Resources.Spro323;
                    break;
                case 324:
                    Imagg = Resources.Spro324;
                    break;
                case 325:
                    Imagg = Resources.Spro325;
                    break;
                case 326:
                    Imagg = Resources.Spro326;
                    break;
                case 327:
                    Imagg = Resources.Spro327;
                    break;
                case 328:
                    Imagg = Resources.Spro328;
                    break;
                case 329:
                    Imagg = Resources.Spro329;
                    break;
                case 330:
                    Imagg = Resources.Spro330;
                    break;
                case 331:
                    Imagg = Resources.Spro331;
                    break;
                case 332:
                    Imagg = Resources.Spro332;
                    break;
                case 333:
                    Imagg = Resources.Spro333;
                    break;
                case 334:
                    Imagg = Resources.Spro334;
                    break;
                case 335:
                    Imagg = Resources.Spro335;
                    break;
                case 336:
                    Imagg = Resources.Spro336;
                    break;
                case 337:
                    Imagg = Resources.Spro337;
                    break;
                case 338:
                    Imagg = Resources.Spro338;
                    break;
                case 339:
                    Imagg = Resources.Spro339;
                    break;
                case 340:
                    Imagg = Resources.Spro340;
                    break;
                case 341:
                    Imagg = Resources.Spro341;
                    break;
                case 342:
                    Imagg = Resources.Spro342;
                    break;
                case 343:
                    Imagg = Resources.Spro343;
                    break;
                case 344:
                    Imagg = Resources.Spro344;
                    break;
                case 345:
                    Imagg = Resources.Spro345;
                    break;
                case 346:
                    Imagg = Resources.Spro346;
                    break;
                case 347:
                    Imagg = Resources.Spro347;
                    break;
                case 348:
                    Imagg = Resources.Spro348;
                    break;
                case 349:
                    Imagg = Resources.Spro349;
                    break;
                case 350:
                    Imagg = Resources.Spro350;
                    break;
                case 351:
                    Imagg = Resources.Spro351;
                    break;
                case 352:
                    Imagg = Resources.Spro352;
                    break;
                case 353:
                    Imagg = Resources.Spro353;
                    break;
                case 354:
                    Imagg = Resources.Spro354;
                    break;
                case 355:
                    Imagg = Resources.Spro355;
                    break;
                case 356:
                    Imagg = Resources.Spro356;
                    break;
                case 357:
                    Imagg = Resources.Spro357;
                    break;
                case 358:
                    Imagg = Resources.Spro358;
                    break;
                case 359:
                    Imagg = Resources.Spro359;
                    break;
                case 360:
                    Imagg = Resources.Spro360;
                    break;
                case 361:
                    Imagg = Resources.Spro361;
                    break;
                case 362:
                    Imagg = Resources.Spro362;
                    break;
                case 363:
                    Imagg = Resources.Spro363;
                    break;
                case 364:
                    Imagg = Resources.Spro364;
                    break;
                case 365:
                    Imagg = Resources.Spro365;
                    break;
                case 366:
                    Imagg = Resources.Spro366;
                    break;
                case 367:
                    Imagg = Resources.Spro367;
                    break;
                case 368:
                    Imagg = Resources.Spro368;
                    break;
                case 369:
                    Imagg = Resources.Spro369;
                    break;
                case 370:
                    Imagg = Resources.Spro370;
                    break;
                case 371:
                    Imagg = Resources.Spro371;
                    break;
                case 372:
                    Imagg = Resources.Spro372;
                    break;
                default:
                    Imagg = Resources.Spro000;
                    break;
            }
            return Imagg;
        }
        public List<Image> ImagenesReloj()
        {
            Img = new List<Image>();
            Img.Add(Resources.num0); //0
            Img.Add(Resources.num1); //1
            Img.Add(Resources.num2); //2
            Img.Add(Resources.num3); //3
            Img.Add(Resources.num4); //4
            Img.Add(Resources.num5); //5
            Img.Add(Resources.num6); //6
            Img.Add(Resources.num7); //7
            Img.Add(Resources.num8); //8
            Img.Add(Resources.num9); //9
            Img.Add(Resources.numP); //10
            return Img;
        }
        public List<String> Textos()
        {
            Txt = new List<String>();
            Txt.Add("Desactivar sonidos"); //0
            Txt.Add("Activar sonidos"); //1
            Txt.Add("Micrososoft SQL Server 2012."); //2
            Txt.Add("Club Sila x86 versión: 1.4.5"); //3
            Txt.Add("Microsoft.NET Framework 4.0"); //4
            Txt.Add(@"Club Sila Express 1.4.5: Versión 
de prueba de Club Sila Professional con licencia de 
típo Shareware, ésta permite al usuario probar las 
funcionalidades del programa durante un periodo de 
tiempo limitado. Al culminar el periodo de prueba, 
la licencia pasa a ser de típo Standard."); //5
            Txt.Add(@"Club Sila Standard 1.4.5: Paquete 
básico de la versión de Club Sila para escritorio con 
licencia de típo Freeware que se adquiere gratuitamente. 
El paquete contiene las funcionalidades mínimas requeridas 
para satisfacer las necestidades básicas y generar en el 
usuario una experiencia agradable."); //6
            Txt.Add(@"Club Sila Professional 1.4.5: Paquete 
completo de la versión de Club Sila para escritorio con 
licencia de típo Comercial. El paquete contiene las herramientas 
profesionales de desarrollo, los servicios y los beneficios en su 
totalidad, que han sido desarrollados para satisfacer las necesidades 
más exigentes."); //7
            return Txt;
        }
        public Boolean Condicionales(Int16 Index, Object Sender)
        {
            switch(Index)
            {
                case 0:
                    Tinte = ((Color)Sender);
                    if ((Tinte.R >= 50 && Tinte.G >= 50 && Tinte.B >= 50)
                        | (Tinte.R >= 30 && Tinte.G >= 60 && Tinte.B >= 60)
                        | (Tinte.R >= 60 && Tinte.G >= 30 && Tinte.B >= 60)
                        | (Tinte.R >= 60 && Tinte.G >= 60 && Tinte.B >= 30)
                        | (Tinte.R >= 100 && Tinte.G >= 20 && Tinte.B >= 20)
                        | (Tinte.R >= 20 && Tinte.G >= 100 && Tinte.B >= 20)
                        | (Tinte.R >= 20 && Tinte.G >= 20 && Tinte.B >= 100)
                        | (Tinte.R >= 100 && Tinte.G >= 40 && Tinte.B >= 0)
                        | (Tinte.R >= 100 && Tinte.G >= 0 && Tinte.B >= 40)
                        | (Tinte.R >= 40 && Tinte.G >= 100 && Tinte.B >= 0)
                        | (Tinte.R >= 0 && Tinte.G >= 100 && Tinte.B >= 40)
                        | (Tinte.R >= 40 && Tinte.G >= 0 && Tinte.B >= 100)
                        | (Tinte.R >= 0 && Tinte.G >= 40 && Tinte.B >= 100)
                        | (Tinte.R >= 130 && Tinte.G >= 0 && Tinte.B >= 0)
                        | (Tinte.R >= 0 && Tinte.G >= 130 && Tinte.B >= 0)
                        | (Tinte.R >= 0 && Tinte.G >= 0 && Tinte.B >= 130))
                    {
                        Retorno = true;
                    }
                    else
                    {
                        Retorno = false;
                    }
                    break;
                case 1:
                    Tinte = ((Color)Sender);
                    if ((Tinte.R <= 205 && Tinte.G <= 205 && Tinte.B <= 205)
                        | (Tinte.R <= 225 && Tinte.G <= 195 && Tinte.B <= 195)
                        | (Tinte.R <= 195 && Tinte.G <= 225 && Tinte.B <= 195)
                        | (Tinte.R <= 195 && Tinte.G <= 195 && Tinte.B <= 225)
                        | (Tinte.R <= 155 && Tinte.G <= 235 && Tinte.B <= 235)
                        | (Tinte.R <= 235 && Tinte.G <= 155 && Tinte.B <= 235)
                        | (Tinte.R <= 235 && Tinte.G <= 235 && Tinte.B <= 155)
                        | (Tinte.R <= 155 && Tinte.G <= 115 && Tinte.B <= 255)
                        | (Tinte.R <= 155 && Tinte.G <= 255 && Tinte.B <= 115)
                        | (Tinte.R <= 115 && Tinte.G <= 155 && Tinte.B <= 255)
                        | (Tinte.R <= 255 && Tinte.G <= 155 && Tinte.B <= 115)
                        | (Tinte.R <= 115 && Tinte.G <= 255 && Tinte.B <= 155)
                        | (Tinte.R <= 255 && Tinte.G <= 115 && Tinte.B <= 155)
                        | (Tinte.R <= 125 && Tinte.G <= 255 && Tinte.B <= 255)
                        | (Tinte.R <= 255 && Tinte.G <= 125 && Tinte.B <= 255)
                        | (Tinte.R <= 255 && Tinte.G <= 255 && Tinte.B <= 125))
                    {
                        Retorno = true;
                    }
                    else
                    {
                        Retorno = false;
                    }
                    break;
                case 2:
                    Diseño();
                    Tinte = ((Color)Sender);
                    if ((Tinte.R == Fondo.R && Tinte.G == Fondo.G && Tinte.B == Fondo.B)
                    | (Tinte.R + 50 >= Fondo.R && Tinte.R - 50 <= Fondo.R && Tinte.G + 50 >= Fondo.G
                    && Tinte.G - 50 <= Fondo.G && Tinte.B + 50 >= Fondo.B && Tinte.B - 50 <= Fondo.B))
                    {
                        Retorno = false;
                    }
                    else
                    {
                        Retorno = true;
                    }
                    break;
                case 3:
                    Diseño();
                    Tinte = ((Color)Sender);
                    if ((Tinte.R == Fuente.R && Tinte.G == Fuente.G && Tinte.B == Fuente.B)
                    | (Tinte.R + 50 >= Fuente.R && Tinte.R - 50 <= Fuente.R && Tinte.G + 50 >= Fuente.G
                    && Tinte.G - 50 <= Fuente.G && Tinte.B + 50 >= Fuente.B && Tinte.B - 50 <= Fuente.B))
                    {
                        Retorno = false;
                    }
                    else
                    {
                        Retorno = true;
                    }
                    break;
                default:
                    break;
            }
            return Retorno;
        }
        public Int32 CondicionalesDobles(Int16 Index, Color Sender, Color Sender2)
        {
            Int32 R = Sender.R, G = Sender.G, B = Sender.B, R2 = Sender2.R, G2 = Sender2.G, B2 = Sender2.B;

            switch (Index)
            {
                case 0:
                    if (R == Color.Black.R && G == Color.Black.G && B == Color.Black.B &&
                        R2 == Color.White.R && G2 == Color.White.G && B2 == Color.White.B)
                    {
                        return 0;
                    }
                    else if (R == Blue.R && G == Blue.G && B == Blue.B &&
                        R2 == Color.White.R && G2 == Color.White.G && B2 == Color.White.B)
                    {
                        return 1;
                    }
                    else if (R == Color.White.R && G == Color.White.G && B == Color.White.B &&
                        R2 == Color.Black.R && G2 == Color.Black.G && B2 == Color.Black.B)
                    {
                        return 2;
                    }
                    else if (R == Color.White.R && G == Color.White.G && B == Color.White.B &&
                        R2 == Color.Tomato.R && G2 == Color.Tomato.G && B2 == Color.Tomato.B)
                    {
                        return 3;
                    }
                    else if (R == Color.White.R && G == Color.White.G && B == Color.White.B &&
                        R2 == Color.Green.R && G2 == Color.Green.G && B2 == Color.Green.B)
                    {
                        return 4;
                    }
                    else if (R == Color.White.R && G == Color.White.G && B == Color.White.B &&
                        R2 == Blue.R && G2 == Blue.G && B2 == Blue.B)
                    {
                        return 5;
                    }
                    else if (R == SystemColors.Control.R && G == SystemColors.Control.G && B == SystemColors.Control.B &&
                        R2 == Color.DimGray.R && G2 == Color.DimGray.G && B2 == Color.DimGray.B)
                    {
                        return 6;
                    }
                    else if (R == Color.DimGray.R && G == Color.DimGray.G && B == Color.DimGray.B &&
                        R2 == SystemColors.Control.R && G2 == SystemColors.Control.G && B2 == SystemColors.Control.B)
                    {
                        return 7;
                    }
                    if (R == Color.Red.R && G == Color.Red.G && B == Color.Red.B &&
                        R2 == Color.White.R && G2 == Color.White.G && B2 == Color.White.B)
                    {
                        return 8;
                    }
                    if (R == Color.Purple.R && G == Color.Purple.G && B == Color.Purple.B &&
                        R2 == Color.White.R && G2 == Color.White.G && B2 == Color.White.B)
                    {
                        return 9;
                    }
                    if (R == Color.DarkOrange.R && G == Color.DarkOrange.G && B == Color.DarkOrange.B &&
                        R2 == Color.White.R && G2 == Color.White.G && B2 == Color.White.B)
                    {
                        return 10;
                    }
                    if (R == Color.Teal.R && G == Color.Teal.G && B == Color.Teal.B &&
                        R2 == Color.White.R && G2 == Color.White.G && B2 == Color.White.B)
                    {
                        return 11;
                    }
                    if (R == Color.Gold.R && G == Color.Gold.G && B == Color.Gold.B &&
                        R2 == Color.White.R && G2 == Color.White.G && B2 == Color.White.B)
                    {
                        return 12;
                    }
                    if (R == Color.Turquoise.R && G == Color.Turquoise.G && B == Color.Turquoise.B &&
                        R2 == Color.White.R && G2 == Color.White.G && B2 == Color.White.B)
                    {
                        return 13;
                    }
                    else if (R == Color.White.R && G == Color.White.G && B == Color.White.B &&
                        R2 == Color.Red.R && G2 == Color.Red.G && B2 == Color.Red.B)
                    {
                        return 14;
                    }
                    else if (R == Color.White.R && G == Color.White.G && B == Color.White.B &&
                        R2 == Color.Purple.R && G2 == Color.Purple.G && B2 == Color.Purple.B)
                    {
                        return 15;
                    }
                    else if (R == Color.White.R && G == Color.White.G && B == Color.White.B &&
                        R2 == Color.DarkOrange.R && G2 == Color.DarkOrange.G && B2 == Color.DarkOrange.B)
                    {
                        return 16;
                    }
                    else if (R == Color.White.R && G == Color.White.G && B == Color.White.B &&
                        R2 == Color.Teal.R && G2 == Color.Teal.G && B2 == Color.Teal.B)
                    {
                        return 17;
                    }
                    else if (R == Color.Black.R && G == Color.Black.G && B == Color.Black.B &&
                        R2 == Color.Gold.R && G2 == Color.Gold.G && B2 == Color.Gold.B)
                    {
                        return 18;
                    }
                    else if (R == Color.White.R && G == Color.White.G && B == Color.White.B &&
                        R2 == Color.Turquoise.R && G2 == Color.Turquoise.G && B2 == Color.Turquoise.B)
                    {
                        return 19;
                    }
                    break;
                default:
                    break;
            }
            return 100;
        }
        public List<Color> Diseño()
        {
            List<Color> Colores = new List<Color>();
            Drow = Prog.TSELECT3().Rows[0];

            if (Drow[5] != null)
            {
                Fondo = Color.FromArgb(255, Convert.ToByte(Drow[3]), Convert.ToByte(Drow[4]), Convert.ToByte(Drow[5]));
            }
            else
            {
                Fondo = Color.FromArgb(255, 255, 255, 255);
            }

            if (Drow[0] != null)
            {
                Fuente = Color.FromArgb(255, Convert.ToByte(Drow[0]), Convert.ToByte(Drow[1]), Convert.ToByte(Drow[2]));
            }
            else
            {
                Fuente = Color.FromArgb(255, 0, 0, 0);
            }
            Colores.Add(Fondo);
            Colores.Add(Fuente);
            return Colores;
        }
        public DataTable TablaBuscar(Int32 Index, String Filtro)
        {
            switch (Index)
            {
                case 0:
                    CEntidad = new CRUD_Objeto();
                    try { Tabla = CEntidad.LIKETT(Filtro); }
                    catch {}
                    break;
                case 1:
                    CEntidad = new CRUD_Objeto();
                    try { Tabla = CEntidad.RLIKETT(Filtro); }
                    catch { }
                    break;
                default:
                    break;
            }
            return Tabla;
        }
        public DataRow TablaSeleccionar(Int32 Index, Int32 Id)
        {
            switch (Index)
            {
                case 0:
                    CRUD_Objeto CEntidad = new CRUD_Objeto();
                    try { Drow = CEntidad.SELECT(Id).Rows[0]; }
                    catch { }
                    break;
                default:
                    break;
            }
            return Drow;
        }
        public String DecryptFile()
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes("password");
            DES.IV = ASCIIEncoding.ASCII.GetBytes("password");
            FileStream fsread = new FileStream(Fichero, FileMode.Open, FileAccess.Read);
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);
            return "Server=" + new StreamReader(cryptostreamDecr).ReadToEnd() + ";DataBase=SILA;Integrated Security=SSPI";
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
