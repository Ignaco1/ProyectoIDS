namespace MODELO.State
{
    public sealed class EstadoAsignacionPendiente : EstadoAsignacionServicioBase
    {
        public static readonly EstadoAsignacionPendiente Instancia = new EstadoAsignacionPendiente();

        private EstadoAsignacionPendiente() { }

        public override string Nombre => "Pendiente";
    }
}
