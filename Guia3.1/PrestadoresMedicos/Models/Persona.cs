using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestadoresMedicos.Models
{
    abstract class Persona
    {
        public string ApellidosNombres {  get; set; }

        public Persona(string apellidosNombres )
        {
            ApellidosNombres = apellidosNombres;
        }
    }
}
