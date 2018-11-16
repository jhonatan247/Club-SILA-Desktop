using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class Calculadora
    {
        public static bool Numero(Char sender, TextBox Text)
        {
            try
            {
                float.Parse(Text.Text);
            }
            catch
            {
                Text.Text = "0";
            }
            if(Text.Text == "0")
            {
                Text.Text = ""+sender;
            }
            else
            {
                Text.Text += sender;
            }
            return true;
        }
        public static bool Borrar(TextBox Text)
        {
            try
            {
                float.Parse(Text.Text);
            }
            catch
            {
                Text.Text = "0";
            }
            if (Text.Text != "0")
            {
                int hasta = Text.Text.Length - 1;
                string rta = Text.Text.Substring(0, hasta);
                Text.Text = rta;
                
            }
            return true;
        }
        public static bool Coma(TextBox Text)
        {

            string rta = Text.Text.Substring(Text.Text.Length - 1, 1);
            if (rta != ",")
            {
                string Rest = Text.Text + ",";
                try
                {
                    float.Parse(Rest);
                    Text.Text = Rest;
                }
                catch { }
            }
            return true;
        }
        public static bool Signo(TextBox Text)
        {
            try
            {
                float.Parse(Text.Text);
            }
            catch
            {
                Text.Text = "0";
            }
            if (Text.Text != "0")
            {
                string rta = Text.Text.Substring(0, 1);
                if (rta == "-")
                {
                    Text.Text = Text.Text.Substring(1, Text.Text.Length - 1);
                }
                else
                {
                    Text.Text = "-" + Text.Text;
                    
                }
            }
            return true;
        }
        public static String Operacion(Int32 Index, String Text)
        {
            switch (Index)
            {
                case 1:
                    return Text + "+";
                case 2:
                    return Text + "-";
                case 3:
                    return Text + "*";
                case 4:
                    return Text + "/";
                default:
                    return Text;
            }
        }
        public static float Operar(float Ini, Int32 Index , float Fin)
        {
            try
            {
                switch (Index)
                {
                    case 1:
                        return Ini + Fin;
                    case 2:
                        return Ini - Fin;
                    case 3:
                        return Ini * Fin;
                    case 4:
                        return Ini / Fin;
                    default:
                        return 0;
                }
            }
            catch { }
            return 0; 
        }
    }
}
