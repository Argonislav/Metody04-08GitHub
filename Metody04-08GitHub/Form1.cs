using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zaklad = Convert.ToInt32(textBox1.Text), exponent = Convert.ToInt32(textBox2.Text);
            label3.Text = "" + CelaCisla.Mocnina(zaklad, exponent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox3.Text);
            label2.Text = "" + CelaCisla.Faktorial(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox4.Text);
            label5.Text = "" + CelaCisla.SoucetLichCifer(x);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox5.Text);
            label7.Text = "" + CelaCisla.JePrvocislo(x);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox6.Text);
            label9.Text = "" + CelaCisla.PocetSudychDelitelu(x);
        }
    }
}
