namespace Assignment4._4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.grpActDetails = new System.Windows.Forms.GroupBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.btnCreateAct = new System.Windows.Forms.Button();
            this.btnActNum = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtActNum = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpActDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Reem Kufi", 36F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(493, -10);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(932, 137);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Bank Management System";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(27, 48);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(86, 20);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name";
            // 
            // grpActDetails
            // 
            this.grpActDetails.BackColor = System.Drawing.Color.White;
            this.grpActDetails.Controls.Add(this.txtBalance);
            this.grpActDetails.Controls.Add(this.txtActNum);
            this.grpActDetails.Controls.Add(this.txtLName);
            this.grpActDetails.Controls.Add(this.txtFName);
            this.grpActDetails.Controls.Add(this.lblBalance);
            this.grpActDetails.Controls.Add(this.btnActNum);
            this.grpActDetails.Controls.Add(this.lblLName);
            this.grpActDetails.Controls.Add(this.lblFName);
            this.grpActDetails.Location = new System.Drawing.Point(26, 174);
            this.grpActDetails.Name = "grpActDetails";
            this.grpActDetails.Size = new System.Drawing.Size(574, 276);
            this.grpActDetails.TabIndex = 2;
            this.grpActDetails.TabStop = false;
            this.grpActDetails.Text = "Account Details";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(27, 102);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(86, 20);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // btnCreateAct
            // 
            this.btnCreateAct.Location = new System.Drawing.Point(225, 456);
            this.btnCreateAct.Name = "btnCreateAct";
            this.btnCreateAct.Size = new System.Drawing.Size(142, 80);
            this.btnCreateAct.TabIndex = 3;
            this.btnCreateAct.Text = "Create Account";
            this.btnCreateAct.UseVisualStyleBackColor = true;
            this.btnCreateAct.Click += new System.EventHandler(this.btnCreateAct_Click);
            // 
            // btnActNum
            // 
            this.btnActNum.AutoSize = true;
            this.btnActNum.Location = new System.Drawing.Point(27, 160);
            this.btnActNum.Name = "btnActNum";
            this.btnActNum.Size = new System.Drawing.Size(128, 20);
            this.btnActNum.TabIndex = 3;
            this.btnActNum.Text = "Account Number";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(27, 212);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(67, 20);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(224, 48);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(230, 26);
            this.txtFName.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(224, 102);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(230, 26);
            this.txtLName.TabIndex = 6;
            // 
            // txtActNum
            // 
            this.txtActNum.Location = new System.Drawing.Point(224, 160);
            this.txtActNum.Name = "txtActNum";
            this.txtActNum.Size = new System.Drawing.Size(230, 26);
            this.txtActNum.TabIndex = 7;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(224, 212);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(230, 26);
            this.txtBalance.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1754, 942);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 80);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCreateAct);
            this.Controls.Add(this.grpActDetails);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpActDetails.ResumeLayout(false);
            this.grpActDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.GroupBox grpActDetails;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Button btnCreateAct;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label btnActNum;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtActNum;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnReturn;
    }
}