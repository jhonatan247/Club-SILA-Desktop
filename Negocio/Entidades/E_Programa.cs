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
    public class E_Programa
    {
        #region Atributos
        public Int64 ID_CUENTA { get; set; }
        public Int64 FORMULARIO { get; set; }
        public String SONIDO { get; set; }
        public Int32 RED { get; set; }
        public Int32 GREEN { get; set; }
        public Int32 BLUE { get; set; }
        public Int32 RED1 { get; set; }
        public Int32 GREEN1 { get; set; }
        public Int32 BLUE1 { get; set; }
        public Image FOTO_PERFIL { get; set; }
        public Int64 FMR_ANTERIOR { get; set; }
        #endregion

        #region Constructor
        public E_Programa()
        {
        }
        #endregion

        #region Métodos
        public E_Programa(Int64 pID_CUENTA, Int64 pFORMULARIO, String pSONIDO,
            Int32 pRED, Int32 pGREEN, Int32 pBLUE, Int32 pRED1, Int32 pGREEN1, Int32 pBLUE1, Image pFOTO_PERFIL,
            Int64 pFMR_ANTERIOR)
        {
            this.ID_CUENTA = pID_CUENTA;
            this.RED = pRED;
            this.GREEN = pGREEN;
            this.BLUE = pBLUE;
            this.RED1 = pRED1;
            this.GREEN1 = pGREEN1;
            this.FMR_ANTERIOR = pFMR_ANTERIOR;
        }
        public E_Programa(Int64 pFORMULARIO)
        {
            this.FORMULARIO = pFORMULARIO;
        }
        public E_Programa(Int64 pFORMULARIO, Int64 pFMR_ANTERIOR)
        {
            this.FORMULARIO = pFORMULARIO;
            this.FMR_ANTERIOR = pFMR_ANTERIOR;
        }
        public E_Programa(Int32 pRED, Int32 pGREEN, Int32 pBLUE, Int32 pRED1, Int32 pGREEN1, Int32 pBLUE1)
        {
            this.RED = pRED;
            this.GREEN = pGREEN;
            this.BLUE = pBLUE;
            this.RED1 = pRED1;
            this.GREEN1 = pGREEN1;
            this.BLUE1 = pBLUE1;
        }
        public E_Programa(String pSONIDO)
        {
            this.SONIDO = pSONIDO;
        }
        public E_Programa(Image pFOTO_PERFIL)
        {
            this.FOTO_PERFIL = pFOTO_PERFIL;
        }
        public E_Programa(Int64 pID_CUENTA,
            Int32 pRED, Int32 pGREEN, Int32 pBLUE, Int32 pRED1, Int32 pGREEN1, Int32 pBLUE1, Image pFOTO_PERFIL)
        {
            this.ID_CUENTA = pID_CUENTA;
            this.RED = pRED;
            this.GREEN = pGREEN;
            this.BLUE = pBLUE;
            this.RED1 = pRED1;
            this.GREEN1 = pGREEN1;
            this.BLUE1 = pBLUE1;
            this.FOTO_PERFIL = pFOTO_PERFIL;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
