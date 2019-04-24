using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text ==  "usuario") 
            {


                textBox1.Text = "UTEC"; 
            
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text == "Contraseña")
            {

                textBox2.Text = "12345";


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           




        }
    }
}
