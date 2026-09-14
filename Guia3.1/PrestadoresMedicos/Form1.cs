using PrestadoresMedicos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestadoresMedicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prestador medico1 = new Prestador("Cormillot");

            Prestador medico2 = new Prestador("Fleming");

            Prestacion consulta = new ObraSocial("Damian", medico1);

            Prestacion consulta2 = new SinObra("Hernan", medico2, "214325816617");

            medico1.AgregarConsulta(consulta);
            medico1.AgregarConsulta(consulta);
            medico1.AgregarConsulta(consulta);

            medico2.AgregarConsulta(consulta2);
            medico2.AgregarConsulta(consulta2);
            medico2.AgregarConsulta(consulta2);

            listBox1.Items.Add($"Consulta de {consulta.ApellidosNombres}, Monto: ${consulta.PrestarServicio().ToString("0.00")}");
            listBox1.Items.Add($"Consulta de {consulta.ApellidosNombres}, Monto: ${consulta.PrestarServicio().ToString("0.00")}");
            listBox1.Items.Add($"Consulta de {consulta.ApellidosNombres}, Monto: ${consulta.PrestarServicio().ToString("0.00")}");
            listBox1.Items.Add($"");

            listBox1.Items.Add($"Medico; {medico1.ApellidosNombres}, Monto a cobrar: ${medico1.GenerarPago().ToString("0.00")}");
            listBox1.Items.Add($"----------------------------------------------------------------------------------------------");
            listBox1.Items.Add($"");
            listBox1.Items.Add($"Consulta de {consulta2.ApellidosNombres}, Monto: ${consulta2.PrestarServicio().ToString("0.00")}");
            listBox1.Items.Add($"Consulta de {consulta2.ApellidosNombres}, Monto: ${consulta2.PrestarServicio().ToString("0.00")}");
            listBox1.Items.Add($"Consulta de {consulta2.ApellidosNombres}, Monto: ${consulta2.PrestarServicio().ToString("0.00")}");
            listBox1.Items.Add($"");
            listBox1.Items.Add($"Medico; {medico2.ApellidosNombres}, Monto a cobrar: ${medico2.GenerarPago().ToString("0.00")}");


        }
    }
}
