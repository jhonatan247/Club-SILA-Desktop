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
    public class E_Examen
    {
        #region Atributos
        public Int64 ID_EXAMEN { get; set; }
        public Int64 ID_ENTRENADOR { get; set; }
        public Int64 ID_EVENTO { get; set; }
        public Int64 PRECIO_TABLA { get; set; }
        #endregion

        #region Constructor
        public E_Examen()
        {
        }
        #endregion

        #region Métodos
        public E_Examen(Int64 pID_EXAMEN, Int64 pID_ENTRENADOR, Int64 pID_EVENTO, Int64 pPRECIO_TABLA)
        {
            this.ID_EXAMEN = pID_EXAMEN;
            this.ID_ENTRENADOR = pID_ENTRENADOR;
            this.ID_EVENTO = pID_EVENTO;
            this.PRECIO_TABLA = pPRECIO_TABLA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
