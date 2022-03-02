namespace PersonalFinanceApp
{
    partial class LogInPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            this.lblUsername = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblPassword = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtUsername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnLogin = new MetroSet_UI.Controls.MetroSetButton();
            this.lblHeading = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnForgotPassword = new MetroSet_UI.Controls.MetroSetButton();
            this.btnSignUp = new MetroSet_UI.Controls.MetroSetButton();
            this.lblSignUp = new MetroSet_UI.Controls.MetroSetLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblUsername.IsDerivedStyle = true;
            this.lblUsername.Location = new System.Drawing.Point(1067, 480);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(130, 46);
            this.lblUsername.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblUsername.StyleManager = null;
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.ThemeAuthor = "Narwin";
            this.lblUsername.ThemeName = "MetroDark";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblPassword.IsDerivedStyle = true;
            this.lblPassword.Location = new System.Drawing.Point(1067, 590);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 46);
            this.lblPassword.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblPassword.StyleManager = null;
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            this.lblPassword.ThemeAuthor = "";
            this.lblPassword.ThemeName = "";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteCustomSource = null;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtUsername.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsername.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUsername.Image = null;
            this.txtUsername.IsDerivedStyle = true;
            this.txtUsername.Lines = null;
            this.txtUsername.Location = new System.Drawing.Point(1067, 529);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(512, 30);
            this.txtUsername.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtUsername.StyleManager = null;
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.ThemeAuthor = "";
            this.txtUsername.ThemeName = "";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WatermarkText = "";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteCustomSource = null;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPassword.Image = null;
            this.txtPassword.IsDerivedStyle = true;
            this.txtPassword.Lines = null;
            this.txtPassword.Location = new System.Drawing.Point(1067, 639);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(512, 30);
            this.txtPassword.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtPassword.StyleManager = null;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.ThemeAuthor = "";
            this.txtPassword.ThemeName = "";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WatermarkText = "";
            // 
            // btnLogin
            // 
            this.btnLogin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogin.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Reem Kufi", 14F);
            this.btnLogin.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLogin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnLogin.HoverTextColor = System.Drawing.Color.White;
            this.btnLogin.IsDerivedStyle = true;
            this.btnLogin.Location = new System.Drawing.Point(1067, 753);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogin.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogin.NormalTextColor = System.Drawing.Color.White;
            this.btnLogin.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLogin.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnLogin.PressTextColor = System.Drawing.Color.White;
            this.btnLogin.Size = new System.Drawing.Size(512, 36);
            this.btnLogin.Style = MetroSet_UI.Enums.Style.Light;
            this.btnLogin.StyleManager = null;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.ThemeAuthor = "Narwin";
            this.btnLogin.ThemeName = "MetroLite";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Reem Kufi", 36F, System.Drawing.FontStyle.Bold);
            this.lblHeading.IsDerivedStyle = true;
            this.lblHeading.Location = new System.Drawing.Point(1211, 302);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(250, 137);
            this.lblHeading.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblHeading.StyleManager = null;
            this.lblHeading.TabIndex = 7;
            this.lblHeading.Text = "Login";
            this.lblHeading.ThemeAuthor = "";
            this.lblHeading.ThemeName = "";
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnForgotPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnForgotPassword.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnForgotPassword.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.btnForgotPassword.HoverBorderColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.HoverColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.HoverTextColor = System.Drawing.Color.Cyan;
            this.btnForgotPassword.IsDerivedStyle = true;
            this.btnForgotPassword.Location = new System.Drawing.Point(1404, 675);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.NormalBorderColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.NormalColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.NormalTextColor = System.Drawing.Color.White;
            this.btnForgotPassword.PressBorderColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.PressColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.PressTextColor = System.Drawing.Color.Black;
            this.btnForgotPassword.Size = new System.Drawing.Size(193, 36);
            this.btnForgotPassword.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnForgotPassword.StyleManager = null;
            this.btnForgotPassword.TabIndex = 8;
            this.btnForgotPassword.Text = "Forgot password?";
            this.btnForgotPassword.ThemeAuthor = "";
            this.btnForgotPassword.ThemeName = "";
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSignUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSignUp.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSignUp.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.btnSignUp.HoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.HoverColor = System.Drawing.Color.Transparent;
            this.btnSignUp.HoverTextColor = System.Drawing.Color.PaleGreen;
            this.btnSignUp.IsDerivedStyle = true;
            this.btnSignUp.Location = new System.Drawing.Point(1496, 795);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.NormalBorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.NormalColor = System.Drawing.Color.Transparent;
            this.btnSignUp.NormalTextColor = System.Drawing.Color.White;
            this.btnSignUp.PressBorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.PressColor = System.Drawing.Color.Transparent;
            this.btnSignUp.PressTextColor = System.Drawing.Color.Black;
            this.btnSignUp.Size = new System.Drawing.Size(92, 36);
            this.btnSignUp.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnSignUp.StyleManager = null;
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.ThemeAuthor = "";
            this.btnSignUp.ThemeName = "";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.lblSignUp.IsDerivedStyle = true;
            this.lblSignUp.Location = new System.Drawing.Point(1271, 792);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(219, 38);
            this.lblSignUp.Style = MetroSet_UI.Enums.Style.Light;
            this.lblSignUp.StyleManager = null;
            this.lblSignUp.TabIndex = 10;
            this.lblSignUp.Text = "Don\'t have an account?";
            this.lblSignUp.ThemeAuthor = "Narwin";
            this.lblSignUp.ThemeName = "MetroLite";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.errorProvider1.SetIconAlignment(this.metroSetControlBox1, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(2445, 14);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 11;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // LogInPage
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2560, 1440);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.HeaderHeight = 0;
            this.MaximumSize = new System.Drawing.Size(2560, 1440);
            this.Name = "LogInPage";
            this.ShowLeftRect = false;
            this.ShowTitle = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogInPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel lblUsername;
        private MetroSet_UI.Controls.MetroSetLabel lblPassword;
        private MetroSet_UI.Controls.MetroSetTextBox txtUsername;
        private MetroSet_UI.Controls.MetroSetTextBox txtPassword;
        private MetroSet_UI.Controls.MetroSetButton btnLogin;
        private MetroSet_UI.Controls.MetroSetLabel lblHeading;
        private MetroSet_UI.Controls.MetroSetButton btnForgotPassword;
        private MetroSet_UI.Controls.MetroSetButton btnSignUp;
        private MetroSet_UI.Controls.MetroSetLabel lblSignUp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}

