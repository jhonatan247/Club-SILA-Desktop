#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
#endregion

#region Conexión
namespace Datos
{
    #region Class
    public class DataConnection
    {
        #region Atributos
        private string cadena = string.Empty;
        private String Fichero = "Conexion.txt";
        #endregion

        #region Propiedades
        public SqlConnection Conexion { get; set; }
        public SqlCommand Comando { get; set; }
        public DataTable TablaRetorno { get; set; }
        public IDataReader Lector { get; set; }
        public Int64 retorno { get; set; }
        private SqlDataAdapter DA { get; set; }
        #endregion

        #region Constructor
        public DataConnection()
        {
            cadena = DecryptFile();
            Conexion = new SqlConnection();
            Comando = new SqlCommand();
            Abrir();
        }
        #endregion

        #region Métodos
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
        private void Abrir()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                return;
            }
            Conexion.ConnectionString = cadena;
            try
            {
                Conexion.Open();
            }
            catch
            {
                Process.Start("SQ_Server.exe");
                throw;
            }
        }
        private void Cerrar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                return;
            }
            try
            {
                Conexion.Close();
            }
            catch
            {
                throw;
            }
        }
        public Int64 ExecuteNonQuery(CommandType TipoComando, String consulta)
        {
            Abrir();
            Comando.Connection = Conexion;
            Comando.CommandType = TipoComando;
            Comando.CommandText = consulta;
            try
            {
                retorno = Comando.ExecuteNonQuery();
                Cerrar();
                return retorno;
            }
            catch
            {
                Cerrar();
                throw;
            }
        }
        public DataTable ExecuteReader(CommandType TipoComando, String consulta)
        {
            Abrir();
            Lector = null;
            Comando.Connection = Conexion;
            Comando.CommandType = TipoComando;
            Comando.CommandText = consulta;
            try
            {
                TablaRetorno = new DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(Comando);
                DA.Fill(TablaRetorno);
                Cerrar();
                return TablaRetorno;
            }
            catch
            {
                Cerrar();
                throw;
            }
        }
        public Int64 ProcedureExecuteNonQuery(SqlCommand pComando)
        {
            Abrir();
            pComando.Connection = Conexion;
            pComando.CommandType = CommandType.StoredProcedure;
            try
            {
                retorno = pComando.ExecuteNonQuery();
                Cerrar();
                return retorno;
            }
            catch
            {
                Cerrar();
                throw;
            }
        }
        public DataTable ProcedureExecuteReader(SqlCommand pComando)
        {
            Lector = null;
            pComando.Connection = Conexion;
            pComando.CommandType = CommandType.StoredProcedure;
            try
            {
                TablaRetorno = new DataTable();
                DA = new SqlDataAdapter(pComando);
                DA.Fill(TablaRetorno);
                Cerrar();
                return TablaRetorno;
            }
            catch
            {
                Cerrar();
                throw;
            }
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion