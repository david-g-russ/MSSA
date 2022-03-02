using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MetroSet_UI.Forms;
using FinanceDll;

namespace PersonalFinanceApp
{
    public partial class SignUp : MetroSetForm
    {
        FinanceDB repo;
        Regex complexity = new Regex(@"(?=.*\d)(?=.*[a - z])(?=.*[A - Z])(?=.*[@#$%!%^&*()]).{8,20}");
        string errorMsg;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            repo = new FinanceDB();

            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void txtSecQ_Validating(object sender, CancelEventArgs e)
        {
            if (txtSecQ.Text.Length == 0)
                errorMsg = "You need to enter a security question.";
            else if (txtSecQ.Text.Length > 100)
                errorMsg = "Your security question must be less than 100 characters.";
            else
                return;
            e.Cancel = true;
            errorProvider1.SetError(txtSecQ, errorMsg);
            txtSecQ.Select(0,txtSecQ.Text.Length);
        }

        private void txtSecQ_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSecQ, "");
        }

        private void txtNewPassword1_Validating(object sender, CancelEventArgs e)
        {
            if (!complexity.IsMatch(txtNewPassword1.Text))
            {
                errorMsg = "Your password must be between 8-20 characters and include 1 lowercase, 1 uppercase, and 1 number.";
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword1, errorMsg);
                txtNewPassword1.Select(0, txtNewPassword1.Text.Length);
            }
        }

        private void txtNewPassword1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNewPassword1, "");
        }

        private void txtNewPassword2_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword1.Text != txtNewPassword2.Text)
            {
                errorMsg = "Your passwords must match.";
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword2, errorMsg);
                txtNewPassword2.Select(0, txtNewPassword2.Text.Length);
            }
        }

        private void txtNewPassword2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNewPassword2, "");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (errorProvider1.GetError(txtNewPassword1) == "" && errorProvider1.GetError(txtNewPassword2) == "" &&
                errorProvider1.GetError(txtSecQ) == "" && errorProvider1.GetError(txtSecA) == "" &&
                errorProvider1.GetError(txtFirstName) == "" && errorProvider1.GetError(txtLastName) == "")
            {
                var newuser = new FinanceDll.User();
                newuser.username = txtUsername.Text;
                newuser.password = txtNewPassword1.Text;
                newuser.fName = txtFirstName.Text;
                newuser.lName = txtLastName.Text;
                newuser.securityQuestion = txtSecQ.Text;
                newuser.securityAnswer = txtSecA.Text;
                repo.AddUser(newuser);
                MessageBox.Show("Successfully signed up.");
                this.Close();
            }
            else
                MessageBox.Show("Resolve all errors in order to sign up.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        private void txtSecA_Validating(object sender, CancelEventArgs e)
        {
            if (txtSecA.Text.Length == 0)
                errorMsg = "You need to enter a security answer.";
            else if (txtSecA.Text.Length > 50)
                errorMsg = "Your security answer must be less than 50 characters.";
            else
                return;
            e.Cancel = true;
            errorProvider1.SetError(txtSecA, errorMsg);
            txtSecA.Select(0, txtSecA.Text.Length);
        }

        private void txtSecA_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSecA, "");
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text.Length == 0)
                errorMsg = "You need to enter a last name.";
            else if (txtLastName.Text.Length > 50)
                errorMsg = "Your last name must be less than 50 characters.";
            else
                return;
            e.Cancel = true;
            errorProvider1.SetError(txtLastName, errorMsg);
            txtLastName.Select(0, txtLastName.Text.Length);
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtLastName, "");
            if(txtUsername.Text.Length != 0)
                txtUsername.Text = (txtFirstName.Text + txtLastName.Text).ToLower();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text.Length == 0)
                errorMsg = "You need to enter a last name.";
            else if (txtFirstName.Text.Length > 50)
                errorMsg = "Your last name must be less than 50 characters.";
            else
                return;
            e.Cancel = true;
            errorProvider1.SetError(txtFirstName, errorMsg);
            txtFirstName.Select(0, txtFirstName.Text.Length);
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFirstName, "");
            if(txtUsername.Text.Length != 0)
                txtUsername.Text = (txtFirstName.Text + txtLastName.Text).ToLower();
            else
                txtUsername.Text = txtFirstName.Text.ToLower();
        }
    }
}