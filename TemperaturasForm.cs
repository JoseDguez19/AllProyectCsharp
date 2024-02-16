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
    public partial class TemperaturasForm : Form
    {
        public Form1 form1 = new Form1();
        public TemperaturasForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int opcion = Convert.ToInt32(textBoxOpcion.Text);
            double tempInicial = Convert.ToDouble(textBox1.Text);
            double tempConvertida = 0;

            tempConvertida = CelsiusAFahrenheit(tempInicial);
            MessageBox.Show($"La temperatura en Fahrenheit es: {tempConvertida} °F");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double tempInicial = Convert.ToDouble(textBox2.Text);
            double tempConvertida = 0;

            tempConvertida = FahrenheitACelsius(tempInicial);
            MessageBox.Show($"La temperatura en Celsius es: {tempConvertida} °C");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double tempInicial = Convert.ToDouble(textBox3.Text);
            double tempConvertida = 0;

            tempConvertida = CelsiusAKelvin(tempInicial);
            MessageBox.Show($"La temperatura en Kelvin es: {tempConvertida} °K");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double tempInicial = Convert.ToDouble(textBox4.Text);
            double tempConvertida = 0;

            tempConvertida = KelvinACelsius(tempInicial);
            MessageBox.Show($"La temperatura en Celsius es: {tempConvertida} °C");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double tempInicial = Convert.ToDouble(textBox5.Text);
            double tempConvertida = 0;

            tempConvertida = FahrenheitAKelvin(tempInicial);
            MessageBox.Show($"La temperatura en Kelvin es: {tempConvertida} °K");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double tempInicial = Convert.ToDouble(textBox6.Text);
            double tempConvertida = 0;

            tempConvertida = KelvinAFahrenheit(tempInicial);
            MessageBox.Show($"La temperatura en Fahrenheit es: {tempConvertida} °F");
        }

        static double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusAKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        static double KelvinACelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        static double FahrenheitAKelvin(double fahrenheit)
        {
            return CelsiusAKelvin(FahrenheitACelsius(fahrenheit));
        }

        static double KelvinAFahrenheit(double kelvin)
        {
            return CelsiusAFahrenheit(KelvinACelsius(kelvin));
        }
    }
}
