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
    public class E_LogroExhibicion
    {
        #region Atributos
        public Int64 ID_LOGRO_EXHIBICION { get; set; }
        public Int64 ID_TIPO_EXHIBICION { get; set; }
        public Int64 N_PRESENTACIONES_EHCIBICION { get; set; }
        public Decimal PROMEDIO_PUNTAJE_EHCIBICION { get; set; }
        #endregion

        #region Constructor
        public E_LogroExhibicion()
        {
        }
        #endregion

        #region Métodos
        public E_LogroExhibicion(Int64 pID_LOGRO_EXHIBICION, Int64 pID_TIPO_EXHIBICION, Int64 pN_PRESENTACIONES_EHCIBICION, Decimal pPROMEDIO_PUNTAJE_EHCIBICION)
        {
            this.ID_LOGRO_EXHIBICION = pID_LOGRO_EXHIBICION;
            this.ID_TIPO_EXHIBICION = pID_TIPO_EXHIBICION;
            this.N_PRESENTACIONES_EHCIBICION = pN_PRESENTACIONES_EHCIBICION;
            this.PROMEDIO_PUNTAJE_EHCIBICION = pPROMEDIO_PUNTAJE_EHCIBICION;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
