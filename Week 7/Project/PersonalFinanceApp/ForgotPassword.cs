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
    public partial class ForgotPassword : MetroSetForm
    {
        FinanceDB repo;
        Regex complexity = new Regex(@"(?=.*\d)(?=.*[a - z])(?=.*[A - Z])(?=.*[@#$%!%^&*()]).{8,20}");
        int count;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            repo = new FinanceDB();
            
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void txtSecQ_Validating(object sender, CancelEventArgs e)
        {
            if (txtSecQ.Text.Length == 0)
                errorProvider1.SetError(txtSecQ, "You need to provide an answer to the security question.");
        }

        private void txtSecQ_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSecQ, "");
        }

        private void txtNewPassword1_Validating(object sender, CancelEventArgs e)
        {
            if(!complexity.IsMatch(txtNewPassword1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword1, "Your password must be between 8-20 characters and include 1 lowercase, 1 uppercase, and 1 number.");
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
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword2, "Your passwords must match.");
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
                errorProvider1.GetError(txtSecQ) == "" && count < 5)
            {
                var user = repo.FindUser(txtUsername.Text);
                if (txtSecQ.Text == user.securityAnswer)
                {
                    user.password = txtNewPassword1.Text;
                    repo.UpdateUser(user.userID, user);
                    MessageBox.Show("Successfully changed password.");
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(txtSecQ, "Incorrect answer.");
                    count++;
                }
            }
            else if (count >= 5)
            {
                MessageBox.Show("Too many failed attempts. Your account has been disabled for 1 hour.");
                Application.Exit();
            }
            else
                MessageBox.Show("Resolve all errors in order to change your password.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (repo.FindUser(txtUsername.Text) == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username not found.");
                txtUsername.Select(0, txtUsername.Text.Length);
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            var user = repo.FindUser(txtUsername.Text);
            lblSecQ.Text = user.securityQuestion;
            errorProvider1.SetError(txtUsername, "");
        }
    }
}
