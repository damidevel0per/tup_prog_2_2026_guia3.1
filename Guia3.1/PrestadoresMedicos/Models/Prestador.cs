using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestadoresMedicos.Models
{
    internal class Prestador : Persona
    {
        private List<Prestacion> consultas = new List<Prestacion>();
        public Prestador(string nombAp ) : base(nombAp) 
        {

        }

        public void AgregarConsulta(Prestacion consulta)
        {
            consultas.Add(consulta);
        }

        public double GenerarPago()
        {
            double pago = 0;
            for(int i = 0; i < consultas.Count; i++)
            {
                pago+= consultas[i].PrestarServicio();
            }
            return pago;
        }


    }
}
