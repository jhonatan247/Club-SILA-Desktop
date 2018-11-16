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
    public class E_HorarioAsistencia
    {
        #region Atributos
        public Int64 ID_HORARIO_ASISTENCIA { get; set; }
        public String HORA_INICIO_CLASE { get; set; }
        public String HORA_FINALIZACION_CLASE { get; set; }
        #endregion

        #region Constructor
        public E_HorarioAsistencia()
        {
        }
        #endregion

        #region Métodos
        public E_HorarioAsistencia(Int64 pID_HORARIO_ASISTENCIA, String pHORA_INICIO_CLASE, String pHORA_FINALIZACION_CLASE)
        {
            this.ID_HORARIO_ASISTENCIA = pID_HORARIO_ASISTENCIA;
            this.HORA_INICIO_CLASE = pHORA_INICIO_CLASE;
            this.HORA_FINALIZACION_CLASE = pHORA_FINALIZACION_CLASE;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
