namespace MODELO.State
{
    public sealed class EstadoAsignacionFinalizada : EstadoAsignacionServicioBase
    {
        public static readonly EstadoAsignacionFinalizada Instancia = new EstadoAsignacionFinalizada();

        private EstadoAsignacionFinalizada() { }

        public override string Nombre => "Finalizado";
    }
}
