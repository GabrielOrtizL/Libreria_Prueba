using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Prueba;

namespace Prueba_Operaciones_Libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double suma = Operaciones.suma(5, 2);
            MessageBox.Show(suma.ToString ());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double resta = Operaciones.resta(5, 2);
            MessageBox.Show(resta.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double multiplicacion = Operaciones.multiplicacion(5, 2);
            MessageBox.Show(multiplicacion.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double division = Operaciones.division(5, 2);
            MessageBox.Show(division.ToString());
        }
    }
}
