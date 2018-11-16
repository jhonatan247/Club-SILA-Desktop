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
    public class E_Evento
    {
        #region Atributos
        public Int64 ID_EVENTO { get; set; }
        public Int64 ID_DATOS_EVENTO { get; set; }
        public DateTime FECHA_REGISTRO_EVENTO { get; set; }
        public DateTime FECHA_INICIO_EVENTO { get; set; }
        public DateTime FECHA_FINALIZACION_EVENTO { get; set; }
        #endregion

        #region Constructor
        public E_Evento()
        {
        }
        #endregion

        #region Métodos
        public E_Evento(Int64 pID_EVENTO, Int64 pID_DATOS_EVENTO, DateTime pFECHA_REGISTRO_EVENTO, DateTime pFECHA_INICIO_EVENTO, DateTime pFECHA_FINALIZACION_EVENTO)
        {
            this.ID_EVENTO = pID_EVENTO;
            this.ID_DATOS_EVENTO = pID_DATOS_EVENTO;
            this.FECHA_REGISTRO_EVENTO = pFECHA_REGISTRO_EVENTO;
            this.FECHA_INICIO_EVENTO = pFECHA_INICIO_EVENTO;
            this.FECHA_FINALIZACION_EVENTO = pFECHA_FINALIZACION_EVENTO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
