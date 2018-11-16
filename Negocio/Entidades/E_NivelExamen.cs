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
    public class E_NivelExamen
    {
        #region Atributos
        public Int64 ID_NIVEL_EXAMEN { get; set; }
        public String NOMBRE_NIVEL_EXAMEN { get; set; }
        public String COLOR_CINTURON_NIVEL_EXAMEN { get; set; }
        public Int64 EDAD_MINIMA_NIVEL_EXAMEN { get; set; }
        public Int64 EDAD_MAXIMA_NIVEL_EXAMEN { get; set; }
        public Decimal PUNTAJE_REQUERIDO_NIVEL_EXAMEN { get; set; }
        #endregion

        #region Constructor
        public E_NivelExamen()
        {
        }
        #endregion

        #region Métodos
        public E_NivelExamen(Int64 pID_NIVEL_EXAMEN, String pNOMBRE_NIVEL_EXAMEN, String pCOLOR_CINTURON_NIVEL_EXAMEN, Int64 pEDAD_MINIMA_NIVEL_EXAMEN, Int64 pEDAD_MAXIMA_NIVEL_EXAMEN, Decimal pPUNTAJE_REQUERIDO_NIVEL_EXAMEN)
        {
            this.ID_NIVEL_EXAMEN = pID_NIVEL_EXAMEN;
            this.NOMBRE_NIVEL_EXAMEN = pNOMBRE_NIVEL_EXAMEN;
            this.COLOR_CINTURON_NIVEL_EXAMEN = pCOLOR_CINTURON_NIVEL_EXAMEN;
            this.EDAD_MINIMA_NIVEL_EXAMEN = pEDAD_MINIMA_NIVEL_EXAMEN;
            this.EDAD_MAXIMA_NIVEL_EXAMEN = pEDAD_MAXIMA_NIVEL_EXAMEN;
            this.PUNTAJE_REQUERIDO_NIVEL_EXAMEN = pPUNTAJE_REQUERIDO_NIVEL_EXAMEN;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
