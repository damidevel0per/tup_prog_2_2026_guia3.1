using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muebles.Models
{
    abstract class Producto
    {
        private string descripcion;
        protected double precioBase;
        protected int tipoMaterial;

        protected string Descripcion { get; }

        public Producto(string desc, double pb, int tipoM)
        {
            descripcion = desc;
            precioBase = pb;
            tipoMaterial = tipoM;
        }

        public abstract double CalcularPrecio();
        public abstract string VerDetalle();

    }
}
