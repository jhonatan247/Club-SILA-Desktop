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
    public class E_Cargo
    {
        #region Atributos
        public Int64 ID_CARGO { get; set; }
        public String NOMBRE_CARGO { get; set; }
        public String FUNCION_CARGO { get; set; }
        public DateTime FECHA_INICIO_CARGO { get; set; }
        public DateTime FECHA_REELECCION_CARGO { get; set; }
        #endregion

        #region Constructor
        public E_Cargo()
        {
        }
        #endregion

        #region Métodos
        public E_Cargo(Int64 pID_CARGO, String pNOMBRE_CARGO, String pFUNCION_CARGO, DateTime pFECHA_INICIO_CARGO, DateTime pFECHA_REELECCION_CARGO)
        {
            this.ID_CARGO = pID_CARGO;
            this.NOMBRE_CARGO = pNOMBRE_CARGO;
            this.FUNCION_CARGO = pFUNCION_CARGO;
            this.FECHA_INICIO_CARGO = pFECHA_INICIO_CARGO;
            this.FECHA_REELECCION_CARGO = pFECHA_REELECCION_CARGO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
