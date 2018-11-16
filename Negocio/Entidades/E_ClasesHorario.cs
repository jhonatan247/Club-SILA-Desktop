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
    public class E_ClasesHorario
    {
        #region Atributos
        public Int64 ID_CLASES_HORARIO { get; set; }
        public Int64 ID_CLASE_DOMINGO { get; set; }
        public Int64 ID_CLASE_SABADO { get; set; }
        public Int64 ID_CLASE_ENTRE_SEMANA { get; set; }
        #endregion

        #region Constructor
        public E_ClasesHorario()
        {
        }
        #endregion

        #region Métodos
        public E_ClasesHorario(Int64 pID_CLASES_HORARIO, Int64 pID_CLASE_DOMINGO, Int64 pID_CLASE_SABADO, Int64 pID_CLASE_ENTRE_SEMANA)
        {
            this.ID_CLASES_HORARIO = pID_CLASES_HORARIO;
            this.ID_CLASE_DOMINGO = pID_CLASE_DOMINGO;
            this.ID_CLASE_SABADO = pID_CLASE_SABADO;
            this.ID_CLASE_ENTRE_SEMANA = pID_CLASE_ENTRE_SEMANA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
