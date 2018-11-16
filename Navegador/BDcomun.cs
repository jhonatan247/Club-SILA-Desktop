using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using Navegador.Properties;
using System.Configuration;

namespace Navegador
{
    class BDcomun
    {
        public static string ObtenerString1()
        {
            return Settings.Default.Navegador1ConnectionString;
        }
        public static OleDbConnection ObtenerConexion()
        {


            OleDbConnection conn = new OleDbConnection(ObtenerString1());
            conn.Open();
            return conn;

        }
    }
}
