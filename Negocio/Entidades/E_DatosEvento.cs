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
    public class E_DatosEvento
    {
        #region Atributos
        public Int64 ID_DATOS_EVENTO { get; set; }
        public Int64 ID_TIPO_EVENTO { get; set; }
        public Int64 ID_HORARIO_EVENTO { get; set; }
        public Int64 ID_REQUISITOS_EVENTO{ get; set; }
        public String DIRECCION_EVENTO { get; set; }
        public String LUGAR_EVENTO { get; set; }
        public String NOMBRE_EVENTO { get; set; }
        public String ANFITRION_EVENTO { get; set; }
        public Int64 VALOR_EVENTO { get; set; }
        #endregion

        #region Constructor
        public E_DatosEvento()
        {
        }
        #endregion

        #region Métodos
        public E_DatosEvento(Int64 pID_DATOS_EVENTO, Int64 pID_TIPO_EVENTO, Int64 pID_HORARIO_EVENTO, Int64 pID_REQUISITOS_EVENTO, 
            String pDIRECCION_EVENTO, String pLUGAR_EVENTO, String pNOMBRE_EVENTO, String pANFITRION_EVENTO, Int64 pVALOR_EVENTO)
        {
            this.ID_DATOS_EVENTO = pID_DATOS_EVENTO;
            this.ID_TIPO_EVENTO = pID_TIPO_EVENTO;
            this.ID_HORARIO_EVENTO = pID_HORARIO_EVENTO;
            this.ID_REQUISITOS_EVENTO = pID_REQUISITOS_EVENTO;
            this.DIRECCION_EVENTO = pDIRECCION_EVENTO;
            this.LUGAR_EVENTO = pLUGAR_EVENTO;
            this.NOMBRE_EVENTO = pNOMBRE_EVENTO;
            this.ANFITRION_EVENTO = pANFITRION_EVENTO;
            this.VALOR_EVENTO = pVALOR_EVENTO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
