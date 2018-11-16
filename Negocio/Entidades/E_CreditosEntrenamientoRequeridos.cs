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
    public class E_CreditosEntrenamientoRequeridos
    {
        #region Atributos
        public Int64 ID_CREDITOS_ENTRENAMIENTO_REQUERIDOS { get; set; }
        public Int64 N_CREDITOS_ENTRENAMIENTO_REQUERIDOS { get; set; }
        public DateTime FECHA_INICIO_CONTEO { get; set; }
        public DateTime FECHA_FINALIZACION_CONTEO { get; set; }
        #endregion

        #region Constructor
        public E_CreditosEntrenamientoRequeridos()
        {
        }
        #endregion

        #region Métodos
        public E_CreditosEntrenamientoRequeridos(Int64 pID_CREDITOS_ENTRENAMIENTO_REQUERIDOS, Int64 pN_CREDITOS_ENTRENAMIENTO_REQUERIDOS, DateTime pFECHA_INICIO_CONTEO, DateTime pFECHA_FINALIZACION_CONTEO)
        {
            this.ID_CREDITOS_ENTRENAMIENTO_REQUERIDOS = pID_CREDITOS_ENTRENAMIENTO_REQUERIDOS;
            this.N_CREDITOS_ENTRENAMIENTO_REQUERIDOS = pN_CREDITOS_ENTRENAMIENTO_REQUERIDOS;
            this.FECHA_INICIO_CONTEO = pFECHA_INICIO_CONTEO;
            this.FECHA_FINALIZACION_CONTEO = pFECHA_FINALIZACION_CONTEO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
