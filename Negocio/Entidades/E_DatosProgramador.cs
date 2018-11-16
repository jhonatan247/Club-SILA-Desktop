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
    public class E_DatosProgramador
    {
        #region Atributos
        public Int64 ID_DATOS_PROGRAMADOR { get; set; }
        public String CODIGO_PROGRAMADOR { get; set; }
        public String CONTRASEÑA_PROGRAMADOR_1 { get; set; }
        public String CONTRASEÑA_PROGRAMADOR_2 { get; set; }
        public String CODIGO_DESBLOQUEO { get; set; }
        public Int64 NUMERO_ACTIVACION { get; set; }
        #endregion

        #region Constructor
        public E_DatosProgramador()
        {
        }
        #endregion

        #region Métodos
        public E_DatosProgramador(Int64 pID_DATOS_PROGRAMADOR, String pCODIGO_PROGRAMADOR, String pCONTRASEÑA_PROGRAMADOR_1, String pCONTRASEÑA_PROGRAMADOR_2, String pCODIGO_DESBLOQUEO, Int64 pNUMERO_ACTIVACION)
        {
            this.ID_DATOS_PROGRAMADOR = pID_DATOS_PROGRAMADOR;
            this.CODIGO_PROGRAMADOR = pCODIGO_PROGRAMADOR;
            this.CONTRASEÑA_PROGRAMADOR_1 = pCONTRASEÑA_PROGRAMADOR_1;
            this.CONTRASEÑA_PROGRAMADOR_2 = pCONTRASEÑA_PROGRAMADOR_2;
            this.CODIGO_DESBLOQUEO = pCODIGO_DESBLOQUEO;
            this.NUMERO_ACTIVACION = pNUMERO_ACTIVACION;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
