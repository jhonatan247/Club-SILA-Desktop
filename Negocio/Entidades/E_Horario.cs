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
    public class E_Horario
    {
        #region Atributos
        public Int64 ID_HORARIO { get; set; }
        public Int64 ID_CLASES_HORARIO { get; set; }
        public String NOMBRE_HORARIO { get; set; }
        public Int64 EDAD_MINIMA_HORARIO { get; set; }
        public Int64 EDAD_MAXIMA_HORARIO { get; set; }
        #endregion

        #region Constructor
        public E_Horario()
        {
        }
        #endregion

        #region Métodos
        public E_Horario(Int64 pID_HORARIO, Int64 pID_CLASES_HORARIO, String pNOMBRE_HORARIO, Int64 pEDAD_MINIMA_HORARIO, Int64 pEDAD_MAXIMA_HORARIO)
        {
            this.ID_HORARIO = pID_HORARIO;
            this.ID_CLASES_HORARIO = pID_CLASES_HORARIO;
            this.NOMBRE_HORARIO = pNOMBRE_HORARIO;
            this.EDAD_MINIMA_HORARIO = pEDAD_MINIMA_HORARIO;
            this.EDAD_MAXIMA_HORARIO= pEDAD_MAXIMA_HORARIO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
