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
    public class E_CategoriaPeso
    {
        #region Atributos
        public Int64 ID_CATEGORIA_PESO { get; set; }
        public String NOMBRE_CATEGORIA_PESO { get; set; }
        public Int64 PESO_MINIMO { get; set; }
        public Int64 PESO_MAXIMO { get; set; }
        #endregion

        #region Constructor
        public E_CategoriaPeso()
        {
        }
        #endregion

        #region Métodos
        public E_CategoriaPeso(Int64 pID_CATEGORIA_PESO, String pNOMBRE_CATEGORIA_PESO, Int64 pPESO_MINIMO, Int64 pPESO_MAXIMO)
        {
            this.ID_CATEGORIA_PESO = pID_CATEGORIA_PESO;
            this.NOMBRE_CATEGORIA_PESO = pNOMBRE_CATEGORIA_PESO;
            this.PESO_MINIMO = pPESO_MINIMO;
            this.PESO_MAXIMO = pPESO_MAXIMO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
