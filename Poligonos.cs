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
    public partial class Poligonos : Form
    {
        Form1 form1 = new Form1();
        
        public Poligonos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcularPerimetro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularArea();
        }

        private void CalcularPerimetro()
        {
            int numLados = Convert.ToInt32(textBox1.Text);
            double longitudLado = Convert.ToDouble(textBox2.Text);
            double perimetro = numLados * longitudLado;
            MessageBox.Show($"El perímetro del polígono regular es: {perimetro}");
        }

        private void CalcularArea()
        {
            int numLados = Convert.ToInt32(textBox1.Text);
            double longitudLado = Convert.ToDouble(textBox2.Text);
            double apotema = Convert.ToDouble(textBox3.Text);
            double perimetro = numLados * longitudLado;
            double area = (perimetro * apotema) / 2;
            MessageBox.Show($"El área del polígono regular es: {area}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}
