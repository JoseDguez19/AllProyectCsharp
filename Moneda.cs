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
    public partial class Moneda : Form
    {
        Form1 form1 = new Form1();
        public Moneda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double tipoCambio = Convert.ToDouble(textBox1.Text);
                double euros = Convert.ToDouble(textBox2.Text);
                double dolares = euros * tipoCambio;

                MessageBox.Show($"La cantidad equivalente en dólares es: {dolares:N2}", "Resultado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un valor válido.", "Error de formato",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double tipoCambio = Convert.ToDouble(textBox1.Text);
                double dolares = Convert.ToDouble(textBox2.Text);
                double euros = dolares / tipoCambio;

                MessageBox.Show($"La cantidad equivalente en euros es: {euros:N2}", "Resultado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un valor válido.", "Error de formato",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
