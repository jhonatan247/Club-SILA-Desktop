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
    public class E_Cinturon
    {
        #region Atributos
        public Int64 ID_CINTURON { get; set; }
        public String COLOR_CINTURON { get; set; }
        public String SIGNIFICADO_CINTURON { get; set; }
        public String IMAGEN_CINTURON { get; set; }
        #endregion

        #region Constructor
        public E_Cinturon()
        {
        }
        #endregion

        #region Métodos
        public E_Cinturon(Int64 pID_CINTURON, String pCOLOR_CINTURON, String pSIGNIFICADO_CINTURON, String pIMAGEN_CINTURON)
        {
            this.ID_CINTURON = pID_CINTURON;
            this.COLOR_CINTURON = pCOLOR_CINTURON;
            this.SIGNIFICADO_CINTURON = pSIGNIFICADO_CINTURON;
            this.IMAGEN_CINTURON = pIMAGEN_CINTURON;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
