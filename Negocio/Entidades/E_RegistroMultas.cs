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
    public class E_RegistroMultas
    {
        #region Atributos
        public Int64 ID_REGISTRO_MULTAS { get; set; }
        public Int64 ID_DEUDA_MULTAS { get; set; }
        public Int64 ID_MULTA { get; set; }
        public DateTime FECHA_REGISTRO_MULTAS { get; set; }
        #endregion

        #region Constructor
        public E_RegistroMultas()
        {
        }
        #endregion

        #region Métodos
        public E_RegistroMultas(Int64 pID_REGISTRO_MULTAS, Int64 pID_DEUDA_MULTAS, Int64 pID_MULTA, DateTime pFECHA_REGISTRO_MULTAS)
        {
            this.ID_REGISTRO_MULTAS = pID_REGISTRO_MULTAS;
            this.ID_DEUDA_MULTAS = pID_DEUDA_MULTAS;
            this.ID_MULTA = pID_MULTA;
            this.FECHA_REGISTRO_MULTAS = pFECHA_REGISTRO_MULTAS;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
