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
    public class E_TipoCombate
    {
        #region Atributos
        public Int64 ID_TIPO_COMBATE { get; set; }
        public String NOMBRE_TIPO_COMBATE { get; set; }
        public String DESCRIPCION_TIPO_COMBATE { get; set; }
        #endregion

        #region Constructor
        public E_TipoCombate()
        {
        }
        #endregion

        #region Métodos
        public E_TipoCombate(Int64 pID_TIPO_COMBATE, String pNOMBRE_TIPO_COMBATE, String pDESCRIPCION_TIPO_COMBATE)
        {
            this.ID_TIPO_COMBATE = pID_TIPO_COMBATE;
            this.NOMBRE_TIPO_COMBATE = pNOMBRE_TIPO_COMBATE;
            this.DESCRIPCION_TIPO_COMBATE = pDESCRIPCION_TIPO_COMBATE;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
