using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Create employee class and use type safe collections like stack, dictionary etc. to store employee records and to use basic methods like add, delete on these collections.

// Create an interface for ICalculator for methods like add, subtract, divide, multiply and implement them in a class.etc.

namespace Assignment5._1
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void btnEmployeeDB_Click(object sender, EventArgs e)
        {
            this.Hide();

            fEmployee f1 = new fEmployee();
            f1.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            this.Hide();

            fCalculator f1 = new fCalculator();
            f1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
