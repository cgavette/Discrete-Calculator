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
    public partial class CalculatorChoice : Form
    {
        public CalculatorChoice()
        {
            InitializeComponent();
        }

        private void EuclideanButton_Click(object sender, EventArgs e)
        {
            EuclideanAlgorithmForm E1= new EuclideanAlgorithmForm();
            E1.ShowDialog();
        }

        private void BinaryButton_Click(object sender, EventArgs e)
        {
            BaseForm B1 = new BaseForm();
            B1.ShowDialog();
        }
    }
}
