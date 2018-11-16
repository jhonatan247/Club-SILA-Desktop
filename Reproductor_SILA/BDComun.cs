#region Código hecho por Jhonatan Torres
#region Librerías
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
using Reproductor_SILA.Properties;
using System.Configuration;
#endregion

#region SILA
namespace Reproductor_SILA
{
    #region Class
    class BDComun
    {
        #region Atributos
        public static string ObtenerString8()
        {
            return Settings.Default.ReproductorConnectionString;
        }
        #endregion

        #region Métodos
        public static OleDbConnection ObtenerConexion8()
        {
            OleDbConnection conn = new OleDbConnection(ObtenerString8());
            conn.Open();
            return conn;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion