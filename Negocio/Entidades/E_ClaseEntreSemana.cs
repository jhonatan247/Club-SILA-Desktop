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
    public class E_ClaseEntreSemana
    {
        #region Atributos
        public Int64 ID_CLASE_ENTRE_SEMANA { get; set; }
        public String TIEMPO_EXPARSIMIENTO_CLASE_ENTRE_SEMANA { get; set; }
        public String HORA_INICIO_CLASE_ENTRE_SEMANA { get; set; }
        public String HORA_FINALIZACION_CLASE_ENTRE_SEMANA { get; set; }
        #endregion

        #region Constructor
        public E_ClaseEntreSemana()
        {
        }
        #endregion

        #region Métodos
        public E_ClaseEntreSemana(Int64 pID_CLASE_ENTRE_SEMANA, String pTIEMPO_EXPARSIMIENTO_CLASE_ENTRE_SEMANA, String pHORA_INICIO_CLASE_ENTRE_SEMANA, String pHORA_FINALIZACION_CLASE_ENTRE_SEMANA)
        {
            this.ID_CLASE_ENTRE_SEMANA = pID_CLASE_ENTRE_SEMANA;
            this.TIEMPO_EXPARSIMIENTO_CLASE_ENTRE_SEMANA = pTIEMPO_EXPARSIMIENTO_CLASE_ENTRE_SEMANA;
            this.HORA_INICIO_CLASE_ENTRE_SEMANA = pHORA_INICIO_CLASE_ENTRE_SEMANA;
            this.HORA_FINALIZACION_CLASE_ENTRE_SEMANA = pHORA_FINALIZACION_CLASE_ENTRE_SEMANA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
