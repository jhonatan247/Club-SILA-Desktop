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
    public class E_LogroPoomsae
    {
        #region Atributos
        public Int64 ID_LOGRO_POOMSAE { get; set; }
        public Int64 ID_TIPO_POOMSAE { get; set; }
        public Int64 N_PRESENTACIONES_POOMSAE { get; set; }
        public Decimal PROMEDIO_PUNTAJE_POOMSAE { get; set; }
        #endregion

        #region Constructor
        public E_LogroPoomsae()
        {
        }
        #endregion

        #region Métodos
        public E_LogroPoomsae(Int64 pID_LOGRO_POOMSAE, Int64 pID_TIPO_POOMSAE, Int64 pN_PRESENTACIONES_POOMSAE, Decimal pPROMEDIO_PUNTAJE_POOMSAE)
        {
            this.ID_LOGRO_POOMSAE = pID_LOGRO_POOMSAE;
            this.ID_TIPO_POOMSAE = pID_TIPO_POOMSAE;
            this.N_PRESENTACIONES_POOMSAE = pN_PRESENTACIONES_POOMSAE;
            this.PROMEDIO_PUNTAJE_POOMSAE = pPROMEDIO_PUNTAJE_POOMSAE;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
