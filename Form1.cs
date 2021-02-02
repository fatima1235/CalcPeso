using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMCApp
{
    public partial class Form1 : Form
    {
        static OperacionIMC op = new OperacionIMC();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void cmdIMC_Click(object sender, EventArgs e)
        {
            lbltotimc.Text = (op.Div(double.Parse(txtval1.Text), double.Parse(txtval2.Text))).ToString();
        }

        private void cmdrespes_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbltotimc.Text) < 18)
            {
                MessageBox.Show("Usted tiene delgadez o bajo peso.");
            }
            else if (double.Parse(lbltotimc.Text) <= 24)
            {
                MessageBox.Show("Usted tiene peso normal y saludable.");
            }
            else if (double.Parse(lbltotimc.Text) <= 29.9)
            {
                MessageBox.Show("Usted tiene sobrepeso.");
            }
            else 
            {
                MessageBox.Show("Usted tiene obesidad, cuidese.");
            }

        }

        private void lbltotimc_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("ADVERTENCIA: Esta aplicación no aplica a mujeres con estado de embarazo y debe ser ajustada si la persona tiene algún grado de edema (Retencion de líquidos).");
        }

    }
}
