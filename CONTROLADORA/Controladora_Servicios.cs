using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.Composite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_Servicios
    {
        private static Controladora_Servicios instancia;

        public static Controladora_Servicios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_Servicios();
                }
                return instancia;
            }
        }

        public Controladora_Servicios()
        {

        }

        public ReadOnlyCollection<Servicio> ListarServicios()
        {
            using (var context = new Context())
            {
                return context.Servicios
                    .Include(s => s.Categorias)      
                    .AsNoTracking()
                    .ToList()
                    .AsReadOnly();
            }

        }

        public Servicio CrearServicio(string nombre, string descripcion, decimal importe)
        {
            Servicio servicio = new Servicio();

            servicio.Nombre = nombre;
            servicio.Descripcion = descripcion;
            servicio.Importe = importe;
            servicio.Activo = true;
            servicio.Categorias = new List<Categoria>();
            return servicio;
        }

        public string AgregarServicio(Servicio nuevoServicio)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Add(nuevoServicio);
                    context.SaveChanges();
                    return $"Nuevo servicio agregado al sistema con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }


        }

        public string ModificarServicio(Servicio servicio)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Update(servicio);
                    context.SaveChanges();
                    return $"Servicio modificado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }


        }

        public string EliminarServicio(Servicio servicio)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Remove(servicio);
                    context.SaveChanges();
                    return $"Servicio eliminado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public string AsignarCategoriaAServicio(int servicioId, List<Categoria> categoriaSeleccionada)
        {
            using (var context = new Context())
            {
                try
                {
                    var servicio = context.Servicios
                        .Include(s => s.Categorias)
                        .FirstOrDefault(s => s.ServicioId == servicioId);

                    if (servicio == null)
                        return "Servicio no encontrado.";

                    servicio.Categorias.Clear();

                    var idSeleccionado = categoriaSeleccionada.Select(c => c.CategoriaId).ToList();

                    var categoriasDesdeDb = context.Categorias
                    .Where(c => idSeleccionado.Contains(c.CategoriaId))
                    .ToList();

                    foreach (var categoria in categoriasDesdeDb)
                    {
                        servicio.Categorias.Add(categoria);
                    }

                    context.SaveChanges();
                    return "categorias asignadas correctamente.";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }


            }
        }
    }
}
