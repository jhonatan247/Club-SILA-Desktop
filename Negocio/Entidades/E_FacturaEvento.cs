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
    public class E_FacturaEvento
    {
        #region Atributos
        public Int64 ID_FACTURA_EVENTO { get; set; }
        public Int64 ID_CONFIRMAR_ASISTENCIA_EVENTO { get; set; }
        public String DESCRIPCION_FACTURA_EVENTO { get; set; }
        public Int64 VALOR_ADICIONAL_FACTURA_EVENTO { get; set; }
        public Int64 TOTAL_PAGAR_FACTURA_EVENTO { get; set; }
        public Int64 VALOR_CANCELADO_FACTURA_EVENTO { get; set; }
        public Int64 VALOR_DEUDA_FACTURA_EVENTO { get; set; }
        public DateTime FECHA_FACTURA_EVENTO{ get; set; }
        #endregion

        #region Constructor
        public E_FacturaEvento()
        {
        }
        #endregion

        #region Métodos
        public E_FacturaEvento(Int64 pID_FACTURA_EVENTO, Int64 pID_CONFIRMAR_ASISTENCIA_EVENTO, String pDESCRIPCION_FACTURA_EVENTO, Int64 pVALOR_ADICIONAL_FACTURA_EVENTO, Int64 pTOTAL_PAGAR_FACTURA_EVENTO, Int64 pVALOR_CANCELADO_FACTURA_EVENTO, Int64 pVALOR_DEUDA_FACTURA_EVENTO, DateTime pFECHA_FACTURA_EVENTO)
        {
            this.ID_FACTURA_EVENTO = pID_FACTURA_EVENTO;
            this.ID_CONFIRMAR_ASISTENCIA_EVENTO = pID_CONFIRMAR_ASISTENCIA_EVENTO;
            this.DESCRIPCION_FACTURA_EVENTO = pDESCRIPCION_FACTURA_EVENTO;
            this.VALOR_ADICIONAL_FACTURA_EVENTO = pVALOR_ADICIONAL_FACTURA_EVENTO;
            this.TOTAL_PAGAR_FACTURA_EVENTO = pTOTAL_PAGAR_FACTURA_EVENTO;
            this.VALOR_CANCELADO_FACTURA_EVENTO = pVALOR_CANCELADO_FACTURA_EVENTO;
            this.VALOR_DEUDA_FACTURA_EVENTO = pVALOR_DEUDA_FACTURA_EVENTO;
            this.FECHA_FACTURA_EVENTO = pFECHA_FACTURA_EVENTO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
