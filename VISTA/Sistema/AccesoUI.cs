using System;
using System.Linq;
using System.Windows.Forms;
using CAPA_COMUN.Cache;

namespace VISTA
{
    public static class AccesoUI
    {
        public static void AplicarPermisos(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is Button boton && !string.IsNullOrWhiteSpace(boton.Tag?.ToString()))
                {
                    string permiso = boton.Tag.ToString();
                    bool tienePermiso = UsuarioCache.Permisos.Any(p => p.Equals(permiso, StringComparison.OrdinalIgnoreCase));

                    boton.Enabled = tienePermiso;
                    boton.Visible = tienePermiso;
                }

                if (control.HasChildren)
                {
                    AplicarPermisos(control);
                }
            }
        }
    }
}
