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
    public class E_Cumpleaños
    {
        #region Atributos
        public Int64 ID_CUMPLEAÑOS { get; set; }
        public Int64 ID_REGISTRO_USUARIO { get; set; }
        public Int64 MES_CUMPLEAÑOS { get; set; }
        public Int64 DIA_CUMPLEAÑOS { get; set; }
        #endregion

        #region Constructor
        public E_Cumpleaños()
        {
        }
        #endregion

        #region Métodos
        public E_Cumpleaños(Int64 pID_CUMPLEAÑOS, Int64 pID_REGISTRO_USUARIO, Int64 pMES_CUMPLEAÑOS, Int64 pDIA_CUMPLEAÑOS)
        {
            this.ID_CUMPLEAÑOS = pID_CUMPLEAÑOS;
            this.ID_REGISTRO_USUARIO = pID_REGISTRO_USUARIO;
            this.MES_CUMPLEAÑOS = pMES_CUMPLEAÑOS;
            this.DIA_CUMPLEAÑOS = pDIA_CUMPLEAÑOS;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
