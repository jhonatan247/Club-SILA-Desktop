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
    public class E_IntencidadHoraria
    {
        #region Atributos
        public Int64 ID_INTENCIDAD_HORARIA { get; set; }
        public String NIVEL_INTENCIDAD_HORARIA { get; set; }
        public String DURACION_CLASE { get; set; }
        public Int64 N_CLASES_SEMANA { get; set; }
        #endregion

        #region Constructor
        public E_IntencidadHoraria()
        {
        }
        #endregion

        #region Métodos
        public E_IntencidadHoraria(Int64 pID_INTENCIDAD_HORARIA, String pNIVEL_INTENCIDAD_HORARIA, String pDURACION_CLASE, Int64 pN_CLASES_SEMANA)
        {
            this.ID_INTENCIDAD_HORARIA = pID_INTENCIDAD_HORARIA;
            this.NIVEL_INTENCIDAD_HORARIA = pNIVEL_INTENCIDAD_HORARIA;
            this.DURACION_CLASE = pDURACION_CLASE;
            this.N_CLASES_SEMANA = pN_CLASES_SEMANA;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
