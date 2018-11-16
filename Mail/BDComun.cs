#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using Mail.Properties;
using System.Configuration;
#endregion

#region Mail
namespace Mail
{
    #region Class
    class BDComun
    {
        #region Atributos
        public static string ObtenerString1()
        {
            return Settings.Default.RegistroConnectionString;
        }
        #endregion

        #region Métodos
        public static OleDbConnection ObtenerConexion()
        {
            OleDbConnection conn = new OleDbConnection(ObtenerString1());
            conn.Open();
            return conn;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
