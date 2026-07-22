namespace MODELO.State
{
    public sealed class EstadoPendiente : EstadoReservaBase
    {
        public static readonly EstadoPendiente Instancia = new EstadoPendiente();

        private EstadoPendiente() { }

        public override string Nombre => "Pendiente";
    }
}
