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
    public class E_TemaPregunta
    {
        #region Atributos
        public Int64 ID_TEMA_PREGUNTA { get; set; }
        public String NOMBRE_TEMA_PREGUNTA { get; set; }
        public Int64 EDAD_MINIMA_TEMA_PREGUNTA { get; set; }
        public Int64 EDAD_MAXIMA_TEMA_PREGUNTA { get; set; }
        #endregion

        #region Constructor
        public E_TemaPregunta()
        {
        }
        #endregion

        #region Métodos
        public E_TemaPregunta(Int64 pID_TEMA_PREGUNTA, String pNOMBRE_TEMA_PREGUNTA, Int64 pEDAD_MINIMA_TEMA_PREGUNTA, Int64 pEDAD_MAXIMA_TEMA_PREGUNTA)
        {
            this.ID_TEMA_PREGUNTA = pID_TEMA_PREGUNTA;
            this.NOMBRE_TEMA_PREGUNTA = pNOMBRE_TEMA_PREGUNTA;
            this.EDAD_MINIMA_TEMA_PREGUNTA = pEDAD_MINIMA_TEMA_PREGUNTA;
            this.EDAD_MAXIMA_TEMA_PREGUNTA = pEDAD_MAXIMA_TEMA_PREGUNTA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
