using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Models
{
    abstract class Evaluador
    {
        protected int añoACalcular;
        public int AñoACalcular
        {
            get { return añoACalcular; }
        }

        public Moto Vehiculo
        {
            get; set;
        }

        public Evaluador(Moto vehiculo, int añoCalcular)
        {
            añoACalcular = añoCalcular;
            Vehiculo = vehiculo;
        }

        public abstract double CalcularDepreciacion();

        public virtual string VerDescripcion()
        {
            return $"{Vehiculo.VerDescripcion()} - Año a Calcular: {AñoACalcular}";
        }
    }
}
