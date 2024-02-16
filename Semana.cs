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
    public partial class Semana : Form
    {
        Form1 form1 = new Form1();

        public Semana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(textBox1.Text, out numero))
            {
                string dia = ObtenerDiaSemana(numero);
                if (dia != null)
                {
                    MessageBox.Show($"El día correspondiente al número {numero} es: {dia}", "Día de la semana");
                }
                else
                {
                    MessageBox.Show("Número de día inválido. Debe estar entre 1 y 7.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido del 1 al 7.", "Error");
            }
        }

        static string ObtenerDiaSemana(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    return null;
            }
        }
    }
}
