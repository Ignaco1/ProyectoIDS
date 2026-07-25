namespace MODELO.State
{
    public sealed class EstadoAsignacionMantenimientoActiva : EstadoAsignacionMantenimientoBase
    {
        public static readonly EstadoAsignacionMantenimientoActiva Instancia = new EstadoAsignacionMantenimientoActiva();

        private EstadoAsignacionMantenimientoActiva() { }

        public override string Nombre => "Activo";
    }
}
