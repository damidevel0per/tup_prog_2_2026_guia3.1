using Muebles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muebles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Mesa("Mesa comedor", 10.1, 1, 1);   
            Producto p2 = new Silla("Silla escritorio", 12.2, 2);

            textBox1.Text = p.VerDetalle();
            textBox1.Text += "\r\n";
            textBox1.Text += p2.VerDetalle();
        }
    }
}
