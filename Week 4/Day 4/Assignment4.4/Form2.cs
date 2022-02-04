using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            grpActDetails.BackColor = Color.FromArgb(200, grpActDetails.BackColor);
        }

        private void btnCreateAct_Click(object sender, EventArgs e)
        {
            BankAccount account = new BankAccount();
            account.LowBalance += Account_LowBalance;
            account.ActNum = Int32.Parse(txtActNum.Text);
            account.Balance = Double.Parse(txtBalance.Text);
            account.FName = txtFName.Text;
            account.LName = txtLName.Text;
            if(account.Balance > 200)
            MessageBox.Show($"Account successfully created for {txtFName.Text} with a balance of ${txtBalance.Text} ");
        }

        private void Account_LowBalance()
        {
            MessageBox.Show("Balance below limit of $200");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}