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
    public class E_RegistroUsuario
    {
        #region Atributos
        public Int64 ID_REGISTRO_USUARIO { get; set; }
        public Int64 ID_CUENTA { get; set; }
        public String NOMBRE_REGISTRADOR { get; set; }
        public Int64 CARGO_REGISTRADOR { get; set; }
        public DateTime FECHA_REGISTRO { get; set; }
        public DateTime FECHA_EXPIRACION { get; set; }
        #endregion

        #region Constructor
        public E_RegistroUsuario()
        {
        }
        #endregion

        #region Métodos
        public E_RegistroUsuario(Int64 pID_REGISTRO_USUARIO, Int64 pID_CUENTA, String pNOMBRE_REGISTRADOR, Int64 pCARGO_REGISTRADOR, DateTime pFECHA_REGISTRO, DateTime pFECHA_EXPIRACION)
        {
            this.ID_REGISTRO_USUARIO = pID_REGISTRO_USUARIO;
            this.ID_CUENTA = pID_CUENTA;
            this.NOMBRE_REGISTRADOR = pNOMBRE_REGISTRADOR;
            this.FECHA_REGISTRO = pFECHA_REGISTRO;
            this.FECHA_EXPIRACION = pFECHA_EXPIRACION;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
