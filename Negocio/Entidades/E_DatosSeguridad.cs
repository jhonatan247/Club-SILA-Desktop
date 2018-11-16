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
    public class E_DatosSeguridad
    {
        #region Atributos
        public Int64 ID_DATOS_SEGURIDAD { get; set; }
        public Int64 ID_PREGUNTA_SEGURIDAD { get; set; }
        public String RESPUESTA_PREGUNTA_SEGURIDAD { get; set; }
        public DateTime FECHA_ULTIMO_CIERRE_SESION { get; set; }
        public DateTime FECHA_ULTIMO_CAMBIO_CONTRASEÑA { get; set; }
        #endregion

        #region Constructor
        public E_DatosSeguridad()
        {
        }
        #endregion

        #region Métodos
        public E_DatosSeguridad(Int64 pID_DATOS_SEGURIDAD, Int64 pID_PREGUNTA_SEGURIDAD, String pRESPUESTA_PREGUNTA_SEGURIDAD, DateTime pFECHA_ULTIMO_CIERRE_SESION, DateTime pFECHA_ULTIMO_CAMBIO_CONTRASEÑA)
        {
            this.ID_DATOS_SEGURIDAD = pID_DATOS_SEGURIDAD;
            this.ID_PREGUNTA_SEGURIDAD = pID_PREGUNTA_SEGURIDAD;
            this.RESPUESTA_PREGUNTA_SEGURIDAD = pRESPUESTA_PREGUNTA_SEGURIDAD;
            this.FECHA_ULTIMO_CIERRE_SESION = pFECHA_ULTIMO_CIERRE_SESION;
            this.FECHA_ULTIMO_CAMBIO_CONTRASEÑA = pFECHA_ULTIMO_CAMBIO_CONTRASEÑA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
