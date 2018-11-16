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
    public class E_DeudaMultas
    {
        #region Atributos
        public Int64 ID_DEUDA_MULTAS { get; set; }
        public String ID_DEPORTISTA { get; set; }
        public String VALOR_DEUDA_MULTAS { get; set; }
        public Int64 VALOR_CANCELADO_DEUDA_MULTAS { get; set; }
        #endregion

        #region Constructor
        public E_DeudaMultas()
        {
        }
        #endregion

        #region Métodos
        public E_DeudaMultas(Int64 pID_DEUDA_MULTAS, String pID_DEPORTISTA, String pVALOR_DEUDA_MULTAS, Int64 pVALOR_CANCELADO_DEUDA_MULTAS)
        {
            this.ID_DEUDA_MULTAS = pID_DEUDA_MULTAS;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.VALOR_DEUDA_MULTAS = pVALOR_DEUDA_MULTAS;
            this.VALOR_CANCELADO_DEUDA_MULTAS = pVALOR_CANCELADO_DEUDA_MULTAS;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
