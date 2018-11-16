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
    public class E_RegistroAhorro
    {
        #region Atributos
        public Int64 ID_REGISTRO_AHORRO { get; set; }
        public Int64 ID_DEPORTISTA { get; set; }
        public Int64 VALOR_DEPOSITADO { get; set; }
        public DateTime FECHA_REGISTRO_AHORRO { get; set; }
        #endregion

        #region Constructor
        public E_RegistroAhorro()
        {
        }
        #endregion

        #region Métodos
        public E_RegistroAhorro(Int64 pID_REGISTRO_AHORRO, Int64 pID_DEPORTISTA, Int64 pVALOR_DEPOSITADO, DateTime pFECHA_REGISTRO_AHORRO)
        {
            this.ID_REGISTRO_AHORRO = pID_REGISTRO_AHORRO;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.VALOR_DEPOSITADO = pVALOR_DEPOSITADO;
            this.FECHA_REGISTRO_AHORRO = pFECHA_REGISTRO_AHORRO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
