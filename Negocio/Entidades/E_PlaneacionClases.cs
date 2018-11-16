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
    public class E_PlaneacionClases
    {
        #region Atributos
        public Int64 ID_PLANEACION_CLASES { get; set; }
        public Int64 ID_ENTRENADOR { get; set; }
        public String DOCUMENTO_PLANEACION { get; set; }
        public DateTime FECHA_INICIO { get; set; }
        public DateTime FECHA_TERMINACIÓN { get; set; }
        #endregion

        #region Constructor
        public E_PlaneacionClases()
        {
        }
        #endregion

        #region Métodos
        public E_PlaneacionClases(Int64 pID_PLANEACION_CLASES, Int64 pID_ENTRENADOR, String pDOCUMENTO_PLANEACION, DateTime pFECHA_INICIO, DateTime pFECHA_TERMINACIÓN)
        {
            this.ID_PLANEACION_CLASES = pID_PLANEACION_CLASES;
            this.ID_ENTRENADOR = pID_ENTRENADOR;
            this.DOCUMENTO_PLANEACION = pDOCUMENTO_PLANEACION;
            this.FECHA_INICIO = pFECHA_INICIO;
            FECHA_TERMINACIÓN = pFECHA_TERMINACIÓN;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
