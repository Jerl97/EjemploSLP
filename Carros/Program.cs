using System;

namespace Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro empVehiculo = new Vehiculo(1, "Chevrolet", "Camaro");
            Console.WriteLine(string.Format("Carros {0} {1}",
               empVehiculo.ToString(),
               empVehiculo.PrecioCarro(50000).ToString()));
        }
    }
}
