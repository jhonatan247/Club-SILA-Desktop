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
    public class E_DatosAdministrador
    {
        #region Atributos
        public Int64 ID_DATOS_ADMINISTRADOR { get; set; }
        public Int64 ID_CARGO { get; set; }
        public String CODIGO_ADMINISTRADOR { get; set; }
        public String CONTRASEÑA_CORREO { get; set; }
        public Int64 SUELDO_ENTRENADOR { get; set; }
        #endregion

        #region Constructor
        public E_DatosAdministrador()
        {
        }
        #endregion

        #region Métodos
        public E_DatosAdministrador(Int64 pID_DATOS_ADMINISTRADOR, Int64 pID_CARGO, String pCODIGO_ADMINISTRADOR, String pCONTRASEÑA_CORREO, Int64 pSUELDO_ENTRENADOR)
        {
            this.ID_DATOS_ADMINISTRADOR = pID_DATOS_ADMINISTRADOR;
            this.ID_CARGO = pID_CARGO;
            this.CODIGO_ADMINISTRADOR = pCODIGO_ADMINISTRADOR;
            this.CONTRASEÑA_CORREO = pCONTRASEÑA_CORREO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
