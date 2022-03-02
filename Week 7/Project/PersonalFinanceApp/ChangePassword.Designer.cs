namespace PersonalFinanceApp
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.lblOldPassword = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblNewPassword1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblNewPassword2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtOldPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtNewPassword1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtNewPassword2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnConfirm = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCancel = new MetroSet_UI.Controls.MetroSetButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblOldPassword.IsDerivedStyle = true;
            this.lblOldPassword.Location = new System.Drawing.Point(32, 50);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(168, 46);
            this.lblOldPassword.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblOldPassword.StyleManager = null;
            this.lblOldPassword.TabIndex = 1;
            this.lblOldPassword.Text = "Old Password:";
            this.lblOldPassword.ThemeAuthor = "Narwin";
            this.lblOldPassword.ThemeName = "MetroDark";
            // 
            // lblNewPassword1
            // 
            this.lblNewPassword1.AutoSize = true;
            this.lblNewPassword1.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblNewPassword1.IsDerivedStyle = true;
            this.lblNewPassword1.Location = new System.Drawing.Point(32, 106);
            this.lblNewPassword1.Name = "lblNewPassword1";
            this.lblNewPassword1.Size = new System.Drawing.Size(176, 46);
            this.lblNewPassword1.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblNewPassword1.StyleManager = null;
            this.lblNewPassword1.TabIndex = 2;
            this.lblNewPassword1.Text = "New Password:";
            this.lblNewPassword1.ThemeAuthor = "Narwin";
            this.lblNewPassword1.ThemeName = "MetroDark";
            // 
            // lblNewPassword2
            // 
            this.lblNewPassword2.AutoSize = true;
            this.lblNewPassword2.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblNewPassword2.IsDerivedStyle = true;
            this.lblNewPassword2.Location = new System.Drawing.Point(32, 169);
            this.lblNewPassword2.Name = "lblNewPassword2";
            this.lblNewPassword2.Size = new System.Drawing.Size(258, 46);
            this.lblNewPassword2.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblNewPassword2.StyleManager = null;
            this.lblNewPassword2.TabIndex = 3;
            this.lblNewPassword2.Text = "Repeat New Password:";
            this.lblNewPassword2.ThemeAuthor = "Narwin";
            this.lblNewPassword2.ThemeName = "MetroDark";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.AutoCompleteCustomSource = null;
            this.txtOldPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOldPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOldPassword.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtOldPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtOldPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtOldPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOldPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtOldPassword.Image = null;
            this.txtOldPassword.IsDerivedStyle = true;
            this.txtOldPassword.Lines = null;
            this.txtOldPassword.Location = new System.Drawing.Point(333, 66);
            this.txtOldPassword.MaxLength = 32767;
            this.txtOldPassword.Multiline = false;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.ReadOnly = false;
            this.txtOldPassword.Size = new System.Drawing.Size(439, 30);
            this.txtOldPassword.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtOldPassword.StyleManager = null;
            this.txtOldPassword.TabIndex = 4;
            this.txtOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOldPassword.ThemeAuthor = "";
            this.txtOldPassword.ThemeName = "";
            this.txtOldPassword.UseSystemPasswordChar = true;
            this.txtOldPassword.WatermarkText = "";
            this.txtOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtOldPassword_Validating);
            this.txtOldPassword.Validated += new System.EventHandler(this.txtOldPassword_Validated);
            // 
            // txtNewPassword1
            // 
            this.txtNewPassword1.AutoCompleteCustomSource = null;
            this.txtNewPassword1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNewPassword1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNewPassword1.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtNewPassword1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNewPassword1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNewPassword1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtNewPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNewPassword1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtNewPassword1.Image = null;
            this.txtNewPassword1.IsDerivedStyle = true;
            this.txtNewPassword1.Lines = null;
            this.txtNewPassword1.Location = new System.Drawing.Point(333, 122);
            this.txtNewPassword1.MaxLength = 32767;
            this.txtNewPassword1.Multiline = false;
            this.txtNewPassword1.Name = "txtNewPassword1";
            this.txtNewPassword1.ReadOnly = false;
            this.txtNewPassword1.Size = new System.Drawing.Size(439, 30);
            this.txtNewPassword1.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtNewPassword1.StyleManager = null;
            this.txtNewPassword1.TabIndex = 5;
            this.txtNewPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword1.ThemeAuthor = "";
            this.txtNewPassword1.ThemeName = "";
            this.txtNewPassword1.UseSystemPasswordChar = true;
            this.txtNewPassword1.WatermarkText = "";
            this.txtNewPassword1.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword1_Validating);
            this.txtNewPassword1.Validated += new System.EventHandler(this.txtNewPassword1_Validated);
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.AutoCompleteCustomSource = null;
            this.txtNewPassword2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNewPassword2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNewPassword2.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtNewPassword2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNewPassword2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNewPassword2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtNewPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNewPassword2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtNewPassword2.Image = null;
            this.txtNewPassword2.IsDerivedStyle = true;
            this.txtNewPassword2.Lines = null;
            this.txtNewPassword2.Location = new System.Drawing.Point(333, 185);
            this.txtNewPassword2.MaxLength = 32767;
            this.txtNewPassword2.Multiline = false;
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.ReadOnly = false;
            this.txtNewPassword2.Size = new System.Drawing.Size(439, 30);
            this.txtNewPassword2.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtNewPassword2.StyleManager = null;
            this.txtNewPassword2.TabIndex = 6;
            this.txtNewPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword2.ThemeAuthor = "";
            this.txtNewPassword2.ThemeName = "";
            this.txtNewPassword2.UseSystemPasswordChar = true;
            this.txtNewPassword2.WatermarkText = "";
            this.txtNewPassword2.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword2_Validating);
            this.txtNewPassword2.Validated += new System.EventHandler(this.txtNewPassword2_Validated);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnConfirm.Font = new System.Drawing.Font("Reem Kufi", 14F);
            this.btnConfirm.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnConfirm.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnConfirm.HoverTextColor = System.Drawing.Color.White;
            this.btnConfirm.IsDerivedStyle = true;
            this.btnConfirm.Location = new System.Drawing.Point(32, 300);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.NormalTextColor = System.Drawing.Color.White;
            this.btnConfirm.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirm.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirm.PressTextColor = System.Drawing.Color.White;
            this.btnConfirm.Size = new System.Drawing.Size(740, 36);
            this.btnConfirm.Style = MetroSet_UI.Enums.Style.Light;
            this.btnConfirm.StyleManager = null;
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.ThemeAuthor = "Narwin";
            this.btnConfirm.ThemeName = "MetroLite";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.btnCancel.HoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.HoverColor = System.Drawing.Color.Transparent;
            this.btnCancel.HoverTextColor = System.Drawing.Color.PaleGreen;
            this.btnCancel.IsDerivedStyle = true;
            this.btnCancel.Location = new System.Drawing.Point(680, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.NormalColor = System.Drawing.Color.Transparent;
            this.btnCancel.NormalTextColor = System.Drawing.Color.Black;
            this.btnCancel.PressBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.PressColor = System.Drawing.Color.Transparent;
            this.btnCancel.PressTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnCancel.StyleManager = null;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeAuthor = "";
            this.btnCancel.ThemeName = "";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageTransparency = 0.7F;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtNewPassword2);
            this.Controls.Add(this.txtNewPassword1);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblNewPassword2);
            this.Controls.Add(this.lblNewPassword1);
            this.Controls.Add(this.lblOldPassword);
            this.Name = "ChangePassword";
            this.ShowLeftRect = false;
            this.ShowTitle = false;
            this.ThemeAuthor = "";
            this.ThemeName = "";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel lblOldPassword;
        private MetroSet_UI.Controls.MetroSetLabel lblNewPassword1;
        private MetroSet_UI.Controls.MetroSetLabel lblNewPassword2;
        private MetroSet_UI.Controls.MetroSetTextBox txtOldPassword;
        private MetroSet_UI.Controls.MetroSetTextBox txtNewPassword1;
        private MetroSet_UI.Controls.MetroSetTextBox txtNewPassword2;
        private MetroSet_UI.Controls.MetroSetButton btnConfirm;
        private MetroSet_UI.Controls.MetroSetButton btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}