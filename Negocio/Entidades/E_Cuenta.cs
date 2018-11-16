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
    public class E_Cuenta
    {
        #region Atributos
        public Int64 ID_CUENTA { get; set; }
        public Int64 ID_DATOS_CUENTA { get; set; }
        public Int64 ID_TIPO_CUENTA { get; set; }
        public String CONTRASEÑA { get; set; }
        public String NOMBRE_USUARIO { get; set; }
        public String NOMBRE_USUARIO_ALTERNATIVO { get; set; }
        public String ESTADO_CUENTA { get; set; }
        public String CORREO { get; set; }
        public String COLOR_FUENTE { get; set; }
        public String TIPO_FUENTE{ get; set; }
        public String COLOR_FONDO { get; set; }
        public String FOTO_PERFIL { get; set; }
        #endregion

        #region Constructor
        public E_Cuenta()
        {
        }
        #endregion

        #region Métodos
        public E_Cuenta(Int64 pID_CUENTA, Int64 pID_DATOS_CUENTA, Int64 pID_TIPO_CUENTA,
            String pCONTRASEÑA, String pNOMBRE_USUARIO, String pNOMBRE_USUARIO_ALTERNATIVO, String pESTADO_CUENTA, String pCORREO, String pCOLOR_FUENTE, String pTIPO_FUENTE, String pCOLOR_FONDO, String pFOTO_PERFIL)
        {
            this.ID_CUENTA = pID_CUENTA;
            this.ID_DATOS_CUENTA = pID_DATOS_CUENTA;
            this.ID_TIPO_CUENTA = pID_TIPO_CUENTA;
            this.CONTRASEÑA = pCONTRASEÑA;
            this.NOMBRE_USUARIO = pNOMBRE_USUARIO;
            this.NOMBRE_USUARIO_ALTERNATIVO = pNOMBRE_USUARIO_ALTERNATIVO;
            this.ESTADO_CUENTA = pESTADO_CUENTA;
            this.CORREO = pCORREO;
            this.COLOR_FUENTE = pCOLOR_FUENTE;
            this.TIPO_FUENTE = pTIPO_FUENTE;
            this.COLOR_FONDO = pCOLOR_FONDO;
            this.FOTO_PERFIL = pFOTO_PERFIL;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
