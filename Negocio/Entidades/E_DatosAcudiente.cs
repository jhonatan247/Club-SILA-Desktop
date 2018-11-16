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
    public class E_DatosAcudiente
    {
        #region Atributos
        public Int64 ID_DATOS_ACUDIENTE { get; set; }
        public Int64 ID_DEPORTISTA { get; set; }
        public String EMPLEO_ACUDIENTE { get; set; }
        public Int64 TELEFONO_TRABAJO_ACUDIENTE { get; set; }
        #endregion

        #region Constructor
        public E_DatosAcudiente()
        {
        }
        #endregion

        #region Métodos
        public E_DatosAcudiente(Int64 pID_DATOS_ACUDIENTE, Int64 pID_DEPORTISTA, String pEMPLEO_ACUDIENTE, Int64 pTELEFONO_TRABAJO_ACUDIENTE)
        {
            this.ID_DATOS_ACUDIENTE = pID_DATOS_ACUDIENTE;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.EMPLEO_ACUDIENTE = pEMPLEO_ACUDIENTE;
            this.TELEFONO_TRABAJO_ACUDIENTE = pTELEFONO_TRABAJO_ACUDIENTE;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
