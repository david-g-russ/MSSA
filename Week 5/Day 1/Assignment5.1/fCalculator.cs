using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._1
{
    public partial class fCalculator : Form
    {
        public fCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            decimal num1, num2;
            if (Decimal.TryParse(txtNum1.Text, out num1) == true && Decimal.TryParse(txtNum2.Text, out num2) == true && cmbOperator.Text != String.Empty)
            {
                txtResult.Visible = true;
                switch (cmbOperator.SelectedIndex)
                {
                    case 0:
                        txtResult.Text = calc.Add(num1, num2).ToString();
                        break;
                    case 1:
                        txtResult.Text = calc.Subtract(num1, num2).ToString();
                        break;
                    case 2:
                        txtResult.Text = calc.Multiply(num1, num2).ToString();
                        break;
                    case 3:
                        txtResult.Text = calc.Divide(num1, num2).ToString();
                        break;
                }

            }
            else if (Decimal.TryParse(txtNum1.Text, out num1) != true || Decimal.TryParse(txtNum2.Text, out num2) != true)
                MessageBox.Show("Please ensure that you are entering a decimal number into the text boxes.");
            else if (cmbOperator.Text == String.Empty)
                MessageBox.Show("Please ensure you select an operator.");
            else
                MessageBox.Show("Try again, you have failed.");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();

            fMenu f1 = new fMenu();
            f1.Show();
        }

        private void fCalculator_Load(object sender, EventArgs e)
        {
            txtResult.Visible = false;
            txtResult.ReadOnly = true;

            cmbOperator.DataSource = Enum.GetValues(typeof(Operator));
        }
    }
}
