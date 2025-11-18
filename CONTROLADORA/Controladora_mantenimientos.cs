using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.Imagenes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_mantenimientos
    {
        private static Controladora_mantenimientos instancia;

        public static Controladora_mantenimientos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_mantenimientos();
                }
                return instancia;
            }
        }

        public Controladora_mantenimientos()
        {

        }

        public ReadOnlyCollection<Mantenimiento> ListarMantenimientos()
        {
            using (var context = new Context())
            {
                return context.Mantenimientos
                    .Include(s => s.Imagenes)
                    .AsNoTracking()
                    .ToList()
                    .AsReadOnly();
            }

        }

        public Mantenimiento CrearMantenimiento(string nombre, string descripcion, List<byte[]> imagenes)
        {
            Mantenimiento mantenimiento = new Mantenimiento();

            mantenimiento.Nombre = nombre;
            mantenimiento.Descripcion = descripcion;
            mantenimiento.Activo = true;

            if (imagenes != null)
            {
                foreach (var img in imagenes)
                {
                    mantenimiento.Imagenes.Add(new ImagenMantenimiento { Imagen = img });
                }
            }

            return mantenimiento;
        }

        public string AgregarMantenimiento(Mantenimiento nuevoMantenimiento)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Add(nuevoMantenimiento);
                    context.SaveChanges();
                    return $"Nuevo mantenimiento agregado al sistema con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }


        }

        public string ModificarMantenimiento(Mantenimiento mantenimiento, List<int> imagenesAEliminar)
        {

            using (var context = new Context())
            {
                var mantenimientoDB = context.Mantenimientos
                    .Include(m => m.Imagenes)
                    .FirstOrDefault(m => m.MantenimientoId == mantenimiento.MantenimientoId);

                if (mantenimientoDB == null)
                    return "No se encontró el mantenimiento.";

                mantenimientoDB.Nombre = mantenimiento.Nombre;
                mantenimientoDB.Descripcion = mantenimiento.Descripcion;

                foreach (var id in imagenesAEliminar)
                {
                    var img = mantenimientoDB.Imagenes.FirstOrDefault(i => i.ImagenMantenimientoId == id);
                    if (img != null) context.ImagenesMantenimiento.Remove(img);
                }

                mantenimientoDB.Imagenes.Clear();
                foreach (var img in mantenimiento.Imagenes)
                {
                    mantenimientoDB.Imagenes.Add(new ImagenMantenimiento { Imagen = img.Imagen });
                }

                context.SaveChanges();
                return "Mantenimiento modificado correctamente.";
            }


        }

        public string EliminarMantenimiento(Mantenimiento mantenimiento)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Remove(mantenimiento);
                    context.SaveChanges();
                    return $"Mantenimiento eliminado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }
    }
}
