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
    public class E_CategoriaCinturon
    {
        #region Atributos
        public Int64 ID_CATEGORIA_CINTURON { get; set; }
        public String NOMBRE_CATEGORÍA_CINTURON { get; set; }
        public String COLOR_CINTURON_MINIMO { get; set; }
        public String COLOR_CINTURON_MAXIMO { get; set; }
        #endregion

        #region Constructor
        public E_CategoriaCinturon()
        {
        }
        #endregion

        #region Métodos
        public E_CategoriaCinturon(Int64 pID_CATEGORIA_CINTURON, String pNOMBRE_CATEGORÍA_CINTURON, String pCOLOR_CINTURON_MINIMO, String pCOLOR_CINTURON_MAXIMO)
        {
            this.ID_CATEGORIA_CINTURON = pID_CATEGORIA_CINTURON;
            this.NOMBRE_CATEGORÍA_CINTURON = pNOMBRE_CATEGORÍA_CINTURON;
            this.COLOR_CINTURON_MINIMO = pCOLOR_CINTURON_MINIMO;
            this.COLOR_CINTURON_MAXIMO = pCOLOR_CINTURON_MAXIMO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
