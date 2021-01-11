namespace PrincipioDeSustitucionLISKOV.Implementacion
{
    public class Vehiculo : Carro
    {
        public Vehiculo()
        { }

        public Vehiculo(int id, string nombre, string modelo) : base(id, nombre, modelo)
        { }

        public override decimal PrecioCarro(decimal precio)
        {
            return (precio);
        }

        public override decimal PrecioEconomico()
        {
            return 30000;
        }
    }
}