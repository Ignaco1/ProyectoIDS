namespace MODELO.State
{
    public sealed class EstadoAsignacionMantenimientoPendiente : EstadoAsignacionMantenimientoBase
    {
        public static readonly EstadoAsignacionMantenimientoPendiente Instancia = new EstadoAsignacionMantenimientoPendiente();

        private EstadoAsignacionMantenimientoPendiente() { }

        public override string Nombre => "Pendiente";
    }
}
