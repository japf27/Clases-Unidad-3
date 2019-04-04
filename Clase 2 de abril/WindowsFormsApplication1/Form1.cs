using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 4;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                progressBar1.PerformStep();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            timer3.Interval = 2000;
            for (int i = 0; i <= 24; i++)
            {
                progressBar1.PerformStep();
            }

            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

     

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
