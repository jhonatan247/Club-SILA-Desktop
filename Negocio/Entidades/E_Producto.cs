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
    public class E_Producto
    {
        #region Atributos
        public Int64 ID_PRODUCTO { get; set; }
        public String NOMBRE_PRODUCTO { get; set; }
        public String DESCRIPCION_PRODUCTO { get; set; }
        public String FOTO_PRODUCTO { get; set; }
        public Int64 PRECIO_PRODUCTO { get; set; }
        #endregion

        #region Constructor
        public E_Producto()
        {
        }
        #endregion

        #region Métodos
        public E_Producto(Int64 pID_PRODUCTO, String pNOMBRE_PRODUCTO, String pDESCRIPCION_PRODUCTO, String pFOTO_PRODUCTO, Int64 pPRECIO_PRODUCTO)
        {
            this.ID_PRODUCTO = pID_PRODUCTO;
            this.NOMBRE_PRODUCTO = pNOMBRE_PRODUCTO;
            this.DESCRIPCION_PRODUCTO = pDESCRIPCION_PRODUCTO;
            this.FOTO_PRODUCTO = pFOTO_PRODUCTO;
            this.PRECIO_PRODUCTO = pPRECIO_PRODUCTO;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
