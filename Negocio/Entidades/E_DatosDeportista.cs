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
    public class E_DatosDeportista
    {
        #region Atributos
        public Int64 ID_DATOS_DEPORTISTA { get; set; }
        public Int64 ID_REQUISITOS_CUMPLIDOS_DEP { get; set; }
        public Int64 ID_CATEGORIA_EDAD { get; set; }
        public Int64 ID_CINTURON { get; set; }
        public Int64 ID_HORARIO { get; set; }
        public Int64 ID_TIPO_MENSUALIDAD { get; set; }
        public String PESO_DEPORTISTA{ get; set; }
        public String ESTATURA_DEPORTISTA { get; set; }
        public String TIPO_SANGRE_DEPORTISTA { get; set; }
        public String FOTOCOPIA_DOCUMENTO_ID { get; set; }
        public String FOTOCOPIA_CARNE_EPS { get; set; }
        public String CERTIFICADO_MEDICO_DEPORTISTA { get; set; }
        public String FOTO_DEPORTISTA{ get; set; }
        public String ESTADO_DEPORTISTA { get; set; }
        #endregion

        #region Constructor
        public E_DatosDeportista()
        {
        }
        #endregion

        #region Métodos
        public E_DatosDeportista(Int64 pID_DATOS_DEPORTISTA, Int64 pID_REQUISITOS_CUMPLIDOS_DEP, Int64 pID_CATEGORIA_EDAD, Int64 pID_CINTURON, Int64 pID_HORARIO, Int64 pID_TIPO_MENSUALIDAD, 
            String pPESO_DEPORTISTA, String pESTATURA_DEPORTISTA, String pTIPO_SANGRE_DEPORTISTA, String pFOTOCOPIA_DOCUMENTO_ID, String pFOTOCOPIA_CARNE_EPS, String pCERTIFICADO_MEDICO_DEPORTISTA, String pFOTO_DEPORTISTA, String pESTADO_DEPORTISTA)
        {
            this.ID_DATOS_DEPORTISTA = pID_DATOS_DEPORTISTA;
            this.ID_REQUISITOS_CUMPLIDOS_DEP = pID_REQUISITOS_CUMPLIDOS_DEP;
            this.ID_CATEGORIA_EDAD = pID_CATEGORIA_EDAD;
            this.ID_CINTURON = pID_CINTURON;
            this.ID_HORARIO = pID_HORARIO;
            this.ID_TIPO_MENSUALIDAD = pID_TIPO_MENSUALIDAD;
            this.PESO_DEPORTISTA = pPESO_DEPORTISTA;
            this.ESTATURA_DEPORTISTA = pESTATURA_DEPORTISTA;
            this.TIPO_SANGRE_DEPORTISTA = pTIPO_SANGRE_DEPORTISTA;
            this.FOTOCOPIA_DOCUMENTO_ID = pFOTOCOPIA_DOCUMENTO_ID;
            this.FOTOCOPIA_CARNE_EPS = pFOTOCOPIA_CARNE_EPS;
            this.CERTIFICADO_MEDICO_DEPORTISTA = pCERTIFICADO_MEDICO_DEPORTISTA;
            this.FOTO_DEPORTISTA = pFOTO_DEPORTISTA;
            this.ESTADO_DEPORTISTA = pESTADO_DEPORTISTA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
