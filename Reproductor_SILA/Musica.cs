#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region SILA
namespace Reproductor_SILA
{
    #region Class
    class Musica
    {
        #region Atributos
        public Int32 Id { get; set; }
        public string Url { get; set; }
        #endregion

        #region Constructor
        public Musica()
        {
        }
        #endregion

        #region Métodos
        public Musica(Int32 pId, String pUrl)
        {
            this.Url = pUrl;
            this.Id = pId;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion