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
    public class E_ClaseDomingo
    {
        #region Atributos
        public Int64 ID_CLASE_DOMINGO { get; set; }
        public String TIEMPO_EXPARSIMIENTO_CLASE_DOMINGO { get; set; }
        public String HORA_INICIO_CLASE_DOMINGO { get; set; }
        public String HORA_FINALIZACION_CLASE_DOMINGO { get; set; }
        #endregion

        #region Constructor
        public E_ClaseDomingo()
        {
        }
        #endregion

        #region Métodos
        public E_ClaseDomingo(Int64 pID_CLASE_DOMINGO, String pTIEMPO_EXPARSIMIENTO_CLASE_DOMINGO, String pHORA_INICIO_CLASE_DOMINGO, String pHORA_FINALIZACION_CLASE_DOMINGO)
        {
            this.ID_CLASE_DOMINGO = pID_CLASE_DOMINGO;
            this.TIEMPO_EXPARSIMIENTO_CLASE_DOMINGO = pTIEMPO_EXPARSIMIENTO_CLASE_DOMINGO;
            this.HORA_INICIO_CLASE_DOMINGO = pHORA_INICIO_CLASE_DOMINGO;
            this.HORA_FINALIZACION_CLASE_DOMINGO = pHORA_FINALIZACION_CLASE_DOMINGO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
