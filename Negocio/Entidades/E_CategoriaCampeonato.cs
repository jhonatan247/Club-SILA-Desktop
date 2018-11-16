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
    public class E_CategoriaCampeonato
    {
        #region Atributos
        public Int64 ID_CATEGORIA_CAMPEONATO { get; set; }
        public String NOMBRE_CATEGORIA_CAMPEONATO { get; set; }
        public String NIVEL_IMPORTANCIA_CATEGORIA_CAMPEONATO { get; set; }
        public String DESCRIPCION_CATEGORIA_CAMPEONATO { get; set; }
        #endregion

        #region Constructor
        public E_CategoriaCampeonato()
        {
        }
        #endregion

        #region Métodos
        public E_CategoriaCampeonato(Int64 pID_CATEGORIA_CAMPEONATO, String pNOMBRE_CATEGORIA_CAMPEONATO, String pNIVEL_IMPORTANCIA_CATEGORIA_CAMPEONATO, String pDESCRIPCION_CATEGORIA_CAMPEONATO)
        {
            this.ID_CATEGORIA_CAMPEONATO = pID_CATEGORIA_CAMPEONATO;
            this.NOMBRE_CATEGORIA_CAMPEONATO = pNOMBRE_CATEGORIA_CAMPEONATO;
            this.NIVEL_IMPORTANCIA_CATEGORIA_CAMPEONATO = pNIVEL_IMPORTANCIA_CATEGORIA_CAMPEONATO;
            this.DESCRIPCION_CATEGORIA_CAMPEONATO = pDESCRIPCION_CATEGORIA_CAMPEONATO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
