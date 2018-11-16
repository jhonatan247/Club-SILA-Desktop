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
    public class E_DatosPersonales
    {
        #region Atributos
        public Int64 ID_DATOS_PERSONALES { get; set; }
        public String PRIMER_APELLIDO { get; set; }
        public String SEGUNDO_APELLIDO { get; set; }
        public String PRIMER_NOMBRE { get; set; }
        public String SEGUNDO_NOMBRE { get; set; }
        public String GENERO { get; set; }
        public String TIPO_DOCUMENTO { get; set; }
        public Int64 NUMERO_DOCUMENTO { get; set; }
        public DateTime FECHA_NACIMIENTO { get; set; }
        #endregion

        #region Constructor
        public E_DatosPersonales()
        {
        }
        #endregion

        #region Métodos
        public E_DatosPersonales(Int64 pID_DATOS_PERSONALES, String pPRIMER_APELLIDO, String pSEGUNDO_APELLIDO, String pPRIMER_NOMBRE, String pSEGUNDO_NOMBRE, String pGENERO, String pTIPO_DOCUMENTO, Int64 pNUMERO_DOCUMENTO, DateTime pFECHA_NACIMIENTO)
        {
            this.ID_DATOS_PERSONALES = pID_DATOS_PERSONALES;
            this.PRIMER_APELLIDO = pPRIMER_APELLIDO;
            this.SEGUNDO_APELLIDO = pSEGUNDO_APELLIDO;
            this.PRIMER_NOMBRE = pPRIMER_NOMBRE;
            this.SEGUNDO_NOMBRE = pSEGUNDO_NOMBRE;
            this.GENERO = pGENERO;
            this.TIPO_DOCUMENTO = pTIPO_DOCUMENTO;
            this.NUMERO_DOCUMENTO = pNUMERO_DOCUMENTO;
            this.FECHA_NACIMIENTO = pFECHA_NACIMIENTO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
