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
    public class E_TipoCuenta
    {
        #region Atributos
        public Int64 ID_TIPO_CUENTA { get; set; }
        public String PERMISOS_TIPO_CUENTA { get; set; }
        public String NOMBRE_TIPO_CUENTA { get; set; }
        public Int64 LIMITE_USUARIOS { get; set; }
        #endregion

        #region Constructor
        public E_TipoCuenta()
        {
        }
        #endregion

        #region Métodos
        public E_TipoCuenta(Int64 pID_TIPO_CUENTA, String pPERMISOS_TIPO_CUENTA, String pNOMBRE_TIPO_CUENTA, Int64 pLIMITE_USUARIOS)
        {
            this.ID_TIPO_CUENTA = pID_TIPO_CUENTA;
            this.PERMISOS_TIPO_CUENTA = pPERMISOS_TIPO_CUENTA;
            this.NOMBRE_TIPO_CUENTA = pNOMBRE_TIPO_CUENTA;
            this.LIMITE_USUARIOS = pLIMITE_USUARIOS;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
