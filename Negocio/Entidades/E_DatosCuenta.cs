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
    public class E_DatosCuenta
    {
        #region Atributos
        public Int64 ID_DATOS_CUENTA { get; set; }
        public Int64 ID_DATOS_PERSONALES { get; set; }
        public Int64 ID_DATOS_CONTACTO { get; set; }
        public Int64 ID_DATOS_DEPORTISTA { get; set; }
        public Int64 ID_DATOS_SEGURIDAD { get; set; }
        public Int64 ID_DATOS_ADMINISTRADOR { get; set; }
        public Int64 ID_DATOS_ACUDIENTE { get; set; }
        public Int64 ID_DATOS_PROGRAMADOR { get; set; }
        public Int64 ID_DATOS_ENTRENADOR { get; set; }
        #endregion

        #region Constructor
        public E_DatosCuenta()
        {
        }
        #endregion

        #region Métodos
        public E_DatosCuenta(Int64 pID_DATOS_CUENTA, Int64 pID_DATOS_PERSONALES, Int64 pID_DATOS_CONTACTO, Int64 pID_DATOS_DEPORTISTA, 
            Int64 pID_DATOS_SEGURIDAD, Int64 pID_DATOS_ADMINISTRADOR, Int64 pID_DATOS_ACUDIENTE, Int64 pID_DATOS_PROGRAMADOR, Int64 pID_DATOS_ENTRENADOR)
        {
            this.ID_DATOS_CUENTA = pID_DATOS_CUENTA;
            this.ID_DATOS_PERSONALES = pID_DATOS_PERSONALES;
            this.ID_DATOS_CONTACTO = pID_DATOS_CONTACTO;
            this.ID_DATOS_DEPORTISTA = pID_DATOS_DEPORTISTA;
            this.ID_DATOS_SEGURIDAD = pID_DATOS_SEGURIDAD;
            this.ID_DATOS_ADMINISTRADOR = pID_DATOS_ADMINISTRADOR;
            this.ID_DATOS_ACUDIENTE = pID_DATOS_ACUDIENTE;
            this.ID_DATOS_PROGRAMADOR = pID_DATOS_PROGRAMADOR;
            this.ID_DATOS_ENTRENADOR = pID_DATOS_ENTRENADOR;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
