#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Manejo_de_datos;
#endregion

#region Lógica
namespace Negocio.Lógica
{
    #region Class
    public class MensajeBx
    {
        #region Atributos
        Programa Prog = new Programa();
        #endregion

        #region Cuadros de mensaje
        public DialogResult Apagar(Int32 Index)
        {
            String Titulo = "";
            switch(Index)
            {
                case 0:
                    Titulo = "Apagar";
                    break;
                case 1:
                    Titulo = "Suspender";
                    break;
                case 2:
                    Titulo = "Reiniciar";
                    break;
                default:
                    break;
            }

            return MessageBox.Show("Estás seguro(a) de que deseas realizar ésta acción?", Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Guardar()
        {
            return MessageBox.Show("Guardar cambios\n¿Desea guardar los cambios realizados?\nPara realizar ésta accion necesita ingresar nuevamente su contraseña.", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Eliminar()
        {
            return MessageBox.Show("Eliminar registro\n¿Desea eliminar el registro seleccionado permanentemente?\nPara realizar ésta accion necesita ingresar nuevamente su contraseña.", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Reciclar()
        {
            return MessageBox.Show("Reciclar registro\n¿Desea enviar a la cesta de reciclaje el registro seleccionado?", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Restaurar()
        {
            return MessageBox.Show("Restaurar registro\n¿Desea restaurar el registro seleccionado?", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult EliminarSelec()
        {
            return MessageBox.Show("Eliminar selección\n¿Desea eliminar permanentemente los registros seleccionados?\nPara realizar ésta accion necesita ingresar nuevamente su contraseña.", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult ReciclarSelec()
        {
            return MessageBox.Show("Reciclar selección\n¿Desea enviar a la cesta de reciclaje los registros seleccionados?", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult RestaurarSelec()
        {
            return MessageBox.Show("Restaurar selección\n¿Desea restaurar los registros seleccionados?", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult EliminarTodos()
        {
            return MessageBox.Show("Eliminar reciclaje\n¿Desea eliminar permanentemente todos los registros de la papelera?\nPara realizar ésta accion necesita ingresar nuevamente su contraseña.", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult ReciclarTodos()
        {
            return MessageBox.Show("Reciclar registros\n¿Desea enviar a la cesta de reciclaje todos los registros de la tabla?", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult RestaurarTodos()
        {
            return MessageBox.Show("Restaurar reciclaje\n¿Desea restaurar todos los registros de la papelera?", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult ActualizarSelec()
        {
            return MessageBox.Show("Actualizar selección\n¿Desea actualizar el mismo valor en el campo seleccionado para los registros escogidos?", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult ActualizarTodos()
        {
            return MessageBox.Show("Actualizar todos los registros\n¿Desea insertar el mismo valor en el campo seleccionado campo para todos los registros de la tabla?\nPara realizar ésta accion necesita ingresar nuevamente su contraseña de administrador.", "Club Sila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Excepcion(Exception ex)
        {
            return MessageBox.Show("Error controlado\n\nDescripción:\n" + ex.ToString(), "Club Sila", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private DialogResult ErrorPersonalizado(string Texto)
        {
            return MessageBox.Show("Ha ocurrido un error\n"+Texto, "Club Sila", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DialogResult Insertado()
        {
            return MessageBox.Show("¡Enviado!\nDatos guardados satisfactoriamente", "Club Sila", MessageBoxButtons.OK);
        }
        public DialogResult Eliminado()
        {
            return MessageBox.Show("¡Eliminado!\nRegistro eliminado correctamente", "Club Sila", MessageBoxButtons.OK);
        }
        public DialogResult Reciclado()
        {
            return MessageBox.Show("¡Reciclado!\nEl registro ha sido enviado correctamente a la papelera", "Club Sila", MessageBoxButtons.OK);
        }
        public DialogResult Reciclados()
        {
            return MessageBox.Show("¡Reciclados!\nLos registros han sido enviados correctamente a la papelera", "Club Sila", MessageBoxButtons.OK);
        }
        public DialogResult Reestaurado()
        {
            return MessageBox.Show("¡Recuperado!\nEl registro han sido correctamente reestaurado", "Club Sila", MessageBoxButtons.OK);
        }
        public DialogResult Reestaurados()
        {
            return MessageBox.Show("¡Recuperados!\nLos registros han sido correctamente reestaurados", "Club Sila", MessageBoxButtons.OK);
        }
        public DialogResult Eliminados()
        {
            return MessageBox.Show("¡Eliminados!\nRegistros eliminados correctamente", "Club Sila", MessageBoxButtons.OK);
        }
        public DialogResult Actualizado()
        {
            return MessageBox.Show("¡Actualizado!\nDatos actualizados satisfactoriamente", "Club Sila", MessageBoxButtons.OK); 
        }
        public DialogResult Salir()
        {
            return MessageBox.Show("Cerrar\n¿Desea salir de la aplicación?", "Club Sila", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); 
        }
        public DialogResult CerrarSesion()
        {
            return MessageBox.Show("Cerrar sesión\n¿Desea cerrar la sesión iniciada?", "Club Sila", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); 
        }
        public DialogResult ImagenesAñadidas()
        {
            return MessageBox.Show("¡Añadidas!\nSe han añadido las imágenes", "Club Sila", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult FotoPerfil()
        {
            return MessageBox.Show("¡Foto de perfil actualizada correctamente!\nHas actualizado tu foto de perfil.", "Club Sila", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult DatosIncorrectos(String NOMBRE_USUARIO)
        {
            if (Prog.SELECT_NOMBRE_USUARIO(NOMBRE_USUARIO).Rows.Count >= 1)
            {
                return MessageBox.Show("Contraseña incorrecta\nLa contraseña que has ingresado no es válida.\nPor favor, revísa e intenta nuevamente.", "Club Sila", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show("Datos de ingreso incorrectos\nEl usuario ingresado no se encuentra registrado.\nPor favor, revísa e intenta nuevamente.", "Club Sila", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ErrorMensaje(Int16 Numero)
        {
            switch (Numero)
            {
                case 0:
                    ErrorPersonalizado(
                        "Error de datos: Asegúrese de que el nombre suministrado sea único entre todos los registros. No es posible insertar más de un objeto con el mismo nombre.");
                    break;
                case 1:
                    ErrorPersonalizado(
                        "Error de eliminación: Es posible que existan datos en el programa que dependen del registro seleccionado o que éste haya sido eliminado previamente.");
                    break;
                case 2:
                    ErrorPersonalizado(
                        "No hay tablas visibles.\n(Lista de registros).");
                    break;
                case 3:
                    ErrorPersonalizado(
                        "No hay entidades visibles.\n(Vista de registro en la página buscar).");
                    break;
                case 4:
                    ErrorPersonalizado(
                        "Error de datos: Asegúrese de que el nombre suministrado sea único entre todos los registros. No es posible insertar más de un objeto con el mismo nombre.\nEs provable que el objeto haya sido eliminado previamente.");
                    break;
                case 5:
                    ErrorPersonalizado(
                        "Error de eliminación: Es posible que existan datos en el programa que dependen de alguno de los registros seleccionados o que éste haya sido eliminado previamente.");
                    break;
                case 6:
                    ErrorPersonalizado(
                        "Debe seleccionar más de una fila para graficar.");
                    break;
                case 7:
                    ErrorPersonalizado(
                        "No hay gráficas visibles.");
                    break;
                case 8:
                    ErrorPersonalizado(
                        "No se puede iniciar el programa correctamente. Es posible que se hayan modificado ó eliminado archivos fundamentales del programa.");
                    break;
                case 9:
                    ErrorPersonalizado(
                        "Los colores de fuente y de fondo no pueden ser similares.");
                    break;
                case 10:
                    ErrorPersonalizado(
                        "No ha seleccionado el campo a actualizar.");
                    break;
                case 11:
                    ErrorPersonalizado(
                        "No ha seleccionado ningún elemento.");
                    break;
                case 12:
                    ErrorPersonalizado(
                        "Error de actualización: No se han podido actualizar todos los elementos seleccionados. Asegurate de que los datos suministrados sean correctos.");
                    break;
                case 13:
                    ErrorPersonalizado(
                        "Error de eliminación: Por seguridad, no es posible vaciar la tabla por completo, ya que ésto ocacionaría errores en el sistema.");
                    break;
                default:
                    break;
            }
        }
        public void DobleInicio()
        {
            MessageBox.Show("No se logró completar el inicio\nActualmente la aplicación Club Sila esta siendo utilizada por un usuario.\n\nLa licencia contratada por el ordenador sólo permite la interacción de un único usuario con el sistema. Si desea permitir el ingreso simultaneo de varios usuarios, comuniquese con la empresa distribuidora del producto.", "Club Sila", MessageBoxButtons.OK);
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
