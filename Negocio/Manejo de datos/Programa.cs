#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;
using System.Data.SqlClient;
using Datos;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
#endregion

#region Manejo de datos
namespace Negocio.Manejo_de_datos
{
    #region Class
    public class Programa
    {
        #region Atributos
        DataConnection ED = new DataConnection();
        #endregion

        #region Parametros
        SqlCommand Comando { get; set; }
        MemoryStream MemS { get; set; }
        #endregion

        #region Constructor
        public Programa()
        {
        }
        #endregion

        #region Métodos
        public Int64 UPDATE1(E_Programa ENTIDAD)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_PROGRAM1";

            SqlParameter FORMULARIO = new SqlParameter();
            FORMULARIO.ParameterName = "@FORMULARIO";
            FORMULARIO.Value = ENTIDAD.FORMULARIO;
            FORMULARIO.Direction = ParameterDirection.Input;
            FORMULARIO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(FORMULARIO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE3(E_Programa ENTIDAD)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_PROGRAM3";

            SqlParameter RED = new SqlParameter();
            RED.ParameterName = "@RED";
            RED.Value = ENTIDAD.RED;
            RED.Direction = ParameterDirection.Input;
            RED.SqlDbType = SqlDbType.Int;
            Comando.Parameters.Add(RED);

            SqlParameter GREEN = new SqlParameter();
            GREEN.ParameterName = "@GREEN";
            GREEN.Value = ENTIDAD.GREEN;
            GREEN.Direction = ParameterDirection.Input;
            GREEN.SqlDbType = SqlDbType.Int;
            Comando.Parameters.Add(GREEN);

            SqlParameter BLUE = new SqlParameter();
            BLUE.ParameterName = "@BLUE";
            BLUE.Value = ENTIDAD.BLUE;
            BLUE.Direction = ParameterDirection.Input;
            BLUE.SqlDbType = SqlDbType.Int;
            Comando.Parameters.Add(BLUE);

            SqlParameter RED1 = new SqlParameter();
            RED1.ParameterName = "@RED1";
            RED1.Value = ENTIDAD.RED1;
            RED1.Direction = ParameterDirection.Input;
            RED1.SqlDbType = SqlDbType.Int;
            Comando.Parameters.Add(RED1);

            SqlParameter GREEN1 = new SqlParameter();
            GREEN1.ParameterName = "@GREEN1";
            GREEN1.Value = ENTIDAD.GREEN1;
            GREEN1.Direction = ParameterDirection.Input;
            GREEN1.SqlDbType = SqlDbType.Int;
            Comando.Parameters.Add(GREEN1);

            SqlParameter BLUE1 = new SqlParameter();
            BLUE1.ParameterName = "@BLUE1";
            BLUE1.Value = ENTIDAD.BLUE1;
            BLUE1.Direction = ParameterDirection.Input;
            BLUE1.SqlDbType = SqlDbType.Int;
            Comando.Parameters.Add(BLUE1);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE4(E_Programa ENTIDAD)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_PROGRAM4";

            SqlParameter SONIDO = new SqlParameter();
            SONIDO.ParameterName = "@SONIDO";
            SONIDO.Value = ENTIDAD.SONIDO;
            SONIDO.Direction = ParameterDirection.Input;
            SONIDO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(SONIDO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE7(E_Programa ENTIDAD)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_PROGRAM7";

            MemS = new MemoryStream();
            ENTIDAD.FOTO_PERFIL.Save(MemS, ImageFormat.Png);
            SqlParameter FOTO_PERFIL = new SqlParameter();
            FOTO_PERFIL.ParameterName = "@FOTO_PERFIL";
            FOTO_PERFIL.Value = MemS.GetBuffer();
            FOTO_PERFIL.Direction = ParameterDirection.Input;
            FOTO_PERFIL.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(FOTO_PERFIL);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE8(E_Programa ENTIDAD)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_PROGRAM8";

            SqlParameter FORMULARIO = new SqlParameter();
            FORMULARIO.ParameterName = "@FORMULARIO";
            FORMULARIO.Value = ENTIDAD.FORMULARIO;
            FORMULARIO.Direction = ParameterDirection.Input;
            FORMULARIO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(FORMULARIO);

            SqlParameter FMR_ANTERIOR = new SqlParameter();
            FMR_ANTERIOR.ParameterName = "@FMR_ANTERIOR";
            FMR_ANTERIOR.Value = ENTIDAD.FMR_ANTERIOR;
            FMR_ANTERIOR.Direction = ParameterDirection.Input;
            FMR_ANTERIOR.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(FMR_ANTERIOR);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public DataTable AUTENTIFICAR(String NOMBRE_USUARIOo, String CONTRASEÑAa)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "AUTENTIFICAR";

            SqlParameter NOMBRE_USUARIO = new SqlParameter();
            NOMBRE_USUARIO.ParameterName = "@NOMBRE_USUARIO";
            NOMBRE_USUARIO.Value = NOMBRE_USUARIOo;
            NOMBRE_USUARIO.Direction = ParameterDirection.Input;
            NOMBRE_USUARIO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_USUARIO);

            SqlParameter CONTRASEÑA = new SqlParameter();
            CONTRASEÑA.ParameterName = "@CONTRASEÑA";
            CONTRASEÑA.Value = CONTRASEÑAa;
            CONTRASEÑA.Direction = ParameterDirection.Input;
            CONTRASEÑA.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(CONTRASEÑA);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable AUTENTIFICAR_MAYUS(Int64 IDD)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "AUTENTIFICAR_MAYUS";

            SqlParameter ID = new SqlParameter();
            ID.ParameterName = "@ID";
            ID.Value = IDD;
            ID.Direction = ParameterDirection.Input;
            ID.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(ID);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable SELECT_NOMBRE_USUARIO(String NOMBRE_USUARIOo)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_NOMBRE_USUARIO";

            SqlParameter NOMBRE_USUARIO = new SqlParameter();
            NOMBRE_USUARIO.ParameterName = "@NOMBRE_USUARIO";
            NOMBRE_USUARIO.Value = NOMBRE_USUARIOo;
            NOMBRE_USUARIO.Direction = ParameterDirection.Input;
            NOMBRE_USUARIO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_USUARIO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable TSELECT()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_PROGRAM";

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable TSELECT1()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_PROGRAM1";

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable TSELECT2()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_PROGRAM2";

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable TSELECT3()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_PROGRAM3";

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable TSELECT4()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_PROGRAM4";

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable TSELECT5()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_PROGRAM5";

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable TSELECT6()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_PROGRAM6";

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable OBTENER_DATOS(Int64 IDD)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "OBTENER_DATOS";

            SqlParameter ID = new SqlParameter();
            ID.ParameterName = "@ID";
            ID.Value = IDD;
            ID.Direction = ParameterDirection.Input;
            ID.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(ID);

            return ED.ProcedureExecuteReader(Comando);
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
