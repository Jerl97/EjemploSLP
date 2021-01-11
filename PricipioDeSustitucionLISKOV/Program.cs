using System;
using System.Collections.Generic;
using PrincipioDeSustitucionLISKOV.Implementacion;

namespace PrincipioDeSustitucionLISKOV
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();
            carros.Add(new Vehiculo(1, "Chevrolet", "Camaro"));

            foreach (var carro in carros)
            {
                Console.WriteLine(string.Format("Carro {0} Precio Carro: {1} Precio Economico: {2}",
                carro.ToString(),
                carro.PrecioCarro(50000).ToString(),
                carro.PrecioEconomico().ToString()));
            }

            Console.WriteLine();
            List<ICarro> Carros = new List<ICarro>();

            Carros.Add(new Vehiculo(1, "Chevrolet","Camaro"));
        }
    }
}
