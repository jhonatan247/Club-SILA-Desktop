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
    public class E_FacturaProducto
    {
        #region Atributos
        public Int64 ID_FACTURA_PRODUCTO { get; set; }
        public Int64 ID_PRODUCTO { get; set; }
        public Int64 ID_DEPORTISTA { get; set; }
        public String DESCRIPCION_FACTURA_PRODUCTO { get; set; }
        public Int64 CANTIDAD_PRODUCTO { get; set; }
        public Int64 TOTAL_PAGAR_FACTURA_PRODUCTO { get; set; }
        public Int64 VALOR_CANCELADO_FACTURA_PRODUCTO { get; set; }
        public Int64 VALOR_DEUDA_FACTURA_PRODUCTO { get; set; }
        public Int64 VALOR_ADICIONAL_FACTURA_PRODUCTO { get; set; }
        public DateTime FECHA_FACTURA_PRODUCTO { get; set; }
        #endregion

        #region Constructor
        public E_FacturaProducto()
        {
        }
        #endregion

        #region Métodos
        public E_FacturaProducto(Int64 pID_FACTURA_PRODUCTO, Int64 pID_PRODUCTO, Int64 pID_DEPORTISTA, String pDESCRIPCION_FACTURA_PRODUCTO, Int64 pCANTIDAD_PRODUCTO, Int64 pTOTAL_PAGAR_FACTURA_PRODUCTO, Int64 pVALOR_CANCELADO_FACTURA_PRODUCTO, Int64 pVALOR_DEUDA_FACTURA_PRODUCTO, Int64 pVALOR_ADICIONAL_FACTURA_PRODUCTO, DateTime pFECHA_FACTURA_PRODUCTO)
        {
            this.ID_FACTURA_PRODUCTO = pID_FACTURA_PRODUCTO;
            this.ID_PRODUCTO = pID_PRODUCTO;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.DESCRIPCION_FACTURA_PRODUCTO = pDESCRIPCION_FACTURA_PRODUCTO;
            this.CANTIDAD_PRODUCTO = pCANTIDAD_PRODUCTO;
            this.TOTAL_PAGAR_FACTURA_PRODUCTO = pTOTAL_PAGAR_FACTURA_PRODUCTO;
            this.VALOR_CANCELADO_FACTURA_PRODUCTO = pVALOR_CANCELADO_FACTURA_PRODUCTO;
            this.VALOR_DEUDA_FACTURA_PRODUCTO = pVALOR_DEUDA_FACTURA_PRODUCTO;
            this.VALOR_ADICIONAL_FACTURA_PRODUCTO = pVALOR_ADICIONAL_FACTURA_PRODUCTO;
            this.FECHA_FACTURA_PRODUCTO = pFECHA_FACTURA_PRODUCTO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
