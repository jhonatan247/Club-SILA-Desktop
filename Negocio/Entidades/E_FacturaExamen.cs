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
    public class E_FacturaExamen
    {
        #region Atributos
        public Int64 ID_FACTURA_EXAMEN { get; set; }
        public Int64 ID_CONFIRMAR_ASISTENCIA_EXAMEN { get; set; }
        public String DESCRIPCION_FACTURA_EXAMEN { get; set; }
        public Int64 VALOR_ADICIONAL_FACTURA_EXAMEN { get; set; }
        public Int64 N_TABLAS_ADICIONALES_FACTURA_EXAMEN { get; set; }
        public Int64 TOTAL_PAGAR_FACTURA_EXAMEN { get; set; }
        public Int64 VALOR_CANCELADO_FACTURA_EXAMEN { get; set; }
        public Int64 VALOR_DEUDA_FACTURA_EXAMEN { get; set; }
        public DateTime FECHA_FACTURA_EXAMEN { get; set; }
        #endregion

        #region Constructor
        public E_FacturaExamen()
        {
        }
        #endregion

        #region Métodos
        public E_FacturaExamen(Int64 pID_FACTURA_EXAMEN, Int64 pID_CONFIRMAR_ASISTENCIA_EXAMEN, String pDESCRIPCION_FACTURA_EXAMEN, Int64 pVALOR_ADICIONAL_FACTURA_EXAMEN, Int64 pN_TABLAS_ADICIONALES_FACTURA_EXAMEN, Int64 pTOTAL_PAGAR_FACTURA_EXAMEN, Int64 pVALOR_CANCELADO_FACTURA_EXAMEN, Int64 pVALOR_DEUDA_FACTURA_EXAMEN, DateTime pFECHA_FACTURA_EXAMEN)
        {
            this.ID_FACTURA_EXAMEN = pID_FACTURA_EXAMEN;
            this.ID_CONFIRMAR_ASISTENCIA_EXAMEN = pID_CONFIRMAR_ASISTENCIA_EXAMEN;
            this.DESCRIPCION_FACTURA_EXAMEN = pDESCRIPCION_FACTURA_EXAMEN;
            this.VALOR_ADICIONAL_FACTURA_EXAMEN = pVALOR_ADICIONAL_FACTURA_EXAMEN;
            this.N_TABLAS_ADICIONALES_FACTURA_EXAMEN = pN_TABLAS_ADICIONALES_FACTURA_EXAMEN;
            this.TOTAL_PAGAR_FACTURA_EXAMEN = pTOTAL_PAGAR_FACTURA_EXAMEN;
            this.VALOR_CANCELADO_FACTURA_EXAMEN = pVALOR_CANCELADO_FACTURA_EXAMEN;
            this.VALOR_DEUDA_FACTURA_EXAMEN = pVALOR_DEUDA_FACTURA_EXAMEN;
            this.FECHA_FACTURA_EXAMEN = pFECHA_FACTURA_EXAMEN;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
