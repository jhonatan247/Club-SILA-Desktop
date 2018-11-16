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
    public class E_CategoriaEdad
    {
        #region Atributos
        public Int64 ID_CATEGORIA_EDAD { get; set; }
        public String NOMBRE_CATEGORIA_EDAD { get; set; }
        public Int64 EDAD_MINIMA_CATEGORIA { get; set; }
        public Int64 EDAD_MAXIMA_CATEGORIA { get; set; }
        #endregion

        #region Constructor
        public E_CategoriaEdad()
        {
        }
        #endregion

        #region Métodos
        public E_CategoriaEdad(Int64 pID_CATEGORIA_EDAD, String pNOMBRE_CATEGORIA_EDAD, Int64 pEDAD_MINIMA_CATEGORIA, Int64 pEDAD_MAXIMA_CATEGORIA)
        {
            this.ID_CATEGORIA_EDAD = pID_CATEGORIA_EDAD;
            this.NOMBRE_CATEGORIA_EDAD = pNOMBRE_CATEGORIA_EDAD;
            this.EDAD_MINIMA_CATEGORIA = pEDAD_MINIMA_CATEGORIA;
            this.EDAD_MAXIMA_CATEGORIA = pEDAD_MAXIMA_CATEGORIA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
