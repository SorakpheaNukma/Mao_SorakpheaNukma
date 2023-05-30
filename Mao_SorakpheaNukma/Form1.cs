using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mao_SorakpheaNukma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox3.Text);
            double c = double.Parse(textBox2.Text);

            double dis = b * b - 4 * a * c;

            if (dis > 0)
            {
                double root1 = (-b + Math.Sqrt(dis)) / (2 * a);
                double root2 = (-b - Math.Sqrt(dis)) / (2 * a);

                txtBoxKq.Text = "Nghiem 1: " + root1.ToString() + Environment.NewLine;
                txtBoxKq.Text += "Nghiem 2: " + root2.ToString();
            }
            else if (dis == 0)
            {
                double root = -b / (2 * a);

                txtBoxKq.Text = "Nghiem: " + root.ToString();
            }
            else
            {
                txtBoxKq.Text = "Phuong Trinh Khong Co Nghiem.";
            }
        }
    }
}
