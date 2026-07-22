namespace MODELO.State
{
    public sealed class EstadoActiva : EstadoReservaBase
    {
        public static readonly EstadoActiva Instancia = new EstadoActiva();

        private EstadoActiva() { }

        public override string Nombre => "Activa";
    }
}
