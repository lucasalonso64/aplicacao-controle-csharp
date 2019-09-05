using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteFormsApplication1
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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double qtdli;
            double vlrli;
            double vlrto;
            double kmatu;
            double kmrod;
            double conme;


            kmrod = double.Parse(km.Text);
            conme = double.Parse(textBox2.Text);
            vlrli = double.Parse(textBox3.Text);

            qtdli = kmrod / conme;
            vlrto = qtdli * vlrli;


            label1.Text= "Quantidade de litros: " + qtdli;
            label2.Text= string.Format ("Valor a ser gasto........: {0:C}", vlrto);
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
