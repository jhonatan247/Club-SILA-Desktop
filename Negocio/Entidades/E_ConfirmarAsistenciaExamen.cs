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
    public class E_ConfirmarAsistenciaExamen
    {
        #region Atributos
        public Int64 ID_CONFIRMAR_ASISTENCIA_EXAMEN { get; set; }
        public Int64 ID_EXAMEN { get; set; }
        public Int64 ID_DEPORTISTA { get; set; }
        public Int64 ID_NIVEL_EXAMEN { get; set; }
        public Int64 EDAD_MAXIMA_NIVEL_EXAMEN { get; set; }
        public DateTime FECHA_CONFIRMACION_ASISTENCIA_EXAMEN { get; set; }
        #endregion

        #region Constructor
        public E_ConfirmarAsistenciaExamen()
        {
        }
        #endregion

        #region Métodos
        public E_ConfirmarAsistenciaExamen(Int64 pID_CONFIRMAR_ASISTENCIA_EXAMEN, Int64 pID_EXAMEN, Int64 pID_DEPORTISTA, Int64 pID_NIVEL_EXAMEN, Int64 pEDAD_MAXIMA_NIVEL_EXAMEN, DateTime pFECHA_CONFIRMACION_ASISTENCIA_EXAMEN)
        {
            this.ID_CONFIRMAR_ASISTENCIA_EXAMEN = pID_CONFIRMAR_ASISTENCIA_EXAMEN;
            this.ID_EXAMEN = pID_EXAMEN;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.ID_NIVEL_EXAMEN = pID_NIVEL_EXAMEN;
            this.EDAD_MAXIMA_NIVEL_EXAMEN = pEDAD_MAXIMA_NIVEL_EXAMEN;
            this.FECHA_CONFIRMACION_ASISTENCIA_EXAMEN = pFECHA_CONFIRMACION_ASISTENCIA_EXAMEN;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
