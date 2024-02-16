using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AllProyectsFramework
{
    public partial class Impuestos : Form
    {
        public Form1 form1 = new Form1 ();
        public Impuestos()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int opcion = Convert.ToInt32(textBox1.Text);
            double precio = Convert.ToDouble(textBox2.Text);

            switch (opcion)
            {
                case 1:
                    CalcularImpuesto(precio, 0); //para medcina
                    break;
                case 2:
                    CalcularImpuesto(precio, 16); //16% de IVA
                    break;
                default:
                    MessageBox.Show("Opción no válida.");
                    break;
            }

            DialogResult result = MessageBox.Show("¿Deseas calcular el impuesto para otro producto?", "Continuar", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                this.Hide(); // Cierra el formulario si el usuario elige no continuar
            }
        }

        static void CalcularImpuesto(double precio, double porcentajeImpuesto)
        {
            double impuesto = (precio * porcentajeImpuesto) / 100;
            double precioTotal = precio + impuesto;

            MessageBox.Show($"Impuesto: {impuesto:C}\nPrecio Total: {precioTotal:C}", "Resultado");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
    
}   
