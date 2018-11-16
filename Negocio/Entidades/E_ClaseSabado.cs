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
    public class E_ClaseSabado
    {
        #region Atributos
        public Int64 ID_CLASE_SABADO { get; set; }
        public String TIEMPO_EXPARSIMIENTO_CLASE_SABADO { get; set; }
        public String HORA_INICIO_CLASE_SABADO { get; set; }
        public String HORA_FINALIZACION_CLASE_SABADO { get; set; }
        #endregion

        #region Constructor
        public E_ClaseSabado()
        {
        }
        #endregion

        #region Métodos
        public E_ClaseSabado(Int64 pID_CLASE_SABADO, String pTIEMPO_EXPARSIMIENTO_CLASE_SABADO, String pHORA_INICIO_CLASE_SABADO, String pHORA_FINALIZACION_CLASE_SABADO)
        {
            this.ID_CLASE_SABADO = pID_CLASE_SABADO;
            this.TIEMPO_EXPARSIMIENTO_CLASE_SABADO = pTIEMPO_EXPARSIMIENTO_CLASE_SABADO;
            this.HORA_INICIO_CLASE_SABADO = pHORA_INICIO_CLASE_SABADO;
            this.HORA_FINALIZACION_CLASE_SABADO = pHORA_FINALIZACION_CLASE_SABADO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
