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
    public class E_Campeonato
    {
        #region Atributos
        public Int64 ID_CAMPEONATO { get; set; }
        public Int64 ID_CATEGORIA_CAMPEONATO { get; set; }
        public Int64 ID_EVENTO { get; set; }
        public Int64 PRECIO_CATEGORIA_ADICIONAL { get; set; }
        #endregion

        #region Constructor
        public E_Campeonato()
        {
        }
        #endregion

        #region Métodos
        public E_Campeonato(Int64 pID_CAMPEONATO, Int64 pID_CATEGORIA_CAMPEONATO, Int64 pID_EVENTO, Int64 pPRECIO_CATEGORIA_ADICIONAL)
        {
            this.ID_CAMPEONATO = pID_CAMPEONATO;
            this.ID_CATEGORIA_CAMPEONATO = pID_CATEGORIA_CAMPEONATO;
            this.ID_EVENTO = pID_EVENTO;
            this.PRECIO_CATEGORIA_ADICIONAL = pPRECIO_CATEGORIA_ADICIONAL;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
