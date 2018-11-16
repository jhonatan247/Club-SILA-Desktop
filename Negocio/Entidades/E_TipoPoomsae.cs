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
    public class E_TipoPoomsae
    {
        #region Atributos
        public Int64 ID_TIPO_POOMSAE { get; set; }
        public String NOMBRE_TIPO_POOMSAE { get; set; }
        public String DESCRIPCION_TIPO_POOMSAE { get; set; }
        #endregion

        #region Constructor
        public E_TipoPoomsae()
        {
        }
        #endregion

        #region Métodos
        public E_TipoPoomsae(Int64 pID_TIPO_POOMSAE, String pNOMBRE_TIPO_POOMSAE, String pDESCRIPCION_TIPO_POOMSAE)
        {
            this.ID_TIPO_POOMSAE = pID_TIPO_POOMSAE;
            this.NOMBRE_TIPO_POOMSAE = pNOMBRE_TIPO_POOMSAE;
            this.DESCRIPCION_TIPO_POOMSAE = pDESCRIPCION_TIPO_POOMSAE;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
