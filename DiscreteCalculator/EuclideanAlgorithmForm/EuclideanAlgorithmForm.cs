using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuclideanAlgorithmForm
{
    public partial class EuclideanAlgorithmForm : Form
    {
        public EuclideanAlgorithmForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            workTextbox.Clear();

            int result = 0;
            int c;

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            

            int temp;
            if (a > b)
            {

            }
            else if (a < b)
            {
                temp = b;
                b = a;
                a = temp;
            }
            else if (a == b)
            {
                result = a;
            }

            while (b > 0)
            {
                c = a % b;

                workTextbox.Text += $"{a} % {b} = {c}\n";

                Console.WriteLine($"{a} % {b} = {c}");

                if (c == 0)
                {
                    result = b; break;
                }
                else
                {
                    a = b;
                    b = c;
                    c = -1;
                }
            };

            workTextbox.Text += $"The GCD is {result}\n";
            workTextbox.Text += $"\n ({Convert.ToInt32(textBox1.Text)} * {Convert.ToInt32(textBox2.Text)}) / {result} " +
                $"= {(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)) / result}";
            workTextbox.Text += $"\nThe LCM is " +
                $"{(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)) / result}";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            workTextbox.Clear();
        }

        

        private void KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CalculateButton_Click(sender, e);
            }
        }
    }
}
