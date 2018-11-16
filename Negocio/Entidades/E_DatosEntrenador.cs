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
    public class E_DatosEntrenador
    {
        #region Atributos
        public Int64 ID_DATOS_ENTRENADOR { get; set; }
        public String HOJA_DE_VIDA_ENTRENADOR { get; set; }
        public String GRADO_DAN_ENTRENADOR { get; set; }
        public String DESCRIPCION_ESTUDIO_ENTRENADOR { get; set; }
        public Int64 SUELDO_ENTRENADOR { get; set; }
        #endregion

        #region Constructor
        public E_DatosEntrenador()
        {
        }
        #endregion

        #region Métodos
        public E_DatosEntrenador(Int64 pID_DATOS_ENTRENADOR, String pHOJA_DE_VIDA_ENTRENADOR, String pGRADO_DAN_ENTRENADOR, String pDESCRIPCION_ESTUDIO_ENTRENADOR, Int64 pSUELDO_ENTRENADOR)
        {
            this.ID_DATOS_ENTRENADOR = pID_DATOS_ENTRENADOR;
            this.HOJA_DE_VIDA_ENTRENADOR = pHOJA_DE_VIDA_ENTRENADOR;
            this.GRADO_DAN_ENTRENADOR = pGRADO_DAN_ENTRENADOR;
            this.DESCRIPCION_ESTUDIO_ENTRENADOR = pDESCRIPCION_ESTUDIO_ENTRENADOR;
            this.SUELDO_ENTRENADOR = pSUELDO_ENTRENADOR;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
