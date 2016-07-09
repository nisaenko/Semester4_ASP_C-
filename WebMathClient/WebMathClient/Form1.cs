using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebMathClient
{
    public partial class Form1 : Form
    {
       ServiceReference1.ServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference1.ServiceClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           int num1= Convert.ToInt32(textBox1.Text);
           int num2 = Convert.ToInt32(textBox2.Text);
           lblResult.Text = client.Add(num1,num2);


        }

        private void btnSub_Click(object sender, EventArgs e)
        {
           int num1= Convert.ToInt32(textBox1.Text);
           int num2 = Convert.ToInt32(textBox2.Text);
           lblResult.Text = client.Sub(num1, num2);

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
           int num1= Convert.ToInt32(textBox1.Text);
           int num2 = Convert.ToInt32(textBox2.Text);
           lblResult.Text = client.Mult(num1, num2);



        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1= Convert.ToInt32(textBox1.Text);
           int num2 = Convert.ToInt32(textBox2.Text);
           lblResult.Text = client.Div(num1, num2);

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            lblResult.Text = client.Mod(num1, num2);


        }
    }
}
