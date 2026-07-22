namespace MODELO.State
{
    public sealed class EstadoAsignacionActiva : EstadoAsignacionServicioBase
    {
        public static readonly EstadoAsignacionActiva Instancia = new EstadoAsignacionActiva();

        private EstadoAsignacionActiva() { }

        public override string Nombre => "Activo";
    }
}
