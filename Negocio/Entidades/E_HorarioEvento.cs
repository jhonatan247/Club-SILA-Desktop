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
    public class E_HorarioEvento
    {
        #region Atributos
        public Int64 ID_HORARIO_EVENTO { get; set; }
        public String HORA_AGRUPACION { get; set; }
        public String HORA_INICIO { get; set; }
        public String HORA_FINALIZACION { get; set; }
        public String HORA_EXPARSIMIENTO { get; set; }
        #endregion

        #region Constructor
        public E_HorarioEvento()
        {
        }
        #endregion

        #region Métodos
        public E_HorarioEvento(Int64 pID_HORARIO_EVENTO, String pHORA_AGRUPACION, String pHORA_INICIO, String pHORA_FINALIZACION, String pHORA_EXPARSIMIENTO)
        {
            this.ID_HORARIO_EVENTO = pID_HORARIO_EVENTO;
            this.HORA_AGRUPACION = pHORA_AGRUPACION;
            this.HORA_INICIO = pHORA_INICIO;
            this.HORA_FINALIZACION = pHORA_FINALIZACION;
            this.HORA_EXPARSIMIENTO = pHORA_EXPARSIMIENTO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
