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
    public class E_PreguntaSeguridad
    {
        #region Atributos
        public Int64 ID_PREGUNTA_SEGURIDAD { get; set; }
        public Int64 ID_TEMA_PREGUNTA { get; set; }
        public String PREGUNTA { get; set; }
        #endregion

        #region Constructor
        public E_PreguntaSeguridad()
        {
        }
        #endregion

        #region Métodos
        public E_PreguntaSeguridad(Int64 pID_PREGUNTA_SEGURIDAD, Int64 pID_TEMA_PREGUNTA, String pPREGUNTA)
        {
            this.ID_PREGUNTA_SEGURIDAD = pID_PREGUNTA_SEGURIDAD;
            this.ID_TEMA_PREGUNTA = pID_TEMA_PREGUNTA;
            this.PREGUNTA = pPREGUNTA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
