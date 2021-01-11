namespace PrincipioDeSustitucionLISKOV
{
    public abstract class Carro : ICarro, IPrecioEconomico
    {
        public int ID { get; set; }

        public string Marca{ get; set; }
        public string Modelo { get; set; }

        public Carro()
        { }

        public Carro(int id, string nombre, string modelo)
        {
            this.ID = id;
            this.Marca = nombre;
            this.Modelo = modelo;

        }

        public abstract decimal PrecioCarro(decimal precio);

        public override string ToString()
        {
            return string.Format("ID : {0} Marca : {1} Modelo : {2}", this.ID, this.Marca, this.Modelo);
        }

        public abstract decimal PrecioEconomico();

    }
}

