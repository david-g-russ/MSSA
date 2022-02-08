namespace Assignment5._1
{
    partial class fMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnEmployeeDB = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeading.Location = new System.Drawing.Point(134, 214);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(775, 54);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Death Star Employee Management System";
            // 
            // btnEmployeeDB
            // 
            this.btnEmployeeDB.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeDB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeDB.BackgroundImage")));
            this.btnEmployeeDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeDB.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDB.ForeColor = System.Drawing.Color.Yellow;
            this.btnEmployeeDB.Location = new System.Drawing.Point(93, 466);
            this.btnEmployeeDB.Name = "btnEmployeeDB";
            this.btnEmployeeDB.Size = new System.Drawing.Size(352, 260);
            this.btnEmployeeDB.TabIndex = 1;
            this.btnEmployeeDB.Text = "Employee Database";
            this.btnEmployeeDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployeeDB.UseVisualStyleBackColor = false;
            this.btnEmployeeDB.Click += new System.EventHandler(this.btnEmployeeDB_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculator.BackgroundImage")));
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculator.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.Yellow;
            this.btnCalculator.Location = new System.Drawing.Point(629, 466);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(352, 260);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Yellow;
            this.btnReturn.Location = new System.Drawing.Point(1672, 916);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(214, 96);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Exit";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnEmployeeDB);
            this.Controls.Add(this.lblHeading);
            this.Name = "fMenu";
            this.Text = "fMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnEmployeeDB;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnReturn;
    }
}