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
    public class E_FacturaMensualidad
    {
        #region Atributos
        public Int64 ID_FACTURA_MENSUALIDAD { get; set; }
        public Int64 ID_DEPORTISTA { get; set; }
        public String DESCRIPCION_FACTURA_MENSUALIDAD { get; set; }
        public Int64 VALOR_ADICIONAL_FACTURA_MENSUALIDAD { get; set; }
        public Int64 N_MESES_A_CANCELAR_FACTURA_MENSUALIDAD { get; set; }
        public Int64 TOTAL_CLASES_EXTRA_FACTURA_MENSUALIDAD { get; set; }
        public Int64 TOTAL_PAGAR_FACTURA_MENSUALIDAD { get; set; }
        public Int64 VALOR_CANCELADO_FACTURA_MENSUALIDAD { get; set; }
        public Int64 VALOR_DEUDA_FACTURA_MENSUALIDAD { get; set; }
        public DateTime FECHA_FACTURA_MENSUALIDAD { get; set; }
        #endregion

        #region Constructor
        public E_FacturaMensualidad()
        {
        }
        #endregion

        #region Métodos
        public E_FacturaMensualidad(Int64 pID_FACTURA_MENSUALIDAD, Int64 pID_DEPORTISTA, String pDESCRIPCION_FACTURA_MENSUALIDAD, Int64 pVALOR_ADICIONAL_FACTURA_MENSUALIDAD, Int64 pN_MESES_A_CANCELAR_FACTURA_MENSUALIDAD, Int64 pTOTAL_CLASES_EXTRA_FACTURA_MENSUALIDAD, Int64 pTOTAL_PAGAR_FACTURA_MENSUALIDAD, Int64 pVALOR_CANCELADO_FACTURA_MENSUALIDAD, Int64 pVALOR_DEUDA_FACTURA_MENSUALIDAD, DateTime pFECHA_FACTURA_MENSUALIDAD)
        {
            this.ID_FACTURA_MENSUALIDAD = pID_FACTURA_MENSUALIDAD;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.DESCRIPCION_FACTURA_MENSUALIDAD = pDESCRIPCION_FACTURA_MENSUALIDAD;
            this.VALOR_ADICIONAL_FACTURA_MENSUALIDAD = pVALOR_ADICIONAL_FACTURA_MENSUALIDAD;
            this.N_MESES_A_CANCELAR_FACTURA_MENSUALIDAD = pN_MESES_A_CANCELAR_FACTURA_MENSUALIDAD;
            this.TOTAL_CLASES_EXTRA_FACTURA_MENSUALIDAD = pTOTAL_CLASES_EXTRA_FACTURA_MENSUALIDAD;
            this.TOTAL_PAGAR_FACTURA_MENSUALIDAD = pTOTAL_PAGAR_FACTURA_MENSUALIDAD;
            this.VALOR_CANCELADO_FACTURA_MENSUALIDAD = pVALOR_CANCELADO_FACTURA_MENSUALIDAD;
            this.VALOR_DEUDA_FACTURA_MENSUALIDAD = pVALOR_DEUDA_FACTURA_MENSUALIDAD;
            this.FECHA_FACTURA_MENSUALIDAD = pFECHA_FACTURA_MENSUALIDAD;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
