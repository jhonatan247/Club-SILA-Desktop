#region Código hecho por Jhonatan Torres
#region Librerías
//Librerías que se requerirán a lo largo de la clase, obtenidas de las referencias de ensamblado.
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
using System.Drawing;
#endregion

#region Manejo de datos
namespace Negocio.Manejo_de_datos
{
    #region Class
    //Clase que realizará los procesos relacionados con la tabla OBJETO de la base de datos SILA.
    public class CRUD_Objeto
    {
        #region Atributos
        //Atributos pertenecientes a la clase.
        private DataConnection ED = new DataConnection();
        private Byte[] DatosImg = new Byte[0];
        private Byte[] _IMAGEN_OBJETO;
        #endregion

        #region Propiedades
        //Propiedades de la clase.
        SqlCommand Comando { get; set; }
        MemoryStream MemS { get; set; }

        public Int64 ID_OBJETO { get; set; }
        public String NOMBRE_OBJETO { get; set; }
        public String DESCRIPCION_OBJETO { get; set; }
        public Int64 VALOR_APROXIMADO_OBJETO { get; set; }
        public Image IMAGEN_OBJETO
        {
            get 
            {
                DatosImg = (Byte[])_IMAGEN_OBJETO;
                MemS = new MemoryStream(DatosImg);
                return Bitmap.FromStream(MemS);
            }
            set 
            {
                MemS = new MemoryStream();
                value.Save(MemS, ImageFormat.Png);
                _IMAGEN_OBJETO = MemS.GetBuffer(); 
            }
        }
        public DateTime FECHA { get; set; }
        #endregion

        #region Constructores
        //Constructores, creadores de la clase.
        public CRUD_Objeto()
        {
        }
        public CRUD_Objeto(Int64 pID_OBJETO, String pNOMBRE_OBJETO, String pDESCRIPCION_OBJETO, Int64 pVALOR_APROXIMADO_OBJETO, Image pIMAGEN_OBJETO)
        {
            this.ID_OBJETO = pID_OBJETO;
            this.NOMBRE_OBJETO = pNOMBRE_OBJETO;
            this.DESCRIPCION_OBJETO = pDESCRIPCION_OBJETO;
            this.VALOR_APROXIMADO_OBJETO = pVALOR_APROXIMADO_OBJETO;
            this.IMAGEN_OBJETO = pIMAGEN_OBJETO;
        }
        public CRUD_Objeto(Int64 pID_OBJETO, Int64 pVALOR_APROXIMADO_OBJETO)
        {
            this.ID_OBJETO = pID_OBJETO;
            this.VALOR_APROXIMADO_OBJETO = pVALOR_APROXIMADO_OBJETO;
        }
        public CRUD_Objeto(Image pIMAGEN_OBJETO)
        {
            this.IMAGEN_OBJETO = pIMAGEN_OBJETO;
        }
        public CRUD_Objeto(DateTime pFECHA)
        {
            this.FECHA = pFECHA;
        }
        public CRUD_Objeto(String pNOMBRE_OBJETO, DateTime pFECHA)
        {
            this.FECHA = pFECHA;
            this.NOMBRE_OBJETO = pNOMBRE_OBJETO;
        }
        public CRUD_Objeto(String pValorString, Int64 pID_OBJETO)
        {
            this.NOMBRE_OBJETO = pValorString;
            this.DESCRIPCION_OBJETO = pValorString;
            this.ID_OBJETO = pID_OBJETO;
        }
        public CRUD_Objeto(Image pIMAGEN_OBJETO, Int64 pID_OBJETO)
        {
            this.IMAGEN_OBJETO = pIMAGEN_OBJETO;
            this.ID_OBJETO = pID_OBJETO;
        }
        public CRUD_Objeto(String pValorString)
        {
            this.NOMBRE_OBJETO = pValorString;
            this.DESCRIPCION_OBJETO = pValorString;
        }
        public CRUD_Objeto(Int64 pValorInt)
        {
            this.ID_OBJETO = pValorInt;
            this.VALOR_APROXIMADO_OBJETO = pValorInt;
        }
        #endregion

        #region Métodos
        //Métodos que realizará la clase con respecto a la base de datos del programa.

        /// Método INSERT:
        /// Realiza el proceso de crear un nuevo registro en la tabla.
        public Int64 INSERT ()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "INSERT_OBJETO";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = this.NOMBRE_OBJETO;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            SqlParameter DESCRIPCION_OBJETO = new SqlParameter();
            DESCRIPCION_OBJETO.ParameterName = "@DESCRIPCION_OBJETO";
            DESCRIPCION_OBJETO.Value = this.DESCRIPCION_OBJETO;
            DESCRIPCION_OBJETO.Direction = ParameterDirection.Input;
            DESCRIPCION_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(DESCRIPCION_OBJETO);

            SqlParameter VALOR_APROXIMADO_OBJETO = new SqlParameter();
            VALOR_APROXIMADO_OBJETO.ParameterName = "@VALOR_APROXIMADO_OBJETO";
            VALOR_APROXIMADO_OBJETO.Value = this.VALOR_APROXIMADO_OBJETO;
            VALOR_APROXIMADO_OBJETO.Direction = ParameterDirection.Input;
            VALOR_APROXIMADO_OBJETO.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(VALOR_APROXIMADO_OBJETO);

            SqlParameter IMAGEN_OBJETO = new SqlParameter();
            IMAGEN_OBJETO.ParameterName = "@IMAGEN_OBJETO";
            IMAGEN_OBJETO.Value = this._IMAGEN_OBJETO;
            IMAGEN_OBJETO.Direction = ParameterDirection.Input;
            IMAGEN_OBJETO.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(IMAGEN_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }


        /// Métodos UPDATE:
        /// Realizan los procesos de actualizar parcial o completamente 
        /// una o todas las columnas de la tabla.
        public Int64 UPDATE()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_OBJETO";

            SqlParameter ID_OBJETO = new SqlParameter();
            ID_OBJETO.ParameterName = "@ID";
            ID_OBJETO.Value = this.ID_OBJETO;
            ID_OBJETO.Direction = ParameterDirection.Input;
            ID_OBJETO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(ID_OBJETO);

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = this.NOMBRE_OBJETO;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            SqlParameter DESCRIPCION_OBJETO = new SqlParameter();
            DESCRIPCION_OBJETO.ParameterName = "@DESCRIPCION_OBJETO";
            DESCRIPCION_OBJETO.Value = this.DESCRIPCION_OBJETO;
            DESCRIPCION_OBJETO.Direction = ParameterDirection.Input;
            DESCRIPCION_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(DESCRIPCION_OBJETO);

            SqlParameter VALOR_APROXIMADO_OBJETO = new SqlParameter();
            VALOR_APROXIMADO_OBJETO.ParameterName = "@VALOR_APROXIMADO_OBJETO";
            VALOR_APROXIMADO_OBJETO.Value = this.VALOR_APROXIMADO_OBJETO;
            VALOR_APROXIMADO_OBJETO.Direction = ParameterDirection.Input;
            VALOR_APROXIMADO_OBJETO.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(VALOR_APROXIMADO_OBJETO);

            SqlParameter IMAGEN_OBJETO = new SqlParameter();
            IMAGEN_OBJETO.ParameterName = "@IMAGEN_OBJETO";
            IMAGEN_OBJETO.Value = this._IMAGEN_OBJETO;
            IMAGEN_OBJETO.Direction = ParameterDirection.Input;
            IMAGEN_OBJETO.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(IMAGEN_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE_1()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_OBJETO_TDESCRIPCION";

            SqlParameter DESCRIPCION_OBJETO = new SqlParameter();
            DESCRIPCION_OBJETO.ParameterName = "@DESCRIPCION_OBJETO";
            DESCRIPCION_OBJETO.Value = this.DESCRIPCION_OBJETO;
            DESCRIPCION_OBJETO.Direction = ParameterDirection.Input;
            DESCRIPCION_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(DESCRIPCION_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE_2()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_OBJETO_TVALOR";

            SqlParameter VALOR_APROXIMADO_OBJETO = new SqlParameter();
            VALOR_APROXIMADO_OBJETO.ParameterName = "@VALOR_APROXIMADO_OBJETO";
            VALOR_APROXIMADO_OBJETO.Value = this.VALOR_APROXIMADO_OBJETO;
            VALOR_APROXIMADO_OBJETO.Direction = ParameterDirection.Input;
            VALOR_APROXIMADO_OBJETO.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(VALOR_APROXIMADO_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE_3()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_OBJETO_TIMAGEN";

            SqlParameter IMAGEN_OBJETO = new SqlParameter();
            IMAGEN_OBJETO.ParameterName = "@IMAGEN_OBJETO";
            IMAGEN_OBJETO.Value = this._IMAGEN_OBJETO;
            IMAGEN_OBJETO.Direction = ParameterDirection.Input;
            IMAGEN_OBJETO.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(IMAGEN_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE_4()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_OBJETO_DESCRIPCION";

            SqlParameter ID_OBJETO = new SqlParameter();
            ID_OBJETO.ParameterName = "@ID_OBJETO";
            ID_OBJETO.Value = this.ID_OBJETO;
            ID_OBJETO.Direction = ParameterDirection.Input;
            ID_OBJETO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(ID_OBJETO);

            SqlParameter DESCRIPCION_OBJETO = new SqlParameter();
            DESCRIPCION_OBJETO.ParameterName = "@DESCRIPCION_OBJETO";
            DESCRIPCION_OBJETO.Value = this.DESCRIPCION_OBJETO;
            DESCRIPCION_OBJETO.Direction = ParameterDirection.Input;
            DESCRIPCION_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(DESCRIPCION_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE_5()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_OBJETO_TVALOR";

            SqlParameter ID_OBJETO = new SqlParameter();
            ID_OBJETO.ParameterName = "@ID_OBJETO";
            ID_OBJETO.Value = this.ID_OBJETO;
            ID_OBJETO.Direction = ParameterDirection.Input;
            ID_OBJETO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(ID_OBJETO);

            SqlParameter VALOR_APROXIMADO_OBJETO = new SqlParameter();
            VALOR_APROXIMADO_OBJETO.ParameterName = "@VALOR_APROXIMADO_OBJETO";
            VALOR_APROXIMADO_OBJETO.Value = this.VALOR_APROXIMADO_OBJETO;
            VALOR_APROXIMADO_OBJETO.Direction = ParameterDirection.Input;
            VALOR_APROXIMADO_OBJETO.SqlDbType = SqlDbType.Money;
            Comando.Parameters.Add(VALOR_APROXIMADO_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 UPDATE_6()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE_OBJETO_TIMAGEN";

            SqlParameter ID_OBJETO = new SqlParameter();
            ID_OBJETO.ParameterName = "@ID_OBJETO";
            ID_OBJETO.Value = this.ID_OBJETO;
            ID_OBJETO.Direction = ParameterDirection.Input;
            ID_OBJETO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(ID_OBJETO);

            SqlParameter IMAGEN_OBJETO = new SqlParameter();
            IMAGEN_OBJETO.ParameterName = "@IMAGEN_OBJETO";
            IMAGEN_OBJETO.Value = this._IMAGEN_OBJETO;
            IMAGEN_OBJETO.Direction = ParameterDirection.Input;
            IMAGEN_OBJETO.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(IMAGEN_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }

        public Int64 RECICLAR(Int64 ID)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "RECICLAR_OBJETO";

            SqlParameter ID_OBJETO = new SqlParameter();
            ID_OBJETO.ParameterName = "@ID";
            ID_OBJETO.Value = ID;
            ID_OBJETO.Direction = ParameterDirection.Input;
            ID_OBJETO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(ID_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 RECUPERAR(Int64 ID)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "RECUPERAR_OBJETO";

            SqlParameter ID_OBJETO = new SqlParameter();
            ID_OBJETO.ParameterName = "@ID";
            ID_OBJETO.Value = ID;
            ID_OBJETO.Direction = ParameterDirection.Input;
            ID_OBJETO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(ID_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }

        public Int64 TRECICLAR()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "RECICLAR_TOBJETO";

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 TRECUPERAR()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "RECUPERAR_TOBJETO";

            return ED.ProcedureExecuteNonQuery(Comando);
        }

        public Int64 DELETE(Int64 ID)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "DELETE_OBJETO";

            SqlParameter ID_OBJETO = new SqlParameter();
            ID_OBJETO.ParameterName = "@ID";
            ID_OBJETO.Value = ID;
            ID_OBJETO.Direction = ParameterDirection.Input;
            ID_OBJETO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(ID_OBJETO);

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 TDELETE()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "DELETE_TOBJETO";

            return ED.ProcedureExecuteNonQuery(Comando);
        }
        public Int64 TRDELETE()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "DELETE_TROBJETO";

            return ED.ProcedureExecuteNonQuery(Comando);
        }

        public DataTable LIKE_OBJETOT(String NOMBRE, DateTime FECHAA)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_OBJETOT";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            SqlParameter FECHA = new SqlParameter();
            FECHA.ParameterName = "@FECHA";
            FECHA.Value = FECHAA;
            FECHA.Direction = ParameterDirection.Input;
            FECHA.SqlDbType = SqlDbType.Date;
            Comando.Parameters.Add(FECHA);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LIKETT(String NOMBRE)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_OBJETOTT";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LIKE1(String NOMBRE)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_OBJETON";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LIKE2(String NOMBRE)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_OBJETOP";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LIKE3(String NOMBRE)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_OBJETOD";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable LIKE4(DateTime FECHAA)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_OBJETOF";

            SqlParameter FECHA = new SqlParameter();
            FECHA.ParameterName = "@FECHA";
            FECHA.Value = FECHAA;
            FECHA.Direction = ParameterDirection.Input;
            FECHA.SqlDbType = SqlDbType.Date;
            Comando.Parameters.Add(FECHA);

            return ED.ProcedureExecuteReader(Comando);
        }

        public DataTable RLIKET(String NOMBRE, DateTime FECHAA)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_ROBJETOT";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            SqlParameter FECHA = new SqlParameter();
            FECHA.ParameterName = "@FECHA";
            FECHA.Value = FECHAA;
            FECHA.Direction = ParameterDirection.Input;
            FECHA.SqlDbType = SqlDbType.Date;
            Comando.Parameters.Add(FECHA);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable RLIKETT(String NOMBRE)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_ROBJETOTT";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable RLIKE1(String NOMBRE)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_ROBJETON";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable RLIKE2(String NOMBRE)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_ROBJETOP";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable RLIKE3(String NOMBRE)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_ROBJETOD";

            SqlParameter NOMBRE_OBJETO = new SqlParameter();
            NOMBRE_OBJETO.ParameterName = "@NOMBRE_OBJETO";
            NOMBRE_OBJETO.Value = NOMBRE;
            NOMBRE_OBJETO.Direction = ParameterDirection.Input;
            NOMBRE_OBJETO.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(NOMBRE_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable RLIKE4(DateTime FECHAA)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "LIKE_ROBJETOF";

            SqlParameter FECHA = new SqlParameter();
            FECHA.ParameterName = "@FECHA";
            FECHA.Value = FECHAA;
            FECHA.Direction = ParameterDirection.Input;
            FECHA.SqlDbType = SqlDbType.Date;
            Comando.Parameters.Add(FECHA);

            return ED.ProcedureExecuteReader(Comando);
        }

        public DataTable SELECT(Int64 ID)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_OBJETO";

            SqlParameter ID_OBJETO = new SqlParameter();
            ID_OBJETO.ParameterName = "@ID";
            ID_OBJETO.Value = ID;
            ID_OBJETO.Direction = ParameterDirection.Input;
            ID_OBJETO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(ID_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable TSELECT()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "TSELECT_OBJETO";

            return ED.ProcedureExecuteReader(Comando);
        }

        public DataTable RSELECT(Int64 ID)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT_ROBJETO";

            SqlParameter ID_OBJETO = new SqlParameter();
            ID_OBJETO.ParameterName = "@ID";
            ID_OBJETO.Value = ID;
            ID_OBJETO.Direction = ParameterDirection.Input;
            ID_OBJETO.SqlDbType = SqlDbType.BigInt;
            Comando.Parameters.Add(ID_OBJETO);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable TRSELECT()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "TSELECT_ROBJETO";

            return ED.ProcedureExecuteReader(Comando);
        }

        public DataTable TSELECT_GRAFICAR()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "TSELECT_GRAFICAR_OBJETO";

            return ED.ProcedureExecuteReader(Comando);
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
