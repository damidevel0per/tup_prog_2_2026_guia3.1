using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Models
{
    internal class EvaluadorLineal : Evaluador
    {
        public int VidaUtil {  get; set; }

        public EvaluadorLineal(Moto vehiculo, int añoACalc, int vidaU) : base(vehiculo, añoACalc)
        {
            VidaUtil = vidaU;
        }

        public override double CalcularDepreciacion()
        {
            int añosUso = añoACalcular - Vehiculo.Modelo;
            return Vehiculo.ValorFabricacion - (Vehiculo.ValorFabricacion * ((double)añosUso / VidaUtil));
        }

        public override string VerDescripcion()
        {
            return $"{base.VerDescripcion()} - Depreciacion Lineal: Monto : ${CalcularDepreciacion().ToString("0.00")}";
        }
    }
}
