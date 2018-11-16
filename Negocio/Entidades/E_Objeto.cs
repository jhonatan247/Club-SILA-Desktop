#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
#endregion

#region ENTIDAD
namespace Negocio.Entidades
{
    #region Class
    public class E_Objeto
    {
        #region Atributos
        private Int64 _ID_OBJETO;

        public Int64 ID_OBJETO
        {
            get { return _ID_OBJETO; }
            set { _ID_OBJETO = value; }
        }
        public String NOMBRE_OBJETO { get; set; }
        public String DESCRIPCION_OBJETO { get; set; }
        public Int64 VALOR_APROXIMADO_OBJETO { get; set; }
        public Image IMAGEN_OBJETO { get; set; }
        #endregion

        #region Constructores
        public E_Objeto()
        {
        }
        public E_Objeto(Int64 pID_OBJETO, String pNOMBRE_OBJETO, String pDESCRIPCION_OBJETO, Int64 pVALOR_APROXIMADO_OBJETO, Image pIMAGEN_OBJETO)
        {
            this.ID_OBJETO = pID_OBJETO;
            this.NOMBRE_OBJETO = pNOMBRE_OBJETO;
            this.DESCRIPCION_OBJETO = pDESCRIPCION_OBJETO;
            this.VALOR_APROXIMADO_OBJETO = pVALOR_APROXIMADO_OBJETO;
            this.IMAGEN_OBJETO = pIMAGEN_OBJETO;
        }
        public E_Objeto(String pValor)
        {
            this.NOMBRE_OBJETO = pValor;
            this.DESCRIPCION_OBJETO = pValor;
        }
        public E_Objeto(Int64 pValor)
        {
            this.ID_OBJETO = pValor;
            this.VALOR_APROXIMADO_OBJETO = pValor;
        }
        public E_Objeto(Image pIMAGEN_OBJETO)
        {
            this.IMAGEN_OBJETO = pIMAGEN_OBJETO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
