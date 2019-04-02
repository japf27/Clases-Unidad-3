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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        multiplicacion obj3;
        resta obj2;
        division obj4;
        suma obj1;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                obj1 = new suma();
                obj1.S1 = double.Parse(textBox1.Text);
                obj1.S2 = double.Parse(textBox2.Text);
                textBox3.Text = obj1.calcular().ToString();

            }
            else if (this.checkBox2.Checked == true)
            {
                obj2 = new resta();
                obj2.R1 = double.Parse(textBox1.Text);
                obj2.R2 = double.Parse(textBox2.Text);
                textBox3.Text = obj2.calcular().ToString();

            }

            else if (this.checkBox3.Checked == true)
            {
                obj3 = new multiplicacion();
                obj3.M1 = double.Parse(textBox1.Text);
                obj3.M2 = double.Parse(textBox2.Text);
                textBox3.Text = obj3.calcular().ToString();

            }
            else if (this.checkBox4.Checked == true)
            {
                obj4 = new division();
                obj4.D1 = double.Parse(textBox1.Text);
                obj4.D2 = double.Parse(textBox2.Text);
                textBox3.Text = obj4.calcular().ToString();

            }
        }
    

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
