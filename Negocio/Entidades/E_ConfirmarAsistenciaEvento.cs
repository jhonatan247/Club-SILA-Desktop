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
    public class E_ConfirmarAsistenciaEvento
    {
        #region Atributos
        public Int64 ID_CONFIRMAR_ASISTENCIA_EVENTO { get; set; }
        public Int64 ID_EVENTO{ get; set; }
        public Int64 ID_DEPORTISTA { get; set; }
        public DateTime FECHA_CONFIRMACION_ASISTENCIA_EVENTO { get; set; }
        #endregion

        #region Constructor
        public E_ConfirmarAsistenciaEvento()
        {
        }
        #endregion

        #region Métodos
        public E_ConfirmarAsistenciaEvento(Int64 pID_CONFIRMAR_ASISTENCIA_EVENTO, Int64 pID_EVENTO, Int64 pID_DEPORTISTA, DateTime pFECHA_CONFIRMACION_ASISTENCIA_EVENTO)
        {
            this.ID_CONFIRMAR_ASISTENCIA_EVENTO = pID_CONFIRMAR_ASISTENCIA_EVENTO;
            this.ID_EVENTO = pID_EVENTO;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.FECHA_CONFIRMACION_ASISTENCIA_EVENTO = pFECHA_CONFIRMACION_ASISTENCIA_EVENTO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
