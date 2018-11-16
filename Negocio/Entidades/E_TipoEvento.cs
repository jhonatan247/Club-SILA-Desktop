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
    public class E_TipoEvento
    {
        #region Atributos
        public Int64 ID_TIPO_EVENTO { get; set; }
        public String NOMBRE_TIPO_EVENTO { get; set; }
        public String DESCRIPCION_TIPO_EVENTO { get; set; }
        public String IMAGEN_TIPO_EVENTO { get; set; }
        #endregion

        #region Constructor
        public E_TipoEvento()
        {
        }
        #endregion

        #region Métodos
        public E_TipoEvento(Int64 pID_TIPO_EVENTO, String pNOMBRE_TIPO_EVENTO, String pDESCRIPCION_TIPO_EVENTO, String pIMAGEN_TIPO_EVENTO)
        {
            this.ID_TIPO_EVENTO = pID_TIPO_EVENTO;
            this.NOMBRE_TIPO_EVENTO = pNOMBRE_TIPO_EVENTO;
            this.DESCRIPCION_TIPO_EVENTO = pDESCRIPCION_TIPO_EVENTO;
            this.IMAGEN_TIPO_EVENTO = pIMAGEN_TIPO_EVENTO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
