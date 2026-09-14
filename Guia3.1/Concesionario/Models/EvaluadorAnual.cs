using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Models
{
    internal class EvaluadorAnual : Evaluador
    {
        public double TasaDepreciacion {  get; set; }

        public EvaluadorAnual(Moto vehic, int añoCal, double tasaDepr) : base(vehic, añoCal)
        {
            TasaDepreciacion = tasaDepr;
        }

        public override double CalcularDepreciacion()
        {
            return Vehiculo.ValorFabricacion * Math.Pow((1 - TasaDepreciacion), (añoACalcular - Vehiculo.Modelo));
        }

        public override string VerDescripcion()
        {
            return $"{base.VerDescripcion()} - Depreciacion Anual: Monto : ${CalcularDepreciacion().ToString("0.00")}";
        }
    }
}
