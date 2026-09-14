using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbLineal_CheckedChanged(object sender, EventArgs e)
        {
            tbTasDepre.Enabled = false;
        }

        private void rbAnual_CheckedChanged(object sender, EventArgs e)
        {
            tbTasDepre.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(numModelo.Value);
            string marca = tbMarca.Text;
            double valorF = Convert.ToDouble(tbValorFabric.Text);
            int añoCalc = Convert.ToInt32(numAñoCalc.Value);
            Moto m = new Moto(marca, año, valorF);

            FormResumen fr = new FormResumen();

            if (rbAnual.Checked == true)
            {
                double tasaDeprec = Convert.ToDouble(tbTasDepre.Text);
                Evaluador eval = new EvaluadorAnual(m, añoCalc, tasaDeprec);
                fr.listBox1.Items.Add(eval.VerDescripcion());
            }
            else if (rbLineal.Checked == true)
            {
                int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);
                Evaluador eval = new EvaluadorLineal(m, añoCalc, vidaUtil);
                fr.listBox1.Items.Add(eval.VerDescripcion());
            }

            fr.ShowDialog();
        }
    }
}

