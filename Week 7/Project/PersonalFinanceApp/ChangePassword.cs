using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceDll;
using MetroSet_UI.Forms;
using System.Text.RegularExpressions;

namespace PersonalFinanceApp
{
    public partial class ChangePassword : MetroSetForm
    {
        FinanceDB repo;
        int userID;
        Regex complexity = new Regex(@"(?=.*\d)(?=.*[a - z])(?=.*[A - Z])(?=.*[@#$%!%^&*()]).{8,20}");
        int count;
        
        public ChangePassword(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            repo = new FinanceDB();

            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void txtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtOldPassword.Text.Length == 0)
                errorProvider1.SetError(txtOldPassword, "You need to enter your old password.");
        }

        private void txtOldPassword_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtOldPassword, "");
        }

        private void txtNewPassword1_Validating(object sender, CancelEventArgs e)
        {
            if (!complexity.IsMatch(txtNewPassword1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword1, "Your password must be between 8-20 characters and include 1 lowercase, 1 uppercase, and 1 number.");
                txtNewPassword1.Select(0,txtNewPassword1.Text.Length);
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
                txtNewPassword2.Select(0,txtNewPassword2.Text.Length);
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
                errorProvider1.GetError(txtOldPassword) == "" && count < 5)
            {
                var user = repo.FindUser(userID);
                if (txtOldPassword.Text == user.password)
                {
                    user.password = txtNewPassword1.Text;
                    repo.UpdateUser(userID, user);
                    MessageBox.Show("Successfully changed password.");
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(txtOldPassword, "Incorrect password.");
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
    }
}
