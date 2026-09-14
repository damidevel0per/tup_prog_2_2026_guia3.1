using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Models
{
    internal class Moto
    {
        public string Marca { get; }
        public int Modelo { get; }
        public double ValorFabricacion { get; }

        public Moto(string marca, int modelo, double valor)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valor;
        }

        public string VerDescripcion()
        {
           return $"Marca: {Marca} - Año: {Modelo} - Fabricacion: ${ValorFabricacion}";
        }
    }
}
