namespace Assignment4._4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpBevDetails = new System.Windows.Forms.GroupBox();
            this.grdCoffee = new System.Windows.Forms.DataGridView();
            this.grdSoda = new System.Windows.Forms.DataGridView();
            this.lblCoffeeGrid = new System.Windows.Forms.Label();
            this.lblSodaGrid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCaffeineContent = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHasHighSugar = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCaffeineContent = new System.Windows.Forms.TextBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbTemp = new System.Windows.Forms.ComboBox();
            this.chkHighSugar = new System.Windows.Forms.CheckBox();
            this.btnCreateCoffee = new System.Windows.Forms.Button();
            this.btnCreateSoda = new System.Windows.Forms.Button();
            this.btnRemoveCoffee = new System.Windows.Forms.Button();
            this.btnRemoveSoda = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpBevDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Reem Kufi", 36F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(532, -38);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(709, 137);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Beverage Database";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBevDetails
            // 
            this.grpBevDetails.BackColor = System.Drawing.Color.White;
            this.grpBevDetails.Controls.Add(this.chkHighSugar);
            this.grpBevDetails.Controls.Add(this.cmbTemp);
            this.grpBevDetails.Controls.Add(this.cmbSize);
            this.grpBevDetails.Controls.Add(this.txtCaffeineContent);
            this.grpBevDetails.Controls.Add(this.txtPrice);
            this.grpBevDetails.Controls.Add(this.txtCalories);
            this.grpBevDetails.Controls.Add(this.txtName);
            this.grpBevDetails.Controls.Add(this.lblHasHighSugar);
            this.grpBevDetails.Controls.Add(this.lblTemp);
            this.grpBevDetails.Controls.Add(this.lblCaffeineContent);
            this.grpBevDetails.Controls.Add(this.lblPrice);
            this.grpBevDetails.Controls.Add(this.lblCalories);
            this.grpBevDetails.Controls.Add(this.lblSize);
            this.grpBevDetails.Controls.Add(this.lblName);
            this.grpBevDetails.Location = new System.Drawing.Point(24, 587);
            this.grpBevDetails.Name = "grpBevDetails";
            this.grpBevDetails.Size = new System.Drawing.Size(615, 417);
            this.grpBevDetails.TabIndex = 1;
            this.grpBevDetails.TabStop = false;
            this.grpBevDetails.Text = "Beverage Details";
            // 
            // grdCoffee
            // 
            this.grdCoffee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCoffee.BackgroundColor = System.Drawing.Color.White;
            this.grdCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCoffee.Location = new System.Drawing.Point(732, 90);
            this.grdCoffee.Name = "grdCoffee";
            this.grdCoffee.RowHeadersWidth = 62;
            this.grdCoffee.RowTemplate.Height = 28;
            this.grdCoffee.Size = new System.Drawing.Size(1028, 261);
            this.grdCoffee.TabIndex = 2;
            // 
            // grdSoda
            // 
            this.grdSoda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdSoda.BackgroundColor = System.Drawing.Color.White;
            this.grdSoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSoda.Location = new System.Drawing.Point(732, 611);
            this.grdSoda.Name = "grdSoda";
            this.grdSoda.RowHeadersWidth = 62;
            this.grdSoda.RowTemplate.Height = 28;
            this.grdSoda.Size = new System.Drawing.Size(1028, 262);
            this.grdSoda.TabIndex = 3;
            // 
            // lblCoffeeGrid
            // 
            this.lblCoffeeGrid.AutoSize = true;
            this.lblCoffeeGrid.BackColor = System.Drawing.Color.White;
            this.lblCoffeeGrid.Font = new System.Drawing.Font("Reem Kufi", 20F);
            this.lblCoffeeGrid.Location = new System.Drawing.Point(1203, 357);
            this.lblCoffeeGrid.Name = "lblCoffeeGrid";
            this.lblCoffeeGrid.Size = new System.Drawing.Size(152, 76);
            this.lblCoffeeGrid.TabIndex = 4;
            this.lblCoffeeGrid.Text = "Coffee";
            // 
            // lblSodaGrid
            // 
            this.lblSodaGrid.AutoSize = true;
            this.lblSodaGrid.BackColor = System.Drawing.Color.White;
            this.lblSodaGrid.Font = new System.Drawing.Font("Reem Kufi", 20F);
            this.lblSodaGrid.Location = new System.Drawing.Point(1230, 876);
            this.lblSodaGrid.Name = "lblSodaGrid";
            this.lblSodaGrid.Size = new System.Drawing.Size(125, 76);
            this.lblSodaGrid.TabIndex = 5;
            this.lblSodaGrid.Text = "Soda";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(19, 107);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 20);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size:";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(19, 157);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(70, 20);
            this.lblCalories.TabIndex = 2;
            this.lblCalories.Text = "Calories:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(19, 216);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblCaffeineContent
            // 
            this.lblCaffeineContent.AutoSize = true;
            this.lblCaffeineContent.Location = new System.Drawing.Point(19, 266);
            this.lblCaffeineContent.Name = "lblCaffeineContent";
            this.lblCaffeineContent.Size = new System.Drawing.Size(134, 20);
            this.lblCaffeineContent.TabIndex = 4;
            this.lblCaffeineContent.Text = "Caffeine Content:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(19, 318);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(104, 20);
            this.lblTemp.TabIndex = 5;
            this.lblTemp.Text = "Temperature:";
            // 
            // lblHasHighSugar
            // 
            this.lblHasHighSugar.AutoSize = true;
            this.lblHasHighSugar.Location = new System.Drawing.Point(19, 374);
            this.lblHasHighSugar.Name = "lblHasHighSugar";
            this.lblHasHighSugar.Size = new System.Drawing.Size(187, 20);
            this.lblHasHighSugar.TabIndex = 6;
            this.lblHasHighSugar.Text = "Has High Sugar Content:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(278, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 26);
            this.txtName.TabIndex = 7;
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(278, 157);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(151, 26);
            this.txtCalories.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(278, 216);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 26);
            this.txtPrice.TabIndex = 10;
            // 
            // txtCaffeineContent
            // 
            this.txtCaffeineContent.Location = new System.Drawing.Point(278, 266);
            this.txtCaffeineContent.Name = "txtCaffeineContent";
            this.txtCaffeineContent.Size = new System.Drawing.Size(151, 26);
            this.txtCaffeineContent.TabIndex = 11;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(278, 107);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(151, 28);
            this.cmbSize.TabIndex = 12;
            // 
            // cmbTemp
            // 
            this.cmbTemp.FormattingEnabled = true;
            this.cmbTemp.Location = new System.Drawing.Point(278, 318);
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(151, 28);
            this.cmbTemp.TabIndex = 13;
            // 
            // chkHighSugar
            // 
            this.chkHighSugar.AutoSize = true;
            this.chkHighSugar.Location = new System.Drawing.Point(278, 374);
            this.chkHighSugar.Name = "chkHighSugar";
            this.chkHighSugar.Size = new System.Drawing.Size(22, 21);
            this.chkHighSugar.TabIndex = 14;
            this.chkHighSugar.UseVisualStyleBackColor = true;
            // 
            // btnCreateCoffee
            // 
            this.btnCreateCoffee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateCoffee.Location = new System.Drawing.Point(16, 312);
            this.btnCreateCoffee.Name = "btnCreateCoffee";
            this.btnCreateCoffee.Size = new System.Drawing.Size(161, 53);
            this.btnCreateCoffee.TabIndex = 6;
            this.btnCreateCoffee.Text = "Create Coffee";
            this.btnCreateCoffee.UseVisualStyleBackColor = false;
            this.btnCreateCoffee.Click += new System.EventHandler(this.btnCreateCoffee_Click);
            // 
            // btnCreateSoda
            // 
            this.btnCreateSoda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateSoda.Location = new System.Drawing.Point(16, 371);
            this.btnCreateSoda.Name = "btnCreateSoda";
            this.btnCreateSoda.Size = new System.Drawing.Size(161, 53);
            this.btnCreateSoda.TabIndex = 7;
            this.btnCreateSoda.Text = "Create Soda";
            this.btnCreateSoda.UseVisualStyleBackColor = false;
            this.btnCreateSoda.Click += new System.EventHandler(this.btnCreateSoda_Click);
            // 
            // btnRemoveCoffee
            // 
            this.btnRemoveCoffee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveCoffee.Location = new System.Drawing.Point(732, 357);
            this.btnRemoveCoffee.Name = "btnRemoveCoffee";
            this.btnRemoveCoffee.Size = new System.Drawing.Size(161, 53);
            this.btnRemoveCoffee.TabIndex = 8;
            this.btnRemoveCoffee.Text = "Remove Coffee";
            this.btnRemoveCoffee.UseVisualStyleBackColor = false;
            this.btnRemoveCoffee.Click += new System.EventHandler(this.btnRemoveCoffee_Click);
            // 
            // btnRemoveSoda
            // 
            this.btnRemoveSoda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveSoda.Location = new System.Drawing.Point(732, 876);
            this.btnRemoveSoda.Name = "btnRemoveSoda";
            this.btnRemoveSoda.Size = new System.Drawing.Size(161, 53);
            this.btnRemoveSoda.TabIndex = 9;
            this.btnRemoveSoda.Text = "Remove Soda";
            this.btnRemoveSoda.UseVisualStyleBackColor = false;
            this.btnRemoveSoda.Click += new System.EventHandler(this.btnRemoveSoda_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(1758, 938);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(141, 87);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveSoda);
            this.Controls.Add(this.btnRemoveCoffee);
            this.Controls.Add(this.btnCreateSoda);
            this.Controls.Add(this.btnCreateCoffee);
            this.Controls.Add(this.lblSodaGrid);
            this.Controls.Add(this.lblCoffeeGrid);
            this.Controls.Add(this.grdSoda);
            this.Controls.Add(this.grdCoffee);
            this.Controls.Add(this.grpBevDetails);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBevDetails.ResumeLayout(false);
            this.grpBevDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpBevDetails;
        private System.Windows.Forms.DataGridView grdCoffee;
        private System.Windows.Forms.DataGridView grdSoda;
        private System.Windows.Forms.Label lblCoffeeGrid;
        private System.Windows.Forms.Label lblSodaGrid;
        private System.Windows.Forms.CheckBox chkHighSugar;
        private System.Windows.Forms.ComboBox cmbTemp;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.TextBox txtCaffeineContent;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHasHighSugar;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblCaffeineContent;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCreateCoffee;
        private System.Windows.Forms.Button btnCreateSoda;
        private System.Windows.Forms.Button btnRemoveCoffee;
        private System.Windows.Forms.Button btnRemoveSoda;
        private System.Windows.Forms.Button btnReturn;
    }
}

