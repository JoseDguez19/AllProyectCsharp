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
    public partial class Form1 : Form
    {
        public TemperaturasForm temperaturasForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TemperaturasForm temperaturasForm = new TemperaturasForm();

            temperaturasForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Impuestos impuestos = new Impuestos();
            impuestos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poligonos poligonos = new Poligonos();
            poligonos.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Radianes radianes = new Radianes();
            radianes.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Semana semana = new Semana();
            semana.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Moneda moneda = new Moneda(); 
            moneda.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
            this.Hide();
        }
    }
}
