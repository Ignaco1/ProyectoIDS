namespace MODELO.State
{
    public sealed class EstadoAsignacionMantenimientoFinalizada : EstadoAsignacionMantenimientoBase
    {
        public static readonly EstadoAsignacionMantenimientoFinalizada Instancia = new EstadoAsignacionMantenimientoFinalizada();

        private EstadoAsignacionMantenimientoFinalizada() { }

        public override string Nombre => "Finalizado";
    }
}
