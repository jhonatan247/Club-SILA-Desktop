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
    public class E_Sede
    {
        #region Atributos
        public Int64 ID_SEDE { get; set; }
        public String NOMBRE_SEDE { get; set; }
        public String DEPARTAMENTO_SEDE { get; set; }
        public String MUNICIPIO_SEDE { get; set; }
        public String DIRECCION_SEDE { get; set; }
        public DateTime FECHA_FUNDACION_SEDE { get; set; }
        #endregion

        #region Constructor
        public E_Sede()
        {
        }
        #endregion

        #region Métodos
        public E_Sede(Int64 pID_SEDE, String pNOMBRE_SEDE, String pDEPARTAMENTO_SEDE, String pMUNICIPIO_SEDE, String pDIRECCION_SEDE, DateTime pFECHA_FUNDACION_SEDE)
        {
            this.ID_SEDE = pID_SEDE;
            this.NOMBRE_SEDE = pNOMBRE_SEDE;
            this.DEPARTAMENTO_SEDE = pDEPARTAMENTO_SEDE;
            this.MUNICIPIO_SEDE = pMUNICIPIO_SEDE;
            this.DIRECCION_SEDE = pDIRECCION_SEDE;
            this.FECHA_FUNDACION_SEDE = pFECHA_FUNDACION_SEDE;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
