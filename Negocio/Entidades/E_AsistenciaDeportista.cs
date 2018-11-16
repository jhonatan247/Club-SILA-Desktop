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
    public class E_AsistenciaDeportista
    {
        #region Atributos
        public Int64 ID_ASISTENCIA_DEPORTISTA { get; set; }
        public Int64 ID_HORARIO_ASISTENCIA { get; set; }
        public Int64 ID_DEPORTISTA { get; set; }
        public String OBSERVACION_ASISTENCIA { get; set; }
        public Int64 CREDITOS_ENTRENAMIENTO { get; set; }
        public DateTime FECHA_ASISTENCIA { get; set; }
        #endregion

        #region Constructor
        public E_AsistenciaDeportista()
        {
        }
        #endregion

        #region Métodos
        public E_AsistenciaDeportista(Int64 pID_ASISTENCIA_DEPORTISTA, Int64 pID_HORARIO_ASISTENCIA, Int64 pID_DEPORTISTA, String pOBSERVACION_ASISTENCIA, Int64 pCREDITOS_ENTRENAMIENTO, DateTime pFECHA_ASISTENCIA)
        {
            this.ID_ASISTENCIA_DEPORTISTA = pID_ASISTENCIA_DEPORTISTA;
            this.ID_HORARIO_ASISTENCIA = pID_HORARIO_ASISTENCIA;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.OBSERVACION_ASISTENCIA = pOBSERVACION_ASISTENCIA;
            this.CREDITOS_ENTRENAMIENTO = pCREDITOS_ENTRENAMIENTO;
            this.FECHA_ASISTENCIA = pFECHA_ASISTENCIA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
