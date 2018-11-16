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
    public class E_LogroCombate
    {
        #region Atributos
        public Int64 ID_LOGRO_COMBATE { get; set; }
        public Int64 ID_TIPO_COMBATE { get; set; }
        public Int64 ID_CATEGORIA_PESO { get; set; }
        public Int64 COMBATES_DISPUTADOS { get; set; }
        public Int64 COMBATES_GANADOS { get; set; }
        #endregion

        #region Constructor
        public E_LogroCombate()
        {
        }
        #endregion

        #region Métodos
        public E_LogroCombate(Int64 pID_LOGRO_COMBATE, Int64 pID_TIPO_COMBATE, Int64 pID_CATEGORIA_PESO, Int64 pCOMBATES_DISPUTADOS, Int64 pCOMBATES_GANADOS)
        {
            this.ID_LOGRO_COMBATE = pID_LOGRO_COMBATE;
            this.ID_TIPO_COMBATE = pID_TIPO_COMBATE;
            this.COMBATES_DISPUTADOS = pCOMBATES_DISPUTADOS;
            this.COMBATES_GANADOS = pCOMBATES_GANADOS;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
