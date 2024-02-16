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
    public partial class Radianes : Form
    {
        Form1 form1 = new Form1();
        public Radianes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double grados = Convert.ToDouble(textBox1.Text);
            double radianes = grados * (Math.PI / 180);
            MessageBox.Show($"{grados} grados equivalen a {radianes} radianes.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radianes = Convert.ToDouble(textBox1.Text);
            double grados = radianes * (180 / Math.PI);
            MessageBox.Show($"{radianes} radianes equivalen a {grados} grados.");
        }
    }
}
