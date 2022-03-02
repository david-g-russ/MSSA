namespace PersonalFinanceApp
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btnCancel = new MetroSet_UI.Controls.MetroSetButton();
            this.btnConfirm = new MetroSet_UI.Controls.MetroSetButton();
            this.txtNewPassword2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtNewPassword1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtSecQ = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblNewPassword2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblNewPassword1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblSecQ = new MetroSet_UI.Controls.MetroSetLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSecA = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblSecA = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtUsername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblLastName = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtLastName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblUsername = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblFirstName = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtFirstName = new MetroSet_UI.Controls.MetroSetTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.Font = new System.Drawing.Font("Reem Kufi", 10F);
            this.btnCancel.HoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.HoverColor = System.Drawing.Color.Transparent;
            this.btnCancel.HoverTextColor = System.Drawing.Color.PaleGreen;
            this.btnCancel.IsDerivedStyle = true;
            this.btnCancel.Location = new System.Drawing.Point(12, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.NormalColor = System.Drawing.Color.Transparent;
            this.btnCancel.NormalTextColor = System.Drawing.Color.Black;
            this.btnCancel.PressBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.PressColor = System.Drawing.Color.Transparent;
            this.btnCancel.PressTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(776, 36);
            this.btnCancel.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnCancel.StyleManager = null;
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = resources.GetString("btnCancel.Text");
            this.btnCancel.ThemeAuthor = "";
            this.btnCancel.ThemeName = "";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfirm.Font = new System.Drawing.Font("Reem Kufi", 14F);
            this.btnConfirm.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnConfirm.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnConfirm.HoverTextColor = System.Drawing.Color.White;
            this.btnConfirm.IsDerivedStyle = true;
            this.btnConfirm.Location = new System.Drawing.Point(12, 366);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.NormalTextColor = System.Drawing.Color.White;
            this.btnConfirm.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirm.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirm.PressTextColor = System.Drawing.Color.White;
            this.btnConfirm.Size = new System.Drawing.Size(776, 36);
            this.btnConfirm.Style = MetroSet_UI.Enums.Style.Light;
            this.btnConfirm.StyleManager = null;
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.ThemeAuthor = "Narwin";
            this.btnConfirm.ThemeName = "MetroLite";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.txtNewPassword2.Location = new System.Drawing.Point(274, 321);
            this.txtNewPassword2.MaxLength = 32767;
            this.txtNewPassword2.Multiline = false;
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.ReadOnly = false;
            this.txtNewPassword2.Size = new System.Drawing.Size(514, 30);
            this.txtNewPassword2.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtNewPassword2.StyleManager = null;
            this.txtNewPassword2.TabIndex = 26;
            this.txtNewPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword2.ThemeAuthor = "";
            this.txtNewPassword2.ThemeName = "";
            this.txtNewPassword2.UseSystemPasswordChar = true;
            this.txtNewPassword2.WatermarkText = "";
            this.txtNewPassword2.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword2_Validating);
            this.txtNewPassword2.Validated += new System.EventHandler(this.txtNewPassword2_Validated);
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
            this.txtNewPassword1.Location = new System.Drawing.Point(274, 275);
            this.txtNewPassword1.MaxLength = 32767;
            this.txtNewPassword1.Multiline = false;
            this.txtNewPassword1.Name = "txtNewPassword1";
            this.txtNewPassword1.ReadOnly = false;
            this.txtNewPassword1.Size = new System.Drawing.Size(514, 30);
            this.txtNewPassword1.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtNewPassword1.StyleManager = null;
            this.txtNewPassword1.TabIndex = 25;
            this.txtNewPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword1.ThemeAuthor = "";
            this.txtNewPassword1.ThemeName = "";
            this.txtNewPassword1.UseSystemPasswordChar = true;
            this.txtNewPassword1.WatermarkText = "";
            this.txtNewPassword1.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword1_Validating);
            this.txtNewPassword1.Validated += new System.EventHandler(this.txtNewPassword1_Validated);
            // 
            // txtSecQ
            // 
            this.txtSecQ.AutoCompleteCustomSource = null;
            this.txtSecQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSecQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSecQ.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtSecQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSecQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSecQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtSecQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSecQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSecQ.Image = null;
            this.txtSecQ.IsDerivedStyle = true;
            this.txtSecQ.Lines = null;
            this.txtSecQ.Location = new System.Drawing.Point(274, 183);
            this.txtSecQ.MaxLength = 32767;
            this.txtSecQ.Multiline = false;
            this.txtSecQ.Name = "txtSecQ";
            this.txtSecQ.ReadOnly = false;
            this.txtSecQ.Size = new System.Drawing.Size(514, 30);
            this.txtSecQ.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtSecQ.StyleManager = null;
            this.txtSecQ.TabIndex = 24;
            this.txtSecQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSecQ.ThemeAuthor = "";
            this.txtSecQ.ThemeName = "";
            this.txtSecQ.UseSystemPasswordChar = false;
            this.txtSecQ.WatermarkText = "";
            this.txtSecQ.Validating += new System.ComponentModel.CancelEventHandler(this.txtSecQ_Validating);
            this.txtSecQ.Validated += new System.EventHandler(this.txtSecQ_Validated);
            // 
            // lblNewPassword2
            // 
            this.lblNewPassword2.AutoSize = true;
            this.lblNewPassword2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNewPassword2.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblNewPassword2.IsDerivedStyle = true;
            this.lblNewPassword2.Location = new System.Drawing.Point(12, 305);
            this.lblNewPassword2.Name = "lblNewPassword2";
            this.lblNewPassword2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lblNewPassword2.Size = new System.Drawing.Size(206, 61);
            this.lblNewPassword2.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblNewPassword2.StyleManager = null;
            this.lblNewPassword2.TabIndex = 23;
            this.lblNewPassword2.Text = "Repeat Password:";
            this.lblNewPassword2.ThemeAuthor = "Narwin";
            this.lblNewPassword2.ThemeName = "MetroDark";
            // 
            // lblNewPassword1
            // 
            this.lblNewPassword1.AutoSize = true;
            this.lblNewPassword1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNewPassword1.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblNewPassword1.IsDerivedStyle = true;
            this.lblNewPassword1.Location = new System.Drawing.Point(12, 259);
            this.lblNewPassword1.Name = "lblNewPassword1";
            this.lblNewPassword1.Size = new System.Drawing.Size(124, 46);
            this.lblNewPassword1.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblNewPassword1.StyleManager = null;
            this.lblNewPassword1.TabIndex = 22;
            this.lblNewPassword1.Text = "Password:";
            this.lblNewPassword1.ThemeAuthor = "Narwin";
            this.lblNewPassword1.ThemeName = "MetroDark";
            // 
            // lblSecQ
            // 
            this.lblSecQ.AutoSize = true;
            this.lblSecQ.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSecQ.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblSecQ.IsDerivedStyle = true;
            this.lblSecQ.Location = new System.Drawing.Point(12, 167);
            this.lblSecQ.Name = "lblSecQ";
            this.lblSecQ.Size = new System.Drawing.Size(212, 46);
            this.lblSecQ.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblSecQ.StyleManager = null;
            this.lblSecQ.TabIndex = 21;
            this.lblSecQ.Text = "Security Question:";
            this.lblSecQ.ThemeAuthor = "Narwin";
            this.lblSecQ.ThemeName = "MetroDark";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtSecA
            // 
            this.txtSecA.AutoCompleteCustomSource = null;
            this.txtSecA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSecA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSecA.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtSecA.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSecA.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSecA.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtSecA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSecA.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSecA.Image = null;
            this.txtSecA.IsDerivedStyle = true;
            this.txtSecA.Lines = null;
            this.txtSecA.Location = new System.Drawing.Point(274, 229);
            this.txtSecA.MaxLength = 32767;
            this.txtSecA.Multiline = false;
            this.txtSecA.Name = "txtSecA";
            this.txtSecA.ReadOnly = false;
            this.txtSecA.Size = new System.Drawing.Size(514, 30);
            this.txtSecA.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtSecA.StyleManager = null;
            this.txtSecA.TabIndex = 30;
            this.txtSecA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSecA.ThemeAuthor = "";
            this.txtSecA.ThemeName = "";
            this.txtSecA.UseSystemPasswordChar = false;
            this.txtSecA.WatermarkText = "";
            this.txtSecA.Validating += new System.ComponentModel.CancelEventHandler(this.txtSecA_Validating);
            this.txtSecA.Validated += new System.EventHandler(this.txtSecA_Validated);
            // 
            // lblSecA
            // 
            this.lblSecA.AutoSize = true;
            this.lblSecA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSecA.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblSecA.IsDerivedStyle = true;
            this.lblSecA.Location = new System.Drawing.Point(12, 213);
            this.lblSecA.Name = "lblSecA";
            this.lblSecA.Size = new System.Drawing.Size(192, 46);
            this.lblSecA.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblSecA.StyleManager = null;
            this.lblSecA.TabIndex = 29;
            this.lblSecA.Text = "Security Answer:";
            this.lblSecA.ThemeAuthor = "Narwin";
            this.lblSecA.ThemeName = "MetroDark";
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
            this.txtUsername.Location = new System.Drawing.Point(274, 137);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(514, 30);
            this.txtUsername.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtUsername.StyleManager = null;
            this.txtUsername.TabIndex = 32;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.ThemeAuthor = "";
            this.txtUsername.ThemeName = "";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WatermarkText = "";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLastName.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblLastName.IsDerivedStyle = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(142, 46);
            this.lblLastName.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblLastName.StyleManager = null;
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.ThemeAuthor = "Narwin";
            this.lblLastName.ThemeName = "MetroDark";
            // 
            // txtLastName
            // 
            this.txtLastName.AutoCompleteCustomSource = null;
            this.txtLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLastName.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtLastName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLastName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLastName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLastName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLastName.Image = null;
            this.txtLastName.IsDerivedStyle = true;
            this.txtLastName.Lines = null;
            this.txtLastName.Location = new System.Drawing.Point(274, 91);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = false;
            this.txtLastName.Size = new System.Drawing.Size(514, 30);
            this.txtLastName.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtLastName.StyleManager = null;
            this.txtLastName.TabIndex = 34;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.ThemeAuthor = "";
            this.txtLastName.ThemeName = "";
            this.txtLastName.UseSystemPasswordChar = false;
            this.txtLastName.WatermarkText = "";
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            this.txtLastName.Validated += new System.EventHandler(this.txtLastName_Validated);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsername.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblUsername.IsDerivedStyle = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 121);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 46);
            this.lblUsername.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblUsername.StyleManager = null;
            this.lblUsername.TabIndex = 33;
            this.lblUsername.Text = "Username:";
            this.lblUsername.ThemeAuthor = "Narwin";
            this.lblUsername.ThemeName = "MetroDark";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFirstName.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.lblFirstName.IsDerivedStyle = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(142, 46);
            this.lblFirstName.Style = MetroSet_UI.Enums.Style.Custom;
            this.lblFirstName.StyleManager = null;
            this.lblFirstName.TabIndex = 35;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.ThemeAuthor = "Narwin";
            this.lblFirstName.ThemeName = "MetroDark";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoCompleteCustomSource = null;
            this.txtFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFirstName.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtFirstName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFirstName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtFirstName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFirstName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtFirstName.Image = null;
            this.txtFirstName.IsDerivedStyle = true;
            this.txtFirstName.Lines = null;
            this.txtFirstName.Location = new System.Drawing.Point(274, 45);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = false;
            this.txtFirstName.Size = new System.Drawing.Size(514, 30);
            this.txtFirstName.Style = MetroSet_UI.Enums.Style.Custom;
            this.txtFirstName.StyleManager = null;
            this.txtFirstName.TabIndex = 36;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.ThemeAuthor = "";
            this.txtFirstName.ThemeName = "";
            this.txtFirstName.UseSystemPasswordChar = false;
            this.txtFirstName.WatermarkText = "";
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_Validated);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageTransparency = 0.7F;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSecQ);
            this.Controls.Add(this.txtSecQ);
            this.Controls.Add(this.lblSecA);
            this.Controls.Add(this.txtSecA);
            this.Controls.Add(this.lblNewPassword1);
            this.Controls.Add(this.txtNewPassword1);
            this.Controls.Add(this.lblNewPassword2);
            this.Controls.Add(this.txtNewPassword2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Name = "SignUp";
            this.ShowLeftRect = false;
            this.ShowTitle = false;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnCancel;
        private MetroSet_UI.Controls.MetroSetButton btnConfirm;
        private MetroSet_UI.Controls.MetroSetTextBox txtNewPassword2;
        private MetroSet_UI.Controls.MetroSetTextBox txtNewPassword1;
        private MetroSet_UI.Controls.MetroSetTextBox txtSecQ;
        private MetroSet_UI.Controls.MetroSetLabel lblNewPassword2;
        private MetroSet_UI.Controls.MetroSetLabel lblNewPassword1;
        private MetroSet_UI.Controls.MetroSetLabel lblSecQ;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroSet_UI.Controls.MetroSetTextBox txtSecA;
        private MetroSet_UI.Controls.MetroSetLabel lblSecA;
        private MetroSet_UI.Controls.MetroSetLabel lblFirstName;
        private MetroSet_UI.Controls.MetroSetTextBox txtFirstName;
        private MetroSet_UI.Controls.MetroSetTextBox txtUsername;
        private MetroSet_UI.Controls.MetroSetLabel lblLastName;
        private MetroSet_UI.Controls.MetroSetTextBox txtLastName;
        private MetroSet_UI.Controls.MetroSetLabel lblUsername;
    }
}