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
    public class E_ConfirmarAsistenciaCampeonato
    {
        #region Atributos
        public Int64 ID_CONFIRMAR_ASISTENCIA_CAMPEONATO { get; set; }
        public Int64 ID_CAMPEONATO { get; set; }
        public Int64 ID_DEPORTISTA { get; set; }
        public DateTime FECHA_CONFIRMACION_ASISTENCIA_CAMPEONATO { get; set; }
        #endregion

        #region Constructor
        public E_ConfirmarAsistenciaCampeonato()
        {
        }
        #endregion

        #region Métodos
        public E_ConfirmarAsistenciaCampeonato(Int64 pID_CONFIRMAR_ASISTENCIA_CAMPEONATO, Int64 pID_CAMPEONATO, Int64 pID_DEPORTISTA, DateTime pFECHA_CONFIRMACION_ASISTENCIA_CAMPEONATO)
        {
            this.ID_CONFIRMAR_ASISTENCIA_CAMPEONATO = pID_CONFIRMAR_ASISTENCIA_CAMPEONATO;
            this.ID_CAMPEONATO = pID_CAMPEONATO;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.FECHA_CONFIRMACION_ASISTENCIA_CAMPEONATO = pFECHA_CONFIRMACION_ASISTENCIA_CAMPEONATO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
