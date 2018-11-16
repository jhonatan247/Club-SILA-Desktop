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
    public class E_Inventario
    {
        #region Atributos
        public Int64 ID_INVENTARIO { get; set; }
        public Int64 ID_SEDE { get; set; }
        public Int64 ID_OBJETO { get; set; }
        public Int64 CANTIDAD_OBJETO_SEDE { get; set; }
        public DateTime FECHA_ACTUALIZACION_INVENTARIO { get; set; }
        #endregion

        #region Constructor
        public E_Inventario()
        {
        }
        #endregion

        #region Métodos
        public E_Inventario(Int64 pID_INVENTARIO, Int64 pID_SEDE, Int64 pID_OBJETO, Int64 pCANTIDAD_OBJETO_SEDE, DateTime pFECHA_ACTUALIZACION_INVENTARIO)
        {
            this.ID_INVENTARIO = pID_INVENTARIO;
            this.ID_SEDE = pID_SEDE;
            this.ID_OBJETO = pID_OBJETO;
            this.CANTIDAD_OBJETO_SEDE = pCANTIDAD_OBJETO_SEDE;
            this.FECHA_ACTUALIZACION_INVENTARIO = pFECHA_ACTUALIZACION_INVENTARIO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
