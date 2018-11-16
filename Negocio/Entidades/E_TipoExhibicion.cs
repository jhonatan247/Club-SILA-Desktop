#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region ENTIDAD
namespace Negocio.Entidades
{
    #region Class
    public class E_TipoExhibicion
    {
        #region Atributos
        public Int64 ID_TIPO_EXHIBICION { get; set; }
        public String NOMBRE_TIPO_EXHIBICION { get; set; }
        public String DESCRIPCION_TIPO_EXHIBICION { get; set; }
        #endregion

        #region Constructor
        public E_TipoExhibicion()
        {
        }
        #endregion

        #region Métodos
        public E_TipoExhibicion(Int64 pID_TIPO_EXHIBICION, String pNOMBRE_TIPO_EXHIBICION, String pDESCRIPCION_TIPO_EXHIBICION)
        {
            this.ID_TIPO_EXHIBICION = pID_TIPO_EXHIBICION;
            this.NOMBRE_TIPO_EXHIBICION = pNOMBRE_TIPO_EXHIBICION;
            this.DESCRIPCION_TIPO_EXHIBICION = pDESCRIPCION_TIPO_EXHIBICION;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
