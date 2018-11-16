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
    public class E_RequisitosCumplidosDep
    {
        #region Atributos
        public Int64 ID_REQUISITOS_CUMPLIDOS_DEP { get; set; }
        public String CUMPLE_CERTIFICADO_MEDICO { get; set; }
        public String CUMPLE_CERTIFICADO_PAZ_Y_SALVO { get; set; }
        public String CUMPLE_DOC_IDENTIDAD { get; set; }
        public String CUMPLE_PERMISO_ACUDIENTE { get; set; }
        #endregion

        #region Constructor
        public E_RequisitosCumplidosDep()
        {
        }
        #endregion

        #region Métodos
        public E_RequisitosCumplidosDep(Int64 pID_REQUISITOS_CUMPLIDOS_DEP, String pCUMPLE_CERTIFICADO_MEDICO, String pCUMPLE_CERTIFICADO_PAZ_Y_SALVO, String pCUMPLE_DOC_IDENTIDAD, String pCUMPLE_PERMISO_ACUDIENTE)
        {
            this.ID_REQUISITOS_CUMPLIDOS_DEP = pID_REQUISITOS_CUMPLIDOS_DEP;
            this.CUMPLE_CERTIFICADO_MEDICO = pCUMPLE_CERTIFICADO_MEDICO;
            this.CUMPLE_CERTIFICADO_PAZ_Y_SALVO = pCUMPLE_CERTIFICADO_PAZ_Y_SALVO;
            this.CUMPLE_DOC_IDENTIDAD = pCUMPLE_DOC_IDENTIDAD;
            this.CUMPLE_PERMISO_ACUDIENTE = pCUMPLE_PERMISO_ACUDIENTE;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
