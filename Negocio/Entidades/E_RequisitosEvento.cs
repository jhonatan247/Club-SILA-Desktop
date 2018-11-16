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
    public class E_RequisitosEvento
    {
        #region Atributos
        public Int64 ID_REQUISITOS_EVENTO { get; set; }
        public Int64 ID_CREDITOS_ENTRENAMIENTO_REQUERIDOS { get; set; }
        public String REQUIERE_CERTIFICADO_MEDICO { get; set; }
        public String REQUIERE_PAZ_Y_SALVO{ get; set; }
        public String REQUIERE_DOCUMENTO_ID { get; set; }
        public String CUMPLE_PERMISO_ACUDIENTE { get; set; }
        public String REQUIERE_PERMISO_ACUDIENTE { get; set; }
        #endregion

        #region Constructor
        public E_RequisitosEvento()
        {
        }
        #endregion

        #region Métodos
        public E_RequisitosEvento(Int64 pID_REQUISITOS_EVENTO, Int64 pID_CREDITOS_ENTRENAMIENTO_REQUERIDOS, String pREQUIERE_CERTIFICADO_MEDICO, String pREQUIERE_PAZ_Y_SALVO, String pREQUIERE_DOCUMENTO_ID, String pCUMPLE_PERMISO_ACUDIENTE, String pREQUIERE_PERMISO_ACUDIENTE)
        {
            this.ID_REQUISITOS_EVENTO = pID_REQUISITOS_EVENTO;
            this.ID_CREDITOS_ENTRENAMIENTO_REQUERIDOS = pID_CREDITOS_ENTRENAMIENTO_REQUERIDOS;
            this.REQUIERE_CERTIFICADO_MEDICO = pREQUIERE_CERTIFICADO_MEDICO;
            this.REQUIERE_PAZ_Y_SALVO = pREQUIERE_PAZ_Y_SALVO;
            this.REQUIERE_DOCUMENTO_ID = pREQUIERE_DOCUMENTO_ID;
            this.REQUIERE_PERMISO_ACUDIENTE = pREQUIERE_PERMISO_ACUDIENTE;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
