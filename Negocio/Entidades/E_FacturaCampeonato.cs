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
    public class E_FacturaCampeonato
    {
        #region Atributos
        public Int64 ID_FACTURA_CAMPEONATO { get; set; }
        public Int64 ID_CONFIRMAR_ASISTENCIA_CAMPEONATO { get; set; }
        public String DESCRIPCION_FACTURA_CAMPEONATO { get; set; }
        public Int64 VALOR_ADICIONAL_FACTURA_CAMPEONATO { get; set; }
        public Int64 N_CATEGORIAS_ADICIONALES_FACTURA_CAMPEONATO { get; set; }
        public Int64 TOTAL_PAGAR_FACTURA_CAMPEONATO { get; set; }
        public Int64 VALOR_CANCELADO_FACTURA_CAMPEONATO { get; set; }
        public Int64 VALOR_DEUDA_FACTURA_CAMPEONATO { get; set; }
        public DateTime FECHA_FACTURA_CAMPEONATO { get; set; }
        #endregion

        #region Constructor
        public E_FacturaCampeonato()
        {
        }
        #endregion

        #region Métodos
        public E_FacturaCampeonato(Int64 pID_FACTURA_CAMPEONATO, Int64 pID_CONFIRMAR_ASISTENCIA_CAMPEONATO, String pDESCRIPCION_FACTURA_CAMPEONATO, Int64 pVALOR_ADICIONAL_FACTURA_CAMPEONATO, Int64 pN_CATEGORIAS_ADICIONALES_FACTURA_CAMPEONATO, Int64 pTOTAL_PAGAR_FACTURA_CAMPEONATO, Int64 pVALOR_CANCELADO_FACTURA_CAMPEONATO, Int64 pVALOR_DEUDA_FACTURA_CAMPEONATO, DateTime pFECHA_FACTURA_CAMPEONATO)
        {
            this.ID_FACTURA_CAMPEONATO = pID_FACTURA_CAMPEONATO;
            this.ID_CONFIRMAR_ASISTENCIA_CAMPEONATO = pID_CONFIRMAR_ASISTENCIA_CAMPEONATO;
            this.DESCRIPCION_FACTURA_CAMPEONATO = pDESCRIPCION_FACTURA_CAMPEONATO;
            this.VALOR_ADICIONAL_FACTURA_CAMPEONATO = pVALOR_ADICIONAL_FACTURA_CAMPEONATO;
            this.N_CATEGORIAS_ADICIONALES_FACTURA_CAMPEONATO = pN_CATEGORIAS_ADICIONALES_FACTURA_CAMPEONATO;
            this.TOTAL_PAGAR_FACTURA_CAMPEONATO = pTOTAL_PAGAR_FACTURA_CAMPEONATO;
            this.VALOR_CANCELADO_FACTURA_CAMPEONATO = pVALOR_CANCELADO_FACTURA_CAMPEONATO;
            this.VALOR_DEUDA_FACTURA_CAMPEONATO = pVALOR_DEUDA_FACTURA_CAMPEONATO;
            this.FECHA_FACTURA_CAMPEONATO = pFECHA_FACTURA_CAMPEONATO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
