#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
#endregion

#region SILA
namespace Reproductor_SILA
{
    #region Class
    class MusicaDAL
    {
        #region Agregar, Eliminar y Reestablecer
        public static int Agregar(Musica pNuevo_Deportista)
        {
            int retorno = 0;


            using (OleDbConnection conn = BDComun.ObtenerConexion8())
            {
                try
                {
                    OleDbCommand Comando = new OleDbCommand(String.Format("Insert Into Url (Url) values ('{0}')",
                        pNuevo_Deportista.Url), conn);

                    retorno = Comando.ExecuteNonQuery();
                    Comando.Dispose();
                }
                catch (Exception)
                {

                }

                if (retorno > 0)
                {
                    OleDbCommand comando2 = new OleDbCommand(string.Format(
                        "Select N from N where Id = {0}", 1), conn);
                    OleDbDataReader reader = comando2.ExecuteReader();


                    while (reader.Read())
                    {

                        Int32 id = reader.GetInt32(0) + 1;

                        using (OleDbConnection con = BDComun.ObtenerConexion8())
                        {
                            OleDbCommand Coman = new OleDbCommand(string.Format("Update N set N = '{0}' where Id = {1}", id, 1), con);
                            Coman.ExecuteNonQuery();
                            Coman.Dispose();
                            con.Close();
                        }
                    }

                    comando2.Dispose();
                }
            }


            return retorno;
        }

        public static int Eliminar(String pId)
        {
            int retorno = 0;
            using (OleDbConnection conexion = BDComun.ObtenerConexion8())
            {
                OleDbCommand Comando = new OleDbCommand(string.Format("Delete from Url where Url = '{0}'", pId), conexion);
                retorno = Comando.ExecuteNonQuery();
                Comando.Dispose();
                if (retorno > 0)
                {
                    OleDbCommand comando2 = new OleDbCommand(string.Format(
                            "Select N from N where Id = {0}", 1), conexion);
                    OleDbDataReader reader = comando2.ExecuteReader();

                    while (reader.Read())
                    {

                        Int32 id = reader.GetInt32(0) - 1;

                        using (OleDbConnection con = BDComun.ObtenerConexion8())
                        {
                            OleDbCommand Coman = new OleDbCommand(string.Format("Update N set N = '{0}' where Id = {1}", id, 1), con);
                            Coman.ExecuteNonQuery();
                            Coman.Dispose();
                            con.Close();
                        }



                    }
                    comando2.Dispose();

                }
                return retorno;
            }
        }
        public static int Reestar()
        {
            int retorno = 0;
            using (OleDbConnection conexion = BDComun.ObtenerConexion8())
            {
                OleDbCommand Comando = new OleDbCommand(string.Format("Drop table Url"), conexion);
                Comando.ExecuteNonQuery();
                retorno = 1;
                Comando.Dispose();


                using (OleDbConnection con = BDComun.ObtenerConexion8())
                {
                    OleDbCommand Coman = new OleDbCommand(string.Format("Update N set N = {0} where Id = {1}", 0, 1), con);
                    Coman.ExecuteNonQuery();
                    Coman.Dispose();
                    con.Close();
                }
                using (OleDbConnection con2 = BDComun.ObtenerConexion8())
                {
                    OleDbCommand Coman = new OleDbCommand(string.Format("Create table Url (Id int identity (1,1) not null, Url text unique)"), con2);
                    Coman.ExecuteNonQuery();
                    Coman.Dispose();
                    con2.Close();
                }


                return retorno;
            }
        }

        #endregion

        #region Buscar y Obtener
        public static List<Musica> BuscarDeportista(String pNombre1)
        {
            List<Musica> lista = new List<Musica>();
            using (OleDbConnection conexion = BDComun.ObtenerConexion8())
            {
                OleDbCommand comando = new OleDbCommand(string.Format(
                    "Select * from Url where Url like '%{0}%'", pNombre1), conexion);

                OleDbDataReader reader = comando.ExecuteReader();
                int idd = 0;
                while (reader.Read())
                {
                    Musica pNuevo_Deportista = new Musica();
                    pNuevo_Deportista.Id = idd;
                    pNuevo_Deportista.Url = reader.GetString(1);

                    lista.Add(pNuevo_Deportista);
                    idd++;
                }
                conexion.Close();
                return lista;



            }

        }
        public static Musica ObtenerDeportista(Int64 pId)
        {
            using (OleDbConnection conexion = BDComun.ObtenerConexion8())
            {
                Musica pNuevo_Deportista = new Musica();
                OleDbCommand comando = new OleDbCommand(string.Format(
                    "Select Id, Url from Url where Id = {0}", pId), conexion);
                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pNuevo_Deportista.Id = reader.GetInt32(0);
                    pNuevo_Deportista.Url = reader.GetString(1);
                }
                conexion.Close();
                return pNuevo_Deportista;
            }
        }
        #endregion

    }
    #endregion
}
#endregion
#endregion