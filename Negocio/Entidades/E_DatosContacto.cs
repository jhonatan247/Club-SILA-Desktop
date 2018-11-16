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
    public class E_DatosContacto
    {
        #region Atributos
        public Int64 ID_DATOS_CONTACTO { get; set; }
        public Int64 ID_SEDE { get; set; }
        public String EPS { get; set; }
        public String DIRECCION_RESIDENCIA { get; set; }
        public Int64 CELULAR { get; set; }
        public Int64 TELEFONO_FIJO { get; set; }
        #endregion

        #region Constructor
        public E_DatosContacto()
        {
        }
        #endregion

        #region Métodos
        public E_DatosContacto(Int64 pID_DATOS_CONTACTO, Int64 pID_SEDE, String pEPS, String pDIRECCION_RESIDENCIA, Int64 pCELULAR, Int64 pTELEFONO_FIJO)
        {
            this.ID_DATOS_CONTACTO = pID_DATOS_CONTACTO;
            this.ID_SEDE = pID_SEDE;
            this.EPS = pEPS;
            this.DIRECCION_RESIDENCIA = pDIRECCION_RESIDENCIA;
            this.CELULAR = pCELULAR;
            this.TELEFONO_FIJO = pTELEFONO_FIJO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
