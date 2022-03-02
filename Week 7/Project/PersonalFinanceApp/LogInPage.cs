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
using System.Threading;

namespace PersonalFinanceApp
{
    public partial class LogInPage : MetroSetForm
    {
        FinanceDB repo;
        public void Splash()
        {
            Application.Run(new LoadingSplash());
        }
        public LogInPage()
        {
            //Thread t = new Thread(new ThreadStart(Splash));
            //for (int i = 0; i <= 1000; i++)
            //{
            //    Thread.Sleep(10);
            //}
            InitializeComponent();
            //t.Abort();
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {
            repo = new FinanceDB();
            btnForgotPassword.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (errorProvider1.GetError(txtUsername) == "" && errorProvider1.GetError(txtPassword) == "")
            {
                if (repo.FindUser(txtUsername.Text) != null)
                {
                    var user = repo.FindUser(txtUsername.Text);
                    if (txtPassword.Text == user.password)
                    {
                        this.Hide();
                        Dashboard dashboard = new Dashboard(user.userID);
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("The password you've entered is incorrect.");
                        btnForgotPassword.Visible = true;
                    }
                }
                else
                    MessageBox.Show("The username you've entered doesn't exist.");
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
            repo = new FinanceDB();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            repo = new FinanceDB();
        }
    }
}