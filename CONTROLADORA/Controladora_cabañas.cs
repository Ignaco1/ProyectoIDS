using MODELO.Composite;
using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CONTROLADORA
{
    public class Controladora_cabañas
    {
        private static Controladora_cabañas instancia;
        public static Controladora_cabañas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_cabañas();
                }
                return instancia;
            }
        }

        public Controladora_cabañas()
        {

        }

        public ReadOnlyCollection<Cabaña> ListarCabañas()
        {
            using (var context = new Context())
            {
                return context.Cabañas.Include(c => c.Imagenes).ToList().AsReadOnly();
            }
        }

        public Cabaña CrearCabaña(string nombre, int capacidad, decimal precioxnoche, string descripcion, bool activa, List<byte[]> imagenes)
        {
            Cabaña cabaña = new Cabaña();

            cabaña.Nombre = nombre;
            cabaña.Capacidad = capacidad;
            cabaña.PrecioPorNoche = precioxnoche;
            cabaña.Descripcion = descripcion;
            cabaña.Activa = activa;

            foreach (var img in imagenes)
            {
                cabaña.Imagenes.Add(new ImagenCabaña
                {
                    Imagen = img
                });
            }

            return cabaña;
        }

        public string AgregarCabaña(Cabaña nuevaCabaña)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Add(nuevaCabaña);
                    context.SaveChanges();
                    return $"Nueva cabaña agregada al sistema con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }


        }

        public string ModificarCabaña(Cabaña cabaña, List<int> imagenesAEliminar)
        {

            using (var context = new Context())
            {
                var cabañaDB = context.Cabañas.Include(c => c.Imagenes).FirstOrDefault(c => c.CabañaId == cabaña.CabañaId);

                if (cabañaDB == null)
                    return "No se encontró la cabaña.";

                cabañaDB.Nombre = cabaña.Nombre;
                cabañaDB.Capacidad = cabaña.Capacidad;
                cabañaDB.PrecioPorNoche = cabaña.PrecioPorNoche;
                cabañaDB.Descripcion = cabaña.Descripcion;

                foreach (var id in imagenesAEliminar)
                {
                    var img = cabañaDB.Imagenes.FirstOrDefault(i => i.ImagenCabañaId == id);
                    if (img != null) context.ImagenesCabaña.Remove(img);
                }

                cabañaDB.Imagenes.Clear();
                foreach (var img in cabaña.Imagenes)
                {
                    cabañaDB.Imagenes.Add(new ImagenCabaña { Imagen = img.Imagen });
                }

                context.SaveChanges();
                return "Cabaña modificada correctamente.";
            }


        }

        public string ModificarActividadCabaña(Cabaña cabaña)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Update(cabaña);
                    context.SaveChanges();
                    if(cabaña.Activa == true)
                    {
                        return $"Cabaña activada con exito.";
                    }
                    else
                    {
                        return $"Cabaña desactivada con exito.";
                    }
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }


        }

        public string EliminarCabaña(Cabaña cabaña)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Remove(cabaña);
                    context.SaveChanges();
                    return $"Cabaña eliminada con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }


        public bool ValidaCabaña(string nombre, int id)
        {
            using (var context = new Context())
            {
                var cabañas = context.Cabañas.ToList();

                foreach (var cabaña in cabañas)
                {
                    if (cabaña.Nombre == nombre  && cabaña.CabañaId != id)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public Cabaña ObtenerCabañaId(int id)
        {
            using (var context = new Context())
            {
                var cabaña = context.Cabañas.Include(c => c.Imagenes).ToList().FirstOrDefault(c => c.CabañaId == id);

                if (cabaña == null)
                    return null;

                return cabaña;
            }

        }
    }
}
