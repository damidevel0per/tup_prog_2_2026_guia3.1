using Muebles.Models;
using Presupuesto_de_Muebles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presupuesto_de_Muebles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Presupuesto p;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormDatosCliente fdc = new FormDatosCliente();

            fdc.ShowDialog();

            if (fdc.DialogResult == DialogResult.OK)
            {
                string nombre = fdc.tbNom.Text;
                string direccion = fdc.tbDirec.Text;

                p = new Presupuesto(nombre, direccion);

                lblNomb.Text = nombre;
                lblDirec.Text = direccion;
            }


        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            DatosProduct dp = new DatosProduct();

            dp.ShowDialog();

            Silla s;
            Mesa m;

            if(dp.DialogResult == DialogResult.OK)
            {
                if (dp.cbProd.SelectedIndex == 0)
                {
                    double largo = Convert.ToDouble(dp.tbLargo.Text);
                    double precio = Convert.ToDouble(dp.tbPrecio.Text);
                    string desc = dp.tbDesc.Text;
                    int material = dp.cbMaterial.SelectedIndex;

                    m = new Mesa(desc, precio, material, largo);
                    p.AgregarProducto(m);

                }
                if (dp.cbProd.SelectedIndex == 1)
                {
                    double precio = Convert.ToDouble(dp.tbPrecio.Text);
                    string desc = dp.tbDesc.Text;
                    int material = dp.cbMaterial.SelectedIndex;

                    s = new Silla(desc, precio, material);
                    p.AgregarProducto(s);

                }
            }
        }

        private void btnVerPresup_Click(object sender, EventArgs e)
        {
            VerPresup vp = new VerPresup();

            vp.tbPresup.Text = $"Cliente: {p.Cliente}";
            vp.tbPresup.Text += $"\r\n";
            vp.tbPresup.Text += $"Direccion: {p.Direccion}";
            vp.tbPresup.Text += $"\r\n\r\n";
            vp.tbPresup.Text += $"Items presupuestados:";
            vp.tbPresup.Text += $"\r\n";

            for (int i = 0; i < p.CantidadProductos; i++)
            {
                vp.tbPresup.Text += p.VerProducto(i).VerDetalle();
                vp.tbPresup.Text += $"\r\n";
            }

            vp.tbPresup.Text += $"\r\n\r\n";
            vp.tbPresup.Text += $"Total: {p.CostoTotal.ToString("0.00")}";

            vp.ShowDialog();
        }
    }
}
