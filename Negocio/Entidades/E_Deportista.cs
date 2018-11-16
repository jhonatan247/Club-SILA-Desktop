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
    public class E_Deportista
    {
        #region Atributos
        public Int64 ID_DEPORTISTA { get; set; }
        public Int64 ID_DATOS_PERSONALES { get; set; }
        public Int64 ID_DATOS_CONTACTO { get; set; }
        public Int64 ID_DATOS_DEPORTISTA { get; set; }
        #endregion

        #region Constructor
        public E_Deportista()
        {
        }
        #endregion

        #region Métodos
        public E_Deportista(Int64 pID_DEPORTISTA, Int64 pID_DATOS_PERSONALES, Int64 pID_DATOS_CONTACTO, Int64 pID_DATOS_DEPORTISTA)
        {
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.ID_DATOS_PERSONALES = pID_DATOS_PERSONALES;
            this.ID_DATOS_CONTACTO = pID_DATOS_CONTACTO;
            this.ID_DATOS_DEPORTISTA = pID_DATOS_DEPORTISTA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
