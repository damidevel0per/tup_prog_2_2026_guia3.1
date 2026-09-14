using Muebles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuesto_de_Muebles.Models
{
    internal class Presupuesto
    {
        private List<Producto> presupuestados = new List<Producto>();

        public int CantidadProductos { get { return presupuestados.Count; } }
        public double CostoTotal
        {
            get
            {
                double total = 0;
                for (int i = 0; i < CantidadProductos; i++)
                {
                    total += presupuestados[i].CalcularPrecio();
                }
                return total;
            }
        }

        public string Cliente { get; set; }
        public string Direccion { get; set; }

        public Presupuesto(string client, string direc)
        {
            Cliente = client;
            Direccion = direc;
        }

        public void AgregarProducto(Producto p)
        {
            presupuestados.Add(p);
        }

        public Producto VerProducto(int idx)
        {
            return presupuestados[idx];
        }

        public string [] Resumen()
        {
            string[] res = new string[presupuestados.Count + 2];

            res[0] = $"Cliente {Cliente} Direccion: {Direccion}";

            for(int i = 1; i < presupuestados.Count; i++)
            {
                res[i] = presupuestados[i].VerDetalle();
            }
            res[presupuestados.Count + 1] = CostoTotal.ToString("0.00");

            return res;
        }

    }
}
