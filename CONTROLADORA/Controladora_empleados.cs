using Microsoft.EntityFrameworkCore;
using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_empleados
    {
        private static Controladora_empleados instancia;

        public static Controladora_empleados Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_empleados();
                }
                return instancia;
            }
        }

        public Controladora_empleados()
        {

        }

        public ReadOnlyCollection<Empleado> ListarEmpleados()
        {
            using (var context = new Context())
            {
                return context.Empleados.Include(e => e.RolEmpleado).ToList().AsReadOnly();
            }

        }

        public Empleado CrearEmpleado(string nombre, string apellido, string dni, string email, string telefono, int rolEmpleadoId, string turno)
        {
            Empleado empleado = new Empleado();

            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.Dni = dni;
            empleado.Email = email;
            empleado.Telefono = telefono;
            empleado.RolEmpleadoId = rolEmpleadoId;
            empleado.Turno = turno;
            empleado.Activo = true;
            return empleado;
        }

        public string AgregarEmpleado(Empleado nuevoEmpleado)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Add(nuevoEmpleado);
                    context.SaveChanges();
                    return $"Nuevo empleado agregado al sistema con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + (ex.InnerException?.Message ?? ex.Message);
                }
            }


        }

        public string ModificarEmpleado(Empleado empleado)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Update(empleado);
                    context.SaveChanges();
                    return $"Empleado modificado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + (ex.InnerException?.Message ?? ex.Message);
                }
            }


        }

        public string EliminarEmpleado(Empleado empleado)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Remove(empleado);
                    context.SaveChanges();
                    return $"Empleado eliminado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + (ex.InnerException?.Message ?? ex.Message);
                }
            }
        }

        public bool ValidaEmpleado(string dni, string email, int id)
        {
            using (var context = new Context())
            {
                var empleados = context.Empleados.ToList();

                foreach (var emple in empleados)
                {
                    if ((emple.Dni == dni || emple.Email == email) && emple.EmpleadoId != id)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public string AsignarRolAEmpleado(int empleadoId, List<RolEmpleado> rolSeleccionado)
        {
            using (var context = new Context())
            {
                try
                {
                    var empleado = context.Empleados.FirstOrDefault(e => e.EmpleadoId == empleadoId);

                    if (empleado == null)
                        return "Empleado no encontrado.";

                    var rolId = rolSeleccionado.Select(r => r.RolEmpleadoId).FirstOrDefault();

                    var rolDesdeDb = context.RolesEmpleados.FirstOrDefault(r => r.RolEmpleadoId == rolId);

                    if (rolDesdeDb == null)
                        return "Rol no encontrado.";

                    empleado.RolEmpleadoId = rolDesdeDb.RolEmpleadoId;

                    context.SaveChanges();
                    return "Rol asignado correctamente.";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + (ex.InnerException?.Message ?? ex.Message);
                }
            }
        }
    }
}
