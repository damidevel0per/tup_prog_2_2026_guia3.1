using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestadoresMedicos.Models
{
    internal class ObraSocial : Prestacion
    {
        public double Arancel { get { return 200; } set { } }

        private static int consultas;
        public int ConsultasMensuales { get { return consultas; } }

        public ObraSocial(string nomb, Prestador medic) : base (nomb, medic)
        {

        }

        public override double PrestarServicio()
        {
            consultas++;

            if (ConsultasMensuales <= 2)
            {
                return 0;

            }
            else
            {
                return Arancel;
            }

        }

    }
}
