namespace MODELO.State
{
    public sealed class EstadoFinalizada : EstadoReservaBase
    {
        public static readonly EstadoFinalizada Instancia = new EstadoFinalizada();

        private EstadoFinalizada() { }

        public override string Nombre => "Finalizada";
    }
}
