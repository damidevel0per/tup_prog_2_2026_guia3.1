using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muebles.Models
{
    internal class Mesa : Producto
    {
        private double largo;

        public Mesa(string desc, double pb, int tipoM, double larg) : base(desc, pb, tipoM)
        {
            this.largo = larg;
        }

        public override double CalcularPrecio()
        {
            return (precioBase * largo) * (1 + tipoMaterial * 0.33);
        }

        public override string VerDetalle()
        {
            if (tipoMaterial == 0)
            {
                return $"Mesa | {Descripcion} | PBase: ${precioBase.ToString("0.00")} | Largo: {largo} | Tipo Material: Pino | PRECIO: {CalcularPrecio().ToString("0.00")}";
            }
            else if (tipoMaterial == 1)
            {
                return $"Mesa | {Descripcion} | PBase: ${precioBase.ToString("0.00")} | Largo: {largo} | Tipo Material: Algarrobo | PRECIO: {CalcularPrecio().ToString("0.00")}";
            }
            else { return $"Mesa | {Descripcion} | PBase: ${precioBase.ToString("0.00")} | Largo: {largo} | Tipo Material: Caoba | PRECIO: {CalcularPrecio().ToString("0.00")}"; }
        }
    }
}
