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
    public class E_Multa
    {
        #region Atributos
        public Int64 ID_MULTA { get; set; }
        public String NOMBRE_MULTA { get; set; }
        public String GRAVEDAD_FALTA { get; set; }
        public Int64 VALOR_MULTA { get; set; }
        #endregion

        #region Constructor
        public E_Multa()
        {
        }
        #endregion

        #region Métodos
        public E_Multa(Int64 pID_MULTA, String pNOMBRE_MULTA, String pGRAVEDAD_FALTA, Int64 pVALOR_MULTA)
        {
            this.ID_MULTA = pID_MULTA;
            this.NOMBRE_MULTA = pNOMBRE_MULTA;
            this.GRAVEDAD_FALTA = pGRAVEDAD_FALTA;
            this.VALOR_MULTA = pVALOR_MULTA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
