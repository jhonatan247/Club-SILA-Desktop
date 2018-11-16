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
    public class E_Entrenador
    {
        #region Atributos
        public Int64 ID_ENTRENADOR { get; set; }
        public Int64 ID_DATOS_PERSONALES { get; set; }
        public Int64 ID_DATOS_CONTACTO { get; set; }
        public Int64 ID_DATOS_ENTRENADOR { get; set; }
        #endregion

        #region Constructor
        public E_Entrenador()
        {
        }
        #endregion

        #region Métodos
        public E_Entrenador(Int64 pID_ENTRENADOR, Int64 pID_DATOS_PERSONALES, Int64 pID_DATOS_CONTACTO, Int64 pID_DATOS_ENTRENADOR)
        {
            this.ID_ENTRENADOR = pID_ENTRENADOR;
            this.ID_DATOS_PERSONALES = pID_DATOS_PERSONALES;
            this.ID_DATOS_CONTACTO = pID_DATOS_CONTACTO;
            this.ID_DATOS_ENTRENADOR = pID_DATOS_ENTRENADOR;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
