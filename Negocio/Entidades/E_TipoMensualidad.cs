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
    public class E_TipoMensualidad
    {
        #region Atributos
        public Int64 ID_TIPO_MENSUALIDAD { get; set; }
        public Int64 ID_INTENCIDAD_HORARIA { get; set; }
        public Int64 PRECIO_MENSUALIDAD { get; set; }
        public Int64 PRECIO_CLASE { get; set; }
        #endregion

        #region Constructor
        public E_TipoMensualidad()
        {
        }
        #endregion

        #region Métodos
        public E_TipoMensualidad(Int64 pID_TIPO_MENSUALIDAD, Int64 pID_INTENCIDAD_HORARIA, Int64 pPRECIO_MENSUALIDAD, Int64 pPRECIO_CLASE)
        {
            this.ID_TIPO_MENSUALIDAD = pID_TIPO_MENSUALIDAD;
            this.ID_INTENCIDAD_HORARIA = pID_INTENCIDAD_HORARIA;
            this.PRECIO_MENSUALIDAD = pPRECIO_MENSUALIDAD;
            this.PRECIO_CLASE = pPRECIO_CLASE;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
