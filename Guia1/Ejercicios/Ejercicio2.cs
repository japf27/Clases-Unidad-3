using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, pass;
            usuario = textBox1.Text.TrimEnd();
            pass = textBox2.Text.TrimEnd();
            if ((usuario == "UTEC") && (pass == "programacion1"))
            {
                MessageBox.Show("Bienvenidos al sistema");
            }
            else
            {
                MessageBox.Show("Verifique usuario y pass");
            }
        
        }
    }
}
