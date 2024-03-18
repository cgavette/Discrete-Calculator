using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuclideanAlgorithmForm
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            string result = "";
            int temp = 1, remainder;
            int a = Convert.ToInt32(numTextBox.Text);
            int b = Convert.ToInt32(baseTextBox.Text);

            while (temp > 0)
            {
                result += a % b;
                remainder = a % b;

                workTextbox.Text += $"{a} = {b}( ) + {remainder}\n";

                if (remainder > 0)
                {
                    temp = (a - remainder) / b;
                }
                else if (remainder == 0)
                {
                    temp = a / b;
                }
                else
                {
                    Console.WriteLine("oops...");
                    throw (new IOException());

                }

                if (temp == 0)
                {
                    workTextbox.Text += Reverse(result);
                }
                else
                {
                    a = temp;
                }

            }
        }
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            numTextBox.Clear();
            baseTextBox.Clear();
            workTextbox.Clear();
        }
        private void KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ConvertButton_Click(sender, e);
            }
        }
    }
}
