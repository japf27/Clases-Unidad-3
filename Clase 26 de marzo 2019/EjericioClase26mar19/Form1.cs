using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace EjericioClase26mar19
{
    public partial class Form1 : Form
    {

        Operacion ingreso;
        Operacion_resta ingresor;
        Operacion_division ingresod;
        Operacion_multiplicacion ingresom;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(textBox1.Text);
            ingreso.V2 = double.Parse(textBox2.Text);
            label3.Text = ingreso.Calcular().ToString();

 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingresom = new Operacion_multiplicacion();
            ingresom.M1 = double.Parse(textBox1.Text);
            ingresom.M2 = double.Parse(textBox2.Text);
            label3.Text = ingresom.Calcular().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingresor = new Operacion_resta();
            ingresor.R1 = double.Parse(textBox1.Text);
            ingresor.R2 = double.Parse(textBox2.Text);
            label3.Text = ingresor.Calcular().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ingresod = new Operacion_division();
            ingresod.D1 = double.Parse(textBox1.Text);
            ingresod.D2 = double.Parse(textBox2.Text);
            label3.Text = ingresod.Calcular().ToString();
        }
    }
}
