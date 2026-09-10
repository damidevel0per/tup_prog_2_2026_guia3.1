using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muebles.Models
{
    internal class Silla : Producto
    {
        public Silla(string desc, double pb, int tipoM) : base(desc, pb, tipoM)
        {

        }

        public override double CalcularPrecio()
        {
            return (precioBase * (1 + tipoMaterial * 0.25));
        }

        public override string VerDetalle()
        {
            if (tipoMaterial == 0)
            {
                return $"Silla | {Descripcion} | PBase: ${precioBase} | Tipo Material: Pino | PRECIO: {CalcularPrecio().ToString("0.00")}";
            }
            else if (tipoMaterial == 1)
            {
                return $"Silla | {Descripcion} | PBase: ${precioBase} | Tipo Material: Algarrobo | PRECIO: {CalcularPrecio().ToString("0.00")}";
            }
            else { return $"Silla | {Descripcion} | PBase: ${precioBase} | Tipo Material: Caoba | PRECIO: {CalcularPrecio().ToString("0.00")}"; }
        }
       
    }
}
