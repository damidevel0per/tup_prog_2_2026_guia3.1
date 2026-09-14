using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestadoresMedicos.Models
{
    internal class SinObra : Prestacion
    {
        public string CUIT {  get; set; }
        public double ImporteFijo
        {
            get { return 250; }
            set { }
        }

        public SinObra(string nombre, Prestador medico, string cuit) : base(nombre, medico)
        {
            CUIT = cuit;
        }

        public override double PrestarServicio()
        {
            return ImporteFijo;
        }
    }
}
