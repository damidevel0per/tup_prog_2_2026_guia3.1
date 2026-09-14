using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestadoresMedicos.Models
{
    abstract class Prestacion : Persona
    {

        public Prestador Medico { get; set; }

        public double MontoTotal
        {
            get;
        }

        public Prestacion(string nombApe, Prestador med) : base(nombApe)
        {
            Medico = med;
        }
        public abstract double PrestarServicio();
    }
}
